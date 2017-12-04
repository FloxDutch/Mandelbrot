using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        private int maxWidth = 400;
        private int maxHeight = 400;

        public void CreateBitmapAtRuntime()
        {
            Bitmap flag = DrawBitMap();
            mandelbrotPicture.Image = flag;
        }

        public Bitmap DrawBitMap()
        {
            var bitMap = new Bitmap(maxWidth, maxHeight);
            Graphics flagGraphics = Graphics.FromImage(bitMap);
            var whitePixels = 0;
            var blackPixels = 0;

            for(int bitMapX = -maxWidth / 2; bitMapX < maxWidth / 2; bitMapX++)
            {
                for(int bitMapY = -maxHeight / 2; bitMapY < maxHeight / 2; bitMapY++)
                {
                    //De gebruiker kan zelf een nieuw x en y coördinaat kiezen
                    var xMidden = double.Parse(XmiddenTextBox.Text, CultureInfo.InvariantCulture);
                    var yMidden = double.Parse(YmiddenTextBox.Text, CultureInfo.InvariantCulture);

                    //De gebruiker kan de schaal aanpassen
                    double schaal = double.Parse(schaalTextBox.Text, CultureInfo.InvariantCulture);

                    double x = schaal * bitMapX + xMidden;
                    double y = schaal * bitMapY + yMidden;

                    double a = 0;
                    double b = 0;
                    int t = 1;

                    //De gebruiker kan verschillende kleurenschema's kiezen
                    int selectedIndex = kleurComboBox.SelectedIndex;

                    //De gebruiker kan het maximale aantal herhalingen kiezen
                    int maxHerhalingen = Int32.Parse(maxTextBox.Text);

                    //Berekening van het Mandelgetal
                    while(a * a + b * b < 4)
                    {
                        var aa = a * a - b * b;
                        var bb = 2 * a * b;

                        a = aa + x;
                        b = bb + y;

                        t++;
                        if(t >= maxHerhalingen)
                        {
                            break;
                        }
                    }
                    var locX = maxWidth / 2 + bitMapX;
                    var locY = maxHeight / 2 - bitMapY;


                    if(selectedIndex == 1)
                    {
                        if(t % 2 != 0)
                        {
                            Brush myBrush = new Brushes(new Color(0, 0, 0));
                            flagGraphics.FillRectangle(, new Rectangle(new Point(locX, locY), new Size(1, 1)));
                            whitePixels++;
                        }
                        else
                        {
                            flagGraphics.FillRectangle(Brushes.Blue, new Rectangle(new Point(locX, locY), new Size(1, 1)));
                            blackPixels++;
                        }
                    }
                    else if(selectedIndex == 0)
                    {
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
            }
            return bitMap;
        }

        //Als op GO! wordt gedrukt wordt het figuur aangepast, anders wordt het figuur met standaardwaarden geladen
        private void button_Click(object sender, EventArgs e)
        {
            RefreshBitMap();
        }

        private void mandelbrotPicture_Click(object sender, MouseEventArgs e)
        {
            var scale = double.Parse(schaalTextBox.Text, CultureInfo.InvariantCulture);
            var curX = double.Parse(XmiddenTextBox.Text, CultureInfo.InvariantCulture);
            var curY = double.Parse(YmiddenTextBox.Text, CultureInfo.InvariantCulture);
            var xPos = curX + (e.X - maxWidth / 2) * scale;
            var yPos = curY + (maxWidth / 2 - e.Y) * scale;
            scale /= 2;
            XmiddenTextBox.Text = xPos.ToString(CultureInfo.InvariantCulture);
            YmiddenTextBox.Text = yPos.ToString(CultureInfo.InvariantCulture);
            schaalTextBox.Text = scale.ToString(CultureInfo.InvariantCulture);
            RefreshBitMap();
        }

        private void RefreshBitMap()
        {
            Bitmap flag = DrawBitMap();
            mandelbrotPicture.Image = flag;
        }
    }
}
