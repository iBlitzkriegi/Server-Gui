using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ServerGui
{
    public partial class ServerGui : Form
    {
        Process compiler = null;
        public ServerGui()
        {
            InitializeComponent();
            consoleTextBox.Dock = DockStyle.Fill;
            playersListBox.Dock = DockStyle.Fill;
            consoleTextBox.VisibleChanged += (sender, e) =>
            {
                Console.WriteLine(consoleTextBox.Visible);
                if (consoleTextBox.Visible)
                {
                    consoleTextBox.SelectionStart = consoleTextBox.TextLength;
                    consoleTextBox.ScrollToCaret();
                }
            };

            //TODO MAKE THIS ACCOUNT FOR SERVER OPTIONS INSTEAD OF HARD CODE




        }

        private void ServerGui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                this.execute_command(this.commandTextBox.Text);
                e.Handled = true;
                this.commandTextBox.Text = "";
            }
        }


        public void process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                if (!string.IsNullOrWhiteSpace(consoleTextBox.Text)) 
                {
                    consoleTextBox.AppendText("\r\n" + e.Data);
                } else
                {
                    consoleTextBox.AppendText(e.Data);
                }
                consoleTextBox.Select(consoleTextBox.TextLength, 0);
                consoleTextBox.ScrollToCaret();
            }));
        }

        private void execute_command(String command)
        {
            if (this.compiler != null)
            {
                //This wont work correctly until creating process code is moved to start button click area
                //Should also handle hittng the stop button when say is checked so it doesnt say "stop"
                System.IO.StreamWriter sr = this.compiler.StandardInput;
                if (this.sayCheckBox.Checked)
                {
                    sr.WriteLine("say " + command);
                }
                else
                {
                    sr.WriteLine(command);
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (this.startButton.Text == "Start")
            {
                //TODO HANDLE THE PROCESS CREATION STUFF HERE SO WE CAN CHECK IF A SERVER IS 
                //RUNNING BY CHECKING IF COMPILER IS NULL OR NOT.

                Process compiler = new Process();
                compiler.StartInfo.FileName = "java";
                compiler.StartInfo.Arguments = "-jar C:\\Users\\matthew\\Desktop\\Minecraft\\Vixio\\paperclip.jar nogui";
                compiler.StartInfo.WorkingDirectory = "C:\\Users\\matthew\\Desktop\\Minecraft\\Vixio";

                compiler.StartInfo.UseShellExecute = false;
                compiler.StartInfo.CreateNoWindow = true;
                compiler.OutputDataReceived += new System.Diagnostics.DataReceivedEventHandler(process_OutputDataReceived);
                compiler.StartInfo.RedirectStandardOutput = true;
                compiler.StartInfo.RedirectStandardInput = true;
                //  compiler.Start();
                //  compiler.BeginOutputReadLine();
                this.compiler = compiler;
                this.KeyPreview = true;
                this.KeyPress += new KeyPressEventHandler(ServerGui_KeyPress);


                compiler.Start();
                compiler.BeginOutputReadLine();
                this.startButton.Text = "Stop";
            }
            else
            {
                if (this.compiler != null) {
                    this.execute_command("stop");
                    this.compiler.Close();
                    this.compiler = null;
                    this.startButton.Text = "Start";
                }
            }
        }

        private void execute_button_Click(object sender, EventArgs e)
        {
            //TODO MAKE THIS CACHE RAN COMMANDS TO ALLOW FOR UP ARROW EDIT
            this.execute_command(this.commandTextBox.Text);
        }

        private void killButton_Click(object sender, EventArgs e)
        {
            if (this.compiler != null)
            {
                this.compiler.Kill();
                this.startButton.Text = "Start";
            }
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            this.execute_command("reload");
            this.execute_command("reload confirm");
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            this.execute_command("stop");
        }
    }
}
