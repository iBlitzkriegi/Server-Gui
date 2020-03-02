using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ServerGui
{
    public partial class ServerGui : Form
    {
        Process compiler = null;
        List<String> executedCommandsList = new List<String>();
        public ServerGui()
        {
            InitializeComponent();
            ConsoleTextBox.VisibleChanged += (sender, e) =>
            {
                Console.WriteLine(ConsoleTextBox.Visible);
                if (ConsoleTextBox.Visible)
                {
                    ConsoleTextBox.SelectionStart = ConsoleTextBox.TextLength;
                    ConsoleTextBox.ScrollToCaret();
                }
            };

        }

        private void ServerGui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Return)
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
                } else
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
                //This wont work correctly until creating process code is moved to start button click area
                //Should also handle hittng the stop button when say is checked so it doesnt say "stop"
                System.IO.StreamWriter sr = this.compiler.StandardInput;
                if (this.SayCheckBox.Checked)
                {
                    sr.WriteLine("say " + command);
                }
                else
                {
                    sr.WriteLine(command);
                    this.executedCommandsList.Add(command);
                }
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (this.StartButton.Text == "Start")
            {
                //TODO HANDLE THE PROCESS CREATION STUFF HERE SO WE CAN CHECK IF A SERVER IS 
                //RUNNING BY CHECKING IF COMPILER IS NULL OR NOT.

                Process compiler = new Process();
                compiler.StartInfo.FileName = "java";
                compiler.StartInfo.Arguments = "-jar C:\\Users\\matthew\\Desktop\\Minecraft\\Vixio\\paperclip.jar nogui";
                compiler.StartInfo.WorkingDirectory = "C:\\Users\\matthew\\Desktop\\Minecraft\\Vixio";

                compiler.StartInfo.UseShellExecute = false;
                compiler.StartInfo.CreateNoWindow = true;
                compiler.OutputDataReceived += new System.Diagnostics.DataReceivedEventHandler(Process_OutputDataReceived);
                compiler.StartInfo.RedirectStandardOutput = true;
                compiler.StartInfo.RedirectStandardInput = true;
                //  compiler.Start();
                //  compiler.BeginOutputReadLine();
                this.compiler = compiler;
                this.KeyPreview = true;
                this.KeyPress += new KeyPressEventHandler(ServerGui_KeyPress);



                compiler.Start();
                compiler.BeginOutputReadLine();
                this.StartButton.Text = "Stop";
            }
            else
            {
                if (this.compiler != null) {
                    this.ExecuteCommand("stop");
                    this.compiler.Close();
                    this.compiler = null;
                    this.StartButton.Text = "Start";
                }
            }
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            //TODO MAKE THIS CACHE RAN COMMANDS TO ALLOW FOR UP ARROW EDIT
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
            this.ExecuteCommand("stop");
        }

        private void CommandTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode != Keys.Up) { return; }
            if (executedCommandsList.Count >= 1)
            {
                this.CommandTextBox.Text = executedCommandsList[executedCommandsList.Count - 1];
                this.CommandTextBox.Focus();
                this.CommandTextBox.SelectionStart = this.CommandTextBox.Text.Trim().Length + 1;
                this.CommandTextBox.SelectionLength = 0;
            }
        }

        private void ExecuteCommandsPanel_Resize(object sender, EventArgs e)
        {
            this.CommandTextBox.Width = this.ExecuteCommandsPanel.Width - this.ExecuteButton.Width - this.flowLayoutPanel9.Width - 25;
            
        }

        private void BottomHalfOfConsolePanel_Resize(object sender, EventArgs e)
        {
            int bottomHalfOfConsoleWidth = this.BottomHalfOfConsole.Width;
            int padding = 35;
            int progressBarWidth = this.ServerStatisticsPanel.Width - this.GuiUsageLabel.Width - this.GuiPercentLabel.Width - padding;

            this.ExecuteCommandsPanel.Width = bottomHalfOfConsoleWidth;
            this.ConsolePageUiElementsPanel.Width = bottomHalfOfConsoleWidth;
            this.ServerStatisticsPanel.Width = bottomHalfOfConsoleWidth - this.ConsolePageButtonsFlowPanel.Width;
            this.GuiUsagePanel.Width = bottomHalfOfConsoleWidth;

            this.GuiProgressBar.Width = progressBarWidth;
            this.GpuProgressBar.Width = progressBarWidth;
            this.RamProgressBar.Width = progressBarWidth;
        }

    }
}
