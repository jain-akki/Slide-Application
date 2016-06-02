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
    public partial class Form2 : Form
    {
        int i;
        public Form2()
        {
            InitializeComponent();
            i = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label1.Text += i.ToString() + "\n";
            //i++;
            //label1.Left += 10; 
            
            label1.Left += 25;
            Form2 f = new Form2();
            int w = f.Width;
            if (label1.Left > Form2.ActiveForm.Width - label1.Width)
            {
                timer1.Enabled = false;
                timer2.Enabled = true;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "C# Windows Application Programming";
            label1.Font = new Font("",12f);
            label1.Left = 0;
            //label1.Font.Size = 15;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Left -= 25;
            if (label1.Left == 0)
            {
                timer2.Enabled = false;
                timer1.Enabled = true;
            }
        }
    }
}
