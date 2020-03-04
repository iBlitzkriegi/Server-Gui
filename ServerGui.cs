using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;

namespace ServerGui
{
    public partial class ServerGui : Form
    {
        Process compiler = null;
        List<String> executedCommandsList = new List<String>();
        int maxSystemMemory;
        public int executedCommandsIndex;

        public ServerGui()
        {
            InitializeComponent();
            ConsoleTextBox.VisibleChanged += (sender, e) =>
            {
                if (ConsoleTextBox.Visible)
                {
                    ConsoleTextBox.SelectionStart = ConsoleTextBox.TextLength;
                    ConsoleTextBox.ScrollToCaret();
                }
            };

        }

        private void ServerGui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                this.ExecuteCommand(this.CommandTextBox.Text);
                e.Handled = true;
                this.CommandTextBox.Text = "";
            }
        }


        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                if (!string.IsNullOrWhiteSpace(ConsoleTextBox.Text))
                {
                    ConsoleTextBox.AppendText("\r\n" + e.Data);
                }
                else
                {
                    ConsoleTextBox.AppendText(e.Data);
                }
                ConsoleTextBox.Select(ConsoleTextBox.TextLength, 0);
                ConsoleTextBox.ScrollToCaret();
            }));
        }

        private void ExecuteCommand(String command)
        {
            if (this.compiler != null)
            {
                System.IO.StreamWriter sr = this.compiler.StandardInput;
                if (this.SayCheckBox.Checked)
                {
                    sr.WriteLine("say " + command);
                    this.executedCommandsList.Add("say " + command);
                }
                else
                {
                    sr.WriteLine(command);
                    this.executedCommandsList.Add(command);
                }
            }
        }

        void StartServer()
        {
            Process compiler = new Process();
            compiler.StartInfo.FileName = "java";
            compiler.StartInfo.Arguments = "-jar C:\\Users\\matthew\\Desktop\\Minecraft\\Vixio\\paperclip.jar nogui";
            compiler.StartInfo.WorkingDirectory = "C:\\Users\\matthew\\Desktop\\Minecraft\\Vixio";

            compiler.StartInfo.UseShellExecute = false;
            compiler.StartInfo.CreateNoWindow = true;
            compiler.OutputDataReceived += new System.Diagnostics.DataReceivedEventHandler(Process_OutputDataReceived);
            compiler.StartInfo.RedirectStandardOutput = true;
            compiler.StartInfo.RedirectStandardInput = true;
            this.compiler = compiler;
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(ServerGui_KeyPress);



            compiler.Start();
            compiler.BeginOutputReadLine();
            this.StartButton.Text = "Stop";
        }

        void StopServer()
        {
            this.ExecuteCommand("stop");
            this.compiler.Close();
            this.compiler = null;
            this.StartButton.Text = "Start";
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (this.StartButton.Text == "Start")
            {
                this.StartServer();
            }
            else
            {
                if (this.compiler != null)
                {
                    this.StopServer();
                }
            }
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            this.ExecuteCommand(this.CommandTextBox.Text);
        }

        private void KillButton_Click(object sender, EventArgs e)
        {
            if (this.compiler != null)
            {
                this.compiler.Kill();
                this.StartButton.Text = "Start";
            }
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            this.ExecuteCommand("reload");
            this.ExecuteCommand("reload confirm");
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            this.StopServer();
            this.StartServer();
        }

        private void ExecuteCommandsPanel_Resize(object sender, EventArgs e)
        {
            this.CommandTextBox.Width = this.ExecuteCommandsPanel.Width - this.ExecuteButton.Width - this.flowLayoutPanel9.Width - 25;

        }

        private void BottomHalfOfConsolePanel_Resize(object sender, EventArgs e)
        {
            int bottomHalfOfConsoleWidth = this.BottomHalfOfConsole.Width;
            int padding = 35;

            this.ExecuteCommandsPanel.Width = bottomHalfOfConsoleWidth;
            this.ConsolePageUiElementsPanel.Width = bottomHalfOfConsoleWidth;
            this.ServerStatisticsPanel.Width = bottomHalfOfConsoleWidth - this.ConsolePageButtonsFlowPanel.Width;
            this.GuiUsagePanel.Width = bottomHalfOfConsoleWidth;

            int progressBarWidth = this.ServerStatisticsPanel.Width - this.GuiUsageLabel.Width - this.GuiPercentLabel.Width - padding;
            this.GuiProgressBar.Width = progressBarWidth;
            this.CpuProgressBar.Width = progressBarWidth;
            this.RamProgressBar.Width = progressBarWidth;
        }

        private void ServerGui_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.compiler != null)
            {
                this.ExecuteCommand("stop");
                this.compiler.Kill();
            }
        }

        private void CommandTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down) { return; }
            if (executedCommandsList.Count >= 1)
            {
                if (!String.IsNullOrEmpty(this.CommandTextBox.Text))
                {

                    if (!(e.KeyCode == Keys.Down && this.executedCommandsIndex == this.executedCommandsList.Count - 1))
                    {
                        if (e.KeyCode == Keys.Up)
                        {
                            this.executedCommandsIndex -= 1;
                        }
                        else
                        {
                            if (this.executedCommandsIndex + 1 < this.executedCommandsList.Count)
                            {
                                this.executedCommandsIndex += 1;
                            }
                        }
                        if (this.executedCommandsIndex >= 0 && this.executedCommandsIndex < this.executedCommandsList.Count)
                        {
                            this.CommandTextBox.Text = this.executedCommandsList[this.executedCommandsIndex];
                        }
                    }
                    else
                    {
                        this.CommandTextBox.Text = "";
                    }

                }
                else
                {
                    int i = this.executedCommandsList.Count - 1;
                    this.CommandTextBox.Text = executedCommandsList[i];
                    this.executedCommandsIndex = i;
                }

            }
            e.Handled = true;
            this.CommandTextBox.Focus();
            this.CommandTextBox.SelectionStart = this.CommandTextBox.TextLength + 1;
            this.CommandTextBox.SelectionLength = 0;


        }

        private void ServerGui_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            this.maxSystemMemory = Convert.ToInt32(new ComputerInfo().TotalPhysicalMemory / 1024 / 1024);

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //TODO Update variable naming, 
            //Also need to implement GUI memory usage statistics
            float fcpu = CPU.NextValue();
            float ram = RAM.NextValue();
            if (fcpu != 0)
            {
                CpuProgressBar.Value = (int)fcpu;
                CpuPercentLabel.Text = ((int)fcpu).ToString() + "%";
            }
            if (ram != 0)
            {
                int value = (int)(ram / 16000 * 100);
                value = 100 - value;
                RamProgressBar.Value = value;
                RamPercentLabel.Text = value.ToString() + "%";
            }

        }

    }
}

