using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandelbrot
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bittyboi = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            double a = 0;
            double b = 0;
            double x = a;
            double y = b;

            int t;
            t = 0;
            do
            {
                x = a * a - b * b + x;
                y = 2 * a * b + y;
                t = t++;
                if (t == 100) break;
            } while (x * x + y * y < 4);
            if (t % 2 != 0)
            {
                bittyboi.SetPixel(Convert.ToInt32(a), Convert.ToInt32(b), Color.White);
            }
            else
            {
                bittyboi.SetPixel(Convert.ToInt32(a), Convert.ToInt32(b), Color.Black);
            }
        }
}
    }
