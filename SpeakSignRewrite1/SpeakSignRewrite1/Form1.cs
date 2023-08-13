using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeakSignRewrite1
{
    public partial class SpeakSign : Form
    {
        string scriptPath = "";
        public SpeakSign()
        {
            InitializeComponent();
        }

        public void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void quit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirm quit?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            this.Close();
        }

        private void info_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DevNerdGR/DV-2134-JM");
        }

        private void PTT_Click(object sender, EventArgs e)
        {   

            if (scriptPath == "")
            {
                richTextBox1.Text = "Python STT script not configured!";
                return;
            }

            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = new System.Diagnostics.ProcessStartInfo("python3", scriptPath);

            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;

            string response = "";

            p.Start();

            while (! p.HasExited)
            {
                response += p.StandardOutput.ReadLine();
            }

            richTextBox1.Text = response;
        }

        private void pathConfig_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Application.StartupPath;
                openFileDialog.Filter = "Python files (*.py)|*.py";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    scriptPath = openFileDialog.FileName;
                }
            }
        }
    }
}
