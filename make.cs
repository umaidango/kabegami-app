using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace weatherApp
{
    public partial class make : Form
    {
        public make()
        {
            InitializeComponent();
        }

        private void make_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ColorDialogクラスのインスタンスを作成
            ColorDialog cd = new ColorDialog();

            //はじめに選択されている色を設定
            cd.Color = pictureBox1.BackColor;
            //色の作成部分を表示可能にする
            //デフォルトがTrueのため必要はない
            cd.AllowFullOpen = true;
            //純色だけに制限しない
            //デフォルトがFalseのため必要はない
            cd.SolidColorOnly = false;
            //[作成した色]に指定した色（RGB値）を表示する
            cd.CustomColors = new int[] {
    0x33, 0x66, 0x99, 0xCC, 0x3300, 0x3333,
    0x3366, 0x3399, 0x33CC, 0x6600, 0x6633,
    0x6666, 0x6699, 0x66CC, 0x9900, 0x9933};

            //ダイアログを表示する
            if (cd.ShowDialog() == DialogResult.OK)
            {
                //選択された色の取得
                pictureBox1.BackColor = cd.Color;
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.syFWkNyNTwv6xHJ1720929014_1720929023;
            pictureBox1.Size = new Size(825, 509);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = pictureBox2.BackColor;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = pictureBox4.BackColor;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = pictureBox3.BackColor;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = pictureBox7.BackColor;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = pictureBox5.BackColor;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = pictureBox6.BackColor;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._4z9B6tSbaS403Y31720928894_1720928919;
            pictureBox1.Size = new Size(825, 509);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //ビットマップデータ形式に関連付けられているデータを取得
            //using System.Drawing;
            //using System.Windows.Forms;

            //画面全体のイメージをクリップボードにコピー
            SendKeys.SendWait("^{PRTSC}");
            //次のようにすると、アクティブなウィンドウのイメージをコピー
            //SendKeys.SendWait("%{PRTSC}");
            //SendKeys.SendWait("{PRTSC}");

            //DoEventsを呼び出したほうがよい場合があるらしい
            //Application.DoEvents();

            //クリップボードにあるデータの取得
            IDataObject d = Clipboard.GetDataObject();
            //クリップボードにデータがあったか確認

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.umaidango_15;
            pictureBox1.Size = new Size(825, 389);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.no_10_1_editor;
            pictureBox1.Size = new Size(825, 410);
        }
    }
}

