namespace YT_DL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            checkBox1 = new CheckBox();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            checkBox2 = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(16, 43);
            button1.Name = "button1";
            button1.Size = new Size(168, 50);
            button1.TabIndex = 0;
            button1.Text = "Download as MP3 (HQ)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(310, 23);
            textBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(349, 14);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "List Quality";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(189, 43);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(191, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Remove Fluff (Music Video etc)";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(16, 99);
            button3.Name = "button3";
            button3.Size = new Size(168, 50);
            button3.TabIndex = 4;
            button3.Text = "Download as MP4 (HQ)";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(740, 12);
            button4.Name = "button4";
            button4.Size = new Size(113, 23);
            button4.TabIndex = 5;
            button4.Text = "Upgrade yt-dlp";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(841, 256);
            label1.TabIndex = 6;
            label1.Text = "yt-dlp is running, please wait";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(190, 68);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.ScrollBars = ScrollBars.Both;
            textBox2.Size = new Size(663, 301);
            textBox2.TabIndex = 7;
            textBox2.WordWrap = false;
            // 
            // label2
            // 
            label2.Location = new Point(64, 402);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 8;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(386, 43);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(129, 19);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "Don't use metadata";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 450);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(checkBox2);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "YT-DL by belemnoid";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private CheckBox checkBox1;
        private Button button3;
        private Button button4;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private CheckBox checkBox2;
    }
}