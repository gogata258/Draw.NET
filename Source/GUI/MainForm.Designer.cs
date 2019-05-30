namespace Draw.GUI
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;


		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		public void InitializeComponent( )
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mainMenu = new System.Windows.Forms.MenuStrip();
			this.mainMenu_ToolStrip_File = new System.Windows.Forms.ToolStripMenuItem();
			this.fileSubMenu_ToolStrip_Load = new System.Windows.Forms.ToolStripMenuItem();
			this.fileSubMenu_ToolStrip_Save = new System.Windows.Forms.ToolStripMenuItem();
			this.fileSubMenu_ToolStrip_Exit = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenu_ToolStrip_Image = new System.Windows.Forms.ToolStripMenuItem();
			this.imageSubMenu_ToolStrip_Export = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenu_ToolStrip_Help = new System.Windows.Forms.ToolStripMenuItem();
			this.helpSubMenu_ToolStrip_About = new System.Windows.Forms.ToolStripMenuItem();
			this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.quickActionsMenu = new System.Windows.Forms.ToolStrip();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.propertiesSideWindow = new System.Windows.Forms.FlowLayoutPanel();
			this.nameLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.nameLabel = new System.Windows.Forms.Label();
			this.nameTextbox = new System.Windows.Forms.TextBox();
			this.sizeLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.scaleLabel = new System.Windows.Forms.Label();
			this.scaleXLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.scaleXLabel = new System.Windows.Forms.Label();
			this.scaleXTextBox = new System.Windows.Forms.TextBox();
			this.scaleYLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.scaleYLabel = new System.Windows.Forms.Label();
			this.scaleYTextBox = new System.Windows.Forms.TextBox();
			this.locationLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.locationLabel = new System.Windows.Forms.Label();
			this.locXLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.locXLabel = new System.Windows.Forms.Label();
			this.LocXTextbox = new System.Windows.Forms.TextBox();
			this.locYLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.locYLabel = new System.Windows.Forms.Label();
			this.LocYTextbox = new System.Windows.Forms.TextBox();
			this.rotationLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.rotationLabel = new System.Windows.Forms.Label();
			this.rotationTextbox = new System.Windows.Forms.TextBox();
			this.colorLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.visualLabel = new System.Windows.Forms.Label();
			this.fillLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.fillColorLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.fillColorLabel = new System.Windows.Forms.Label();
			this.fillColorButton = new System.Windows.Forms.Button();
			this.fillAlphaLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.fillAlphaLabel = new System.Windows.Forms.Label();
			this.fillAlphaTextbox = new System.Windows.Forms.TextBox();
			this.borderLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.borderColorLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.borderColorLabel = new System.Windows.Forms.Label();
			this.borderColorButton = new System.Windows.Forms.Button();
			this.borderAlphaLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.borderAlphaLabel = new System.Windows.Forms.Label();
			this.borderAlphaTextbox = new System.Windows.Forms.TextBox();
			this.borderThicknessLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.borderThicknessLabel = new System.Windows.Forms.Label();
			this.borderThicknessTextbox = new System.Windows.Forms.TextBox();
			this.hierarchyListbox = new System.Windows.Forms.ListBox();
			this.rootContainer = new System.Windows.Forms.SplitContainer();
			this.ControlsContainer = new System.Windows.Forms.SplitContainer();
			this.viewPort = new Draw.DoubleBufferedPanel();
			this.dialogSave = new System.Windows.Forms.SaveFileDialog();
			this.dialogOpen = new System.Windows.Forms.OpenFileDialog();
			this.dialogExport = new System.Windows.Forms.SaveFileDialog();
			this.dialogColorFill = new System.Windows.Forms.ColorDialog();
			this.dialogColorBorder = new System.Windows.Forms.ColorDialog();
			this.quickAction_Draw_Elipse = new System.Windows.Forms.ToolStripButton();
			this.quickAction_Draw_Rect = new System.Windows.Forms.ToolStripButton();
			this.quickAction_Draw_Triangle = new System.Windows.Forms.ToolStripButton();
			this.quickAction_Draw_Envelope = new System.Windows.Forms.ToolStripButton();
			this.quickAction_Toggle_Select = new System.Windows.Forms.ToolStripButton();
			this.quickAction_Toggle_Move = new System.Windows.Forms.ToolStripButton();
			this.quickAction_Toggle_Rotate = new System.Windows.Forms.ToolStripButton();
			this.quickAction_Toggle_Scale = new System.Windows.Forms.ToolStripButton();
			this.quickAction_Tool_Group = new System.Windows.Forms.ToolStripButton();
			this.quickAction_Tool_UnGroup = new System.Windows.Forms.ToolStripButton();
			this.quickAction_Tool_Delete = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.mainMenu.SuspendLayout();
			this.quickActionsMenu.SuspendLayout();
			this.propertiesSideWindow.SuspendLayout();
			this.nameLayout.SuspendLayout();
			this.sizeLayout.SuspendLayout();
			this.scaleXLayout.SuspendLayout();
			this.scaleYLayout.SuspendLayout();
			this.locationLayout.SuspendLayout();
			this.locXLayout.SuspendLayout();
			this.locYLayout.SuspendLayout();
			this.rotationLayout.SuspendLayout();
			this.colorLayout.SuspendLayout();
			this.fillLayout.SuspendLayout();
			this.fillColorLayout.SuspendLayout();
			this.fillAlphaLayout.SuspendLayout();
			this.borderLayout.SuspendLayout();
			this.borderColorLayout.SuspendLayout();
			this.borderAlphaLayout.SuspendLayout();
			this.borderThicknessLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.rootContainer)).BeginInit();
			this.rootContainer.Panel1.SuspendLayout();
			this.rootContainer.Panel2.SuspendLayout();
			this.rootContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ControlsContainer)).BeginInit();
			this.ControlsContainer.Panel1.SuspendLayout();
			this.ControlsContainer.Panel2.SuspendLayout();
			this.ControlsContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenu
			// 
			this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenu_ToolStrip_File,
            this.mainMenu_ToolStrip_Image,
            this.mainMenu_ToolStrip_Help});
			this.mainMenu.Location = new System.Drawing.Point(0, 0);
			this.mainMenu.Name = "mainMenu";
			this.mainMenu.Size = new System.Drawing.Size(1264, 24);
			this.mainMenu.TabIndex = 1;
			this.mainMenu.Text = "Main Menu";
			// 
			// mainMenu_ToolStrip_File
			// 
			this.mainMenu_ToolStrip_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileSubMenu_ToolStrip_Load,
            this.fileSubMenu_ToolStrip_Save,
            this.fileSubMenu_ToolStrip_Exit});
			this.mainMenu_ToolStrip_File.Name = "mainMenu_ToolStrip_File";
			this.mainMenu_ToolStrip_File.Size = new System.Drawing.Size(37, 20);
			this.mainMenu_ToolStrip_File.Text = "File";
			// 
			// fileSubMenu_ToolStrip_Load
			// 
			this.fileSubMenu_ToolStrip_Load.Name = "fileSubMenu_ToolStrip_Load";
			this.fileSubMenu_ToolStrip_Load.Size = new System.Drawing.Size(100, 22);
			this.fileSubMenu_ToolStrip_Load.Text = "Load";
			this.fileSubMenu_ToolStrip_Load.Click += new System.EventHandler(this.ToolStripMenuItem_Load_Click);
			// 
			// fileSubMenu_ToolStrip_Save
			// 
			this.fileSubMenu_ToolStrip_Save.Name = "fileSubMenu_ToolStrip_Save";
			this.fileSubMenu_ToolStrip_Save.Size = new System.Drawing.Size(100, 22);
			this.fileSubMenu_ToolStrip_Save.Text = "Save";
			this.fileSubMenu_ToolStrip_Save.Click += new System.EventHandler(this.ToolStripMenuItem_Save_Click);
			// 
			// fileSubMenu_ToolStrip_Exit
			// 
			this.fileSubMenu_ToolStrip_Exit.Name = "fileSubMenu_ToolStrip_Exit";
			this.fileSubMenu_ToolStrip_Exit.Size = new System.Drawing.Size(100, 22);
			this.fileSubMenu_ToolStrip_Exit.Text = "Exit";
			this.fileSubMenu_ToolStrip_Exit.Click += new System.EventHandler(this.ToolStripMenuItem_Exit_Click);
			// 
			// mainMenu_ToolStrip_Image
			// 
			this.mainMenu_ToolStrip_Image.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageSubMenu_ToolStrip_Export});
			this.mainMenu_ToolStrip_Image.Name = "mainMenu_ToolStrip_Image";
			this.mainMenu_ToolStrip_Image.Size = new System.Drawing.Size(52, 20);
			this.mainMenu_ToolStrip_Image.Text = "Image";
			// 
			// imageSubMenu_ToolStrip_Export
			// 
			this.imageSubMenu_ToolStrip_Export.Name = "imageSubMenu_ToolStrip_Export";
			this.imageSubMenu_ToolStrip_Export.Size = new System.Drawing.Size(107, 22);
			this.imageSubMenu_ToolStrip_Export.Text = "Export";
			this.imageSubMenu_ToolStrip_Export.Click += new System.EventHandler(this.ToolStripMenuItem_Export_Click);
			// 
			// mainMenu_ToolStrip_Help
			// 
			this.mainMenu_ToolStrip_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpSubMenu_ToolStrip_About});
			this.mainMenu_ToolStrip_Help.Name = "mainMenu_ToolStrip_Help";
			this.mainMenu_ToolStrip_Help.Size = new System.Drawing.Size(44, 20);
			this.mainMenu_ToolStrip_Help.Text = "Help";
			// 
			// helpSubMenu_ToolStrip_About
			// 
			this.helpSubMenu_ToolStrip_About.Name = "helpSubMenu_ToolStrip_About";
			this.helpSubMenu_ToolStrip_About.Size = new System.Drawing.Size(116, 22);
			this.helpSubMenu_ToolStrip_About.Text = "About...";
			// 
			// currentStatusLabel
			// 
			this.currentStatusLabel.Name = "currentStatusLabel";
			this.currentStatusLabel.Size = new System.Drawing.Size(0, 17);
			// 
			// quickActionsMenu
			// 
			this.quickActionsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quickAction_Draw_Elipse,
            this.quickAction_Draw_Rect,
            this.quickAction_Draw_Triangle,
            this.quickAction_Draw_Envelope,
            this.toolStripSeparator1,
            this.quickAction_Toggle_Select,
            this.quickAction_Toggle_Move,
            this.quickAction_Toggle_Rotate,
            this.quickAction_Toggle_Scale,
            this.toolStripSeparator2,
            this.quickAction_Tool_Group,
            this.quickAction_Tool_UnGroup,
            this.toolStripSeparator3,
            this.quickAction_Tool_Delete});
			this.quickActionsMenu.Location = new System.Drawing.Point(0, 24);
			this.quickActionsMenu.Name = "quickActionsMenu";
			this.quickActionsMenu.Size = new System.Drawing.Size(1264, 25);
			this.quickActionsMenu.TabIndex = 3;
			this.quickActionsMenu.Text = "toolStrip1";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// propertiesSideWindow
			// 
			this.propertiesSideWindow.AutoSize = true;
			this.propertiesSideWindow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.propertiesSideWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.propertiesSideWindow.Controls.Add(this.nameLayout);
			this.propertiesSideWindow.Controls.Add(this.sizeLayout);
			this.propertiesSideWindow.Controls.Add(this.locationLayout);
			this.propertiesSideWindow.Controls.Add(this.rotationLayout);
			this.propertiesSideWindow.Controls.Add(this.colorLayout);
			this.propertiesSideWindow.Dock = System.Windows.Forms.DockStyle.Fill;
			this.propertiesSideWindow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.propertiesSideWindow.Location = new System.Drawing.Point(0, 0);
			this.propertiesSideWindow.Margin = new System.Windows.Forms.Padding(0);
			this.propertiesSideWindow.MaximumSize = new System.Drawing.Size(400, 600);
			this.propertiesSideWindow.MinimumSize = new System.Drawing.Size(100, 200);
			this.propertiesSideWindow.Name = "propertiesSideWindow";
			this.propertiesSideWindow.Size = new System.Drawing.Size(340, 290);
			this.propertiesSideWindow.TabIndex = 5;
			this.propertiesSideWindow.WrapContents = false;
			// 
			// nameLayout
			// 
			this.nameLayout.AutoSize = true;
			this.nameLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.nameLayout.Controls.Add(this.nameLabel);
			this.nameLayout.Controls.Add(this.nameTextbox);
			this.nameLayout.Dock = System.Windows.Forms.DockStyle.Left;
			this.nameLayout.Location = new System.Drawing.Point(3, 3);
			this.nameLayout.Name = "nameLayout";
			this.nameLayout.Size = new System.Drawing.Size(138, 26);
			this.nameLayout.TabIndex = 11;
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameLabel.Location = new System.Drawing.Point(0, 0);
			this.nameLabel.Margin = new System.Windows.Forms.Padding(0);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(52, 26);
			this.nameLabel.TabIndex = 1;
			this.nameLabel.Text = "Name:";
			this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// nameTextbox
			// 
			this.nameTextbox.Location = new System.Drawing.Point(55, 3);
			this.nameTextbox.Name = "nameTextbox";
			this.nameTextbox.Size = new System.Drawing.Size(80, 20);
			this.nameTextbox.TabIndex = 0;
			this.nameTextbox.TextChanged += new System.EventHandler(this.PropertyTextBox_TextChanged);
			// 
			// sizeLayout
			// 
			this.sizeLayout.AutoSize = true;
			this.sizeLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.sizeLayout.Controls.Add(this.scaleLabel);
			this.sizeLayout.Controls.Add(this.scaleXLayout);
			this.sizeLayout.Controls.Add(this.scaleYLayout);
			this.sizeLayout.Dock = System.Windows.Forms.DockStyle.Left;
			this.sizeLayout.Location = new System.Drawing.Point(3, 35);
			this.sizeLayout.Name = "sizeLayout";
			this.sizeLayout.Size = new System.Drawing.Size(242, 32);
			this.sizeLayout.TabIndex = 8;
			// 
			// scaleLabel
			// 
			this.scaleLabel.AutoSize = true;
			this.scaleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scaleLabel.Location = new System.Drawing.Point(0, 0);
			this.scaleLabel.Margin = new System.Windows.Forms.Padding(0);
			this.scaleLabel.Name = "scaleLabel";
			this.scaleLabel.Size = new System.Drawing.Size(49, 32);
			this.scaleLabel.TabIndex = 1;
			this.scaleLabel.Text = "Scale:";
			this.scaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// scaleXLayout
			// 
			this.scaleXLayout.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.scaleXLayout.AutoSize = true;
			this.scaleXLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.scaleXLayout.Controls.Add(this.scaleXLabel);
			this.scaleXLayout.Controls.Add(this.scaleXTextBox);
			this.scaleXLayout.Location = new System.Drawing.Point(52, 3);
			this.scaleXLayout.Name = "scaleXLayout";
			this.scaleXLayout.Size = new System.Drawing.Size(91, 26);
			this.scaleXLayout.TabIndex = 0;
			// 
			// scaleXLabel
			// 
			this.scaleXLabel.AutoSize = true;
			this.scaleXLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scaleXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scaleXLabel.Location = new System.Drawing.Point(0, 0);
			this.scaleXLabel.Margin = new System.Windows.Forms.Padding(0);
			this.scaleXLabel.Name = "scaleXLabel";
			this.scaleXLabel.Size = new System.Drawing.Size(15, 26);
			this.scaleXLabel.TabIndex = 1;
			this.scaleXLabel.Text = "X";
			this.scaleXLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// scaleXTextBox
			// 
			this.scaleXTextBox.Location = new System.Drawing.Point(18, 3);
			this.scaleXTextBox.Name = "scaleXTextBox";
			this.scaleXTextBox.Size = new System.Drawing.Size(70, 20);
			this.scaleXTextBox.TabIndex = 0;
			this.scaleXTextBox.TextChanged += new System.EventHandler(this.PropertyTextBox_TextChanged);
			// 
			// scaleYLayout
			// 
			this.scaleYLayout.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.scaleYLayout.AutoSize = true;
			this.scaleYLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.scaleYLayout.Controls.Add(this.scaleYLabel);
			this.scaleYLayout.Controls.Add(this.scaleYTextBox);
			this.scaleYLayout.Location = new System.Drawing.Point(149, 3);
			this.scaleYLayout.Name = "scaleYLayout";
			this.scaleYLayout.Size = new System.Drawing.Size(90, 26);
			this.scaleYLayout.TabIndex = 1;
			// 
			// scaleYLabel
			// 
			this.scaleYLabel.AutoSize = true;
			this.scaleYLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scaleYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scaleYLabel.Location = new System.Drawing.Point(0, 0);
			this.scaleYLabel.Margin = new System.Windows.Forms.Padding(0);
			this.scaleYLabel.Name = "scaleYLabel";
			this.scaleYLabel.Size = new System.Drawing.Size(14, 26);
			this.scaleYLabel.TabIndex = 1;
			this.scaleYLabel.Text = "Y";
			this.scaleYLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// scaleYTextBox
			// 
			this.scaleYTextBox.Location = new System.Drawing.Point(17, 3);
			this.scaleYTextBox.Name = "scaleYTextBox";
			this.scaleYTextBox.Size = new System.Drawing.Size(70, 20);
			this.scaleYTextBox.TabIndex = 0;
			this.scaleYTextBox.TextChanged += new System.EventHandler(this.PropertyTextBox_TextChanged);
			// 
			// locationLayout
			// 
			this.locationLayout.AutoSize = true;
			this.locationLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.locationLayout.Controls.Add(this.locationLabel);
			this.locationLayout.Controls.Add(this.locXLayout);
			this.locationLayout.Controls.Add(this.locYLayout);
			this.locationLayout.Dock = System.Windows.Forms.DockStyle.Left;
			this.locationLayout.Location = new System.Drawing.Point(3, 73);
			this.locationLayout.Name = "locationLayout";
			this.locationLayout.Size = new System.Drawing.Size(282, 32);
			this.locationLayout.TabIndex = 9;
			// 
			// locationLabel
			// 
			this.locationLabel.AutoSize = true;
			this.locationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.locationLabel.Location = new System.Drawing.Point(0, 0);
			this.locationLabel.Margin = new System.Windows.Forms.Padding(0);
			this.locationLabel.Name = "locationLabel";
			this.locationLabel.Size = new System.Drawing.Size(69, 32);
			this.locationLabel.TabIndex = 1;
			this.locationLabel.Text = "Location:";
			this.locationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// locXLayout
			// 
			this.locXLayout.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.locXLayout.AutoSize = true;
			this.locXLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.locXLayout.Controls.Add(this.locXLabel);
			this.locXLayout.Controls.Add(this.LocXTextbox);
			this.locXLayout.Location = new System.Drawing.Point(72, 3);
			this.locXLayout.Name = "locXLayout";
			this.locXLayout.Size = new System.Drawing.Size(101, 26);
			this.locXLayout.TabIndex = 2;
			// 
			// locXLabel
			// 
			this.locXLabel.AutoSize = true;
			this.locXLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.locXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.locXLabel.Location = new System.Drawing.Point(0, 0);
			this.locXLabel.Margin = new System.Windows.Forms.Padding(0);
			this.locXLabel.Name = "locXLabel";
			this.locXLabel.Size = new System.Drawing.Size(15, 26);
			this.locXLabel.TabIndex = 1;
			this.locXLabel.Text = "X";
			this.locXLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LocXTextbox
			// 
			this.LocXTextbox.Location = new System.Drawing.Point(18, 3);
			this.LocXTextbox.Name = "LocXTextbox";
			this.LocXTextbox.Size = new System.Drawing.Size(80, 20);
			this.LocXTextbox.TabIndex = 0;
			this.LocXTextbox.TextChanged += new System.EventHandler(this.PropertyTextBox_TextChanged);
			// 
			// locYLayout
			// 
			this.locYLayout.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.locYLayout.AutoSize = true;
			this.locYLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.locYLayout.Controls.Add(this.locYLabel);
			this.locYLayout.Controls.Add(this.LocYTextbox);
			this.locYLayout.Location = new System.Drawing.Point(179, 3);
			this.locYLayout.Name = "locYLayout";
			this.locYLayout.Size = new System.Drawing.Size(100, 26);
			this.locYLayout.TabIndex = 2;
			// 
			// locYLabel
			// 
			this.locYLabel.AutoSize = true;
			this.locYLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.locYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.locYLabel.Location = new System.Drawing.Point(0, 0);
			this.locYLabel.Margin = new System.Windows.Forms.Padding(0);
			this.locYLabel.Name = "locYLabel";
			this.locYLabel.Size = new System.Drawing.Size(14, 26);
			this.locYLabel.TabIndex = 1;
			this.locYLabel.Text = "Y";
			this.locYLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LocYTextbox
			// 
			this.LocYTextbox.Location = new System.Drawing.Point(17, 3);
			this.LocYTextbox.Name = "LocYTextbox";
			this.LocYTextbox.Size = new System.Drawing.Size(80, 20);
			this.LocYTextbox.TabIndex = 0;
			this.LocYTextbox.TextChanged += new System.EventHandler(this.PropertyTextBox_TextChanged);
			// 
			// rotationLayout
			// 
			this.rotationLayout.AutoSize = true;
			this.rotationLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.rotationLayout.Controls.Add(this.rotationLabel);
			this.rotationLayout.Controls.Add(this.rotationTextbox);
			this.rotationLayout.Dock = System.Windows.Forms.DockStyle.Left;
			this.rotationLayout.Location = new System.Drawing.Point(3, 111);
			this.rotationLayout.Name = "rotationLayout";
			this.rotationLayout.Size = new System.Drawing.Size(194, 26);
			this.rotationLayout.TabIndex = 10;
			// 
			// rotationLabel
			// 
			this.rotationLabel.AutoSize = true;
			this.rotationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rotationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rotationLabel.Location = new System.Drawing.Point(0, 0);
			this.rotationLabel.Margin = new System.Windows.Forms.Padding(0);
			this.rotationLabel.Name = "rotationLabel";
			this.rotationLabel.Size = new System.Drawing.Size(108, 26);
			this.rotationLabel.TabIndex = 1;
			this.rotationLabel.Text = "Rotation Angle:";
			this.rotationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rotationTextbox
			// 
			this.rotationTextbox.Location = new System.Drawing.Point(111, 3);
			this.rotationTextbox.Name = "rotationTextbox";
			this.rotationTextbox.Size = new System.Drawing.Size(80, 20);
			this.rotationTextbox.TabIndex = 0;
			this.rotationTextbox.TextChanged += new System.EventHandler(this.PropertyTextBox_TextChanged);
			// 
			// colorLayout
			// 
			this.colorLayout.AutoSize = true;
			this.colorLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.colorLayout.Controls.Add(this.visualLabel);
			this.colorLayout.Controls.Add(this.fillLayout);
			this.colorLayout.Controls.Add(this.borderLayout);
			this.colorLayout.Dock = System.Windows.Forms.DockStyle.Left;
			this.colorLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.colorLayout.Location = new System.Drawing.Point(3, 143);
			this.colorLayout.Name = "colorLayout";
			this.colorLayout.Size = new System.Drawing.Size(330, 104);
			this.colorLayout.TabIndex = 4;
			this.colorLayout.WrapContents = false;
			// 
			// visualLabel
			// 
			this.visualLabel.AutoSize = true;
			this.visualLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.visualLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.visualLabel.Location = new System.Drawing.Point(0, 0);
			this.visualLabel.Margin = new System.Windows.Forms.Padding(0);
			this.visualLabel.Name = "visualLabel";
			this.visualLabel.Size = new System.Drawing.Size(330, 18);
			this.visualLabel.TabIndex = 1;
			this.visualLabel.Text = "Visual Properties:";
			this.visualLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// fillLayout
			// 
			this.fillLayout.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.fillLayout.AutoSize = true;
			this.fillLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.fillLayout.Controls.Add(this.fillColorLayout);
			this.fillLayout.Controls.Add(this.fillAlphaLayout);
			this.fillLayout.Location = new System.Drawing.Point(82, 21);
			this.fillLayout.Name = "fillLayout";
			this.fillLayout.Size = new System.Drawing.Size(166, 37);
			this.fillLayout.TabIndex = 7;
			// 
			// fillColorLayout
			// 
			this.fillColorLayout.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.fillColorLayout.AutoSize = true;
			this.fillColorLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.fillColorLayout.Controls.Add(this.fillColorLabel);
			this.fillColorLayout.Controls.Add(this.fillColorButton);
			this.fillColorLayout.Location = new System.Drawing.Point(3, 3);
			this.fillColorLayout.Name = "fillColorLayout";
			this.fillColorLayout.Size = new System.Drawing.Size(60, 31);
			this.fillColorLayout.TabIndex = 6;
			// 
			// fillColorLabel
			// 
			this.fillColorLabel.AutoSize = true;
			this.fillColorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fillColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fillColorLabel.Location = new System.Drawing.Point(0, 0);
			this.fillColorLabel.Margin = new System.Windows.Forms.Padding(0);
			this.fillColorLabel.Name = "fillColorLabel";
			this.fillColorLabel.Size = new System.Drawing.Size(29, 31);
			this.fillColorLabel.TabIndex = 1;
			this.fillColorLabel.Text = "Fill:";
			this.fillColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// fillColorButton
			// 
			this.fillColorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.fillColorButton.Location = new System.Drawing.Point(32, 3);
			this.fillColorButton.Name = "fillColorButton";
			this.fillColorButton.Size = new System.Drawing.Size(25, 25);
			this.fillColorButton.TabIndex = 2;
			this.fillColorButton.UseVisualStyleBackColor = false;
			this.fillColorButton.Click += new System.EventHandler(this.ColorBox_Fill_Click);
			// 
			// fillAlphaLayout
			// 
			this.fillAlphaLayout.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.fillAlphaLayout.AutoSize = true;
			this.fillAlphaLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.fillAlphaLayout.Controls.Add(this.fillAlphaLabel);
			this.fillAlphaLayout.Controls.Add(this.fillAlphaTextbox);
			this.fillAlphaLayout.Location = new System.Drawing.Point(69, 3);
			this.fillAlphaLayout.Name = "fillAlphaLayout";
			this.fillAlphaLayout.Size = new System.Drawing.Size(94, 26);
			this.fillAlphaLayout.TabIndex = 7;
			// 
			// fillAlphaLabel
			// 
			this.fillAlphaLabel.AutoSize = true;
			this.fillAlphaLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fillAlphaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fillAlphaLabel.Location = new System.Drawing.Point(0, 0);
			this.fillAlphaLabel.Margin = new System.Windows.Forms.Padding(0);
			this.fillAlphaLabel.Name = "fillAlphaLabel";
			this.fillAlphaLabel.Size = new System.Drawing.Size(48, 26);
			this.fillAlphaLabel.TabIndex = 1;
			this.fillAlphaLabel.Text = "Alpha:";
			this.fillAlphaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// fillAlphaTextbox
			// 
			this.fillAlphaTextbox.Location = new System.Drawing.Point(51, 3);
			this.fillAlphaTextbox.Name = "fillAlphaTextbox";
			this.fillAlphaTextbox.Size = new System.Drawing.Size(40, 20);
			this.fillAlphaTextbox.TabIndex = 2;
			this.fillAlphaTextbox.TextChanged += new System.EventHandler(this.PropertyTextBox_TextChanged);
			// 
			// borderLayout
			// 
			this.borderLayout.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.borderLayout.AutoSize = true;
			this.borderLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.borderLayout.Controls.Add(this.borderColorLayout);
			this.borderLayout.Controls.Add(this.borderAlphaLayout);
			this.borderLayout.Controls.Add(this.borderThicknessLayout);
			this.borderLayout.Location = new System.Drawing.Point(3, 64);
			this.borderLayout.Name = "borderLayout";
			this.borderLayout.Size = new System.Drawing.Size(324, 37);
			this.borderLayout.TabIndex = 8;
			// 
			// borderColorLayout
			// 
			this.borderColorLayout.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.borderColorLayout.AutoSize = true;
			this.borderColorLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.borderColorLayout.Controls.Add(this.borderColorLabel);
			this.borderColorLayout.Controls.Add(this.borderColorButton);
			this.borderColorLayout.Location = new System.Drawing.Point(3, 3);
			this.borderColorLayout.Name = "borderColorLayout";
			this.borderColorLayout.Size = new System.Drawing.Size(86, 31);
			this.borderColorLayout.TabIndex = 6;
			// 
			// borderColorLabel
			// 
			this.borderColorLabel.AutoSize = true;
			this.borderColorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.borderColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.borderColorLabel.Location = new System.Drawing.Point(0, 0);
			this.borderColorLabel.Margin = new System.Windows.Forms.Padding(0);
			this.borderColorLabel.Name = "borderColorLabel";
			this.borderColorLabel.Size = new System.Drawing.Size(55, 31);
			this.borderColorLabel.TabIndex = 1;
			this.borderColorLabel.Text = "Border:";
			this.borderColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// borderColorButton
			// 
			this.borderColorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.borderColorButton.Location = new System.Drawing.Point(58, 3);
			this.borderColorButton.Name = "borderColorButton";
			this.borderColorButton.Size = new System.Drawing.Size(25, 25);
			this.borderColorButton.TabIndex = 2;
			this.borderColorButton.UseVisualStyleBackColor = false;
			this.borderColorButton.Click += new System.EventHandler(this.ColorBox_Border_Click);
			// 
			// borderAlphaLayout
			// 
			this.borderAlphaLayout.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.borderAlphaLayout.AutoSize = true;
			this.borderAlphaLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.borderAlphaLayout.Controls.Add(this.borderAlphaLabel);
			this.borderAlphaLayout.Controls.Add(this.borderAlphaTextbox);
			this.borderAlphaLayout.Location = new System.Drawing.Point(95, 3);
			this.borderAlphaLayout.Name = "borderAlphaLayout";
			this.borderAlphaLayout.Size = new System.Drawing.Size(94, 26);
			this.borderAlphaLayout.TabIndex = 7;
			// 
			// borderAlphaLabel
			// 
			this.borderAlphaLabel.AutoSize = true;
			this.borderAlphaLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.borderAlphaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.borderAlphaLabel.Location = new System.Drawing.Point(0, 0);
			this.borderAlphaLabel.Margin = new System.Windows.Forms.Padding(0);
			this.borderAlphaLabel.Name = "borderAlphaLabel";
			this.borderAlphaLabel.Size = new System.Drawing.Size(48, 26);
			this.borderAlphaLabel.TabIndex = 1;
			this.borderAlphaLabel.Text = "Alpha:";
			this.borderAlphaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// borderAlphaTextbox
			// 
			this.borderAlphaTextbox.Location = new System.Drawing.Point(51, 3);
			this.borderAlphaTextbox.Name = "borderAlphaTextbox";
			this.borderAlphaTextbox.Size = new System.Drawing.Size(40, 20);
			this.borderAlphaTextbox.TabIndex = 2;
			this.borderAlphaTextbox.TextChanged += new System.EventHandler(this.PropertyTextBox_TextChanged);
			// 
			// borderThicknessLayout
			// 
			this.borderThicknessLayout.AutoSize = true;
			this.borderThicknessLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.borderThicknessLayout.Controls.Add(this.borderThicknessLabel);
			this.borderThicknessLayout.Controls.Add(this.borderThicknessTextbox);
			this.borderThicknessLayout.Dock = System.Windows.Forms.DockStyle.Left;
			this.borderThicknessLayout.Location = new System.Drawing.Point(195, 3);
			this.borderThicknessLayout.Name = "borderThicknessLayout";
			this.borderThicknessLayout.Size = new System.Drawing.Size(126, 31);
			this.borderThicknessLayout.TabIndex = 3;
			// 
			// borderThicknessLabel
			// 
			this.borderThicknessLabel.AutoSize = true;
			this.borderThicknessLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.borderThicknessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.borderThicknessLabel.Location = new System.Drawing.Point(0, 0);
			this.borderThicknessLabel.Margin = new System.Windows.Forms.Padding(0);
			this.borderThicknessLabel.Name = "borderThicknessLabel";
			this.borderThicknessLabel.Size = new System.Drawing.Size(80, 26);
			this.borderThicknessLabel.TabIndex = 1;
			this.borderThicknessLabel.Text = "Thickness:";
			this.borderThicknessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// borderThicknessTextbox
			// 
			this.borderThicknessTextbox.Location = new System.Drawing.Point(83, 3);
			this.borderThicknessTextbox.Name = "borderThicknessTextbox";
			this.borderThicknessTextbox.Size = new System.Drawing.Size(40, 20);
			this.borderThicknessTextbox.TabIndex = 0;
			this.borderThicknessTextbox.TextChanged += new System.EventHandler(this.PropertyTextBox_TextChanged);
			// 
			// hierarchyListbox
			// 
			this.hierarchyListbox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.hierarchyListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hierarchyListbox.ItemHeight = 20;
			this.hierarchyListbox.Location = new System.Drawing.Point(0, 0);
			this.hierarchyListbox.Name = "hierarchyListbox";
			this.hierarchyListbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.hierarchyListbox.Size = new System.Drawing.Size(340, 338);
			this.hierarchyListbox.TabIndex = 0;
			this.hierarchyListbox.SelectedValueChanged += new System.EventHandler(this.HierarchySelectionChanged);
			// 
			// rootContainer
			// 
			this.rootContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rootContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.rootContainer.Location = new System.Drawing.Point(0, 49);
			this.rootContainer.Name = "rootContainer";
			// 
			// rootContainer.Panel1
			// 
			this.rootContainer.Panel1.Controls.Add(this.ControlsContainer);
			this.rootContainer.Panel1MinSize = 20;
			// 
			// rootContainer.Panel2
			// 
			this.rootContainer.Panel2.Controls.Add(this.viewPort);
			this.rootContainer.Panel2.Padding = new System.Windows.Forms.Padding(3);
			this.rootContainer.Size = new System.Drawing.Size(1264, 632);
			this.rootContainer.SplitterDistance = 340;
			this.rootContainer.TabIndex = 8;
			// 
			// ControlsContainer
			// 
			this.ControlsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ControlsContainer.Location = new System.Drawing.Point(0, 0);
			this.ControlsContainer.Name = "ControlsContainer";
			this.ControlsContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// ControlsContainer.Panel1
			// 
			this.ControlsContainer.Panel1.Controls.Add(this.propertiesSideWindow);
			// 
			// ControlsContainer.Panel2
			// 
			this.ControlsContainer.Panel2.Controls.Add(this.hierarchyListbox);
			this.ControlsContainer.Size = new System.Drawing.Size(340, 632);
			this.ControlsContainer.SplitterDistance = 290;
			this.ControlsContainer.TabIndex = 1;
			// 
			// viewPort
			// 
			this.viewPort.AutoSize = true;
			this.viewPort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.viewPort.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
			this.viewPort.Location = new System.Drawing.Point(3, 3);
			this.viewPort.Margin = new System.Windows.Forms.Padding(0);
			this.viewPort.Name = "viewPort";
			this.viewPort.Padding = new System.Windows.Forms.Padding(10);
			this.viewPort.Size = new System.Drawing.Size(914, 626);
			this.viewPort.TabIndex = 0;
			this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPort_Paint);
			this.viewPort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ViewPort_KeyDown);
			this.viewPort.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ViewPort_KeyUp);
			this.viewPort.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ViewPort_MouseClick);
			this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPort_MouseDown);
			this.viewPort.MouseEnter += new System.EventHandler(this.ViewPort_MouseEnter);
			this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPort_MouseMove);
			this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPort_MouseUp);
			// 
			// dialogSave
			// 
			this.dialogSave.DefaultExt = "json";
			this.dialogSave.Filter = "Json file|*.json";
			// 
			// dialogOpen
			// 
			this.dialogOpen.DefaultExt = "json";
			this.dialogOpen.Filter = "Json file|*.json";
			// 
			// dialogExport
			// 
			this.dialogExport.DefaultExt = "png";
			this.dialogExport.Filter = "PNG|*.png";
			// 
			// dialogColorFill
			// 
			this.dialogColorFill.AnyColor = true;
			// 
			// dialogColorBorder
			// 
			this.dialogColorBorder.AnyColor = true;
			// 
			// quickAction_Draw_Elipse
			// 
			this.quickAction_Draw_Elipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.quickAction_Draw_Elipse.Image = global::Draw.Properties.Resources.Icon_Prim_Elipse;
			this.quickAction_Draw_Elipse.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.quickAction_Draw_Elipse.Name = "quickAction_Draw_Elipse";
			this.quickAction_Draw_Elipse.Size = new System.Drawing.Size(23, 22);
			this.quickAction_Draw_Elipse.Text = "DrawElipse";
			this.quickAction_Draw_Elipse.ToolTipText = "Draw new elipse";
			this.quickAction_Draw_Elipse.Click += new System.EventHandler(this.SpeedButton_Draw_Elipse_Click);
			// 
			// quickAction_Draw_Rect
			// 
			this.quickAction_Draw_Rect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.quickAction_Draw_Rect.Image = global::Draw.Properties.Resources.Icon_Prim_Rectangle;
			this.quickAction_Draw_Rect.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.quickAction_Draw_Rect.Name = "quickAction_Draw_Rect";
			this.quickAction_Draw_Rect.Size = new System.Drawing.Size(23, 22);
			this.quickAction_Draw_Rect.Text = "DrawRectangle";
			this.quickAction_Draw_Rect.ToolTipText = "Draw new rectangle";
			this.quickAction_Draw_Rect.Click += new System.EventHandler(this.SpeedButton_Draw_Rectangle_Click);
			// 
			// quickAction_Draw_Triangle
			// 
			this.quickAction_Draw_Triangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.quickAction_Draw_Triangle.Image = global::Draw.Properties.Resources.Icon_Prim_Triangle;
			this.quickAction_Draw_Triangle.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.quickAction_Draw_Triangle.Name = "quickAction_Draw_Triangle";
			this.quickAction_Draw_Triangle.Size = new System.Drawing.Size(23, 22);
			this.quickAction_Draw_Triangle.Text = "DrawTriangle";
			this.quickAction_Draw_Triangle.ToolTipText = "Draw new triangle";
			this.quickAction_Draw_Triangle.Click += new System.EventHandler(this.SpeedButton_Draw_Triangle_Click);
			// 
			// quickAction_Draw_Envelope
			// 
			this.quickAction_Draw_Envelope.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.quickAction_Draw_Envelope.Image = global::Draw.Properties.Resources.Icon_Prim_Unknown;
			this.quickAction_Draw_Envelope.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.quickAction_Draw_Envelope.Name = "quickAction_Draw_Envelope";
			this.quickAction_Draw_Envelope.Size = new System.Drawing.Size(23, 22);
			this.quickAction_Draw_Envelope.Text = "DrawTriangle";
			this.quickAction_Draw_Envelope.ToolTipText = "Draw new envelope";
			this.quickAction_Draw_Envelope.Click += new System.EventHandler(this.SpeedButton_Draw_Envelope_Click);
			// 
			// quickAction_Toggle_Select
			// 
			this.quickAction_Toggle_Select.CheckOnClick = true;
			this.quickAction_Toggle_Select.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.quickAction_Toggle_Select.Image = global::Draw.Properties.Resources.Icon_Tool_Select;
			this.quickAction_Toggle_Select.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.quickAction_Toggle_Select.Name = "quickAction_Toggle_Select";
			this.quickAction_Toggle_Select.Size = new System.Drawing.Size(23, 22);
			this.quickAction_Toggle_Select.Text = "SelectTool";
			this.quickAction_Toggle_Select.ToolTipText = "Select items";
			this.quickAction_Toggle_Select.CheckedChanged += new System.EventHandler(this.SpeedButton_Toggleable_Select_CheckChanged);
			this.quickAction_Toggle_Select.Click += new System.EventHandler(this.SpeedButton_Toggleable_Clicked);
			// 
			// quickAction_Toggle_Move
			// 
			this.quickAction_Toggle_Move.CheckOnClick = true;
			this.quickAction_Toggle_Move.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.quickAction_Toggle_Move.Image = global::Draw.Properties.Resources.Icon_Tool_Move;
			this.quickAction_Toggle_Move.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.quickAction_Toggle_Move.Name = "quickAction_Toggle_Move";
			this.quickAction_Toggle_Move.Size = new System.Drawing.Size(23, 22);
			this.quickAction_Toggle_Move.Text = "MoveTool";
			this.quickAction_Toggle_Move.ToolTipText = "Move selected items";
			this.quickAction_Toggle_Move.CheckedChanged += new System.EventHandler(this.SpeedButton_Toggleable_Move_CheckChanged);
			this.quickAction_Toggle_Move.Click += new System.EventHandler(this.SpeedButton_Toggleable_Clicked);
			// 
			// quickAction_Toggle_Rotate
			// 
			this.quickAction_Toggle_Rotate.CheckOnClick = true;
			this.quickAction_Toggle_Rotate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.quickAction_Toggle_Rotate.Image = global::Draw.Properties.Resources.Icon_Tool_Rotate;
			this.quickAction_Toggle_Rotate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.quickAction_Toggle_Rotate.Name = "quickAction_Toggle_Rotate";
			this.quickAction_Toggle_Rotate.Size = new System.Drawing.Size(23, 22);
			this.quickAction_Toggle_Rotate.Text = "SelectTool";
			this.quickAction_Toggle_Rotate.ToolTipText = "Rotate selected Items";
			this.quickAction_Toggle_Rotate.CheckedChanged += new System.EventHandler(this.SpeedButton_Toggleable_Rotate_CheckChanged);
			this.quickAction_Toggle_Rotate.Click += new System.EventHandler(this.SpeedButton_Toggleable_Clicked);
			// 
			// quickAction_Toggle_Scale
			// 
			this.quickAction_Toggle_Scale.CheckOnClick = true;
			this.quickAction_Toggle_Scale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.quickAction_Toggle_Scale.Image = global::Draw.Properties.Resources.Icon_Tool_Scale;
			this.quickAction_Toggle_Scale.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.quickAction_Toggle_Scale.Name = "quickAction_Toggle_Scale";
			this.quickAction_Toggle_Scale.Size = new System.Drawing.Size(23, 22);
			this.quickAction_Toggle_Scale.Text = "SelectTool";
			this.quickAction_Toggle_Scale.ToolTipText = "Scale selected Items";
			this.quickAction_Toggle_Scale.CheckedChanged += new System.EventHandler(this.SpeedButton_Toggleable_Scale_CheckChanged);
			this.quickAction_Toggle_Scale.Click += new System.EventHandler(this.SpeedButton_Toggleable_Clicked);
			// 
			// quickAction_Tool_Group
			// 
			this.quickAction_Tool_Group.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.quickAction_Tool_Group.Image = global::Draw.Properties.Resources.Icon_Tool_Group;
			this.quickAction_Tool_Group.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.quickAction_Tool_Group.Name = "quickAction_Tool_Group";
			this.quickAction_Tool_Group.Size = new System.Drawing.Size(23, 22);
			this.quickAction_Tool_Group.Text = "Group Selected";
			this.quickAction_Tool_Group.ToolTipText = "Group selected items";
			this.quickAction_Tool_Group.Click += new System.EventHandler(this.SpeedButton_Group_Click);
			// 
			// quickAction_Tool_UnGroup
			// 
			this.quickAction_Tool_UnGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.quickAction_Tool_UnGroup.Image = global::Draw.Properties.Resources.Icon_Tool_Ungroup;
			this.quickAction_Tool_UnGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.quickAction_Tool_UnGroup.Name = "quickAction_Tool_UnGroup";
			this.quickAction_Tool_UnGroup.Size = new System.Drawing.Size(23, 22);
			this.quickAction_Tool_UnGroup.Text = "Ungroup Selected";
			this.quickAction_Tool_UnGroup.ToolTipText = "Ungroup selected groups";
			this.quickAction_Tool_UnGroup.Click += new System.EventHandler(this.SpeedButton_UnGroup_Click);
			// 
			// quickAction_Tool_Delete
			// 
			this.quickAction_Tool_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.quickAction_Tool_Delete.Image = global::Draw.Properties.Resources.Icon_Tool_Delete;
			this.quickAction_Tool_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.quickAction_Tool_Delete.Name = "quickAction_Tool_Delete";
			this.quickAction_Tool_Delete.Size = new System.Drawing.Size(23, 22);
			this.quickAction_Tool_Delete.Text = "Group Selected";
			this.quickAction_Tool_Delete.ToolTipText = "Delete selected Items";
			this.quickAction_Tool_Delete.Click += new System.EventHandler(this.SpeedButton_Delete_Clicked);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "toolStripButton1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 681);
			this.Controls.Add(this.rootContainer);
			this.Controls.Add(this.quickActionsMenu);
			this.Controls.Add(this.mainMenu);
			this.MainMenuStrip = this.mainMenu;
			this.Name = "MainForm";
			this.Text = "Draw";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.mainMenu.ResumeLayout(false);
			this.mainMenu.PerformLayout();
			this.quickActionsMenu.ResumeLayout(false);
			this.quickActionsMenu.PerformLayout();
			this.propertiesSideWindow.ResumeLayout(false);
			this.propertiesSideWindow.PerformLayout();
			this.nameLayout.ResumeLayout(false);
			this.nameLayout.PerformLayout();
			this.sizeLayout.ResumeLayout(false);
			this.sizeLayout.PerformLayout();
			this.scaleXLayout.ResumeLayout(false);
			this.scaleXLayout.PerformLayout();
			this.scaleYLayout.ResumeLayout(false);
			this.scaleYLayout.PerformLayout();
			this.locationLayout.ResumeLayout(false);
			this.locationLayout.PerformLayout();
			this.locXLayout.ResumeLayout(false);
			this.locXLayout.PerformLayout();
			this.locYLayout.ResumeLayout(false);
			this.locYLayout.PerformLayout();
			this.rotationLayout.ResumeLayout(false);
			this.rotationLayout.PerformLayout();
			this.colorLayout.ResumeLayout(false);
			this.colorLayout.PerformLayout();
			this.fillLayout.ResumeLayout(false);
			this.fillLayout.PerformLayout();
			this.fillColorLayout.ResumeLayout(false);
			this.fillColorLayout.PerformLayout();
			this.fillAlphaLayout.ResumeLayout(false);
			this.fillAlphaLayout.PerformLayout();
			this.borderLayout.ResumeLayout(false);
			this.borderLayout.PerformLayout();
			this.borderColorLayout.ResumeLayout(false);
			this.borderColorLayout.PerformLayout();
			this.borderAlphaLayout.ResumeLayout(false);
			this.borderAlphaLayout.PerformLayout();
			this.borderThicknessLayout.ResumeLayout(false);
			this.borderThicknessLayout.PerformLayout();
			this.rootContainer.Panel1.ResumeLayout(false);
			this.rootContainer.Panel2.ResumeLayout(false);
			this.rootContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.rootContainer)).EndInit();
			this.rootContainer.ResumeLayout(false);
			this.ControlsContainer.Panel1.ResumeLayout(false);
			this.ControlsContainer.Panel1.PerformLayout();
			this.ControlsContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ControlsContainer)).EndInit();
			this.ControlsContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private System.Windows.Forms.ToolStripStatusLabel currentStatusLabel;
		private Draw.DoubleBufferedPanel viewPort;
		private System.Windows.Forms.ToolStripButton quickAction_Toggle_Select;
		private System.Windows.Forms.ToolStripButton quickAction_Draw_Rect;
		private System.Windows.Forms.ToolStripMenuItem helpSubMenu_ToolStrip_About;
		private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStrip_Help;
		private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStrip_Image;
		private System.Windows.Forms.ToolStripMenuItem fileSubMenu_ToolStrip_Exit;
		private System.Windows.Forms.ToolStripMenuItem mainMenu_ToolStrip_File;
		private System.Windows.Forms.ToolStrip quickActionsMenu;
		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.ToolStripButton quickAction_Draw_Elipse;
		private System.Windows.Forms.FlowLayoutPanel propertiesSideWindow;
		private System.Windows.Forms.FlowLayoutPanel scaleXLayout;
		private System.Windows.Forms.Label scaleXLabel;
		private System.Windows.Forms.TextBox scaleXTextBox;
		private System.Windows.Forms.FlowLayoutPanel scaleYLayout;
		private System.Windows.Forms.Label scaleYLabel;
		private System.Windows.Forms.TextBox scaleYTextBox;
		private System.Windows.Forms.FlowLayoutPanel borderThicknessLayout;
		private System.Windows.Forms.Label borderThicknessLabel;
		private System.Windows.Forms.TextBox borderThicknessTextbox;
		private System.Windows.Forms.FlowLayoutPanel colorLayout;
		private System.Windows.Forms.Label visualLabel;
		private System.Windows.Forms.FlowLayoutPanel sizeLayout;
		private System.Windows.Forms.Label scaleLabel;
		private System.Windows.Forms.FlowLayoutPanel locationLayout;
		private System.Windows.Forms.Label locationLabel;
		private System.Windows.Forms.FlowLayoutPanel locXLayout;
		private System.Windows.Forms.Label locXLabel;
		private System.Windows.Forms.TextBox LocXTextbox;
		private System.Windows.Forms.FlowLayoutPanel locYLayout;
		private System.Windows.Forms.Label locYLabel;
		private System.Windows.Forms.TextBox LocYTextbox;
		private System.Windows.Forms.ListBox hierarchyListbox;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton quickAction_Tool_Group;
		private System.Windows.Forms.ToolStripButton quickAction_Tool_UnGroup;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.SplitContainer rootContainer;
		private System.Windows.Forms.SplitContainer ControlsContainer;
		private System.Windows.Forms.ToolStripButton quickAction_Toggle_Move;
		private System.Windows.Forms.ToolStripButton quickAction_Draw_Triangle;
		private System.Windows.Forms.FlowLayoutPanel nameLayout;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.TextBox nameTextbox;
		private System.Windows.Forms.FlowLayoutPanel rotationLayout;
		private System.Windows.Forms.Label rotationLabel;
		private System.Windows.Forms.TextBox rotationTextbox;
		private System.Windows.Forms.ToolStripMenuItem fileSubMenu_ToolStrip_Load;
		private System.Windows.Forms.ToolStripMenuItem fileSubMenu_ToolStrip_Save;
		private System.Windows.Forms.ToolStripMenuItem imageSubMenu_ToolStrip_Export;
		private System.Windows.Forms.SaveFileDialog dialogSave;
		private System.Windows.Forms.OpenFileDialog dialogOpen;
		private System.Windows.Forms.SaveFileDialog dialogExport;
		private System.Windows.Forms.ToolStripButton quickAction_Toggle_Scale;
		private System.Windows.Forms.ToolStripButton quickAction_Toggle_Rotate;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton quickAction_Tool_Delete;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ColorDialog dialogColorFill;
		private System.Windows.Forms.FlowLayoutPanel fillColorLayout;
		private System.Windows.Forms.Label fillColorLabel;
		private System.Windows.Forms.Button fillColorButton;
		private System.Windows.Forms.ColorDialog dialogColorBorder;
		private System.Windows.Forms.FlowLayoutPanel fillLayout;
		private System.Windows.Forms.FlowLayoutPanel fillAlphaLayout;
		private System.Windows.Forms.Label fillAlphaLabel;
		private System.Windows.Forms.TextBox fillAlphaTextbox;
		private System.Windows.Forms.FlowLayoutPanel borderLayout;
		private System.Windows.Forms.FlowLayoutPanel borderColorLayout;
		private System.Windows.Forms.Label borderColorLabel;
		private System.Windows.Forms.Button borderColorButton;
		private System.Windows.Forms.FlowLayoutPanel borderAlphaLayout;
		private System.Windows.Forms.Label borderAlphaLabel;
		private System.Windows.Forms.TextBox borderAlphaTextbox;
		private System.Windows.Forms.ToolStripButton quickAction_Draw_Envelope;
	}
}
