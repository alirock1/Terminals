﻿namespace Terminals
{
    using CommandLine;
    using Configuration.Files.Main.Settings;
    using Forms;
    using Kohl.Framework.Info;
    using Kohl.Framework.Logging;
    using Network.Services;
    using System;
    using System.IO;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Threading;
    using System.Windows.Forms;
    using Updates;

    static class Program
    {
        private static MainForm mainForm;
        public static int LimitFavorites { get; private set; }
        public static int LimitTags { get; private set; }

        // The supported UI languages
        public static string[] Languages
        {
            get
            {
                return new string[] { "de", "en" };
            }
        }

        private static string captionBasePart = null;
        private static string captionMiddlePart = null;

        public static string Caption
        {
            get
            {
                return captionBasePart.TrimEnd() + (string.IsNullOrEmpty(captionMiddlePart) ? string.Empty : (captionMiddlePart.StartsWith("  - ") ? captionMiddlePart : " - " + captionMiddlePart));
            }
            set
            {
                captionBasePart = value;
            }
        }

        // <summary>
        ///     Holds the application start time.
        /// </summary>
        private static DateTime StartTime { get; set; }

        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll")]
        private static extern bool AttachConsole(int pid);

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // Set the type to be reflected.
            AssemblyInfo.Assembly = System.Reflection.Assembly.GetAssembly(typeof(Program));

            Log.Info(String.Format("-------------------------------{0} started. Version: {1}, Date: {2}-------------------------------", AssemblyInfo.Title, AssemblyInfo.Version, AssemblyInfo.BuildDate));

            try
            {
            	new Thread(() => { Network.DNS.AdapterInfo.LoadDnsServers(); }).Start();
            }
            catch
            {
            	Log.Debug("Error caching DNS servers");
            }
            
            string[] cmdLineArgs = Environment.GetCommandLineArgs();

            #region Command line
            // Check if we need to display the help screen.
            if (Parser.ParseHelp(cmdLineArgs))
            {
                Log.Info("Showing Terminals in command line mode.");

                string helpText = Parser.ArgumentsUsage(typeof(CommandLineArgs));

                // Attach to an parent process console
                if (!AttachConsole(-1))
                {
                    // Alloc a new console
                    AllocConsole();
                }

                const ConsoleColor headerBackground = ConsoleColor.Blue;

                int maxLen = 0;

                if (AssemblyInfo.TitleVersion.Count() >= AssemblyInfo.Url.Count() && AssemblyInfo.TitleVersion.Count() >= AssemblyInfo.Author.Count())
                {
                    maxLen = AssemblyInfo.TitleVersion.Count();
                }

                if (AssemblyInfo.Author.Count() >= AssemblyInfo.Url.Count() && AssemblyInfo.Author.Count() >= AssemblyInfo.TitleVersion.Count())
                {
                    maxLen = AssemblyInfo.Author.Count();
                }

                if (AssemblyInfo.Url.Count() >= AssemblyInfo.TitleVersion.Count() && AssemblyInfo.Url.Count() >= AssemblyInfo.Author.Count())
                {
                    maxLen = AssemblyInfo.Url.Count();
                }

                // * * * Set the program name * * * 

                ConsoleColor backgroundColor = Console.BackgroundColor;
                ConsoleColor foregroundColor = Console.ForegroundColor;

                Console.Write(Environment.NewLine + Environment.NewLine + " ");

                Console.BackgroundColor = headerBackground;

                // +2 -> one ' ' before the text and one after
                for (int i = 0; i < maxLen + 2; i++)
                {
                    Console.Write(" ");
                }

                Console.ForegroundColor = foregroundColor;
                Console.BackgroundColor = backgroundColor;

                Console.Write(Environment.NewLine + " ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = headerBackground;
                Console.Write(" ");

                Console.Write(AssemblyInfo.TitleVersion.PadRight(maxLen + 1));

                Console.ForegroundColor = foregroundColor;
                Console.BackgroundColor = backgroundColor;

                // * * * Set the line * * * 

                Console.Write(Environment.NewLine + " ");

                string t = null;

                for (int i = 0; i < AssemblyInfo.TitleVersion.Count(); i++)
                    t += "═";

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.BackgroundColor = headerBackground;
                Console.Write(" ");
                Console.Write(t.PadRight(maxLen + 1));


                Console.ForegroundColor = foregroundColor;
                Console.BackgroundColor = backgroundColor;

                Console.Write(Environment.NewLine + " ");

                Console.BackgroundColor = headerBackground;

                // +2 -> one ' ' before the text and one after
                for (int i = 0; i < maxLen + 2; i++)
                {
                    Console.Write(" ");
                }

                // * * * Set the author * * * 

                Console.ForegroundColor = foregroundColor;
                Console.BackgroundColor = backgroundColor;

                Console.Write(Environment.NewLine + " ");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = headerBackground;

                Console.Write(" ");
                Console.Write(AssemblyInfo.Author.PadRight(maxLen + 1));

                Console.ForegroundColor = foregroundColor;
                Console.BackgroundColor = backgroundColor;

                // * * * Set the url * * * 

                Console.ForegroundColor = foregroundColor;
                Console.BackgroundColor = backgroundColor;

                Console.Write(Environment.NewLine + " ");

                Console.BackgroundColor = headerBackground;
                Console.Write(" ");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.BackgroundColor = ConsoleColor.White;

                Console.Write(AssemblyInfo.Url);

                Console.BackgroundColor = headerBackground;
                Console.Write(" ");

                Console.ForegroundColor = foregroundColor;
                Console.BackgroundColor = backgroundColor;

                Console.Write(Environment.NewLine + " ");

                Console.BackgroundColor = headerBackground;

                // +2 -> one ' ' before the text and one after
                for (int i = 0; i < maxLen + 2; i++)
                {
                    Console.Write(" ");
                }

                Console.ForegroundColor = foregroundColor;
                Console.BackgroundColor = backgroundColor;

                // * * * Add the rest of the text * * * 

                Console.Write(Environment.NewLine + Environment.NewLine + helpText + Environment.NewLine +
                              Environment.NewLine);

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.Write("Press any key to continue . . .");

                Console.ForegroundColor = foregroundColor;
                Console.BackgroundColor = backgroundColor;

                Console.Write(" ");

                LogTerminalsStopped();
                return;
            }

            #endregion

            // Set application behaviour -> this must occur before the first UI creation events!
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CommandLineArgs commandLine = ParseCommandline(cmdLineArgs);

            // Create a backup of the current Terminals.config file
            CreateConfigFileBackup();

            // This won't force the configuration to get invalid -> parsing will occur later.
            if (Settings.IsMasterPasswordDefined
            && !Settings.IsMasterPasswordValid(Settings.SavedMasterPassword))
            {
                using (RequestPassword requestPassword = new RequestPassword())
                {
                    // If the password has been entered three times wrong or the user has clicked the cancel button ->
                    // Return from the main procedure. - Application.Exit() will not work here!
                    if (requestPassword.ShowDialog() != DialogResult.OK)
                        return;
                }
            }

            // Upgrade the configuration file if necessary
            UpdateConfig.CheckConfigVersionUpdate();

            Application.ThreadException += Application_ThreadException;

            // Create the main form.
            mainForm = new MainForm();

            if (UserAccountControlNotSatisfied())
            {
                LogTerminalsStopped();
                return;
            }

            if (commandLine.SingleInstance && SingleInstanceApplication.Instance.NotifyExisting(commandLine))
            {
                LogTerminalsStopped();
                return;
            }

            // Log the company name, current windows user, machine domain, etc.
            LogGeneralProperties();

            // Start the main form and wait for it to return.
            StartMainForm(commandLine);

            LogTerminalsStopped();
        }

        private static void LogTerminalsStopped()
        {
            Log.Info(String.Format("-------------------------------{0} stopped. Version: {1}, Date: {2}-------------------------------", AssemblyInfo.Title, AssemblyInfo.Version, AssemblyInfo.BuildDate));
        }

        private static void CreateConfigFileBackup()
        {
            try
            {
                if (File.Exists(Settings.ConfigurationFileLocation))
                    File.Copy(Settings.ConfigurationFileLocation, Path.Combine(AssemblyInfo.DirectoryConfigFiles, AssemblyInfo.Title + ".bak"), true);

                if (File.Exists(Configuration.Files.Credentials.StoredCredentials.ConfigurationFileLocation))
                    File.Copy(Configuration.Files.Credentials.StoredCredentials.ConfigurationFileLocation, Path.Combine(AssemblyInfo.DirectoryConfigFiles, "Credentials.bak"), true);

                Log.Info("Configuration file backup has been created successfully.");
            }
            catch (Exception ex)
            {
                Log.Warn("Configuration file backup has failed.", ex);
            }
        }

        private static bool UserAccountControlNotSatisfied()
        {
            LogNonAdministrator();

            bool hasAccess = AssemblyInfo.DirectoryConfigFiles.CanWriteToFolder();

            if (!hasAccess)
            {
                string message = "Write Access is denied. Please make sure your user account has sufficient permissions. Write access to the current directory is needed.";
                Log.Fatal(message);
                MessageBox.Show(message, AssemblyInfo.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return !hasAccess;
        }

        private static void LogNonAdministrator()
        {
            if (!UserInfo.IsAdministrator)
            {
                Log.Info(string.Format("{0} is running in non-admin mode.", AssemblyInfo.Title));
            }
        }

        private static void StartMainForm(CommandLineArgs commandLine)
        {
            try
            {
                RunMainForm(commandLine);
            }
            catch (Exception exc)
            {
                Log.Fatal("The main form has thrown an exception.", exc);
            }
        }

        private static void RunMainForm(CommandLineArgs commandLine)
        {
            try
            {
                SingleInstanceApplication.Instance.Start(mainForm);
                mainForm.HandleCommandLineActions(commandLine);
                Application.Run(mainForm);
            }
            catch (Exception exc)
            {
                Log.Fatal("The main form has thrown an exception.", exc);
            }
        }

        private static void LogGeneralProperties()
        {
            new Thread(new ThreadStart(delegate
            {
                HumanReadableInfo.ToLog();
            }
            )).Start();
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Log.Fatal("The application has thrown an unhandled exception.", e.Exception);
        }

        private static CommandLineArgs ParseCommandline(string[] cmdLineArgs)
        {
            CommandLineArgs commandline = new CommandLineArgs();

            Parser.ParseArguments(cmdLineArgs, commandline);

            if (!string.IsNullOrEmpty(commandline.Config))
            {
                Log.Info(string.Format("Loading configuration file at {0}", commandline.Config));
                Settings.ConfigurationFileLocation = commandline.Config;
            }

            if (!string.IsNullOrEmpty(commandline.Cred))
            {
                Log.Info(string.Format("Loading password safe at {0}", commandline.Cred));
                Configuration.Files.Credentials.StoredCredentials.ConfigurationFileLocation = commandline.Cred;
            }

            return commandline;
        }
    }
}