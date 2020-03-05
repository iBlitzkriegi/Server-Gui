﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;

namespace ServerGui
{
    public partial class ServerGui : Form
    {
        //TODO 
        //Make a global list of players so that when one leaves they can be removed from the list and the list can be reloaded.
        //Make OutputDataReceived also detect when a player leaves the game
        //Make playerFlowPanel remove players when they leave
        //Find actual icons for each item in the context menu 
        //
        Process compiler = null;
        List<String> executedCommandsList = new List<String>();
        int maxSystemMemory;
        string playerName;
        string playerUUID;
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
                if (SayCheckBox.Checked)
                {
                    this.ExecuteServerCommand("say " + this.CommandTextBox.Text);
                } else
                {
                    this.ExecuteCommand(this.CommandTextBox.Text);
                }
                e.Handled = true;
                this.CommandTextBox.Text = "";
            }
        }


        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {

            this.Invoke(new MethodInvoker(() =>
            {
                if (!String.IsNullOrEmpty(e.Data))
                {
                    if (!string.IsNullOrWhiteSpace(ConsoleTextBox.Text))
                    {
                        ConsoleTextBox.AppendText("\r\n" + e.Data);
                        if (e.Data.Contains("UUID of player"))
                        {
                            string[] line = e.Data.Split(' ');
                            this.playerUUID = line[line.Length - 1];
                        }
                        if (e.Data.Contains("logged in"))
                        {
                            Console.WriteLine("logged in!");
                            string[] line = e.Data.Split(' ');
                            Dictionary<object, string> player_information = new Dictionary<object, string>
                            {
                                ["name"] = line[2].Split('[')[0],
                                ["ip"] = line[2].Split('/')[1].Replace("]", string.Empty),
                                ["uuid"] = this.playerUUID
                            };
                            Console.WriteLine(String.Format("Player {0} joined with IP {1} and UUID {2}", player_information["name"], player_information["ip"], player_information["uuid"]));
                            add_player(player_information["name"]);
                            this.playerUUID = "";
                        }
                    }
                    else
                    {
                        ConsoleTextBox.AppendText(e.Data);
                    }
                    ConsoleTextBox.Select(ConsoleTextBox.TextLength, 0);
                    ConsoleTextBox.ScrollToCaret();
                }
            }));
        }

        void add_player(string name)
        {
            Button button = new Button();
            button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button.Image = Properties.Resources.head;
            button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button.Name = "button1";
            button.Size = new System.Drawing.Size(101, 24);
            button.Margin = new Padding(5, 0, 0, 0);
            button.TabIndex = 0;
            button.Text = name;
            button.TextImageRelation = TextImageRelation.ImageBeforeText;
            button.UseVisualStyleBackColor = true;
            button.MouseDown += (clickSender, clickEvent) =>
            {
                switch (clickEvent.Button)
                {
                    case MouseButtons.Right:
                        PlayersContextMenu.Show(Cursor.Position);
                        playerName = button.Text;
                        break;
                }
            };

            this.PlayerFlowPanel.Controls.Add(button);
        }

        private void ExecuteCommand(String command)
        {
            //TODO Add optiona boolean to decide if it should be added to executedCOmmandsList for things like stop
            //Or context menu commands
            if (this.compiler != null)
            {
                System.IO.StreamWriter sr = this.compiler.StandardInput;
                command = SayCheckBox.Checked ? "say " + command : command;
                sr.WriteLine(command);
                this.executedCommandsList.Add(command);
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
            this.ExecuteServerCommand("stop");
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
            this.ExecuteServerCommand("reload");
            this.ExecuteServerCommand("reload confirm");
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

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string clickedItem = e.ClickedItem.Text.ToLower().Replace("-", string.Empty);
            if (!clickedItem.Contains("gamemode"))
            {
                Console.WriteLine(String.Format("Potential command: {0} {1}", clickedItem, playerName));
                this.ExecuteServerCommand(clickedItem + " " + playerName);
            }
        }

        private void ServerGui_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.compiler != null)
            {
                this.ExecuteServerCommand("stop");
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
            this.ProgressBarTimer.Enabled = true;
            this.maxSystemMemory = Convert.ToInt32(new ComputerInfo().TotalPhysicalMemory / 1024 / 1024);

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //Implement GUI memory usage statistics
            float cpuUsage = CPU.NextValue();
            float ramUsage = RAM.NextValue();
            if (cpuUsage != 0)
            {
                CpuProgressBar.Value = (int)cpuUsage;
                CpuPercentLabel.Text = String.Format("{0}%", ((int)cpuUsage).ToString());
            }
            if (ramUsage != 0)
            {
                int value = (int)(ramUsage / this.maxSystemMemory * 100);
                value = 100 - value;
                RamProgressBar.Value = value;
                RamPercentLabel.Text = value.ToString() + "%";
            }

        }

        void ExecuteServerCommand(string command)
        {
            System.IO.StreamWriter sr = this.compiler.StandardInput;
            sr.WriteLine(command);
        }

        private void GamemodeMenu_Clicked(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            this.ExecuteServerCommand(String.Format("gamemode {0} {1}", item.Text.ToLower(), playerName));
        }
    }
}

