using System;
using System.Windows.Forms;
using System.Text.Json;
using System.Net;
using System.Text;


/* v1.0, Rewrite 1 Stable Demo
 * TODO:
 * Implement ERROR HANDLING, especially for ill formatted user inputs such as poor target IP input
 * Impelment checks to check for python.exe
 * Implement redundancy features to deal with network issues
 */
namespace SpeakSignRewrite1
{
    public partial class SpeakSign : Form
    {
        string scriptPath = string.Empty;
        string targetIP = string.Empty;
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

            if (scriptPath == string.Empty)
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

            richTextBox1.Text = "You said: " + response;


            int returnCode = request(targetIP, response);

            if (returnCode == 0)
            {
                return;
            }
            else if (returnCode == 1)
            {
                richTextBox1.Text = "Error (Code 1): Target IP not found";
            }
            else if (returnCode == 2)
            {
                richTextBox1.Text = "Sorry, could not recognise what you said :(. Please try again (Error: Code 2)";
            }
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

        private void ipField_TextChanged(object sender, EventArgs e)
        {
            targetIP = ipField.Text;
        }

        private int request(string targetIP, string contents)
        {
            /* HTTP Request function,
             * Return code of 0 signifies successful
             * Return code of 1 signifies target IP not found
             * Return code of 2 signifies contents string is empty
             */
            if (targetIP == string.Empty)
            {
                return 1;
            }
            else if (contents == string.Empty)
            {
                return 2;
            }

            string URL = "http://" + targetIP + "/";
            
            
            var request = WebRequest.Create(URL);
            //request.Timeout = 100;
            request.Method = "POST";
            var json = JsonSerializer.Serialize(contents);
            byte[] bytearray = Encoding.UTF8.GetBytes(json);
            
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = bytearray.Length;

            
            var reqStream = request.GetRequestStream();
            reqStream.Write(bytearray, 0, bytearray.Length);
            reqStream.Close();
            return 0;
            
            
        }
    }
}
