namespace YT_DL

{
    using System;
    using System.Diagnostics;
    using System.Linq.Expressions;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
            label1.Hide();
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
                //string command;
                string mode;
                string selectedFolder = folderBrowserDialog.SelectedPath;
                if (checkBox1.Checked == true)
                {
                    /*command = "yt-dlp -f bestaudio -x --audio-format mp3 --sponsorblock-remove all --embed-thumbnail --no-mtime " + textBox1.Text;*/
                    mode = "mp3novideo";
                }
                else
                {
                    //command = "yt-dlp -f bestaudio -x --audio-format mp3 --embed-thumbnail --no-mtime " + textBox1.Text;
                    mode = "mp3video";
                }
                async(selectedFolder, mode);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedFolder = "C:\\";
            async(selectedFolder, "listq");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string selectedFolder = "C:\\";
            async(selectedFolder, "upgrade");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            // Set the initial directory (optional)
            folderBrowserDialog.SelectedPath = "C:\\";

            // Show the folder picker dialog
            DialogResult result = folderBrowserDialog.ShowDialog();
            string selectedFolder = folderBrowserDialog.SelectedPath;
            async(selectedFolder, "hqmp4");
        }
        async void async(string selectedFolder, string mode)
        {
            string command = "";
            switch (mode)
            {
                case "hqmp4":
                    command = "yt-dlp -f bestvideo+bestaudio --embed-subs --embed-thumbnail --remux-video mp4 --no-mtime " + textBox1.Text;
                    break;
                case "upgrade":
                    command = "pip3 install --upgrade yt-dlp";
                    break;
                case "listq":
                    command = "yt-dlp -F " + textBox1.Text;
                    break;
                case "mp3novideo":
                    command = "yt-dlp -f bestaudio -x --audio-format mp3 --sponsorblock-remove all --embed-thumbnail --no-mtime " + textBox1.Text;
                    break;
                case "mp3video":
                    command = "yt-dlp -f bestaudio -x --audio-format mp3 --embed-thumbnail --no-mtime " + textBox1.Text;
                    break;
                default:
                    command = "echo Internal Error #1";
                    break;
            }
            label1.Show();
            string output = "";
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

                output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                process.Dispose();
            });

            label1.Hide();
            if (string.IsNullOrEmpty(output)) { output = "Internal Error #2"; }
            MessageBox.Show(output, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}