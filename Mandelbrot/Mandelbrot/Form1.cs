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

        //We maken een picturebox en een bitmap
        PictureBox pictureBox1 = new PictureBox();
        public void CreateBitmapAtRuntime()
        {
            pictureBox1.Size = new Size(maxWidth, maxHeight);
            pictureBox1.Location = startLocation;
            Bitmap flag = DrawBitMap();
            pictureBox1.Image = flag;
            this.Controls.Add(pictureBox1);
        }

        public Bitmap DrawBitMap()
        {
            var bitMap = new Bitmap(maxWidth, maxHeight);
            Graphics flagGraphics = Graphics.FromImage(bitMap);
            List<int> mandelbrotGetallen = new List<int>();
            var whitePixels = 0;
            var blackPixels = 0;

            for (int bitMapX = -maxWidth / 2; bitMapX < maxWidth / 2; bitMapX++)
            {
                for (int bitMapY = -maxHeight / 2; bitMapY < maxHeight / 2; bitMapY++)
                {
                    //De gebruiker kan zelf een nieuw x en y coördinaat kiezen
                    double xMidden = 0;
                    double yMidden = 0;
                    xMidden = 100 * Double.Parse(XmiddenTextBox.Text);
                    yMidden = 100 * Double.Parse(YmiddenTextBox.Text);

                    //De gebruiker kan de schaal aanpassen
                    double schaal = 1;
                    schaal = Double.Parse(schaalTextBox.Text);

                    double x = ((double)bitMapX / (maxWidth / 5) * schaal) + (xMidden);
                    double y = ((double)bitMapY / (maxHeight / 5) * schaal) - (yMidden);

                    double a = 0;
                    double b = 0;
                    int t = 1;

                    //De gebruiker kan verschillende kleurenschema's kiezen
                    int selectedIndex = kleurComboBox.SelectedIndex;

                    //De gebruiker kan het maximale aantal herhalingen kiezen
                    int maxHerhalingen = 100;
                    maxHerhalingen = Int32.Parse(maxTextBox.Text);
                    
                    //Berekening van het Mandelgetal
                    while ((a * a) + (b * b) < 4)
                    {
                        var aa = a * a - b * b;
                        var bb = 2 * a * b;

                        a = aa + x;
                        b = bb + y;


                        t++;
                        if (t >= maxHerhalingen)
                        {
                            break;
                        }
                    }
                    mandelbrotGetallen.Add(t);

                    var locX = (maxWidth / 2 + bitMapX);
                    var locY = (maxHeight / 2 - bitMapY);
                    
                
                    if (selectedIndex == 1)
                    {
                        if (t % 2 != 0)
                        {
                            flagGraphics.FillRectangle(Brushes.Red, new Rectangle(new Point(locX, locY), new Size(1, 1)));
                            whitePixels++;
                        }
                        else
                        {
                            flagGraphics.FillRectangle(Brushes.Blue, new Rectangle(new Point(locX, locY), new Size(1, 1)));
                            blackPixels++;
                        }
                    }
                    else
                    {
                        if (t % 2 != 0)
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
            Bitmap flag = DrawBitMap();
            pictureBox1.Image = flag;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
