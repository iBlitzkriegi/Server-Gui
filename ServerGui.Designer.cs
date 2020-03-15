namespace ServerGui
{
    partial class ServerGui
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
            if (disposing && (components != null))
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PlayersGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.SayLabel = new System.Windows.Forms.Label();
            this.SayCheckBox = new System.Windows.Forms.CheckBox();
            this.CommandTextBox = new System.Windows.Forms.TextBox();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.CpuUsageLabel = new System.Windows.Forms.Label();
            this.CpuProgressBar = new System.Windows.Forms.ProgressBar();
            this.CpuPercentLabel = new System.Windows.Forms.Label();
            this.RamUsageLabel = new System.Windows.Forms.Label();
            this.RamPercentLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PlayerFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ConsoleTextBox = new System.Windows.Forms.RichTextBox();
            this.StartupPage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CreateNewConfigurationButton = new System.Windows.Forms.Button();
            this.JavaOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.CustomArgumentsLabel = new System.Windows.Forms.Label();
            this.CustomArgumentsTextBox = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.MaxRamLabel = new System.Windows.Forms.Label();
            this.MaxRamTrackBar = new System.Windows.Forms.TrackBar();
            this.panel6 = new System.Windows.Forms.Panel();
            this.MinRamLabel = new System.Windows.Forms.Label();
            this.MinRamTrackBar = new System.Windows.Forms.TrackBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.JarFileLabel = new System.Windows.Forms.Label();
            this.JarFileTextBox = new System.Windows.Forms.TextBox();
            this.OpenJarFileButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.JavaVersionComboBox = new System.Windows.Forms.ComboBox();
            this.JavaVersionLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CurrentConfigurationComboBox = new System.Windows.Forms.ComboBox();
            this.CurrentConfigurationLabel = new System.Windows.Forms.Label();
            this.ProgressBarTimer = new System.Windows.Forms.Timer(this.components);
            this.CPU = new System.Diagnostics.PerformanceCounter();
            this.RAM = new System.Diagnostics.PerformanceCounter();
            this.PlayersContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.opToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deOpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.banToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamemodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.survivalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spectatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GuiPercentLabel = new System.Windows.Forms.Label();
            this.GuiProgressBar = new System.Windows.Forms.ProgressBar();
            this.GuiUsageLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.ConsolePageButtonsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.KillButton = new System.Windows.Forms.Button();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.RamProgressBar = new System.Windows.Forms.ProgressBar();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayersGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.StartupPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.JavaOptionsGroupBox.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRamTrackBar)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinRamTrackBar)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).BeginInit();
            this.PlayersContextMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.ConsolePageButtonsFlowPanel.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PlayersGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(10);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 648);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Players";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PlayersGridView
            // 
            this.PlayersGridView.AllowUserToAddRows = false;
            this.PlayersGridView.AllowUserToDeleteRows = false;
            this.PlayersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PlayersGridView.BackgroundColor = System.Drawing.Color.White;
            this.PlayersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayersGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayersGridView.Location = new System.Drawing.Point(3, 3);
            this.PlayersGridView.Name = "PlayersGridView";
            this.PlayersGridView.ReadOnly = true;
            this.PlayersGridView.Size = new System.Drawing.Size(970, 642);
            this.PlayersGridView.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.StartupPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(8, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 676);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel13);
            this.tabPage3.Controls.Add(this.splitContainer1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 648);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Console";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // SayLabel
            // 
            this.SayLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SayLabel.AutoSize = true;
            this.SayLabel.BackColor = System.Drawing.Color.White;
            this.SayLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SayLabel.Location = new System.Drawing.Point(1, 0);
            this.SayLabel.Name = "SayLabel";
            this.SayLabel.Size = new System.Drawing.Size(32, 19);
            this.SayLabel.TabIndex = 7;
            this.SayLabel.Text = "Say";
            // 
            // SayCheckBox
            // 
            this.SayCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SayCheckBox.AutoSize = true;
            this.SayCheckBox.BackColor = System.Drawing.Color.White;
            this.SayCheckBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SayCheckBox.Location = new System.Drawing.Point(33, 4);
            this.SayCheckBox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.SayCheckBox.Name = "SayCheckBox";
            this.SayCheckBox.Size = new System.Drawing.Size(15, 14);
            this.SayCheckBox.TabIndex = 8;
            this.SayCheckBox.UseVisualStyleBackColor = false;
            // 
            // CommandTextBox
            // 
            this.CommandTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CommandTextBox.BackColor = System.Drawing.Color.White;
            this.CommandTextBox.Location = new System.Drawing.Point(54, 6);
            this.CommandTextBox.Name = "CommandTextBox";
            this.CommandTextBox.Size = new System.Drawing.Size(832, 22);
            this.CommandTextBox.TabIndex = 9;
            this.CommandTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommandTextBox_KeyDown);
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ExecuteButton.BackColor = System.Drawing.Color.LightGray;
            this.ExecuteButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteButton.Location = new System.Drawing.Point(892, 6);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(75, 22);
            this.ExecuteButton.TabIndex = 9;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.UseVisualStyleBackColor = false;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // CpuUsageLabel
            // 
            this.CpuUsageLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CpuUsageLabel.AutoSize = true;
            this.CpuUsageLabel.BackColor = System.Drawing.Color.White;
            this.CpuUsageLabel.Location = new System.Drawing.Point(0, 13);
            this.CpuUsageLabel.Name = "CpuUsageLabel";
            this.CpuUsageLabel.Size = new System.Drawing.Size(68, 15);
            this.CpuUsageLabel.TabIndex = 18;
            this.CpuUsageLabel.Text = "CPU Usage";
            // 
            // CpuProgressBar
            // 
            this.CpuProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CpuProgressBar.BackColor = System.Drawing.Color.White;
            this.CpuProgressBar.Location = new System.Drawing.Point(69, 11);
            this.CpuProgressBar.Name = "CpuProgressBar";
            this.CpuProgressBar.Size = new System.Drawing.Size(774, 23);
            this.CpuProgressBar.TabIndex = 13;
            this.CpuProgressBar.Value = 50;
            // 
            // CpuPercentLabel
            // 
            this.CpuPercentLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CpuPercentLabel.AutoSize = true;
            this.CpuPercentLabel.BackColor = System.Drawing.Color.White;
            this.CpuPercentLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpuPercentLabel.Location = new System.Drawing.Point(845, 13);
            this.CpuPercentLabel.Name = "CpuPercentLabel";
            this.CpuPercentLabel.Size = new System.Drawing.Size(35, 17);
            this.CpuPercentLabel.TabIndex = 15;
            this.CpuPercentLabel.Text = "34%";
            // 
            // RamUsageLabel
            // 
            this.RamUsageLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RamUsageLabel.AutoSize = true;
            this.RamUsageLabel.BackColor = System.Drawing.Color.White;
            this.RamUsageLabel.Location = new System.Drawing.Point(-1, 12);
            this.RamUsageLabel.Name = "RamUsageLabel";
            this.RamUsageLabel.Size = new System.Drawing.Size(67, 15);
            this.RamUsageLabel.TabIndex = 17;
            this.RamUsageLabel.Text = "Ram Usage";
            // 
            // RamPercentLabel
            // 
            this.RamPercentLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RamPercentLabel.AutoSize = true;
            this.RamPercentLabel.BackColor = System.Drawing.Color.White;
            this.RamPercentLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RamPercentLabel.Location = new System.Drawing.Point(847, 11);
            this.RamPercentLabel.Name = "RamPercentLabel";
            this.RamPercentLabel.Size = new System.Drawing.Size(35, 17);
            this.RamPercentLabel.TabIndex = 14;
            this.RamPercentLabel.Text = "34%";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PlayerFlowPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.ConsoleTextBox);
            this.splitContainer1.Panel2MinSize = 40;
            this.splitContainer1.Size = new System.Drawing.Size(968, 462);
            this.splitContainer1.SplitterDistance = 152;
            this.splitContainer1.TabIndex = 2;
            // 
            // PlayerFlowPanel
            // 
            this.PlayerFlowPanel.AutoScroll = true;
            this.PlayerFlowPanel.BackColor = System.Drawing.Color.White;
            this.PlayerFlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayerFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PlayerFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.PlayerFlowPanel.Name = "PlayerFlowPanel";
            this.PlayerFlowPanel.Size = new System.Drawing.Size(152, 462);
            this.PlayerFlowPanel.TabIndex = 0;
            this.PlayerFlowPanel.WrapContents = false;
            // 
            // ConsoleTextBox
            // 
            this.ConsoleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsoleTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleTextBox.Location = new System.Drawing.Point(0, 0);
            this.ConsoleTextBox.Margin = new System.Windows.Forms.Padding(30);
            this.ConsoleTextBox.Name = "ConsoleTextBox";
            this.ConsoleTextBox.ReadOnly = true;
            this.ConsoleTextBox.Size = new System.Drawing.Size(812, 462);
            this.ConsoleTextBox.TabIndex = 1;
            this.ConsoleTextBox.Text = "";
            // 
            // StartupPage
            // 
            this.StartupPage.Controls.Add(this.panel2);
            this.StartupPage.Location = new System.Drawing.Point(4, 24);
            this.StartupPage.Name = "StartupPage";
            this.StartupPage.Padding = new System.Windows.Forms.Padding(3);
            this.StartupPage.Size = new System.Drawing.Size(976, 648);
            this.StartupPage.TabIndex = 5;
            this.StartupPage.Text = "Startup";
            this.StartupPage.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.CreateNewConfigurationButton);
            this.panel2.Controls.Add(this.JavaOptionsGroupBox);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(970, 642);
            this.panel2.TabIndex = 0;
            // 
            // CreateNewConfigurationButton
            // 
            this.CreateNewConfigurationButton.BackColor = System.Drawing.Color.LightGray;
            this.CreateNewConfigurationButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateNewConfigurationButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewConfigurationButton.Location = new System.Drawing.Point(0, 462);
            this.CreateNewConfigurationButton.Name = "CreateNewConfigurationButton";
            this.CreateNewConfigurationButton.Size = new System.Drawing.Size(970, 67);
            this.CreateNewConfigurationButton.TabIndex = 4;
            this.CreateNewConfigurationButton.Text = "Create New Configuration";
            this.CreateNewConfigurationButton.UseVisualStyleBackColor = false;
            // 
            // JavaOptionsGroupBox
            // 
            this.JavaOptionsGroupBox.BackColor = System.Drawing.Color.White;
            this.JavaOptionsGroupBox.Controls.Add(this.panel8);
            this.JavaOptionsGroupBox.Controls.Add(this.panel7);
            this.JavaOptionsGroupBox.Controls.Add(this.panel6);
            this.JavaOptionsGroupBox.Controls.Add(this.panel5);
            this.JavaOptionsGroupBox.Controls.Add(this.panel4);
            this.JavaOptionsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.JavaOptionsGroupBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JavaOptionsGroupBox.Location = new System.Drawing.Point(0, 70);
            this.JavaOptionsGroupBox.Name = "JavaOptionsGroupBox";
            this.JavaOptionsGroupBox.Size = new System.Drawing.Size(970, 392);
            this.JavaOptionsGroupBox.TabIndex = 3;
            this.JavaOptionsGroupBox.TabStop = false;
            this.JavaOptionsGroupBox.Text = "Java Server Options";
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Controls.Add(this.CustomArgumentsLabel);
            this.panel8.Controls.Add(this.CustomArgumentsTextBox);
            this.panel8.Location = new System.Drawing.Point(9, 315);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(956, 60);
            this.panel8.TabIndex = 9;
            // 
            // CustomArgumentsLabel
            // 
            this.CustomArgumentsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CustomArgumentsLabel.AutoSize = true;
            this.CustomArgumentsLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomArgumentsLabel.Location = new System.Drawing.Point(6, 21);
            this.CustomArgumentsLabel.Name = "CustomArgumentsLabel";
            this.CustomArgumentsLabel.Size = new System.Drawing.Size(154, 21);
            this.CustomArgumentsLabel.TabIndex = 1;
            this.CustomArgumentsLabel.Text = "Custom Arguments";
            // 
            // CustomArgumentsTextBox
            // 
            this.CustomArgumentsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomArgumentsTextBox.BackColor = System.Drawing.Color.White;
            this.CustomArgumentsTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomArgumentsTextBox.Location = new System.Drawing.Point(166, 19);
            this.CustomArgumentsTextBox.Name = "CustomArgumentsTextBox";
            this.CustomArgumentsTextBox.ReadOnly = true;
            this.CustomArgumentsTextBox.Size = new System.Drawing.Size(782, 26);
            this.CustomArgumentsTextBox.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.MaxRamLabel);
            this.panel7.Controls.Add(this.MaxRamTrackBar);
            this.panel7.Location = new System.Drawing.Point(9, 234);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(957, 75);
            this.panel7.TabIndex = 8;
            // 
            // MaxRamLabel
            // 
            this.MaxRamLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MaxRamLabel.AutoSize = true;
            this.MaxRamLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxRamLabel.Location = new System.Drawing.Point(3, 28);
            this.MaxRamLabel.Name = "MaxRamLabel";
            this.MaxRamLabel.Size = new System.Drawing.Size(156, 21);
            this.MaxRamLabel.TabIndex = 2;
            this.MaxRamLabel.Text = "Max Ram: 1422MB";
            // 
            // MaxRamTrackBar
            // 
            this.MaxRamTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxRamTrackBar.LargeChange = 0;
            this.MaxRamTrackBar.Location = new System.Drawing.Point(161, 19);
            this.MaxRamTrackBar.Name = "MaxRamTrackBar";
            this.MaxRamTrackBar.Size = new System.Drawing.Size(787, 45);
            this.MaxRamTrackBar.TabIndex = 3;
            this.MaxRamTrackBar.TickFrequency = 0;
            this.MaxRamTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.MinRamLabel);
            this.panel6.Controls.Add(this.MinRamTrackBar);
            this.panel6.Location = new System.Drawing.Point(9, 153);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(957, 75);
            this.panel6.TabIndex = 7;
            // 
            // MinRamLabel
            // 
            this.MinRamLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MinRamLabel.AutoSize = true;
            this.MinRamLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinRamLabel.Location = new System.Drawing.Point(3, 28);
            this.MinRamLabel.Name = "MinRamLabel";
            this.MinRamLabel.Size = new System.Drawing.Size(152, 21);
            this.MinRamLabel.TabIndex = 2;
            this.MinRamLabel.Text = "Min Ram: 1422MB";
            // 
            // MinRamTrackBar
            // 
            this.MinRamTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MinRamTrackBar.LargeChange = 0;
            this.MinRamTrackBar.Location = new System.Drawing.Point(161, 19);
            this.MinRamTrackBar.Name = "MinRamTrackBar";
            this.MinRamTrackBar.Size = new System.Drawing.Size(787, 45);
            this.MinRamTrackBar.TabIndex = 3;
            this.MinRamTrackBar.TickFrequency = 0;
            this.MinRamTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.JarFileLabel);
            this.panel5.Controls.Add(this.JarFileTextBox);
            this.panel5.Controls.Add(this.OpenJarFileButton);
            this.panel5.Location = new System.Drawing.Point(9, 87);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(955, 60);
            this.panel5.TabIndex = 5;
            // 
            // JarFileLabel
            // 
            this.JarFileLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.JarFileLabel.AutoSize = true;
            this.JarFileLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JarFileLabel.Location = new System.Drawing.Point(6, 18);
            this.JarFileLabel.Name = "JarFileLabel";
            this.JarFileLabel.Size = new System.Drawing.Size(79, 21);
            this.JarFileLabel.TabIndex = 4;
            this.JarFileLabel.Text = "JAR file: ";
            // 
            // JarFileTextBox
            // 
            this.JarFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.JarFileTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JarFileTextBox.Location = new System.Drawing.Point(91, 16);
            this.JarFileTextBox.Name = "JarFileTextBox";
            this.JarFileTextBox.ReadOnly = true;
            this.JarFileTextBox.Size = new System.Drawing.Size(760, 26);
            this.JarFileTextBox.TabIndex = 5;
            // 
            // OpenJarFileButton
            // 
            this.OpenJarFileButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OpenJarFileButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenJarFileButton.Location = new System.Drawing.Point(857, 16);
            this.OpenJarFileButton.Name = "OpenJarFileButton";
            this.OpenJarFileButton.Size = new System.Drawing.Size(91, 26);
            this.OpenJarFileButton.TabIndex = 6;
            this.OpenJarFileButton.Text = "...";
            this.OpenJarFileButton.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.JavaVersionComboBox);
            this.panel4.Controls.Add(this.JavaVersionLabel);
            this.panel4.Location = new System.Drawing.Point(9, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(955, 60);
            this.panel4.TabIndex = 4;
            // 
            // JavaVersionComboBox
            // 
            this.JavaVersionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JavaVersionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JavaVersionComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JavaVersionComboBox.FormattingEnabled = true;
            this.JavaVersionComboBox.IntegralHeight = false;
            this.JavaVersionComboBox.Location = new System.Drawing.Point(113, 16);
            this.JavaVersionComboBox.Name = "JavaVersionComboBox";
            this.JavaVersionComboBox.Size = new System.Drawing.Size(835, 27);
            this.JavaVersionComboBox.TabIndex = 1;
            // 
            // JavaVersionLabel
            // 
            this.JavaVersionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.JavaVersionLabel.AutoSize = true;
            this.JavaVersionLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JavaVersionLabel.Location = new System.Drawing.Point(4, 18);
            this.JavaVersionLabel.Name = "JavaVersionLabel";
            this.JavaVersionLabel.Size = new System.Drawing.Size(103, 21);
            this.JavaVersionLabel.TabIndex = 0;
            this.JavaVersionLabel.Text = "Java Version";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.CurrentConfigurationComboBox);
            this.panel3.Controls.Add(this.CurrentConfigurationLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(970, 70);
            this.panel3.TabIndex = 2;
            // 
            // CurrentConfigurationComboBox
            // 
            this.CurrentConfigurationComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentConfigurationComboBox.BackColor = System.Drawing.Color.White;
            this.CurrentConfigurationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrentConfigurationComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentConfigurationComboBox.FormattingEnabled = true;
            this.CurrentConfigurationComboBox.Location = new System.Drawing.Point(184, 21);
            this.CurrentConfigurationComboBox.Name = "CurrentConfigurationComboBox";
            this.CurrentConfigurationComboBox.Size = new System.Drawing.Size(773, 27);
            this.CurrentConfigurationComboBox.TabIndex = 1;
            // 
            // CurrentConfigurationLabel
            // 
            this.CurrentConfigurationLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CurrentConfigurationLabel.AutoSize = true;
            this.CurrentConfigurationLabel.BackColor = System.Drawing.Color.White;
            this.CurrentConfigurationLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentConfigurationLabel.Location = new System.Drawing.Point(5, 23);
            this.CurrentConfigurationLabel.Name = "CurrentConfigurationLabel";
            this.CurrentConfigurationLabel.Size = new System.Drawing.Size(173, 21);
            this.CurrentConfigurationLabel.TabIndex = 0;
            this.CurrentConfigurationLabel.Text = "Current Configuration";
            // 
            // ProgressBarTimer
            // 
            this.ProgressBarTimer.Interval = 1000;
            this.ProgressBarTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CPU
            // 
            this.CPU.CategoryName = "Processor";
            this.CPU.CounterName = "% Processor Time";
            this.CPU.InstanceName = "_Total";
            // 
            // RAM
            // 
            this.RAM.CategoryName = "Memory";
            this.RAM.CounterName = "Available MBytes";
            // 
            // PlayersContextMenu
            // 
            this.PlayersContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opToolStripMenuItem,
            this.deOpToolStripMenuItem,
            this.kickToolStripMenuItem,
            this.banToolStripMenuItem,
            this.gamemodeToolStripMenuItem});
            this.PlayersContextMenu.Name = "contextMenuStrip1";
            this.PlayersContextMenu.Size = new System.Drawing.Size(137, 114);
            this.PlayersContextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // opToolStripMenuItem
            // 
            this.opToolStripMenuItem.Image = global::ServerGui.Properties.Resources.head;
            this.opToolStripMenuItem.Name = "opToolStripMenuItem";
            this.opToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.opToolStripMenuItem.Text = "Op";
            // 
            // deOpToolStripMenuItem
            // 
            this.deOpToolStripMenuItem.Image = global::ServerGui.Properties.Resources.head;
            this.deOpToolStripMenuItem.Name = "deOpToolStripMenuItem";
            this.deOpToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.deOpToolStripMenuItem.Text = "De-Op";
            // 
            // kickToolStripMenuItem
            // 
            this.kickToolStripMenuItem.Image = global::ServerGui.Properties.Resources.head;
            this.kickToolStripMenuItem.Name = "kickToolStripMenuItem";
            this.kickToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.kickToolStripMenuItem.Text = "Kick";
            // 
            // banToolStripMenuItem
            // 
            this.banToolStripMenuItem.Image = global::ServerGui.Properties.Resources.head;
            this.banToolStripMenuItem.Name = "banToolStripMenuItem";
            this.banToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.banToolStripMenuItem.Text = "Ban";
            // 
            // gamemodeToolStripMenuItem
            // 
            this.gamemodeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.survivalToolStripMenuItem,
            this.creativeToolStripMenuItem,
            this.spectatorToolStripMenuItem});
            this.gamemodeToolStripMenuItem.Image = global::ServerGui.Properties.Resources.head;
            this.gamemodeToolStripMenuItem.Name = "gamemodeToolStripMenuItem";
            this.gamemodeToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.gamemodeToolStripMenuItem.Text = "Gamemode";
            // 
            // survivalToolStripMenuItem
            // 
            this.survivalToolStripMenuItem.Name = "survivalToolStripMenuItem";
            this.survivalToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.survivalToolStripMenuItem.Text = "Survival";
            this.survivalToolStripMenuItem.Click += new System.EventHandler(this.GamemodeMenu_Clicked);
            // 
            // creativeToolStripMenuItem
            // 
            this.creativeToolStripMenuItem.Name = "creativeToolStripMenuItem";
            this.creativeToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.creativeToolStripMenuItem.Text = "Creative";
            this.creativeToolStripMenuItem.Click += new System.EventHandler(this.GamemodeMenu_Clicked);
            // 
            // spectatorToolStripMenuItem
            // 
            this.spectatorToolStripMenuItem.Name = "spectatorToolStripMenuItem";
            this.spectatorToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.spectatorToolStripMenuItem.Text = "Spectator";
            this.spectatorToolStripMenuItem.Click += new System.EventHandler(this.GamemodeMenu_Clicked);
            // 
            // GuiPercentLabel
            // 
            this.GuiPercentLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GuiPercentLabel.AutoSize = true;
            this.GuiPercentLabel.BackColor = System.Drawing.Color.White;
            this.GuiPercentLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuiPercentLabel.Location = new System.Drawing.Point(844, 10);
            this.GuiPercentLabel.Name = "GuiPercentLabel";
            this.GuiPercentLabel.Size = new System.Drawing.Size(35, 17);
            this.GuiPercentLabel.TabIndex = 16;
            this.GuiPercentLabel.Text = "34%";
            // 
            // GuiProgressBar
            // 
            this.GuiProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GuiProgressBar.BackColor = System.Drawing.Color.White;
            this.GuiProgressBar.Location = new System.Drawing.Point(70, 9);
            this.GuiProgressBar.Name = "GuiProgressBar";
            this.GuiProgressBar.Size = new System.Drawing.Size(772, 23);
            this.GuiProgressBar.TabIndex = 12;
            this.GuiProgressBar.Value = 50;
            // 
            // GuiUsageLabel
            // 
            this.GuiUsageLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GuiUsageLabel.AutoSize = true;
            this.GuiUsageLabel.BackColor = System.Drawing.Color.White;
            this.GuiUsageLabel.Location = new System.Drawing.Point(-1, 11);
            this.GuiUsageLabel.Name = "GuiUsageLabel";
            this.GuiUsageLabel.Size = new System.Drawing.Size(65, 15);
            this.GuiUsageLabel.TabIndex = 19;
            this.GuiUsageLabel.Text = "GUI Usage";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.ExecuteButton);
            this.panel1.Controls.Add(this.CommandTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 34);
            this.panel1.TabIndex = 28;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.SayCheckBox);
            this.panel9.Controls.Add(this.SayLabel);
            this.panel9.Location = new System.Drawing.Point(1, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(50, 27);
            this.panel9.TabIndex = 29;
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Controls.Add(this.GuiUsageLabel);
            this.panel10.Controls.Add(this.GuiProgressBar);
            this.panel10.Controls.Add(this.GuiPercentLabel);
            this.panel10.Location = new System.Drawing.Point(88, 37);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(879, 43);
            this.panel10.TabIndex = 29;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Controls.Add(this.CpuUsageLabel);
            this.panel11.Controls.Add(this.CpuProgressBar);
            this.panel11.Controls.Add(this.CpuPercentLabel);
            this.panel11.Location = new System.Drawing.Point(87, 79);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(879, 43);
            this.panel11.TabIndex = 30;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.Controls.Add(this.RamUsageLabel);
            this.panel12.Controls.Add(this.RamProgressBar);
            this.panel12.Controls.Add(this.RamPercentLabel);
            this.panel12.Location = new System.Drawing.Point(88, 123);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(879, 43);
            this.panel12.TabIndex = 31;
            // 
            // ConsolePageButtonsFlowPanel
            // 
            this.ConsolePageButtonsFlowPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConsolePageButtonsFlowPanel.Controls.Add(this.StartButton);
            this.ConsolePageButtonsFlowPanel.Controls.Add(this.RestartButton);
            this.ConsolePageButtonsFlowPanel.Controls.Add(this.ReloadButton);
            this.ConsolePageButtonsFlowPanel.Controls.Add(this.KillButton);
            this.ConsolePageButtonsFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ConsolePageButtonsFlowPanel.Location = new System.Drawing.Point(3, 37);
            this.ConsolePageButtonsFlowPanel.Name = "ConsolePageButtonsFlowPanel";
            this.ConsolePageButtonsFlowPanel.Size = new System.Drawing.Size(83, 129);
            this.ConsolePageButtonsFlowPanel.TabIndex = 24;
            this.ConsolePageButtonsFlowPanel.WrapContents = false;
            // 
            // KillButton
            // 
            this.KillButton.BackColor = System.Drawing.Color.LightGray;
            this.KillButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KillButton.Location = new System.Drawing.Point(3, 90);
            this.KillButton.Name = "KillButton";
            this.KillButton.Size = new System.Drawing.Size(75, 23);
            this.KillButton.TabIndex = 6;
            this.KillButton.Text = "Kill";
            this.KillButton.UseVisualStyleBackColor = false;
            this.KillButton.Click += new System.EventHandler(this.KillButton_Click);
            // 
            // ReloadButton
            // 
            this.ReloadButton.BackColor = System.Drawing.Color.LightGray;
            this.ReloadButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReloadButton.Location = new System.Drawing.Point(3, 61);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(75, 23);
            this.ReloadButton.TabIndex = 5;
            this.ReloadButton.Text = "Reload";
            this.ReloadButton.UseVisualStyleBackColor = false;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.BackColor = System.Drawing.Color.LightGray;
            this.RestartButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartButton.Location = new System.Drawing.Point(3, 32);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(75, 23);
            this.RestartButton.TabIndex = 4;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.LightGray;
            this.StartButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(3, 3);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.Controls.Add(this.panel12);
            this.panel13.Controls.Add(this.panel11);
            this.panel13.Controls.Add(this.panel10);
            this.panel13.Controls.Add(this.ConsolePageButtonsFlowPanel);
            this.panel13.Controls.Add(this.panel1);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(3, 471);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(970, 174);
            this.panel13.TabIndex = 34;
            // 
            // RamProgressBar
            // 
            this.RamProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RamProgressBar.BackColor = System.Drawing.Color.White;
            this.RamProgressBar.Location = new System.Drawing.Point(68, 8);
            this.RamProgressBar.Name = "RamProgressBar";
            this.RamProgressBar.Size = new System.Drawing.Size(774, 23);
            this.RamProgressBar.TabIndex = 11;
            this.RamProgressBar.Value = 50;
            // 
            // ServerGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 676);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Name = "ServerGui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server Gui - iBlitzkriegi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerGui_FormClosing);
            this.Load += new System.EventHandler(this.ServerGui_Load);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlayersGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.StartupPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.JavaOptionsGroupBox.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRamTrackBar)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinRamTrackBar)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).EndInit();
            this.PlayersContextMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ConsolePageButtonsFlowPanel.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label CpuUsageLabel;
        private System.Windows.Forms.ProgressBar CpuProgressBar;
        private System.Windows.Forms.Label CpuPercentLabel;
        private System.Windows.Forms.Label RamUsageLabel;
        private System.Windows.Forms.Label RamPercentLabel;
        private System.Windows.Forms.Label SayLabel;
        private System.Windows.Forms.CheckBox SayCheckBox;
        private System.Windows.Forms.TextBox CommandTextBox;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox ConsoleTextBox;
        private System.Windows.Forms.Timer ProgressBarTimer;
        private System.Diagnostics.PerformanceCounter CPU;
        private System.Diagnostics.PerformanceCounter RAM;
        private System.Windows.Forms.FlowLayoutPanel PlayerFlowPanel;
        private System.Windows.Forms.ContextMenuStrip PlayersContextMenu;
        private System.Windows.Forms.ToolStripMenuItem opToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deOpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem banToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamemodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem survivalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spectatorToolStripMenuItem;
        private System.Windows.Forms.DataGridView PlayersGridView;
        private System.Windows.Forms.TabPage StartupPage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CurrentConfigurationLabel;
        private System.Windows.Forms.ComboBox CurrentConfigurationComboBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox JavaOptionsGroupBox;
        private System.Windows.Forms.Button CreateNewConfigurationButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox JavaVersionComboBox;
        private System.Windows.Forms.Label JavaVersionLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label JarFileLabel;
        private System.Windows.Forms.TextBox JarFileTextBox;
        private System.Windows.Forms.Button OpenJarFileButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label MinRamLabel;
        private System.Windows.Forms.TrackBar MinRamTrackBar;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label MaxRamLabel;
        private System.Windows.Forms.TrackBar MaxRamTrackBar;
        private System.Windows.Forms.Label CustomArgumentsLabel;
        private System.Windows.Forms.TextBox CustomArgumentsTextBox;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label GuiUsageLabel;
        private System.Windows.Forms.ProgressBar GuiProgressBar;
        private System.Windows.Forms.Label GuiPercentLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.FlowLayoutPanel ConsolePageButtonsFlowPanel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Button ReloadButton;
        private System.Windows.Forms.Button KillButton;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.ProgressBar RamProgressBar;
    }
}

