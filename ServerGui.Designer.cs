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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ConsolePage = new System.Windows.Forms.TabPage();
            this.GuiUsageLabel = new System.Windows.Forms.Label();
            this.GpuUsageLabel = new System.Windows.Forms.Label();
            this.RamUsageLabel = new System.Windows.Forms.Label();
            this.GuiPercentLabel = new System.Windows.Forms.Label();
            this.GpuPercentLabel = new System.Windows.Forms.Label();
            this.RamPercentLabel = new System.Windows.Forms.Label();
            this.GpuProgressBar = new System.Windows.Forms.ProgressBar();
            this.GuiProgressBar = new System.Windows.Forms.ProgressBar();
            this.RamProgressBar = new System.Windows.Forms.ProgressBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.SayLabel = new System.Windows.Forms.Label();
            this.SayCheckBox = new System.Windows.Forms.CheckBox();
            this.CommandTextBox = new System.Windows.Forms.TextBox();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.KillButton = new System.Windows.Forms.Button();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.consoleContainer = new System.Windows.Forms.SplitContainer();
            this.PlayersListBox = new System.Windows.Forms.ListBox();
            this.ConsoleTextBox = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ConsolePage.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consoleContainer)).BeginInit();
            this.consoleContainer.Panel1.SuspendLayout();
            this.consoleContainer.Panel2.SuspendLayout();
            this.consoleContainer.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            // ConsolePage
            // 
            this.ConsolePage.Controls.Add(this.GuiUsageLabel);
            this.ConsolePage.Controls.Add(this.GpuUsageLabel);
            this.ConsolePage.Controls.Add(this.RamUsageLabel);
            this.ConsolePage.Controls.Add(this.GuiPercentLabel);
            this.ConsolePage.Controls.Add(this.GpuPercentLabel);
            this.ConsolePage.Controls.Add(this.RamPercentLabel);
            this.ConsolePage.Controls.Add(this.GpuProgressBar);
            this.ConsolePage.Controls.Add(this.GuiProgressBar);
            this.ConsolePage.Controls.Add(this.RamProgressBar);
            this.ConsolePage.Controls.Add(this.flowLayoutPanel1);
            this.ConsolePage.Controls.Add(this.KillButton);
            this.ConsolePage.Controls.Add(this.ReloadButton);
            this.ConsolePage.Controls.Add(this.RestartButton);
            this.ConsolePage.Controls.Add(this.StartButton);
            this.ConsolePage.Controls.Add(this.consoleContainer);
            this.ConsolePage.Location = new System.Drawing.Point(4, 24);
            this.ConsolePage.Name = "ConsolePage";
            this.ConsolePage.Padding = new System.Windows.Forms.Padding(3);
            this.ConsolePage.Size = new System.Drawing.Size(976, 648);
            this.ConsolePage.TabIndex = 0;
            this.ConsolePage.Text = "Console";
            this.ConsolePage.UseVisualStyleBackColor = true;
            // 
            // GuiUsageLabel
            // 
            this.GuiUsageLabel.AutoSize = true;
            this.GuiUsageLabel.Location = new System.Drawing.Point(89, 608);
            this.GuiUsageLabel.Name = "GuiUsageLabel";
            this.GuiUsageLabel.Size = new System.Drawing.Size(65, 15);
            this.GuiUsageLabel.TabIndex = 19;
            this.GuiUsageLabel.Text = "GUI Usage";
            // 
            // GpuUsageLabel
            // 
            this.GpuUsageLabel.AutoSize = true;
            this.GpuUsageLabel.Location = new System.Drawing.Point(86, 568);
            this.GpuUsageLabel.Name = "GpuUsageLabel";
            this.GpuUsageLabel.Size = new System.Drawing.Size(68, 15);
            this.GpuUsageLabel.TabIndex = 18;
            this.GpuUsageLabel.Text = "GPU Usage";
            // 
            // RamUsageLabel
            // 
            this.RamUsageLabel.AutoSize = true;
            this.RamUsageLabel.Location = new System.Drawing.Point(87, 530);
            this.RamUsageLabel.Name = "RamUsageLabel";
            this.RamUsageLabel.Size = new System.Drawing.Size(67, 15);
            this.RamUsageLabel.TabIndex = 17;
            this.RamUsageLabel.Text = "Ram Usage";
            // 
            // GuiPercentLabel
            // 
            this.GuiPercentLabel.AutoSize = true;
            this.GuiPercentLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuiPercentLabel.Location = new System.Drawing.Point(935, 607);
            this.GuiPercentLabel.Name = "GuiPercentLabel";
            this.GuiPercentLabel.Size = new System.Drawing.Size(35, 17);
            this.GuiPercentLabel.TabIndex = 16;
            this.GuiPercentLabel.Text = "34%";
            // 
            // GpuPercentLabel
            // 
            this.GpuPercentLabel.AutoSize = true;
            this.GpuPercentLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpuPercentLabel.Location = new System.Drawing.Point(932, 568);
            this.GpuPercentLabel.Name = "GpuPercentLabel";
            this.GpuPercentLabel.Size = new System.Drawing.Size(35, 17);
            this.GpuPercentLabel.TabIndex = 15;
            this.GpuPercentLabel.Text = "34%";
            // 
            // RamPercentLabel
            // 
            this.RamPercentLabel.AutoSize = true;
            this.RamPercentLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RamPercentLabel.Location = new System.Drawing.Point(933, 529);
            this.RamPercentLabel.Name = "RamPercentLabel";
            this.RamPercentLabel.Size = new System.Drawing.Size(35, 17);
            this.RamPercentLabel.TabIndex = 14;
            this.RamPercentLabel.Text = "34%";
            // 
            // GpuProgressBar
            // 
            this.GpuProgressBar.Location = new System.Drawing.Point(160, 565);
            this.GpuProgressBar.Name = "GpuProgressBar";
            this.GpuProgressBar.Size = new System.Drawing.Size(766, 23);
            this.GpuProgressBar.TabIndex = 13;
            this.GpuProgressBar.Value = 50;
            // 
            // GuiProgressBar
            // 
            this.GuiProgressBar.Location = new System.Drawing.Point(160, 604);
            this.GuiProgressBar.Name = "GuiProgressBar";
            this.GuiProgressBar.Size = new System.Drawing.Size(766, 23);
            this.GuiProgressBar.TabIndex = 12;
            this.GuiProgressBar.Value = 50;
            // 
            // RamProgressBar
            // 
            this.RamProgressBar.Location = new System.Drawing.Point(160, 526);
            this.RamProgressBar.Name = "RamProgressBar";
            this.RamProgressBar.Size = new System.Drawing.Size(764, 23);
            this.RamProgressBar.TabIndex = 11;
            this.RamProgressBar.Value = 50;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.CommandTextBox);
            this.flowLayoutPanel1.Controls.Add(this.ExecuteButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 482);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(969, 34);
            this.flowLayoutPanel1.TabIndex = 10;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.SayLabel);
            this.flowLayoutPanel2.Controls.Add(this.SayCheckBox);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(59, 27);
            this.flowLayoutPanel2.TabIndex = 11;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // SayLabel
            // 
            this.SayLabel.AutoSize = true;
            this.SayLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SayLabel.Location = new System.Drawing.Point(3, 0);
            this.SayLabel.Name = "SayLabel";
            this.SayLabel.Size = new System.Drawing.Size(30, 17);
            this.SayLabel.TabIndex = 7;
            this.SayLabel.Text = "Say";
            // 
            // SayCheckBox
            // 
            this.SayCheckBox.AutoSize = true;
            this.SayCheckBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SayCheckBox.Location = new System.Drawing.Point(39, 3);
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
            this.CommandTextBox.Size = new System.Drawing.Size(818, 22);
            this.CommandTextBox.TabIndex = 9;
            this.CommandTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.CommandTextBox_PreviewKeyDown);
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExecuteButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteButton.Location = new System.Drawing.Point(892, 5);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(75, 23);
            this.ExecuteButton.TabIndex = 9;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // KillButton
            // 
            this.KillButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KillButton.Location = new System.Drawing.Point(6, 604);
            this.KillButton.Name = "KillButton";
            this.KillButton.Size = new System.Drawing.Size(75, 23);
            this.KillButton.TabIndex = 6;
            this.KillButton.Text = "Kill";
            this.KillButton.UseVisualStyleBackColor = true;
            this.KillButton.Click += new System.EventHandler(this.KillButton_Click);
            // 
            // ReloadButton
            // 
            this.ReloadButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReloadButton.Location = new System.Drawing.Point(6, 576);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(75, 23);
            this.ReloadButton.TabIndex = 5;
            this.ReloadButton.Text = "Reload";
            this.ReloadButton.UseVisualStyleBackColor = true;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartButton.Location = new System.Drawing.Point(6, 547);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(75, 23);
            this.RestartButton.TabIndex = 4;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(6, 518);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // consoleContainer
            // 
            this.consoleContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.consoleContainer.Location = new System.Drawing.Point(3, 3);
            this.consoleContainer.Name = "consoleContainer";
            // 
            // consoleContainer.Panel1
            // 
            this.consoleContainer.Panel1.Controls.Add(this.PlayersListBox);
            // 
            // consoleContainer.Panel2
            // 
            this.consoleContainer.Panel2.Controls.Add(this.ConsoleTextBox);
            this.consoleContainer.Panel2MinSize = 40;
            this.consoleContainer.Size = new System.Drawing.Size(970, 473);
            this.consoleContainer.SplitterDistance = 153;
            this.consoleContainer.TabIndex = 2;
            // 
            // PlayersListBox
            // 
            this.PlayersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayersListBox.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayersListBox.FormattingEnabled = true;
            this.PlayersListBox.IntegralHeight = false;
            this.PlayersListBox.ItemHeight = 14;
            this.PlayersListBox.Location = new System.Drawing.Point(0, 0);
            this.PlayersListBox.Name = "PlayersListBox";
            this.PlayersListBox.Size = new System.Drawing.Size(153, 473);
            this.PlayersListBox.TabIndex = 0;
            // 
            // ConsoleTextBox
            // 
            this.ConsoleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsoleTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleTextBox.Location = new System.Drawing.Point(0, 0);
            this.ConsoleTextBox.Name = "ConsoleTextBox";
            this.ConsoleTextBox.ReadOnly = true;
            this.ConsoleTextBox.Size = new System.Drawing.Size(813, 473);
            this.ConsoleTextBox.TabIndex = 1;
            this.ConsoleTextBox.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ConsolePage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 676);
            this.tabControl1.TabIndex = 0;
            // 
            // ServerGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 676);
            this.Controls.Add(this.tabControl1);
            this.Name = "ServerGui";
            this.Text = "Server Gui - iBlitzkriegi";
            this.ConsolePage.ResumeLayout(false);
            this.ConsolePage.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.consoleContainer.Panel1.ResumeLayout(false);
            this.consoleContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.consoleContainer)).EndInit();
            this.consoleContainer.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage ConsolePage;
        private System.Windows.Forms.Label GuiUsageLabel;
        private System.Windows.Forms.Label GpuUsageLabel;
        private System.Windows.Forms.Label RamUsageLabel;
        private System.Windows.Forms.Label GuiPercentLabel;
        private System.Windows.Forms.Label GpuPercentLabel;
        private System.Windows.Forms.Label RamPercentLabel;
        private System.Windows.Forms.ProgressBar GpuProgressBar;
        private System.Windows.Forms.ProgressBar GuiProgressBar;
        private System.Windows.Forms.ProgressBar RamProgressBar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label SayLabel;
        private System.Windows.Forms.CheckBox SayCheckBox;
        private System.Windows.Forms.TextBox CommandTextBox;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.Button KillButton;
        private System.Windows.Forms.Button ReloadButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.SplitContainer consoleContainer;
        private System.Windows.Forms.ListBox PlayersListBox;
        private System.Windows.Forms.RichTextBox ConsoleTextBox;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

