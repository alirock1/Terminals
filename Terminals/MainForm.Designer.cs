using Terminals.Connection.TabControl;
using Terminals.Forms.Controls;

namespace Terminals
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) 
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ShortcutsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ilTagConnections = new System.Windows.Forms.ImageList(this.components);
            this.ilTags = new System.Windows.Forms.ImageList(this.components);
            this.timerHover = new System.Windows.Forms.Timer(this.components);
            this.MainWindowNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.QuickContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripContainer = new Terminals.Forms.Controls.ToolStripContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlTagsFavorites = new System.Windows.Forms.Panel();
            this.favsList1 = new Terminals.Forms.Controls.FavsList();
            this.pnlHideTagsFavorites = new System.Windows.Forms.Panel();
            this.pbHideTagsFavorites = new System.Windows.Forms.PictureBox();
            this.pnlShowTagsFavorites = new System.Windows.Forms.Panel();
            this.pbShowTagsFavorites = new System.Windows.Forms.PictureBox();
            this.tcTerminals = new Terminals.Connection.TabControl.TabControl();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTerminalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemImport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menubarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemShowHideFavoriteToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.shortcutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lockToolbarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInNewWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showInDualScreensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageFavoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizeFavoritesToolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureTerminalScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCaptureManager = new System.Windows.Forms.ToolStripMenuItem();
            this.networkingToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripOrganizeShortucts = new System.Windows.Forms.ToolStripMenuItem();
            this.credentialManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.rebuildTagsIndexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebuildShortcutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebuildToolbarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.openLogFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLogFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLogLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetLogLevelToDebugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetLogLevelToInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyLogFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizeGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTerminalsAsGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTerminalToGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoriteToolBar = new System.Windows.Forms.ToolStrip();
            this.SpecialCommandsToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolbarStd = new System.Windows.Forms.ToolStrip();
            this.tsbNewTerminal = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tscConnectTo = new System.Windows.Forms.ToolStripComboBox();
            this.tsbConnect = new System.Windows.Forms.ToolStripButton();
            this.tsbConnectToConsole = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDisconnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbManageConnections = new System.Windows.Forms.ToolStripButton();
            this.CredentialManagementToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFullScreen = new System.Windows.Forms.ToolStripButton();
            this.tsbFixDesktopSize = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbTags = new System.Windows.Forms.ToolStripButton();
            this.CaptureScreenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCaptureManager = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.VMRCAdminSwitchButton = new System.Windows.Forms.ToolStripButton();
            this.VMRCViewOnlyButton = new System.Windows.Forms.ToolStripButton();
            this.tsbNetworkingTools = new System.Windows.Forms.ToolStripButton();
            this.vncActionButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.sendALTKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendALTF4KeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendCTRLKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendCTRLESCKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sentCTRLALTDELETEKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbComputerManagement = new System.Windows.Forms.ToolStripButton();
            this.ShortcutsContextMenu.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlTagsFavorites.SuspendLayout();
            this.pnlHideTagsFavorites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHideTagsFavorites)).BeginInit();
            this.pnlShowTagsFavorites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowTagsFavorites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcTerminals)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.toolbarStd.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShortcutsContextMenu
            // 
            this.ShortcutsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.ShortcutsContextMenu.Name = "ShortcutsContextMenu";
            this.ShortcutsContextMenu.Size = new System.Drawing.Size(175, 26);
            this.ShortcutsContextMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShortcutsContextMenu_MouseClick);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(174, 22);
            this.toolStripMenuItem3.Text = "Organize Shortcuts";
            // 
            // ilTagConnections
            // 
            this.ilTagConnections.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilTagConnections.ImageStream")));
            this.ilTagConnections.TransparentColor = System.Drawing.Color.Transparent;
            this.ilTagConnections.Images.SetKeyName(0, "");
            // 
            // ilTags
            // 
            this.ilTags.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilTags.ImageStream")));
            this.ilTags.TransparentColor = System.Drawing.Color.Transparent;
            this.ilTags.Images.SetKeyName(0, "tag.png");
            // 
            // timerHover
            // 
            this.timerHover.Interval = 200;
            this.timerHover.Tick += new System.EventHandler(this.timerHover_Tick);
            // 
            // MainWindowNotifyIcon
            // 
            this.MainWindowNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.MainWindowNotifyIcon.BalloonTipText = "Click to show or hide Terminals main window";
            this.MainWindowNotifyIcon.BalloonTipTitle = "Terminals";
            this.MainWindowNotifyIcon.ContextMenuStrip = this.QuickContextMenu;
            this.MainWindowNotifyIcon.Text = "Click to show or hide Terminals main window";
            this.MainWindowNotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainWindowNotifyIcon_MouseClick);
            // 
            // QuickContextMenu
            // 
            this.QuickContextMenu.Name = "QuickContextMenu";
            this.QuickContextMenu.Size = new System.Drawing.Size(61, 4);
            this.QuickContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.QuickContextMenu_Opening);
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.AutoScroll = true;
            this.toolStripContainer.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(961, 499);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(961, 573);
            this.toolStripContainer.TabIndex = 0;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.menuStrip);
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.favoriteToolBar);
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.SpecialCommandsToolStrip);
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolbarStd);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlTagsFavorites);
            this.splitContainer1.Panel1MinSize = 7;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tcTerminals);
            this.splitContainer1.Size = new System.Drawing.Size(961, 499);
            this.splitContainer1.SplitterDistance = 224;
            this.splitContainer1.TabIndex = 7;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // pnlTagsFavorites
            // 
            this.pnlTagsFavorites.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTagsFavorites.Controls.Add(this.favsList1);
            this.pnlTagsFavorites.Controls.Add(this.pnlHideTagsFavorites);
            this.pnlTagsFavorites.Controls.Add(this.pnlShowTagsFavorites);
            this.pnlTagsFavorites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTagsFavorites.Location = new System.Drawing.Point(0, 0);
            this.pnlTagsFavorites.Name = "pnlTagsFavorites";
            this.pnlTagsFavorites.Size = new System.Drawing.Size(224, 499);
            this.pnlTagsFavorites.TabIndex = 6;
            // 
            // favsList1
            // 
            this.favsList1.BackColor = System.Drawing.Color.White;
            this.favsList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.favsList1.Location = new System.Drawing.Point(5, 0);
            this.favsList1.Margin = new System.Windows.Forms.Padding(4);
            this.favsList1.Name = "favsList1";
            this.favsList1.Size = new System.Drawing.Size(212, 497);
            this.favsList1.TabIndex = 2;
            // 
            // pnlHideTagsFavorites
            // 
            this.pnlHideTagsFavorites.BackColor = System.Drawing.Color.Gray;
            this.pnlHideTagsFavorites.Controls.Add(this.pbHideTagsFavorites);
            this.pnlHideTagsFavorites.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlHideTagsFavorites.Location = new System.Drawing.Point(217, 0);
            this.pnlHideTagsFavorites.Name = "pnlHideTagsFavorites";
            this.pnlHideTagsFavorites.Size = new System.Drawing.Size(5, 497);
            this.pnlHideTagsFavorites.TabIndex = 1;
            this.pnlHideTagsFavorites.Visible = false;
            // 
            // pbHideTagsFavorites
            // 
            this.pbHideTagsFavorites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHideTagsFavorites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbHideTagsFavorites.Image = global::Terminals.Properties.Resources.HidePanel;
            this.pbHideTagsFavorites.Location = new System.Drawing.Point(0, 0);
            this.pbHideTagsFavorites.Name = "pbHideTagsFavorites";
            this.pbHideTagsFavorites.Size = new System.Drawing.Size(5, 497);
            this.pbHideTagsFavorites.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbHideTagsFavorites.TabIndex = 2;
            this.pbHideTagsFavorites.TabStop = false;
            this.pbHideTagsFavorites.Click += new System.EventHandler(this.pbHideTags_Click);
            // 
            // pnlShowTagsFavorites
            // 
            this.pnlShowTagsFavorites.BackColor = System.Drawing.Color.Gray;
            this.pnlShowTagsFavorites.Controls.Add(this.pbShowTagsFavorites);
            this.pnlShowTagsFavorites.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlShowTagsFavorites.Location = new System.Drawing.Point(0, 0);
            this.pnlShowTagsFavorites.Name = "pnlShowTagsFavorites";
            this.pnlShowTagsFavorites.Size = new System.Drawing.Size(5, 497);
            this.pnlShowTagsFavorites.TabIndex = 0;
            // 
            // pbShowTagsFavorites
            // 
            this.pbShowTagsFavorites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbShowTagsFavorites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbShowTagsFavorites.Image = global::Terminals.Properties.Resources.ShowPanel;
            this.pbShowTagsFavorites.Location = new System.Drawing.Point(0, 0);
            this.pbShowTagsFavorites.Name = "pbShowTagsFavorites";
            this.pbShowTagsFavorites.Size = new System.Drawing.Size(5, 497);
            this.pbShowTagsFavorites.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbShowTagsFavorites.TabIndex = 0;
            this.pbShowTagsFavorites.TabStop = false;
            this.pbShowTagsFavorites.Click += new System.EventHandler(this.pbShowTags_Click);
            this.pbShowTagsFavorites.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbShowTagsFavorites_MouseMove);
            // 
            // tcTerminals
            // 
            this.tcTerminals.AllowDrop = true;
            this.tcTerminals.AlwaysShowClose = false;
            this.tcTerminals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTerminals.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tcTerminals.Location = new System.Drawing.Point(0, 0);
            this.tcTerminals.Name = "tcTerminals";
            this.tcTerminals.Padding = new System.Windows.Forms.Padding(1, 20, 1, 1);
            this.tcTerminals.ShowToolTipOnTitle = false;
            this.tcTerminals.Size = new System.Drawing.Size(733, 499);
            this.tcTerminals.TabIndex = 3;
            this.tcTerminals.TabControlItemClosing += new Terminals.Connection.TabControl.TabControlItemClosingHandler(this.tcTerminals_TabControlItemClosing);
            this.tcTerminals.TabControlItemSelectionChanged += new Terminals.Connection.TabControl.TabControlItemChangedHandler(this.tcTerminals_TabControlItemSelectionChanged);
            this.tcTerminals.TabControlMouseOnTitle += new Terminals.Connection.TabControl.TabControlMouseOnTitleHandler(this.tcTerminals_TabControlMouseOnTitle);
            this.tcTerminals.TabControlMouseLeftTitle += new Terminals.Connection.TabControl.TabControlMouseLeftTitleHandler(this.tcTerminals_TabControlMouseLeftTitle);
            this.tcTerminals.MenuItemsLoaded += new System.EventHandler(this.tcTerminals_MenuItemsLoaded);
            this.tcTerminals.TabControlItemClosed += new System.EventHandler(this.tcTerminals_TabControlItemClosed);
            this.tcTerminals.SizeChanged += new System.EventHandler(this.tcTerminals_SizeChanged);
            this.tcTerminals.DoubleClick += new System.EventHandler(this.tcTerminals_DoubleClick);
            this.tcTerminals.MouseLeave += new System.EventHandler(this.tcTerminals_MouseLeave);
            this.tcTerminals.MouseHover += new System.EventHandler(this.tcTerminals_MouseHover);
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.favoritesToolStripMenuItem,
            this.terminalToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.groupsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(3, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(317, 24);
            this.menuStrip.Stretch = false;
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTerminalToolStripMenuItem,
            this.toolStripMenuItemImport,
            this.toolStripMenuItemExport,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newTerminalToolStripMenuItem
            // 
            this.newTerminalToolStripMenuItem.Image = global::Terminals.Properties.Resources.add;
            this.newTerminalToolStripMenuItem.Name = "newTerminalToolStripMenuItem";
            this.newTerminalToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newTerminalToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.newTerminalToolStripMenuItem.Text = "&New Connection";
            this.newTerminalToolStripMenuItem.ToolTipText = "Make a new connection";
            this.newTerminalToolStripMenuItem.Click += new System.EventHandler(this.newTerminalToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItemImport
            // 
            this.toolStripMenuItemImport.Name = "toolStripMenuItemImport";
            this.toolStripMenuItemImport.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.toolStripMenuItemImport.Size = new System.Drawing.Size(215, 22);
            this.toolStripMenuItemImport.Text = "&Import connections";
            this.toolStripMenuItemImport.Click += new System.EventHandler(this.toolStripMenuItemImport_Click);
            // 
            // toolStripMenuItemExport
            // 
            this.toolStripMenuItemExport.Name = "toolStripMenuItemExport";
            this.toolStripMenuItemExport.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.toolStripMenuItemExport.Size = new System.Drawing.Size(215, 22);
            this.toolStripMenuItemExport.Text = "&Export connections";
            this.toolStripMenuItemExport.ToolTipText = "Opens export dialog to select connections to export into a xml file.";
            this.toolStripMenuItemExport.Click += new System.EventHandler(this.exportConnectionsListToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(212, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullScreenToolStripMenuItem,
            this.menubarToolStripMenuItem,
            this.standardToolbarToolStripMenuItem,
            this.toolStripMenuItemShowHideFavoriteToolbar,
            this.shortcutsToolStripMenuItem,
            this.lockToolbarsToolStripMenuItem,
            this.viewInNewWindowToolStripMenuItem,
            this.showInDualScreensToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.Image = global::Terminals.Properties.Resources.arrow_out;
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            this.fullScreenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F11)));
            this.fullScreenToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.fullScreenToolStripMenuItem.Text = "&Full Screen";
            this.fullScreenToolStripMenuItem.ToolTipText = "Set Terminals full screen";
            this.fullScreenToolStripMenuItem.Click += new System.EventHandler(this.tsbFullScreen_Click);
            // 
            // menubarToolStripMenuItem
            // 
            this.menubarToolStripMenuItem.Checked = true;
            this.menubarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menubarToolStripMenuItem.Name = "menubarToolStripMenuItem";
            this.menubarToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.menubarToolStripMenuItem.Text = "&Menubar";
            this.menubarToolStripMenuItem.Visible = false;
            this.menubarToolStripMenuItem.Click += new System.EventHandler(this.menubarToolStripMenuItem_Click);
            // 
            // standardToolbarToolStripMenuItem
            // 
            this.standardToolbarToolStripMenuItem.Checked = true;
            this.standardToolbarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.standardToolbarToolStripMenuItem.Name = "standardToolbarToolStripMenuItem";
            this.standardToolbarToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.standardToolbarToolStripMenuItem.Text = "&Standard Toolbar";
            this.standardToolbarToolStripMenuItem.ToolTipText = "Show/Hide standard toolbar";
            this.standardToolbarToolStripMenuItem.Click += new System.EventHandler(this.standardToolbarToolStripMenuItem_Click);
            // 
            // toolStripMenuItemShowHideFavoriteToolbar
            // 
            this.toolStripMenuItemShowHideFavoriteToolbar.Checked = true;
            this.toolStripMenuItemShowHideFavoriteToolbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemShowHideFavoriteToolbar.Name = "toolStripMenuItemShowHideFavoriteToolbar";
            this.toolStripMenuItemShowHideFavoriteToolbar.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItemShowHideFavoriteToolbar.Text = "F&avorites";
            this.toolStripMenuItemShowHideFavoriteToolbar.ToolTipText = "Show/Hide favorite toolbar";
            this.toolStripMenuItemShowHideFavoriteToolbar.Click += new System.EventHandler(this.toolStripMenuItemShowHideFavoriteToolbar_Click);
            // 
            // shortcutsToolStripMenuItem
            // 
            this.shortcutsToolStripMenuItem.Checked = true;
            this.shortcutsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.shortcutsToolStripMenuItem.Name = "shortcutsToolStripMenuItem";
            this.shortcutsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.shortcutsToolStripMenuItem.Text = "S&hortcuts";
            this.shortcutsToolStripMenuItem.ToolTipText = "Show/Hide Shourtcutes";
            this.shortcutsToolStripMenuItem.Click += new System.EventHandler(this.shortcutsToolStripMenuItem_Click);
            // 
            // lockToolbarsToolStripMenuItem
            // 
            this.lockToolbarsToolStripMenuItem.Checked = true;
            this.lockToolbarsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lockToolbarsToolStripMenuItem.Name = "lockToolbarsToolStripMenuItem";
            this.lockToolbarsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.lockToolbarsToolStripMenuItem.Text = "&Lock Toolbars";
            this.lockToolbarsToolStripMenuItem.ToolTipText = "Lock all toolbars";
            this.lockToolbarsToolStripMenuItem.Click += new System.EventHandler(this.lockToolbarsToolStripMenuItem_Click);
            // 
            // viewInNewWindowToolStripMenuItem
            // 
            this.viewInNewWindowToolStripMenuItem.Name = "viewInNewWindowToolStripMenuItem";
            this.viewInNewWindowToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.viewInNewWindowToolStripMenuItem.Text = "&View in new Window";
            this.viewInNewWindowToolStripMenuItem.ToolTipText = "Show terminals in a new window";
            this.viewInNewWindowToolStripMenuItem.Click += new System.EventHandler(this.viewInNewWindowToolStripMenuItem_Click);
            // 
            // showInDualScreensToolStripMenuItem
            // 
            this.showInDualScreensToolStripMenuItem.Name = "showInDualScreensToolStripMenuItem";
            this.showInDualScreensToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.showInDualScreensToolStripMenuItem.Text = "Sh&ow In Multi Screens";
            this.showInDualScreensToolStripMenuItem.ToolTipText = "Show Terminals in all screen you have connected";
            this.showInDualScreensToolStripMenuItem.Click += new System.EventHandler(this.showInDualScreensToolStripMenuItem_Click);
            // 
            // favoritesToolStripMenuItem
            // 
            this.favoritesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageFavoritesToolStripMenuItem,
            this.organizeFavoritesToolbarToolStripMenuItem});
            this.favoritesToolStripMenuItem.Name = "favoritesToolStripMenuItem";
            this.favoritesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.favoritesToolStripMenuItem.Text = "F&avorites";
            // 
            // manageFavoritesToolStripMenuItem
            // 
            this.manageFavoritesToolStripMenuItem.Image = global::Terminals.Properties.Resources.star;
            this.manageFavoritesToolStripMenuItem.Name = "manageFavoritesToolStripMenuItem";
            this.manageFavoritesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.manageFavoritesToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.manageFavoritesToolStripMenuItem.Text = "&Organize Favorites";
            this.manageFavoritesToolStripMenuItem.ToolTipText = "Organize your favorite connections";
            this.manageFavoritesToolStripMenuItem.Click += new System.EventHandler(this.manageConnectionsToolStripMenuItem_Click);
            // 
            // organizeFavoritesToolbarToolStripMenuItem
            // 
            this.organizeFavoritesToolbarToolStripMenuItem.Name = "organizeFavoritesToolbarToolStripMenuItem";
            this.organizeFavoritesToolbarToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.organizeFavoritesToolbarToolStripMenuItem.Text = "Organize Favorites &Toolbar";
            this.organizeFavoritesToolbarToolStripMenuItem.ToolTipText = "Organize your favorite connections in toolbar";
            this.organizeFavoritesToolbarToolStripMenuItem.Click += new System.EventHandler(this.organizeFavoritesToolbarToolStripMenuItem_Click);
            // 
            // terminalToolStripMenuItem
            // 
            this.terminalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disconnectToolStripMenuItem});
            this.terminalToolStripMenuItem.Name = "terminalToolStripMenuItem";
            this.terminalToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.terminalToolStripMenuItem.Text = "&Terminal";
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Enabled = false;
            this.disconnectToolStripMenuItem.Image = global::Terminals.Properties.Resources.disconnect;
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F4)));
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.disconnectToolStripMenuItem.Text = "&Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.tsbDisconnect_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.captureTerminalScreenToolStripMenuItem,
            this.toolStripMenuItemCaptureManager,
            this.networkingToolsToolStripMenuItem,
            this.toolStripSeparator8,
            this.toolStripOrganizeShortucts,
            this.credentialManagementToolStripMenuItem,
            this.toolStripSeparator7,
            this.rebuildTagsIndexToolStripMenuItem,
            this.rebuildShortcutsToolStripMenuItem,
            this.rebuildToolbarsToolStripMenuItem,
            this.toolStripMenuItem6,
            this.openLogFolderToolStripMenuItem,
            this.openLogFileToolStripMenuItem,
            this.changeLogLevelToolStripMenuItem,
            this.emptyLogFileToolStripMenuItem,
            this.toolStripMenuItem2,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "T&ools";
            this.toolsToolStripMenuItem.DropDownOpening += new System.EventHandler(this.toolsToolStripMenuItem_DropDownOpening);
            // 
            // captureTerminalScreenToolStripMenuItem
            // 
            this.captureTerminalScreenToolStripMenuItem.Image = global::Terminals.Properties.Resources.camera;
            this.captureTerminalScreenToolStripMenuItem.Name = "captureTerminalScreenToolStripMenuItem";
            this.captureTerminalScreenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.captureTerminalScreenToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.captureTerminalScreenToolStripMenuItem.Text = "&Capture Terminal Screen";
            this.captureTerminalScreenToolStripMenuItem.ToolTipText = "Capture Terminal Screen";
            this.captureTerminalScreenToolStripMenuItem.Click += new System.EventHandler(this.captureTerminalScreenToolStripMenuItem_Click);
            // 
            // toolStripMenuItemCaptureManager
            // 
            this.toolStripMenuItemCaptureManager.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCaptureManager.Image")));
            this.toolStripMenuItemCaptureManager.Name = "toolStripMenuItemCaptureManager";
            this.toolStripMenuItemCaptureManager.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItemCaptureManager.Size = new System.Drawing.Size(276, 22);
            this.toolStripMenuItemCaptureManager.Text = "Screen Capture &Manager";
            this.toolStripMenuItemCaptureManager.ToolTipText = "Screen Capture Manager";
            this.toolStripMenuItemCaptureManager.Click += new System.EventHandler(this.toolStripMenuItemCaptureManager_Click);
            // 
            // networkingToolsToolStripMenuItem
            // 
            this.networkingToolsToolStripMenuItem.Image = global::Terminals.Properties.Resources.computer_link;
            this.networkingToolsToolStripMenuItem.Name = "networkingToolsToolStripMenuItem";
            this.networkingToolsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.networkingToolsToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.networkingToolsToolStripMenuItem.Text = "&Networking Tools";
            this.networkingToolsToolStripMenuItem.ToolTipText = "Networking Tools";
            this.networkingToolsToolStripMenuItem.Click += new System.EventHandler(this.networkingToolsToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(273, 6);
            // 
            // toolStripOrganizeShortucts
            // 
            this.toolStripOrganizeShortucts.Image = global::Terminals.Properties.Resources.application_edit;
            this.toolStripOrganizeShortucts.Name = "toolStripOrganizeShortucts";
            this.toolStripOrganizeShortucts.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.toolStripOrganizeShortucts.Size = new System.Drawing.Size(276, 22);
            this.toolStripOrganizeShortucts.Text = "Or&ganize Shortcuts";
            this.toolStripOrganizeShortucts.ToolTipText = "Organize Shortcuts";
            this.toolStripOrganizeShortucts.Click += new System.EventHandler(this.ToolStripOrganizeShortucts_Click);
            // 
            // credentialManagementToolStripMenuItem
            // 
            this.credentialManagementToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("credentialManagementToolStripMenuItem.Image")));
            this.credentialManagementToolStripMenuItem.Name = "credentialManagementToolStripMenuItem";
            this.credentialManagementToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.credentialManagementToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.credentialManagementToolStripMenuItem.Text = "C&redential Management";
            this.credentialManagementToolStripMenuItem.ToolTipText = "OPen Credential Management";
            this.credentialManagementToolStripMenuItem.Click += new System.EventHandler(this.credentialManagementToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(273, 6);
            // 
            // rebuildTagsIndexToolStripMenuItem
            // 
            this.rebuildTagsIndexToolStripMenuItem.Name = "rebuildTagsIndexToolStripMenuItem";
            this.rebuildTagsIndexToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.rebuildTagsIndexToolStripMenuItem.Text = "Rebuild &Tags Index";
            this.rebuildTagsIndexToolStripMenuItem.ToolTipText = "Recreates connection \"Tags\" list used by all connections.";
            this.rebuildTagsIndexToolStripMenuItem.Click += new System.EventHandler(this.rebuildTagsIndexToolStripMenuItem_Click);
            // 
            // rebuildShortcutsToolStripMenuItem
            // 
            this.rebuildShortcutsToolStripMenuItem.Name = "rebuildShortcutsToolStripMenuItem";
            this.rebuildShortcutsToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.rebuildShortcutsToolStripMenuItem.Text = "Rebuild &Shortcuts";
            this.rebuildShortcutsToolStripMenuItem.ToolTipText = "Recreates Shortcuts list to default state.";
            this.rebuildShortcutsToolStripMenuItem.Click += new System.EventHandler(this.rebuildShortcutsToolStripMenuItem_Click);
            // 
            // rebuildToolbarsToolStripMenuItem
            // 
            this.rebuildToolbarsToolStripMenuItem.Name = "rebuildToolbarsToolStripMenuItem";
            this.rebuildToolbarsToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.rebuildToolbarsToolStripMenuItem.Text = "&Rebuild Toolbars";
            this.rebuildToolbarsToolStripMenuItem.ToolTipText = "Restores last saved position of all Toolbars in main window";
            this.rebuildToolbarsToolStripMenuItem.Click += new System.EventHandler(this.rebuildToolbarsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(273, 6);
            // 
            // openLogFolderToolStripMenuItem
            // 
            this.openLogFolderToolStripMenuItem.Name = "openLogFolderToolStripMenuItem";
            this.openLogFolderToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.openLogFolderToolStripMenuItem.Text = "Open &Log Folder";
            this.openLogFolderToolStripMenuItem.ToolTipText = "Open Log Folder";
            this.openLogFolderToolStripMenuItem.Click += new System.EventHandler(this.openLogFolderToolStripMenuItem_Click);
            // 
            // openLogFileToolStripMenuItem
            // 
            this.openLogFileToolStripMenuItem.Name = "openLogFileToolStripMenuItem";
            this.openLogFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.openLogFileToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.openLogFileToolStripMenuItem.Text = "Open Log &File";
            this.openLogFileToolStripMenuItem.Click += new System.EventHandler(this.openLogFileToolStripMenuItem_Click);
            // 
            // changeLogLevelToolStripMenuItem
            // 
            this.changeLogLevelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetLogLevelToDebugToolStripMenuItem,
            this.SetLogLevelToInfoToolStripMenuItem});
            this.changeLogLevelToolStripMenuItem.Image = global::Terminals.Properties.Resources.ladybug;
            this.changeLogLevelToolStripMenuItem.Name = "changeLogLevelToolStripMenuItem";
            this.changeLogLevelToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.changeLogLevelToolStripMenuItem.Text = "Set Log Level";
            // 
            // SetLogLevelToDebugToolStripMenuItem
            // 
            this.SetLogLevelToDebugToolStripMenuItem.Image = global::Terminals.Properties.Resources.ladybug;
            this.SetLogLevelToDebugToolStripMenuItem.Name = "SetLogLevelToDebugToolStripMenuItem";
            this.SetLogLevelToDebugToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.SetLogLevelToDebugToolStripMenuItem.Text = "Debug";
            this.SetLogLevelToDebugToolStripMenuItem.Click += new System.EventHandler(this.SetLogLevelToDebugToolStripMenuItemClick);
            // 
            // SetLogLevelToInfoToolStripMenuItem
            // 
            this.SetLogLevelToInfoToolStripMenuItem.Image = global::Terminals.Properties.Resources.Information;
            this.SetLogLevelToInfoToolStripMenuItem.Name = "SetLogLevelToInfoToolStripMenuItem";
            this.SetLogLevelToInfoToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.SetLogLevelToInfoToolStripMenuItem.Text = "Info";
            this.SetLogLevelToInfoToolStripMenuItem.Click += new System.EventHandler(this.SetLogLevelToInfoToolStripMenuItemClick);
            // 
            // emptyLogFileToolStripMenuItem
            // 
            this.emptyLogFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("emptyLogFileToolStripMenuItem.Image")));
            this.emptyLogFileToolStripMenuItem.Name = "emptyLogFileToolStripMenuItem";
            this.emptyLogFileToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.emptyLogFileToolStripMenuItem.Text = "Empty Log File";
            this.emptyLogFileToolStripMenuItem.Click += new System.EventHandler(this.EmptyLogFileToolStripMenuItemClick);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(273, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Image = global::Terminals.Properties.Resources.ConfigTools;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.ToolTipText = "Open Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.organizeGroupsToolStripMenuItem,
            this.saveTerminalsAsGroupToolStripMenuItem,
            this.addTerminalToGroupToolStripMenuItem,
            this.groupsSeparator});
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            this.groupsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.groupsToolStripMenuItem.Text = "&Groups";
            this.groupsToolStripMenuItem.Visible = false;
            // 
            // organizeGroupsToolStripMenuItem
            // 
            this.organizeGroupsToolStripMenuItem.Name = "organizeGroupsToolStripMenuItem";
            this.organizeGroupsToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.organizeGroupsToolStripMenuItem.Text = "&Organize Groups";
            this.organizeGroupsToolStripMenuItem.ToolTipText = "Organize Groups";
            this.organizeGroupsToolStripMenuItem.Click += new System.EventHandler(this.organizeGroupsToolStripMenuItem_Click);
            // 
            // saveTerminalsAsGroupToolStripMenuItem
            // 
            this.saveTerminalsAsGroupToolStripMenuItem.Name = "saveTerminalsAsGroupToolStripMenuItem";
            this.saveTerminalsAsGroupToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.saveTerminalsAsGroupToolStripMenuItem.Text = "&Create Group From Active Connections";
            this.saveTerminalsAsGroupToolStripMenuItem.ToolTipText = "Create Group From Active Connections";
            this.saveTerminalsAsGroupToolStripMenuItem.Click += new System.EventHandler(this.saveTerminalsAsGroupToolStripMenuItem_Click);
            // 
            // addTerminalToGroupToolStripMenuItem
            // 
            this.addTerminalToGroupToolStripMenuItem.Name = "addTerminalToGroupToolStripMenuItem";
            this.addTerminalToGroupToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.addTerminalToGroupToolStripMenuItem.Text = "&Add Current Connection To";
            this.addTerminalToGroupToolStripMenuItem.ToolTipText = "Add Current Connection To";
            // 
            // groupsSeparator
            // 
            this.groupsSeparator.Name = "groupsSeparator";
            this.groupsSeparator.Size = new System.Drawing.Size(278, 6);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.updateToolStripItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.ToolTipText = "Open About Window";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // updateToolStripItem
            // 
            this.updateToolStripItem.Name = "updateToolStripItem";
            this.updateToolStripItem.Size = new System.Drawing.Size(251, 22);
            this.updateToolStripItem.Text = "Checking for a new &release online";
            this.updateToolStripItem.ToolTipText = "Check whether a new release is available";
            this.updateToolStripItem.Visible = false;
            this.updateToolStripItem.Click += new System.EventHandler(this.updateToolStripItem_Click);
            // 
            // favoriteToolBar
            // 
            this.favoriteToolBar.Dock = System.Windows.Forms.DockStyle.None;
            this.favoriteToolBar.Location = new System.Drawing.Point(3, 24);
            this.favoriteToolBar.Name = "favoriteToolBar";
            this.favoriteToolBar.Size = new System.Drawing.Size(111, 25);
            this.favoriteToolBar.TabIndex = 4;
            // 
            // SpecialCommandsToolStrip
            // 
            this.SpecialCommandsToolStrip.ContextMenuStrip = this.ShortcutsContextMenu;
            this.SpecialCommandsToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.SpecialCommandsToolStrip.Location = new System.Drawing.Point(3, 49);
            this.SpecialCommandsToolStrip.Name = "SpecialCommandsToolStrip";
            this.SpecialCommandsToolStrip.Size = new System.Drawing.Size(111, 25);
            this.SpecialCommandsToolStrip.TabIndex = 6;
            this.SpecialCommandsToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.SpecialCommandsToolStrip_ItemClicked_1);
            // 
            // toolbarStd
            // 
            this.toolbarStd.AllowItemReorder = true;
            this.toolbarStd.Dock = System.Windows.Forms.DockStyle.None;
            this.toolbarStd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewTerminal,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.tscConnectTo,
            this.tsbConnect,
            this.tsbConnectToConsole,
            this.toolStripSeparator5,
            this.tsbDisconnect,
            this.toolStripSeparator3,
            this.tsbManageConnections,
            this.CredentialManagementToolStripButton,
            this.toolStripSeparator2,
            this.tsbFullScreen,
            this.tsbFixDesktopSize,
            this.toolStripSeparator6,
            this.tsbTags,
            this.CaptureScreenToolStripButton,
            this.toolStripButtonCaptureManager,
            this.toolStripSeparator4,
            this.VMRCAdminSwitchButton,
            this.VMRCViewOnlyButton,
            this.tsbNetworkingTools,
            this.vncActionButton,
            this.tsbComputerManagement});
            this.toolbarStd.Location = new System.Drawing.Point(114, 49);
            this.toolbarStd.Name = "toolbarStd";
            this.toolbarStd.Size = new System.Drawing.Size(668, 25);
            this.toolbarStd.TabIndex = 2;
            // 
            // tsbNewTerminal
            // 
            this.tsbNewTerminal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewTerminal.Image = global::Terminals.Properties.Resources.add;
            this.tsbNewTerminal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewTerminal.Name = "tsbNewTerminal";
            this.tsbNewTerminal.Size = new System.Drawing.Size(23, 22);
            this.tsbNewTerminal.ToolTipText = "New Connection (Ctrl+N)";
            this.tsbNewTerminal.Click += new System.EventHandler(this.newTerminalToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel1.Text = "Search:";
            // 
            // tscConnectTo
            // 
            this.tscConnectTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tscConnectTo.Name = "tscConnectTo";
            this.tscConnectTo.Size = new System.Drawing.Size(199, 25);
            this.tscConnectTo.Sorted = true;
            this.tscConnectTo.ToolTipText = resources.GetString("tscConnectTo.ToolTipText");
            this.tscConnectTo.SelectedIndexChanged += new System.EventHandler(this.tscConnectTo_SelectedIndexChanged);
            this.tscConnectTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tscConnectTo_KeyDown);
            this.tscConnectTo.TextChanged += new System.EventHandler(this.tscConnectTo_TextChanged);
            // 
            // tsbConnect
            // 
            this.tsbConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbConnect.Enabled = false;
            this.tsbConnect.Image = global::Terminals.Properties.Resources.application_lightning;
            this.tsbConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConnect.Name = "tsbConnect";
            this.tsbConnect.Size = new System.Drawing.Size(23, 22);
            this.tsbConnect.ToolTipText = "Connect To Server";
            this.tsbConnect.Click += new System.EventHandler(this.tsbConnect_Click);
            // 
            // tsbConnectToConsole
            // 
            this.tsbConnectToConsole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbConnectToConsole.Enabled = false;
            this.tsbConnectToConsole.Image = global::Terminals.Properties.Resources.application_get;
            this.tsbConnectToConsole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConnectToConsole.Name = "tsbConnectToConsole";
            this.tsbConnectToConsole.Size = new System.Drawing.Size(23, 22);
            this.tsbConnectToConsole.ToolTipText = "Connect To Console";
            this.tsbConnectToConsole.Click += new System.EventHandler(this.tsbConnectToConsole_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbDisconnect
            // 
            this.tsbDisconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDisconnect.Enabled = false;
            this.tsbDisconnect.Image = global::Terminals.Properties.Resources.disconnect;
            this.tsbDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDisconnect.Name = "tsbDisconnect";
            this.tsbDisconnect.Size = new System.Drawing.Size(23, 22);
            this.tsbDisconnect.ToolTipText = "Disconnect From Server";
            this.tsbDisconnect.Click += new System.EventHandler(this.tsbDisconnect_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbManageConnections
            // 
            this.tsbManageConnections.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbManageConnections.Image = global::Terminals.Properties.Resources.star;
            this.tsbManageConnections.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbManageConnections.Name = "tsbManageConnections";
            this.tsbManageConnections.Size = new System.Drawing.Size(23, 22);
            this.tsbManageConnections.ToolTipText = "Organize Favorites";
            this.tsbManageConnections.Click += new System.EventHandler(this.manageConnectionsToolStripMenuItem_Click);
            // 
            // CredentialManagementToolStripButton
            // 
            this.CredentialManagementToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CredentialManagementToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CredentialManagementToolStripButton.Image")));
            this.CredentialManagementToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CredentialManagementToolStripButton.Name = "CredentialManagementToolStripButton";
            this.CredentialManagementToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.CredentialManagementToolStripButton.Text = "Credential Management";
            this.CredentialManagementToolStripButton.ToolTipText = "Credential Management";
            this.CredentialManagementToolStripButton.Click += new System.EventHandler(this.CredentialManagementToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbFullScreen
            // 
            this.tsbFullScreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFullScreen.Image = global::Terminals.Properties.Resources.arrow_out;
            this.tsbFullScreen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFullScreen.Name = "tsbFullScreen";
            this.tsbFullScreen.Size = new System.Drawing.Size(23, 22);
            this.tsbFullScreen.ToolTipText = "Full Screen (Alt + F11)";
            this.tsbFullScreen.Click += new System.EventHandler(this.tsbFullScreen_Click);
            // 
            // tsbFixDesktopSize
            // 
            this.tsbFixDesktopSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFixDesktopSize.Image = global::Terminals.Properties.Resources.Refresh;
            this.tsbFixDesktopSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFixDesktopSize.Name = "tsbFixDesktopSize";
            this.tsbFixDesktopSize.Size = new System.Drawing.Size(23, 22);
            this.tsbFixDesktopSize.Text = "Fix current connection\'s content size";
            this.tsbFixDesktopSize.Click += new System.EventHandler(this.TsbFixDesktopSize_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbTags
            // 
            this.tsbTags.CheckOnClick = true;
            this.tsbTags.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTags.Image = global::Terminals.Properties.Resources.tag;
            this.tsbTags.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTags.Name = "tsbTags";
            this.tsbTags.Size = new System.Drawing.Size(23, 22);
            this.tsbTags.ToolTipText = "Show/Hide Tags pane";
            this.tsbTags.Click += new System.EventHandler(this.tsbTags_Click);
            // 
            // CaptureScreenToolStripButton
            // 
            this.CaptureScreenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CaptureScreenToolStripButton.Image = global::Terminals.Properties.Resources.camera;
            this.CaptureScreenToolStripButton.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.CaptureScreenToolStripButton.Name = "CaptureScreenToolStripButton";
            this.CaptureScreenToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.CaptureScreenToolStripButton.Click += new System.EventHandler(this.CaptureScreenToolStripButton_Click);
            // 
            // toolStripButtonCaptureManager
            // 
            this.toolStripButtonCaptureManager.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCaptureManager.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCaptureManager.Image")));
            this.toolStripButtonCaptureManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCaptureManager.Name = "toolStripButtonCaptureManager";
            this.toolStripButtonCaptureManager.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCaptureManager.Text = "Screen Capture Manager";
            this.toolStripButtonCaptureManager.Click += new System.EventHandler(this.toolStripButtonCaptureManager_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // VMRCAdminSwitchButton
            // 
            this.VMRCAdminSwitchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.VMRCAdminSwitchButton.Image = global::Terminals.Properties.Resources.server_administrator_icon;
            this.VMRCAdminSwitchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.VMRCAdminSwitchButton.Name = "VMRCAdminSwitchButton";
            this.VMRCAdminSwitchButton.Size = new System.Drawing.Size(23, 22);
            this.VMRCAdminSwitchButton.Text = "VMRC: Switch to Administrator View";
            this.VMRCAdminSwitchButton.Click += new System.EventHandler(this.VMRCAdminSwitchButton_Click);
            // 
            // VMRCViewOnlyButton
            // 
            this.VMRCViewOnlyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.VMRCViewOnlyButton.Image = ((System.Drawing.Image)(resources.GetObject("VMRCViewOnlyButton.Image")));
            this.VMRCViewOnlyButton.ImageTransparentColor = System.Drawing.Color.White;
            this.VMRCViewOnlyButton.Name = "VMRCViewOnlyButton";
            this.VMRCViewOnlyButton.Size = new System.Drawing.Size(23, 22);
            this.VMRCViewOnlyButton.Text = "VMRC: View Only Mode";
            this.VMRCViewOnlyButton.Click += new System.EventHandler(this.VMRCViewOnlyButton_Click);
            // 
            // tsbNetworkingTools
            // 
            this.tsbNetworkingTools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNetworkingTools.Image = global::Terminals.Properties.Resources.computer_link;
            this.tsbNetworkingTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNetworkingTools.Name = "tsbNetworkingTools";
            this.tsbNetworkingTools.Size = new System.Drawing.Size(23, 22);
            this.tsbNetworkingTools.Text = "Networking Tools";
            this.tsbNetworkingTools.Click += new System.EventHandler(this.TsbNetworkingTools_Click);
            // 
            // vncActionButton
            // 
            this.vncActionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vncActionButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendALTKeyToolStripMenuItem,
            this.sendALTF4KeyToolStripMenuItem,
            this.sendCTRLKeyToolStripMenuItem,
            this.sendCTRLESCKeysToolStripMenuItem,
            this.sentCTRLALTDELETEKeysToolStripMenuItem});
            this.vncActionButton.Image = ((System.Drawing.Image)(resources.GetObject("vncActionButton.Image")));
            this.vncActionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.vncActionButton.Name = "vncActionButton";
            this.vncActionButton.Size = new System.Drawing.Size(29, 22);
            this.vncActionButton.Text = "toolStripButton4";
            // 
            // sendALTKeyToolStripMenuItem
            // 
            this.sendALTKeyToolStripMenuItem.Name = "sendALTKeyToolStripMenuItem";
            this.sendALTKeyToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.sendALTKeyToolStripMenuItem.Text = "Send ALT Key";
            this.sendALTKeyToolStripMenuItem.Click += new System.EventHandler(this.sendALTKeyToolStripMenuItem_Click);
            // 
            // sendALTF4KeyToolStripMenuItem
            // 
            this.sendALTF4KeyToolStripMenuItem.Name = "sendALTF4KeyToolStripMenuItem";
            this.sendALTF4KeyToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.sendALTF4KeyToolStripMenuItem.Text = "Send ALT-F4 Keys";
            this.sendALTF4KeyToolStripMenuItem.Click += new System.EventHandler(this.sendALTKeyToolStripMenuItem_Click);
            // 
            // sendCTRLKeyToolStripMenuItem
            // 
            this.sendCTRLKeyToolStripMenuItem.Name = "sendCTRLKeyToolStripMenuItem";
            this.sendCTRLKeyToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.sendCTRLKeyToolStripMenuItem.Text = "Send CTRL Key";
            this.sendCTRLKeyToolStripMenuItem.Click += new System.EventHandler(this.sendALTKeyToolStripMenuItem_Click);
            // 
            // sendCTRLESCKeysToolStripMenuItem
            // 
            this.sendCTRLESCKeysToolStripMenuItem.Name = "sendCTRLESCKeysToolStripMenuItem";
            this.sendCTRLESCKeysToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.sendCTRLESCKeysToolStripMenuItem.Text = "Send CTRL ESC Keys";
            this.sendCTRLESCKeysToolStripMenuItem.Click += new System.EventHandler(this.sendALTKeyToolStripMenuItem_Click);
            // 
            // sentCTRLALTDELETEKeysToolStripMenuItem
            // 
            this.sentCTRLALTDELETEKeysToolStripMenuItem.Name = "sentCTRLALTDELETEKeysToolStripMenuItem";
            this.sentCTRLALTDELETEKeysToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.sentCTRLALTDELETEKeysToolStripMenuItem.Text = "Sent CTRL ALT DEL Keys";
            this.sentCTRLALTDELETEKeysToolStripMenuItem.Click += new System.EventHandler(this.sendALTKeyToolStripMenuItem_Click);
            // 
            // tsbComputerManagement
            // 
            this.tsbComputerManagement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbComputerManagement.Image = global::Terminals.Properties.Resources.CompMgmt;
            this.tsbComputerManagement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbComputerManagement.Name = "tsbComputerManagement";
            this.tsbComputerManagement.Size = new System.Drawing.Size(23, 22);
            this.tsbComputerManagement.Text = "Computer Management (MMC)";
            this.tsbComputerManagement.Click += new System.EventHandler(this.TsbComputerManagement_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(961, 573);
            this.Controls.Add(this.toolStripContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(100, 100);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Terminals";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ShortcutsContextMenu.ResumeLayout(false);
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlTagsFavorites.ResumeLayout(false);
            this.pnlHideTagsFavorites.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHideTagsFavorites)).EndInit();
            this.pnlShowTagsFavorites.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbShowTagsFavorites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcTerminals)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolbarStd.ResumeLayout(false);
            this.toolbarStd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTerminalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolbarStd;
        private System.Windows.Forms.ToolStripButton tsbNewTerminal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox tscConnectTo;
        private System.Windows.Forms.ToolStripButton tsbConnect;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbDisconnect;
        private System.Windows.Forms.ToolStripMenuItem terminalToolStripMenuItem;
        private Connection.TabControl.TabControl tcTerminals;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbManageConnections;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbFullScreen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem favoritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageFavoritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizeGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTerminalsAsGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTerminalToGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator groupsSeparator;
        private Terminals.Forms.Controls.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.Timer timerHover;
        private System.Windows.Forms.ToolStripMenuItem organizeFavoritesToolbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbTags;
        private System.Windows.Forms.Panel pnlTagsFavorites;
        private System.Windows.Forms.Panel pnlHideTagsFavorites;
        private System.Windows.Forms.PictureBox pbHideTagsFavorites;
        private System.Windows.Forms.Panel pnlShowTagsFavorites;
        private System.Windows.Forms.PictureBox pbShowTagsFavorites;
        private System.Windows.Forms.ImageList ilTagConnections;
        private System.Windows.Forms.ImageList ilTags;
        private System.Windows.Forms.NotifyIcon MainWindowNotifyIcon;
        private System.Windows.Forms.ToolStripButton CaptureScreenToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem captureTerminalScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton VMRCAdminSwitchButton;
        private System.Windows.Forms.ToolStripButton VMRCViewOnlyButton;
        private System.Windows.Forms.ContextMenuStrip QuickContextMenu;
        private System.Windows.Forms.ToolStrip favoriteToolBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem toolStripOrganizeShortucts;
        private System.Windows.Forms.ContextMenuStrip ShortcutsContextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStrip SpecialCommandsToolStrip;
        private System.Windows.Forms.ToolStripButton tsbNetworkingTools;
        private System.Windows.Forms.ToolStripMenuItem networkingToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCaptureManager;
        private System.Windows.Forms.ToolStripButton toolStripButtonCaptureManager;
        private System.Windows.Forms.ToolStripDropDownButton vncActionButton;
        private System.Windows.Forms.ToolStripMenuItem sendALTKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendALTF4KeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendCTRLKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendCTRLESCKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sentCTRLALTDELETEKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbFixDesktopSize;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem standardToolbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowHideFavoriteToolbar;
        private System.Windows.Forms.ToolStripMenuItem shortcutsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lockToolbarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripItem;
        private System.Windows.Forms.ToolStripButton tsbComputerManagement;
        private System.Windows.Forms.ToolStripMenuItem rebuildTagsIndexToolStripMenuItem;
        private Terminals.Forms.Controls.FavsList favsList1;
        private System.Windows.Forms.ToolStripMenuItem viewInNewWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rebuildShortcutsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rebuildToolbarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem credentialManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton CredentialManagementToolStripButton;
        private System.Windows.Forms.ToolStripButton tsbConnectToConsole;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem showInDualScreensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menubarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemImport;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExport;
        private System.Windows.Forms.ToolStripMenuItem openLogFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLogFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emptyLogFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeLogLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetLogLevelToDebugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetLogLevelToInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}
