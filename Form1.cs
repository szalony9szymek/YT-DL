namespace YT_DL

{
    using System;
    using System.Diagnostics;

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            // Set the initial directory (optional)
            folderBrowserDialog.SelectedPath = "C:\\";

            // Show the folder picker dialog
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string selectedFolder = folderBrowserDialog.SelectedPath;
                string command = "yt-dlp -f bestaudio -x --audio-format mp3 " + textBox1.Text;
                Process process = new Process();
                process.StartInfo.WorkingDirectory = selectedFolder;
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/c " + command;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = true; // Set to hide the command prompt window
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                Console.WriteLine("Command Output:\n" + output);
                MessageBox.Show(output, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                process.Dispose();

            }
        }
    }
}