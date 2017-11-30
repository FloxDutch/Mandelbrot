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
      CreateBitmapAtRuntime();
    }

    Point startLocation = new Point(100, 100);
    private int maxWidth = 500;
    private int maxHeight = 500;

    PictureBox pictureBox1 = new PictureBox();
    public void CreateBitmapAtRuntime()
    {
      pictureBox1.Size = new Size(maxWidth, maxHeight);
      pictureBox1.Location = startLocation;
      this.Controls.Add(pictureBox1);

      Bitmap flag = DrawBitMap();
      pictureBox1.Image = flag;
    }

    private Bitmap DrawBitMap()
    {
      var bitMap = new Bitmap(maxWidth, maxHeight);
      Graphics flagGraphics = Graphics.FromImage(bitMap);
      List<int> mandelbrotGetallen = new List<int>();
      var whitePixels = 0;
      var blackPixels = 0;

      for(int bitMapX = -maxWidth / 2; bitMapX < maxWidth / 2; bitMapX++)
      {
        for(int bitMapY = -maxHeight / 2; bitMapY < maxHeight / 2; bitMapY++)
        {
          double x = (double)bitMapX / (maxWidth / 2);
          double y = (double)bitMapY / (maxHeight / 2);

          double a = 0;
          double b = 0;
          int t = 0;

          while(Math.Sqrt(a * a) + Math.Sqrt(b * b) < 2)
          {
            a = a * a - b * b + x;
            b = 2 * a * b + y;
            t++;
            if(t >= 100)
            {
              break;
            }
          }
          mandelbrotGetallen.Add(t);

          var locX = maxWidth / 2 + bitMapX;
          var locY = maxHeight / 2 - bitMapY;
          if(t % 2 != 0)
          {
            flagGraphics.FillRectangle(Brushes.White, new Rectangle(new Point(locX, locY), new Size(1, 1)));
            whitePixels++;
          }
          else
          {
            flagGraphics.FillRectangle(Brushes.Black, new Rectangle(new Point(locX, locY), new Size(1, 1)));
            blackPixels++;
          }
        }
      }
      return bitMap;
    }
  }
}
