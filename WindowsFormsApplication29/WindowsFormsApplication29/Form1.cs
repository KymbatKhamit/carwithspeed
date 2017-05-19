using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Image imager = Image.FromFile(@"C:\Users\Lenovo\Pictures\right1.jpg");

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }
        int x = 30, y = 30;
        Pen pen = new Pen(Color.Blue);



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentspeed == Speed.first) x = x + 2;
            if (currentspeed == Speed.second) x = x + 3;
            if (currentspeed == Speed.third) x = x + 10;
            Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) currentspeed = Speed.zero;
            if (e.KeyCode == Keys.Right && currentspeed == Speed.zero) currentspeed = Speed.first;
            if (e.KeyCode == Keys.Right && currentspeed == Speed.first) currentspeed = Speed.second;
            if (e.KeyCode == Keys.Right && currentspeed == Speed.second) currentspeed = Speed.third;

            Refresh();
        }
        enum Speed
        {
            zero, first, second, third
        }
        Speed currentspeed = Speed.first;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(imager, x, y);

        }
    }
}

