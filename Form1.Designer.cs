namespace weatherApp
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox2 = new PictureBox();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            pictureBox1 = new PictureBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            label1 = new Label();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 30000;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.bfeiu;
            pictureBox2.ErrorImage = Properties.Resources.error;
            pictureBox2.Image = Properties.Resources.kabegami_logo;
            pictureBox2.ImageLocation = "";
            pictureBox2.InitialImage = Properties.Resources.icon_loader_d_gw_01_s1;
            pictureBox2.Location = new Point(21, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(166, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(3, 93);
            webView21.Name = "webView21";
            webView21.Size = new Size(1215, 584);
            webView21.Source = new Uri("https://ku-da-a9352.web.app/webapp/kabegami.html", UriKind.Absolute);
            webView21.TabIndex = 3;
            webView21.ZoomFactor = 1D;
            webView21.Click += webView21_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonShadow;
            pictureBox1.Location = new Point(0, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1348, 5);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackgroundImage = Properties.Resources.bfeiu;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Yu Gothic UI", 12F);
            radioButton1.ForeColor = SystemColors.ControlText;
            radioButton1.Location = new Point(685, 19);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(111, 25);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "いつもの表示";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackgroundImage = Properties.Resources.bfeiu;
            radioButton2.Font = new Font("Yu Gothic UI", 12F);
            radioButton2.ForeColor = SystemColors.ControlText;
            radioButton2.Location = new Point(685, 44);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(92, 25);
            radioButton2.TabIndex = 8;
            radioButton2.Text = "一覧表示";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.bfeiu;
            pictureBox3.Image = Properties.Resources.huh1;
            pictureBox3.Location = new Point(1101, 23);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            pictureBox3.MouseLeave += chipichapaneko;
            pictureBox3.MouseMove += ukaaaa;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.bfeiu;
            pictureBox4.Image = Properties.Resources.kinokino1;
            pictureBox4.Location = new Point(1009, 23);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 37);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click_1;
            pictureBox4.MouseLeave += saisyouka2;
            pictureBox4.MouseMove += osaretatokisaisyouka;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.bfeiu;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = Properties.Resources.stationery015;
            pictureBox5.Location = new Point(584, 20);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(52, 49);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            pictureBox5.MouseLeave += pictureBox5_MouseLeave;
            pictureBox5.MouseMove += pictureBox5_MouseMove;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = Properties.Resources.bfeiu;
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = Properties.Resources.symbol065;
            pictureBox6.Location = new Point(513, 20);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(52, 49);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 12;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            pictureBox6.MouseLeave += pictureBox6_MouseLeave;
            pictureBox6.MouseMove += pictureBox6_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(193, 41);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 13;
            label1.Text = "Beta 1.012";
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = Properties.Resources.bfeiu;
            pictureBox7.Cursor = Cursors.Hand;
            pictureBox7.Image = Properties.Resources.star;
            pictureBox7.Location = new Point(441, 20);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(52, 50);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 14;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            pictureBox7.MouseLeave += pictureBox7_MouseLeave;
            pictureBox7.MouseMove += pictureBox7_MouseMove;
            // 
            // pictureBox8
            // 
            pictureBox8.BackgroundImage = Properties.Resources.bfeiu;
            pictureBox8.Cursor = Cursors.Hand;
            pictureBox8.Image = Properties.Resources.chaticon;
            pictureBox8.Location = new Point(368, 19);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(52, 50);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 15;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            pictureBox8.MouseLeave += pictureBox8_MouseLeave;
            pictureBox8.MouseMove += pictureBox8_MouseMove;
            // 
            // pictureBox9
            // 
            pictureBox9.BackgroundImage = Properties.Resources.bfeiu;
            pictureBox9.Cursor = Cursors.Hand;
            pictureBox9.Image = Properties.Resources.search;
            pictureBox9.Location = new Point(295, 19);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(52, 50);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 16;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            pictureBox9.MouseLeave += pictureBox9_MouseLeave;
            pictureBox9.MouseMove += pictureBox9_MouseMove;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.ForeColor = Color.White;
            label2.Location = new Point(282, 72);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 17;
            label2.Text = "　壁紙検索　";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.ForeColor = Color.White;
            label3.Location = new Point(356, 72);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 18;
            label3.Text = "　ﾁｬｯﾄｻﾎﾟｰﾄ　";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.ForeColor = Color.White;
            label4.Location = new Point(414, 72);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 19;
            label4.Text = "いいねした壁紙一覧";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.ForeColor = Color.White;
            label5.Location = new Point(513, 72);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 20;
            label5.Text = "ｱｯﾌﾟﾃﾞｰﾄ";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.ForeColor = Color.White;
            label6.Location = new Point(574, 72);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 21;
            label6.Text = "　壁紙編集　";
            label6.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.スクリーンショット_2024_07_30_175846;
            ClientSize = new Size(1219, 676);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(label1);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(pictureBox1);
            Controls.Add(webView21);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Kabegami (壁紙アプリ)";
            Load += Form1_Load;
            DoubleClick += daburuuu;
            KeyDown += up;
            MouseDown += window_MouseDown;
            MouseMove += window_MouseMove;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox2;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private PictureBox pictureBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label1;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
