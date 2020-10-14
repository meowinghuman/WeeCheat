using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeeCheat.Properties;



namespace WeeCheat
{


    public partial class WeeCheat : Form
    {

        string folder = Application.StartupPath;

        string scripts = Application.StartupPath + "\\Scripts";

        private Point lastClick;



        public WeeCheat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WeeCheat_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }

     
        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Process.Start(scripts + "\\Bhop.exe");
            }

            else if (checkBox1.Checked == false)
            {
                foreach (var process in Process.GetProcessesByName("Bhop"))
                {
                    process.Kill();
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                Process.Start(scripts + "\\LegitStrafe.exe");
            }

            else if (checkBox2.Checked == false)
            {
                foreach (var process in Process.GetProcessesByName("LegitStrafe"))
                {
                    process.Kill();
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                Process.Start(scripts + "\\TapFire.exe");
            }

            else if (checkBox3.Checked == false)
            {
                foreach (var process in Process.GetProcessesByName("TapFire"))
                {
                    process.Kill();
                }
            }
        }
    }
}
