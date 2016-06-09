using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageColorChange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String pathname = textBox1.Text;
                Bitmap bmp = new Bitmap(pathname);
                pictureBox1.Image = Image.FromFile(pathname);
                int height = bmp.Height;
                int width = bmp.Width;
                Color p;
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        p = bmp.GetPixel(j, i);
                        int alpha = p.A;
                        int red = p.R;
                        int green = p.G;
                        int blue = p.B;
                        int avg = (red + green + blue) / 3;
                        bmp.SetPixel(j, i, Color.FromArgb(alpha , avg, avg, avg));

                    }
                }
                pictureBox2.Image = bmp;
            }
            catch(Exception ex){
                MessageBox.Show("Please type correct url");
            
            }



            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
