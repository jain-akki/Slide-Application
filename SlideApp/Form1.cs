using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SlideApp
{
    public partial class Form1 : Form
    {
        int counter1;
        int counter2;
        public Form1()
        {
            InitializeComponent();
            counter1 = 1;
            counter2 = 8;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Load(@"im1.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Anchor = AnchorStyles.Left & AnchorStyles.Bottom;
            pictureBox3.Anchor = AnchorStyles.Left & AnchorStyles.Bottom & AnchorStyles.Right;
            pictureBox4.Anchor = AnchorStyles.Right & AnchorStyles.Bottom;
            pictureBox5.Anchor = AnchorStyles.Left;
            pictureBox6.Anchor = AnchorStyles.Right;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            counter2--;
            switch (counter2)
            {
                case 1:
                    pictureBox1.Load(@"im" + counter2 + ".jpg");
                    break;
                case 2:
                    pictureBox1.Load(@"im" + counter2 + ".jpg");
                    break;
                case 3:
                    pictureBox1.Load(@"im" + counter2 + ".jpg");
                    break;
                case 4:
                    pictureBox1.Load(@"im" + counter2 + ".jpg");
                    break;
                case 5:
                    pictureBox1.Load(@"im" + counter2 + ".jpg");
                    break;
                case 6:
                    pictureBox1.Load(@"im" + counter2 + ".jpg");
                    break;
                case 7:
                    pictureBox1.Load(@"im" + counter2 + ".jpg");
                    break;
                case 8:
                    pictureBox1.Load(@"im" + counter2 + ".jpg");
                    break;
                default:
                    pictureBox1.Load(@"im" + counter2 + ".jpg");
                    break;
            }
            if (counter2 == 1)
                counter2 = 8;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            counter1++;
            switch (counter1)
            {
                case 1:
                    pictureBox1.Load(@"im" + counter1 + ".jpg");
                    break;
                case 2:
                    pictureBox1.Load(@"im" + counter1 + ".jpg");
                    break;
                case 3:
                    pictureBox1.Load(@"im" + counter1 + ".jpg");
                    break;
                case 4:
                    pictureBox1.Load(@"im" + counter1 + ".jpg");
                    break;
                case 5:
                    pictureBox1.Load(@"im" + counter1 + ".jpg");
                    break;
                case 6:
                    pictureBox1.Load(@"im" + counter1 + ".jpg");
                    break;
                case 7:
                    pictureBox1.Load(@"im" + counter1 + ".jpg");
                    break;
                case 8:
                    pictureBox1.Load(@"im" + counter1 + ".jpg");
                    break;
                default:
                    pictureBox1.Load(@"im" + counter1 + ".jpg");
                    break;
            }
            if (counter1 == 8)
                counter1 = 0;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //pictureBox1.Size = 
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right)
            {
                //MessageBox.Show("right");
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }

            if (e.Button == MouseButtons.Left)
            {
               // MessageBox.Show("left"); 
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Load(@"im" + counter1 + ".jpg");
            counter1++;
            if (counter1 == 8)
                counter1 = 1;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackColor = Color.DarkGray;
        }
    }
}
