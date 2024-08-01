using Microsoft.VisualBasic.Devices;
using Microsoft.Web.WebView2.Core;
using System.Runtime.InteropServices;

namespace weatherApp
{
    public partial class Form1 : Form
    {
        int MouseX;
        int MouseY;

        // The enum flag for DwmSetWindowAttribute's second parameter, which tells the function what attribute to set.

        // ...
        // Various other definitions
        // ...


        // The enum flag for DwmSetWindowAttribute's second parameter, which tells the function what attribute to set.
        // Copied from dwmapi.h
        public enum DWMWINDOWATTRIBUTE
        {
            DWMWA_WINDOW_CORNER_PREFERENCE = 33
        }

        // The DWM_WINDOW_CORNER_PREFERENCE enum for DwmSetWindowAttribute's third parameter, which tells the function
        // what value of the enum to set.
        // Copied from dwmapi.h
        public enum DWM_WINDOW_CORNER_PREFERENCE
        {
            DWMWCP_DEFAULT = 0,
            DWMWCP_DONOTROUND = 1,
            DWMWCP_ROUND = 2,
            DWMWCP_ROUNDSMALL = 3
        }

        // Import dwmapi.dll and define DwmSetWindowAttribute in C# corresponding to the native function.
        [DllImport("dwmapi.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
        internal static extern void DwmSetWindowAttribute(IntPtr hwnd,
                                                         DWMWINDOWATTRIBUTE attribute,
                                                         ref DWM_WINDOW_CORNER_PREFERENCE pvAttribute,
                                                         uint cbAttribute);

        // ...
        // Various other definitions
        // ...



        public Form1()
        {
            InitializeComponent();


            var attribute = DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE;
            var preference = DWM_WINDOW_CORNER_PREFERENCE.DWMWCP_ROUND;
            DwmSetWindowAttribute(this.Handle, attribute, ref preference, sizeof(uint));

            // ...
            // Perform any other work necessary
            // ...

        }

        private void window_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.MouseX = e.X;
                this.MouseY = e.Y;
            }




        }

        private void window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - MouseX;
                this.Top += e.Y - MouseY;

            }



        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            int radius = 5;
            int diameter = radius * 2;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

            // ç∂è„
            gp.AddPie(0, 0, diameter, diameter, 180, 90);
            // âEè„
            gp.AddPie(this.Width - diameter, 0, diameter, diameter, 270, 90);
            // ç∂â∫
            gp.AddPie(0, this.Height - diameter, diameter, diameter, 90, 90);
            // âEâ∫
            gp.AddPie(this.Width - diameter, this.Height - diameter, diameter, diameter, 0, 90);
            // íÜâõ
            gp.AddRectangle(new Rectangle(radius, 0, this.Width - diameter, this.Height));
            // ç∂
            gp.AddRectangle(new Rectangle(0, radius, radius, this.Height - diameter));
            // âE
            gp.AddRectangle(new Rectangle(this.Width - radius, radius, radius, this.Height - diameter));

            this.Region = new Region(gp);

        }



        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void CitySelected(object sender, EventArgs e)
        {

        }

        private void up(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.PageUp)
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void batuuu(object sender, MouseEventArgs e)
        {



        }

        private void batyuuuu(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void daburuuu(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://ku-da-a9352.web.app/webapp/kabegami.html");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://umaidango.github.io/webapp/kabegami/guriddo");

        }

        private void batyu(object sender, MouseEventArgs e)
        {
            pictureBox3.Image = Properties.Resources.huh2;
        }




        private void chipichapaneko(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.huh1;
        }

        private void saisyouka(object sender, MouseEventArgs e)
        {

        }

        private void saisyoukaa(object sender, MouseEventArgs e)
        {

        }



        private void saisyouka2(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.kinokino1;
        }

        private void ukaaaa(object sender, MouseEventArgs e)
        {
            pictureBox3.Image = Properties.Resources.huh2;
        }

        private void osaretatokisaisyouka(object sender, MouseEventArgs e)
        {
            pictureBox4.Image = Properties.Resources.kinokino2;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            make make = new make();
            make.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            var startInfo = new System.Diagnostics.ProcessStartInfo("https://umaidango.github.io/kabegami-app/update/ver-1-0-1");
            startInfo.UseShellExecute = true;
            System.Diagnostics.Process.Start(startInfo);
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            star star = new star();
            star.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            chatsapo chatsapo = new chatsapo();
            chatsapo.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            search search = new search();
            search.Show();
        }

        private void pictureBox9_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Visible = true;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            Thread.Sleep(200);
            label2.Visible = false;
        }

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Visible = true;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            Thread.Sleep(200);
            label3.Visible = false;
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            label4.Visible = true;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            Thread.Sleep(200);
            label4.Visible = false;
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            label5.Visible = true;

        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            Thread.Sleep(200);
            label5.Visible = false;
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            label6.Visible = true;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            Thread.Sleep(200);
            label6.Visible = false;
        }
    }


}

