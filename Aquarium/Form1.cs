using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aquarium
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            fish.Visible = true;
            pictureBox1.Width = Width;
            pictureBox1.Height = Height;
            fish.Height = 198;
            fish.Width = 374;
            
            //Image a = fish.Image;
            //a.RotateFlip(RotateFlipType.RotateNoneFlipY);
            //fish.Image = a;
            //for(int i=1; i<10;i++)
            //{
            //    fish.Left += i * 100;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Image a = fish.Image;    //все 3 строчки зеркально отражают картинку рыбы в picturebox
            a.RotateFlip(RotateFlipType.RotateNoneFlipY);
            fish.Image = a;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (fish.Top > 0)   //рыба всплывает
                fish.Top -= 20;
            else
                timer1.Enabled = false;
        }
    }
}
