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

      for(int bitMapX = -maxWidth / 2; bitMapX < maxWidth / 2; bitMapX++)
      {
        for(int bitMapY = -maxHeight / 2; bitMapY < maxHeight / 2; bitMapY++)
        {
          var x = bitMapX / (maxWidth / 2);
          var y = bitMapY / (maxHeight / 2);

          var a = 0;
          var b = 0;

          int t = 0;

          while(a * a + b * b < 4)
          {
            a = a * a - b * b + x;
            b = 2 * a * b + y;
            t++;
            if(t >= 100)
            {
              break;
            }
          }

          if(t % 2 != 0)
          {
            flagGraphics.DrawRectangle(Pens.White, new Rectangle(new Point(maxWidth / 2 + bitMapX, maxHeight / 2 + bitMapY), new Size(1, 1)));
          }
          else
          {
            flagGraphics.DrawRectangle(Pens.Black, new Rectangle(new Point(maxWidth / 2 + bitMapX, maxHeight / 2 + bitMapY), new Size(1, 1)));
          }
        }
      }
      return bitMap;
    }
  }
}
