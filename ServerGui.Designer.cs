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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BottomHalfOfConsole = new System.Windows.Forms.FlowLayoutPanel();
            this.ExecuteCommandsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.SayLabel = new System.Windows.Forms.Label();
            this.SayCheckBox = new System.Windows.Forms.CheckBox();
            this.CommandTextBox = new System.Windows.Forms.TextBox();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.ConsolePageUiElementsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ConsolePageButtonsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.StartButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.KillButton = new System.Windows.Forms.Button();
            this.ServerStatisticsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.GuiUsagePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.GuiUsageLabel = new System.Windows.Forms.Label();
            this.GuiProgressBar = new System.Windows.Forms.ProgressBar();
            this.GuiPercentLabel = new System.Windows.Forms.Label();
            this.GpuUsagePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CpuUsageLabel = new System.Windows.Forms.Label();
            this.CpuProgressBar = new System.Windows.Forms.ProgressBar();
            this.CpuPercentLabel = new System.Windows.Forms.Label();
            this.RamUsagePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.RamUsageLabel = new System.Windows.Forms.Label();
            this.RamProgressBar = new System.Windows.Forms.ProgressBar();
            this.RamPercentLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PlayerFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ConsoleTextBox = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.BottomHalfOfConsole.SuspendLayout();
            this.ExecuteCommandsPanel.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.ConsolePageUiElementsPanel.SuspendLayout();
            this.ConsolePageButtonsFlowPanel.SuspendLayout();
            this.ServerStatisticsPanel.SuspendLayout();
            this.GuiUsagePanel.SuspendLayout();
            this.GpuUsagePanel.SuspendLayout();
            this.RamUsagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).BeginInit();
            this.PlayersContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 648);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
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
            this.tabPage3.Controls.Add(this.BottomHalfOfConsole);
            this.tabPage3.Controls.Add(this.splitContainer1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 648);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Console";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // BottomHalfOfConsole
            // 
            this.BottomHalfOfConsole.BackColor = System.Drawing.Color.Transparent;
            this.BottomHalfOfConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BottomHalfOfConsole.Controls.Add(this.ExecuteCommandsPanel);
            this.BottomHalfOfConsole.Controls.Add(this.ConsolePageUiElementsPanel);
            this.BottomHalfOfConsole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomHalfOfConsole.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.BottomHalfOfConsole.Location = new System.Drawing.Point(3, 474);
            this.BottomHalfOfConsole.Name = "BottomHalfOfConsole";
            this.BottomHalfOfConsole.Size = new System.Drawing.Size(970, 171);
            this.BottomHalfOfConsole.TabIndex = 27;
            this.BottomHalfOfConsole.WrapContents = false;
            this.BottomHalfOfConsole.Resize += new System.EventHandler(this.BottomHalfOfConsolePanel_Resize);
            // 
            // ExecuteCommandsPanel
            // 
            this.ExecuteCommandsPanel.BackColor = System.Drawing.Color.Transparent;
            this.ExecuteCommandsPanel.Controls.Add(this.flowLayoutPanel9);
            this.ExecuteCommandsPanel.Controls.Add(this.CommandTextBox);
            this.ExecuteCommandsPanel.Controls.Add(this.ExecuteButton);
            this.ExecuteCommandsPanel.Location = new System.Drawing.Point(3, 3);
            this.ExecuteCommandsPanel.Name = "ExecuteCommandsPanel";
            this.ExecuteCommandsPanel.Size = new System.Drawing.Size(967, 34);
            this.ExecuteCommandsPanel.TabIndex = 10;
            this.ExecuteCommandsPanel.WrapContents = false;
            this.ExecuteCommandsPanel.Resize += new System.EventHandler(this.ExecuteCommandsPanel_Resize);
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel9.Controls.Add(this.SayLabel);
            this.flowLayoutPanel9.Controls.Add(this.SayCheckBox);
            this.flowLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(59, 27);
            this.flowLayoutPanel9.TabIndex = 11;
            this.flowLayoutPanel9.WrapContents = false;
            // 
            // SayLabel
            // 
            this.SayLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SayLabel.AutoSize = true;
            this.SayLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SayLabel.Location = new System.Drawing.Point(3, 4);
            this.SayLabel.Name = "SayLabel";
            this.SayLabel.Size = new System.Drawing.Size(30, 17);
            this.SayLabel.TabIndex = 7;
            this.SayLabel.Text = "Say";
            // 
            // SayCheckBox
            // 
            this.SayCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SayCheckBox.AutoSize = true;
            this.SayCheckBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SayCheckBox.Location = new System.Drawing.Point(39, 8);
            this.SayCheckBox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.SayCheckBox.Name = "SayCheckBox";
            this.SayCheckBox.Size = new System.Drawing.Size(15, 14);
            this.SayCheckBox.TabIndex = 8;
            this.SayCheckBox.UseVisualStyleBackColor = true;
            // 
            // CommandTextBox
            // 
            this.CommandTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CommandTextBox.Location = new System.Drawing.Point(68, 5);
            this.CommandTextBox.Name = "CommandTextBox";
            this.CommandTextBox.Size = new System.Drawing.Size(811, 22);
            this.CommandTextBox.TabIndex = 9;
            this.CommandTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommandTextBox_KeyDown);
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExecuteButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteButton.Location = new System.Drawing.Point(885, 4);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(75, 24);
            this.ExecuteButton.TabIndex = 9;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // ConsolePageUiElementsPanel
            // 
            this.ConsolePageUiElementsPanel.Controls.Add(this.ConsolePageButtonsFlowPanel);
            this.ConsolePageUiElementsPanel.Controls.Add(this.ServerStatisticsPanel);
            this.ConsolePageUiElementsPanel.Location = new System.Drawing.Point(3, 43);
            this.ConsolePageUiElementsPanel.Name = "ConsolePageUiElementsPanel";
            this.ConsolePageUiElementsPanel.Size = new System.Drawing.Size(973, 122);
            this.ConsolePageUiElementsPanel.TabIndex = 26;
            this.ConsolePageUiElementsPanel.WrapContents = false;
            // 
            // ConsolePageButtonsFlowPanel
            // 
            this.ConsolePageButtonsFlowPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConsolePageButtonsFlowPanel.Controls.Add(this.StartButton);
            this.ConsolePageButtonsFlowPanel.Controls.Add(this.RestartButton);
            this.ConsolePageButtonsFlowPanel.Controls.Add(this.ReloadButton);
            this.ConsolePageButtonsFlowPanel.Controls.Add(this.KillButton);
            this.ConsolePageButtonsFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ConsolePageButtonsFlowPanel.Location = new System.Drawing.Point(3, 3);
            this.ConsolePageButtonsFlowPanel.Name = "ConsolePageButtonsFlowPanel";
            this.ConsolePageButtonsFlowPanel.Size = new System.Drawing.Size(83, 127);
            this.ConsolePageButtonsFlowPanel.TabIndex = 24;
            this.ConsolePageButtonsFlowPanel.WrapContents = false;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(3, 3);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartButton.Location = new System.Drawing.Point(3, 32);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(75, 23);
            this.RestartButton.TabIndex = 4;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // ReloadButton
            // 
            this.ReloadButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReloadButton.Location = new System.Drawing.Point(3, 61);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(75, 23);
            this.ReloadButton.TabIndex = 5;
            this.ReloadButton.Text = "Reload";
            this.ReloadButton.UseVisualStyleBackColor = true;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // KillButton
            // 
            this.KillButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KillButton.Location = new System.Drawing.Point(3, 90);
            this.KillButton.Name = "KillButton";
            this.KillButton.Size = new System.Drawing.Size(75, 23);
            this.KillButton.TabIndex = 6;
            this.KillButton.Text = "Kill";
            this.KillButton.UseVisualStyleBackColor = true;
            this.KillButton.Click += new System.EventHandler(this.KillButton_Click);
            // 
            // ServerStatisticsPanel
            // 
            this.ServerStatisticsPanel.BackColor = System.Drawing.Color.Transparent;
            this.ServerStatisticsPanel.Controls.Add(this.GuiUsagePanel);
            this.ServerStatisticsPanel.Controls.Add(this.GpuUsagePanel);
            this.ServerStatisticsPanel.Controls.Add(this.RamUsagePanel);
            this.ServerStatisticsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ServerStatisticsPanel.Location = new System.Drawing.Point(92, 3);
            this.ServerStatisticsPanel.Name = "ServerStatisticsPanel";
            this.ServerStatisticsPanel.Size = new System.Drawing.Size(875, 117);
            this.ServerStatisticsPanel.TabIndex = 25;
            this.ServerStatisticsPanel.WrapContents = false;
            // 
            // GuiUsagePanel
            // 
            this.GuiUsagePanel.BackColor = System.Drawing.Color.Transparent;
            this.GuiUsagePanel.Controls.Add(this.GuiUsageLabel);
            this.GuiUsagePanel.Controls.Add(this.GuiProgressBar);
            this.GuiUsagePanel.Controls.Add(this.GuiPercentLabel);
            this.GuiUsagePanel.Location = new System.Drawing.Point(3, 3);
            this.GuiUsagePanel.Name = "GuiUsagePanel";
            this.GuiUsagePanel.Size = new System.Drawing.Size(872, 34);
            this.GuiUsagePanel.TabIndex = 23;
            this.GuiUsagePanel.WrapContents = false;
            // 
            // GuiUsageLabel
            // 
            this.GuiUsageLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GuiUsageLabel.AutoSize = true;
            this.GuiUsageLabel.Location = new System.Drawing.Point(3, 7);
            this.GuiUsageLabel.Name = "GuiUsageLabel";
            this.GuiUsageLabel.Size = new System.Drawing.Size(65, 15);
            this.GuiUsageLabel.TabIndex = 19;
            this.GuiUsageLabel.Text = "GUI Usage";
            // 
            // GuiProgressBar
            // 
            this.GuiProgressBar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GuiProgressBar.Location = new System.Drawing.Point(74, 3);
            this.GuiProgressBar.Name = "GuiProgressBar";
            this.GuiProgressBar.Size = new System.Drawing.Size(752, 23);
            this.GuiProgressBar.TabIndex = 12;
            this.GuiProgressBar.Value = 50;
            // 
            // GuiPercentLabel
            // 
            this.GuiPercentLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GuiPercentLabel.AutoSize = true;
            this.GuiPercentLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuiPercentLabel.Location = new System.Drawing.Point(832, 6);
            this.GuiPercentLabel.Name = "GuiPercentLabel";
            this.GuiPercentLabel.Size = new System.Drawing.Size(35, 17);
            this.GuiPercentLabel.TabIndex = 16;
            this.GuiPercentLabel.Text = "34%";
            // 
            // GpuUsagePanel
            // 
            this.GpuUsagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GpuUsagePanel.BackColor = System.Drawing.Color.Transparent;
            this.GpuUsagePanel.Controls.Add(this.CpuUsageLabel);
            this.GpuUsagePanel.Controls.Add(this.CpuProgressBar);
            this.GpuUsagePanel.Controls.Add(this.CpuPercentLabel);
            this.GpuUsagePanel.Location = new System.Drawing.Point(3, 43);
            this.GpuUsagePanel.Name = "GpuUsagePanel";
            this.GpuUsagePanel.Size = new System.Drawing.Size(872, 34);
            this.GpuUsagePanel.TabIndex = 22;
            this.GpuUsagePanel.WrapContents = false;
            // 
            // CpuUsageLabel
            // 
            this.CpuUsageLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CpuUsageLabel.AutoSize = true;
            this.CpuUsageLabel.Location = new System.Drawing.Point(3, 7);
            this.CpuUsageLabel.Name = "CpuUsageLabel";
            this.CpuUsageLabel.Size = new System.Drawing.Size(68, 15);
            this.CpuUsageLabel.TabIndex = 18;
            this.CpuUsageLabel.Text = "CPU Usage";
            // 
            // CpuProgressBar
            // 
            this.CpuProgressBar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CpuProgressBar.Location = new System.Drawing.Point(77, 3);
            this.CpuProgressBar.Name = "CpuProgressBar";
            this.CpuProgressBar.Size = new System.Drawing.Size(752, 23);
            this.CpuProgressBar.TabIndex = 13;
            this.CpuProgressBar.Value = 50;
            // 
            // CpuPercentLabel
            // 
            this.CpuPercentLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CpuPercentLabel.AutoSize = true;
            this.CpuPercentLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpuPercentLabel.Location = new System.Drawing.Point(835, 6);
            this.CpuPercentLabel.Name = "CpuPercentLabel";
            this.CpuPercentLabel.Size = new System.Drawing.Size(35, 17);
            this.CpuPercentLabel.TabIndex = 15;
            this.CpuPercentLabel.Text = "34%";
            // 
            // RamUsagePanel
            // 
            this.RamUsagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RamUsagePanel.BackColor = System.Drawing.Color.Transparent;
            this.RamUsagePanel.Controls.Add(this.RamUsageLabel);
            this.RamUsagePanel.Controls.Add(this.RamProgressBar);
            this.RamUsagePanel.Controls.Add(this.RamPercentLabel);
            this.RamUsagePanel.Location = new System.Drawing.Point(3, 83);
            this.RamUsagePanel.Name = "RamUsagePanel";
            this.RamUsagePanel.Size = new System.Drawing.Size(872, 34);
            this.RamUsagePanel.TabIndex = 21;
            this.RamUsagePanel.WrapContents = false;
            // 
            // RamUsageLabel
            // 
            this.RamUsageLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RamUsageLabel.AutoSize = true;
            this.RamUsageLabel.Location = new System.Drawing.Point(3, 7);
            this.RamUsageLabel.Name = "RamUsageLabel";
            this.RamUsageLabel.Size = new System.Drawing.Size(67, 15);
            this.RamUsageLabel.TabIndex = 17;
            this.RamUsageLabel.Text = "Ram Usage";
            // 
            // RamProgressBar
            // 
            this.RamProgressBar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RamProgressBar.Location = new System.Drawing.Point(76, 3);
            this.RamProgressBar.Name = "RamProgressBar";
            this.RamProgressBar.Size = new System.Drawing.Size(752, 23);
            this.RamProgressBar.TabIndex = 11;
            this.RamProgressBar.Value = 50;
            // 
            // RamPercentLabel
            // 
            this.RamPercentLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RamPercentLabel.AutoSize = true;
            this.RamPercentLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RamPercentLabel.Location = new System.Drawing.Point(834, 6);
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
            this.splitContainer1.Panel2.Controls.Add(this.ConsoleTextBox);
            this.splitContainer1.Panel2MinSize = 40;
            this.splitContainer1.Size = new System.Drawing.Size(968, 471);
            this.splitContainer1.SplitterDistance = 152;
            this.splitContainer1.TabIndex = 2;
            // 
            // PlayerFlowPanel
            // 
            this.PlayerFlowPanel.AutoScroll = true;
            this.PlayerFlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayerFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PlayerFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.PlayerFlowPanel.Name = "PlayerFlowPanel";
            this.PlayerFlowPanel.Size = new System.Drawing.Size(152, 471);
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
            this.ConsoleTextBox.Size = new System.Drawing.Size(812, 471);
            this.ConsoleTextBox.TabIndex = 1;
            this.ConsoleTextBox.Text = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.PlayersContextMenu.Size = new System.Drawing.Size(181, 136);
            this.PlayersContextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // opToolStripMenuItem
            // 
            this.opToolStripMenuItem.Image = global::ServerGui.Properties.Resources.head;
            this.opToolStripMenuItem.Name = "opToolStripMenuItem";
            this.opToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.opToolStripMenuItem.Text = "Op";
            // 
            // deOpToolStripMenuItem
            // 
            this.deOpToolStripMenuItem.Image = global::ServerGui.Properties.Resources.head;
            this.deOpToolStripMenuItem.Name = "deOpToolStripMenuItem";
            this.deOpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deOpToolStripMenuItem.Text = "De-Op";
            // 
            // kickToolStripMenuItem
            // 
            this.kickToolStripMenuItem.Image = global::ServerGui.Properties.Resources.head;
            this.kickToolStripMenuItem.Name = "kickToolStripMenuItem";
            this.kickToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kickToolStripMenuItem.Text = "Kick";
            // 
            // banToolStripMenuItem
            // 
            this.banToolStripMenuItem.Image = global::ServerGui.Properties.Resources.head;
            this.banToolStripMenuItem.Name = "banToolStripMenuItem";
            this.banToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.gamemodeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gamemodeToolStripMenuItem.Text = "Gamemode";
            // 
            // survivalToolStripMenuItem
            // 
            this.survivalToolStripMenuItem.Name = "survivalToolStripMenuItem";
            this.survivalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.survivalToolStripMenuItem.Text = "Survival";
            // 
            // creativeToolStripMenuItem
            // 
            this.creativeToolStripMenuItem.Name = "creativeToolStripMenuItem";
            this.creativeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.creativeToolStripMenuItem.Text = "Creative";
            // 
            // spectatorToolStripMenuItem
            // 
            this.spectatorToolStripMenuItem.Name = "spectatorToolStripMenuItem";
            this.spectatorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.spectatorToolStripMenuItem.Text = "Spectator";
            // 
            // ServerGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 676);
            this.Controls.Add(this.tabControl1);
            this.Name = "ServerGui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server Gui - iBlitzkriegi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerGui_FormClosing);
            this.Load += new System.EventHandler(this.ServerGui_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.BottomHalfOfConsole.ResumeLayout(false);
            this.ExecuteCommandsPanel.ResumeLayout(false);
            this.ExecuteCommandsPanel.PerformLayout();
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
            this.ConsolePageUiElementsPanel.ResumeLayout(false);
            this.ConsolePageButtonsFlowPanel.ResumeLayout(false);
            this.ServerStatisticsPanel.ResumeLayout(false);
            this.GuiUsagePanel.ResumeLayout(false);
            this.GuiUsagePanel.PerformLayout();
            this.GpuUsagePanel.ResumeLayout(false);
            this.GpuUsagePanel.PerformLayout();
            this.RamUsagePanel.ResumeLayout(false);
            this.RamUsagePanel.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).EndInit();
            this.PlayersContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.FlowLayoutPanel ServerStatisticsPanel;
        private System.Windows.Forms.FlowLayoutPanel ConsolePageButtonsFlowPanel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Button ReloadButton;
        private System.Windows.Forms.Button KillButton;
        private System.Windows.Forms.FlowLayoutPanel GpuUsagePanel;
        private System.Windows.Forms.Label CpuUsageLabel;
        private System.Windows.Forms.ProgressBar CpuProgressBar;
        private System.Windows.Forms.Label CpuPercentLabel;
        private System.Windows.Forms.FlowLayoutPanel RamUsagePanel;
        private System.Windows.Forms.Label RamUsageLabel;
        private System.Windows.Forms.ProgressBar RamProgressBar;
        private System.Windows.Forms.Label RamPercentLabel;
        private System.Windows.Forms.FlowLayoutPanel ExecuteCommandsPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.Label SayLabel;
        private System.Windows.Forms.CheckBox SayCheckBox;
        private System.Windows.Forms.TextBox CommandTextBox;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.FlowLayoutPanel GuiUsagePanel;
        private System.Windows.Forms.Label GuiUsageLabel;
        private System.Windows.Forms.ProgressBar GuiProgressBar;
        private System.Windows.Forms.Label GuiPercentLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox ConsoleTextBox;
        private System.Windows.Forms.FlowLayoutPanel ConsolePageUiElementsPanel;
        private System.Windows.Forms.FlowLayoutPanel BottomHalfOfConsole;
        private System.Windows.Forms.Timer timer1;
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
    }
}

