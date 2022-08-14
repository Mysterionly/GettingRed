using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace цветокоррекцияЛЕНА
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath;
            Bitmap bm;
            Bitmap bm_new;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog1.FileName;
                bm = new Bitmap((Bitmap)Image.FromFile(filePath), new Size(panel1.Width, panel1.Height));
                bm_new = new Bitmap((Bitmap)Image.FromFile(filePath), new Size(panel2.Width, panel2.Height));


                for (int i = 1; i < bm_new.Width; i++)
                {
                    for (int j = 1; j < bm_new.Height; j++)
                    {
                        if (bm.GetPixel(i, j).R >= 100 && bm.GetPixel(i, j).G <= 100 && bm.GetPixel(i, j).B < 90 && Math.Abs(bm.GetPixel(i, j).G - bm.GetPixel(i, j).B) < 85)
                        {
                            int q = 0; 
                        }
                        else
                        {
                            Color c = bm.GetPixel(i, j);
                            int mxP = Math.Max(c.R, Math.Max(c.G, c.B));
                            bm_new.SetPixel(i, j, Color.FromArgb(mxP, mxP, mxP));
                        }
                    }
                }

                panel1.BackgroundImage = bm;

                panel2.BackgroundImage = bm_new;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
