namespace onlyfun
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
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            button3 = new Button();
            groupBox1 = new GroupBox();
            button4 = new Button();
            LB2 = new ListBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(396, 245);
            button1.Name = "button1";
            button1.Size = new Size(126, 51);
            button1.TabIndex = 0;
            button1.Text = "↑ \r\nup\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(396, 302);
            button2.Name = "button2";
            button2.Size = new Size(126, 51);
            button2.TabIndex = 1;
            button2.Text = "↓ \r\ndown\r\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(351, 35);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(218, 204);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(351, 359);
            button3.Name = "button3";
            button3.Size = new Size(224, 94);
            button3.TabIndex = 3;
            button3.Text = "0";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(LB2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 494);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button4
            // 
            button4.Location = new Point(93, 404);
            button4.Name = "button4";
            button4.Size = new Size(117, 56);
            button4.TabIndex = 1;
            button4.Text = "spel spelen";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // LB2
            // 
            LB2.FormattingEnabled = true;
            LB2.ItemHeight = 20;
            LB2.Location = new Point(6, 23);
            LB2.Name = "LB2";
            LB2.Size = new Size(295, 364);
            LB2.TabIndex = 0;
            LB2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.of2;
            pictureBox1.Location = new Point(581, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(471, 452);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 527);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "l";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private Button button3;
        private GroupBox groupBox1;
        private ListBox LB2;
        private PictureBox pictureBox1;
        private Button button4;
    }
}