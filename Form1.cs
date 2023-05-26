namespace YT_DL

{
    using System;
    using System.Diagnostics;
    using System.Windows.Forms;

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
                string command;
                string selectedFolder = folderBrowserDialog.SelectedPath;
                if (checkBox1.Checked == true)
                {
                    command = "yt-dlp -f bestaudio -x --audio-format mp3 --sponsorblock-remove all --embed-thumbnail --no-mtime " + textBox1.Text;
                }
                else
                {
                    command = "yt-dlp -f bestaudio -x --audio-format mp3 --embed-thumbnail --no-mtime " + textBox1.Text;
                }
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

        private void button2_Click(object sender, EventArgs e)
        {
            string command = "yt-dlp -F " + textBox1.Text;
            Process process = new Process();
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

        private void button4_Click(object sender, EventArgs e)
        {
            string command = "pip3 install --upgrade yt-dlp";
            Process process = new Process();
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

        private void button3_Click(object sender, EventArgs e)
        {
            asyncmp4();
        }
        async void asyncmp4()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            // Set the initial directory (optional)
            folderBrowserDialog.SelectedPath = "C:\\";

            // Show the folder picker dialog
            DialogResult result = folderBrowserDialog.ShowDialog();
            string selectedFolder = folderBrowserDialog.SelectedPath;
            string command = "yt-dlp -f bestvideo+bestaudio --embed-subs --embed-thumbnail --remux-video mp4 --no-mtime " + textBox1.Text;

            await Task.Run(() =>
            {
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

                MessageBox.Show(output, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                process.Dispose();
            });

        }
    }
}