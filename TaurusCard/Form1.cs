using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

//Constellation Card, By Avery, Sept. 27.
namespace TaurusCard
{
    public partial class taurusCardForm : Form
    {
        public taurusCardForm()
        {
            InitializeComponent();
        }

        private void taurusCardForm_Shown(object sender, EventArgs e)
        {
            // Graphics set up and title screen
            Graphics cardGraphics = this.CreateGraphics();
            SolidBrush textBrush = new SolidBrush(Color.Brown);
            Font titleFont = new Font("Arial", 28, FontStyle.Bold);

            //title
            cardGraphics.DrawString("Taurus", titleFont, textBrush, 85, 240);
            cardGraphics.DrawString("Greeting", titleFont, textBrush, 95, 280);
            cardGraphics.DrawString("Card", titleFont, textBrush, 110, 320);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            // Clear screen and set up gramphics and pens etc
            BackgroundImage = null;
            Refresh();

            Graphics cardGraphics = this.CreateGraphics();
            Font infoFont = new Font("Arial", 14, FontStyle.Italic);
            SolidBrush textBrush = new SolidBrush(Color.Brown);
            SolidBrush starBrush = new SolidBrush(Color.White);
            Pen linePen = new Pen(Color.FromArgb(10, 225, 225, 225), 2);
            cardGraphics.Clear(Color.Black);

            // Set up sound players
            SoundPlayer starPlayer = new SoundPlayer(Properties.Resources.star);
            SoundPlayer jinglePlayer = new SoundPlayer(Properties.Resources.jingle);

            // Stars
            cardGraphics.FillEllipse(starBrush, 209, 62, 18, 18);
            starPlayer.Play();
            Thread.Sleep(700);
            cardGraphics.FillEllipse(starBrush, 293, 234, 22, 22);
            starPlayer.Play();
            Thread.Sleep(700);
            cardGraphics.FillEllipse(starBrush, 321, 211, 12, 12);
            starPlayer.Play();
            Thread.Sleep(700);
            cardGraphics.FillEllipse(starBrush, 461, 353, 13, 13);
            starPlayer.Play();
            Thread.Sleep(700);
            cardGraphics.FillEllipse(starBrush, 332, 233, 13, 13);
            starPlayer.Play();
            Thread.Sleep(700);
            cardGraphics.FillEllipse(starBrush, 352, 372, 16, 16);
            starPlayer.Play();
            Thread.Sleep(700);
            cardGraphics.FillEllipse(starBrush, 325, 225, 13, 13);
            starPlayer.Play();
            Thread.Sleep(700);
            cardGraphics.FillEllipse(starBrush, 152, 130, 16, 16);
            starPlayer.Play();
            Thread.Sleep(700);
            cardGraphics.FillEllipse(starBrush, 374, 300, 16, 16);
            starPlayer.Play();
            Thread.Sleep(700);
            cardGraphics.FillEllipse(starBrush, 329, 262, 13, 13);
            starPlayer.Play();
            Thread.Sleep(700);
            cardGraphics.FillEllipse(starBrush, 336, 253, 12, 12);
            starPlayer.Play();
            Thread.Sleep(600);
            cardGraphics.FillEllipse(starBrush, 409, 456, 20, 20);
            starPlayer.Play();
            Thread.Sleep(600);
            cardGraphics.FillEllipse(starBrush, 297, 160, 14, 14);
            starPlayer.Play();
            Thread.Sleep(600);
            cardGraphics.FillEllipse(starBrush, 466, 363, 12, 12);
            starPlayer.Play();
            Thread.Sleep(800);

            // Lines fading in
            jinglePlayer.Play();

            cardGraphics.DrawLine(linePen, 223, 77, 299, 162);
            cardGraphics.DrawLine(linePen, 307, 170, 325, 215);
            cardGraphics.DrawLine(linePen, 329, 222, 331, 226);
            cardGraphics.DrawLine(linePen, 340, 244, 342, 254);
            cardGraphics.DrawLine(linePen, 312, 250, 333, 265);
            cardGraphics.DrawLine(linePen, 165, 141, 297, 241);
            cardGraphics.DrawLine(linePen, 341, 269, 376, 302);
            cardGraphics.DrawLine(linePen, 388, 310, 462, 356);
            cardGraphics.DrawLine(linePen, 466, 369, 365, 379);
            cardGraphics.DrawLine(linePen, 469, 374, 423, 457);
            Thread.Sleep(120);

            linePen.Color = Color.FromArgb(20, 225, 225, 225);
            cardGraphics.DrawLine(linePen, 223, 77, 299, 162);
            cardGraphics.DrawLine(linePen, 307, 170, 325, 215);
            cardGraphics.DrawLine(linePen, 329, 222, 331, 226);
            cardGraphics.DrawLine(linePen, 340, 244, 342, 254);
            cardGraphics.DrawLine(linePen, 312, 250, 333, 265);
            cardGraphics.DrawLine(linePen, 165, 141, 297, 241);
            cardGraphics.DrawLine(linePen, 341, 269, 376, 302);
            cardGraphics.DrawLine(linePen, 388, 310, 462, 356);
            cardGraphics.DrawLine(linePen, 466, 369, 365, 379);
            cardGraphics.DrawLine(linePen, 469, 374, 423, 457);
            Thread.Sleep(120);

            linePen.Color = Color.FromArgb(30, 225, 225, 225);
            cardGraphics.DrawLine(linePen, 223, 77, 299, 162);
            cardGraphics.DrawLine(linePen, 307, 170, 325, 215);
            cardGraphics.DrawLine(linePen, 329, 222, 331, 226);
            cardGraphics.DrawLine(linePen, 340, 244, 342, 254);
            cardGraphics.DrawLine(linePen, 312, 250, 333, 265);
            cardGraphics.DrawLine(linePen, 165, 141, 297, 241);
            cardGraphics.DrawLine(linePen, 341, 269, 376, 302);
            cardGraphics.DrawLine(linePen, 388, 310, 462, 356);
            cardGraphics.DrawLine(linePen, 466, 369, 365, 379);
            cardGraphics.DrawLine(linePen, 469, 374, 423, 457);
            Thread.Sleep(120);
            
            linePen.Color = Color.FromArgb(40, 225, 225, 225);
            cardGraphics.DrawLine(linePen, 223, 77, 299, 162);
            cardGraphics.DrawLine(linePen, 307, 170, 325, 215);
            cardGraphics.DrawLine(linePen, 329, 222, 331, 226);
            cardGraphics.DrawLine(linePen, 340, 244, 342, 254);
            cardGraphics.DrawLine(linePen, 312, 250, 333, 265);
            cardGraphics.DrawLine(linePen, 165, 141, 297, 241);
            cardGraphics.DrawLine(linePen, 341, 269, 376, 302);
            cardGraphics.DrawLine(linePen, 388, 310, 462, 356);
            cardGraphics.DrawLine(linePen, 466, 369, 365, 379);
            cardGraphics.DrawLine(linePen, 469, 374, 423, 457);
            Thread.Sleep(120);

            linePen.Color = Color.FromArgb(50, 225, 225, 225);
            cardGraphics.DrawLine(linePen, 223, 77, 299, 162);
            cardGraphics.DrawLine(linePen, 307, 170, 325, 215);
            cardGraphics.DrawLine(linePen, 329, 222, 331, 226);
            cardGraphics.DrawLine(linePen, 340, 244, 342, 254);
            cardGraphics.DrawLine(linePen, 312, 250, 333, 265);
            cardGraphics.DrawLine(linePen, 165, 141, 297, 241);
            cardGraphics.DrawLine(linePen, 341, 269, 376, 302);
            cardGraphics.DrawLine(linePen, 388, 310, 462, 356);
            cardGraphics.DrawLine(linePen, 466, 369, 365, 379);
            cardGraphics.DrawLine(linePen, 469, 374, 423, 457);
            Thread.Sleep(120);

            linePen.Color = Color.FromArgb(60, 225, 225, 225);
            cardGraphics.DrawLine(linePen, 223, 77, 299, 162);
            cardGraphics.DrawLine(linePen, 307, 170, 325, 215);
            cardGraphics.DrawLine(linePen, 329, 222, 331, 226);
            cardGraphics.DrawLine(linePen, 340, 244, 342, 254);
            cardGraphics.DrawLine(linePen, 312, 250, 333, 265);
            cardGraphics.DrawLine(linePen, 165, 141, 297, 241);
            cardGraphics.DrawLine(linePen, 341, 269, 376, 302);
            cardGraphics.DrawLine(linePen, 388, 310, 462, 356);
            cardGraphics.DrawLine(linePen, 466, 369, 365, 379);
            cardGraphics.DrawLine(linePen, 469, 374, 423, 457);
            Thread.Sleep(120);

            linePen.Color = Color.FromArgb(70, 225, 225, 225);
            cardGraphics.DrawLine(linePen, 223, 77, 299, 162);
            cardGraphics.DrawLine(linePen, 307, 170, 325, 215);
            cardGraphics.DrawLine(linePen, 329, 222, 331, 226);
            cardGraphics.DrawLine(linePen, 340, 244, 342, 254);
            cardGraphics.DrawLine(linePen, 312, 250, 333, 265);
            cardGraphics.DrawLine(linePen, 165, 141, 297, 241);
            cardGraphics.DrawLine(linePen, 341, 269, 376, 302);
            cardGraphics.DrawLine(linePen, 388, 310, 462, 356);
            cardGraphics.DrawLine(linePen, 466, 369, 365, 379);
            cardGraphics.DrawLine(linePen, 469, 374, 423, 457);
            Thread.Sleep(120);

            linePen.Color = Color.FromArgb(80, 225, 225, 225);
            cardGraphics.DrawLine(linePen, 223, 77, 299, 162);
            cardGraphics.DrawLine(linePen, 307, 170, 325, 215);
            cardGraphics.DrawLine(linePen, 329, 222, 331, 226);
            cardGraphics.DrawLine(linePen, 340, 244, 342, 254);
            cardGraphics.DrawLine(linePen, 312, 250, 333, 265);
            cardGraphics.DrawLine(linePen, 165, 141, 297, 241);
            cardGraphics.DrawLine(linePen, 341, 269, 376, 302);
            cardGraphics.DrawLine(linePen, 388, 310, 462, 356);
            cardGraphics.DrawLine(linePen, 466, 369, 365, 379);
            cardGraphics.DrawLine(linePen, 469, 374, 423, 457);
            Thread.Sleep(120);

            linePen.Color = Color.FromArgb(90, 225, 225, 225);
            cardGraphics.DrawLine(linePen, 223, 77, 299, 162);
            cardGraphics.DrawLine(linePen, 307, 170, 325, 215);
            cardGraphics.DrawLine(linePen, 329, 222, 331, 226);
            cardGraphics.DrawLine(linePen, 340, 244, 342, 254);
            cardGraphics.DrawLine(linePen, 312, 250, 333, 265);
            cardGraphics.DrawLine(linePen, 165, 141, 297, 241);
            cardGraphics.DrawLine(linePen, 341, 269, 376, 302);
            cardGraphics.DrawLine(linePen, 388, 310, 462, 356);
            cardGraphics.DrawLine(linePen, 466, 369, 365, 379);
            cardGraphics.DrawLine(linePen, 469, 374, 423, 457);
            Thread.Sleep(120);

            linePen.Color = Color.FromArgb(100, 225, 225, 225);
            cardGraphics.DrawLine(linePen, 223, 77, 299, 162);
            cardGraphics.DrawLine(linePen, 307, 170, 325, 215);
            cardGraphics.DrawLine(linePen, 329, 222, 331, 226);
            cardGraphics.DrawLine(linePen, 340, 244, 342, 254);
            cardGraphics.DrawLine(linePen, 312, 250, 333, 265);
            cardGraphics.DrawLine(linePen, 165, 141, 297, 241);
            cardGraphics.DrawLine(linePen, 341, 269, 376, 302);
            cardGraphics.DrawLine(linePen, 388, 310, 462, 356);
            cardGraphics.DrawLine(linePen, 466, 369, 365, 379);
            cardGraphics.DrawLine(linePen, 469, 374, 423, 457);
            Thread.Sleep(500);

            // Line colour change loop
            linePen.Color = Color.Yellow;
            for (int x = 1; x <= 15; x++)
            {
                if(linePen.Color == Color.Yellow)
                {
                    linePen.Color = Color.Red;
                    cardGraphics.DrawLine(linePen, 223, 77, 299, 162);
                    cardGraphics.DrawLine(linePen, 307, 170, 325, 215);
                    cardGraphics.DrawLine(linePen, 329, 222, 331, 226);
                    cardGraphics.DrawLine(linePen, 340, 244, 342, 254);
                    cardGraphics.DrawLine(linePen, 312, 250, 333, 265);
                    cardGraphics.DrawLine(linePen, 165, 141, 297, 241);
                    cardGraphics.DrawLine(linePen, 341, 269, 376, 302);
                    cardGraphics.DrawLine(linePen, 388, 310, 462, 356);
                    cardGraphics.DrawLine(linePen, 466, 369, 365, 379);
                    cardGraphics.DrawLine(linePen, 469, 374, 423, 457);
                    Thread.Sleep(50);
                }
                if (linePen.Color == Color.Red)
                {
                    linePen.Color = Color.Blue;
                    cardGraphics.DrawLine(linePen, 223, 77, 299, 162);
                    cardGraphics.DrawLine(linePen, 307, 170, 325, 215);
                    cardGraphics.DrawLine(linePen, 329, 222, 331, 226);
                    cardGraphics.DrawLine(linePen, 340, 244, 342, 254);
                    cardGraphics.DrawLine(linePen, 312, 250, 333, 265);
                    cardGraphics.DrawLine(linePen, 165, 141, 297, 241);
                    cardGraphics.DrawLine(linePen, 341, 269, 376, 302);
                    cardGraphics.DrawLine(linePen, 388, 310, 462, 356);
                    cardGraphics.DrawLine(linePen, 466, 369, 365, 379);
                    cardGraphics.DrawLine(linePen, 469, 374, 423, 457);
                    Thread.Sleep(50);
                }
                if(linePen.Color == Color.Blue)
                {
                    linePen.Color = Color.Green;
                    cardGraphics.DrawLine(linePen, 223, 77, 299, 162);
                    cardGraphics.DrawLine(linePen, 307, 170, 325, 215);
                    cardGraphics.DrawLine(linePen, 329, 222, 331, 226);
                    cardGraphics.DrawLine(linePen, 340, 244, 342, 254);
                    cardGraphics.DrawLine(linePen, 312, 250, 333, 265);
                    cardGraphics.DrawLine(linePen, 165, 141, 297, 241);
                    cardGraphics.DrawLine(linePen, 341, 269, 376, 302);
                    cardGraphics.DrawLine(linePen, 388, 310, 462, 356);
                    cardGraphics.DrawLine(linePen, 466, 369, 365, 379);
                    cardGraphics.DrawLine(linePen, 469, 374, 423, 457);
                    Thread.Sleep(50);
                }
                if(linePen.Color == Color.Green)
                {
                    linePen.Color = Color.Yellow;
                    cardGraphics.DrawLine(linePen, 223, 77, 299, 162);
                    cardGraphics.DrawLine(linePen, 307, 170, 325, 215);
                    cardGraphics.DrawLine(linePen, 329, 222, 331, 226);
                    cardGraphics.DrawLine(linePen, 340, 244, 342, 254);
                    cardGraphics.DrawLine(linePen, 312, 250, 333, 265);
                    cardGraphics.DrawLine(linePen, 165, 141, 297, 241);
                    cardGraphics.DrawLine(linePen, 341, 269, 376, 302);
                    cardGraphics.DrawLine(linePen, 388, 310, 462, 356);
                    cardGraphics.DrawLine(linePen, 466, 369, 365, 379);
                    cardGraphics.DrawLine(linePen, 469, 374, 423, 457);
                    Thread.Sleep(50);
                }
            }
            textBrush.Color = Color.FromArgb(10, 132, 9, 9);
            cardGraphics.DrawString("Taurus (Latin for 'the Bull') is one of the constellations of the", infoFont, textBrush, 20, 20);
            cardGraphics.DrawString("Zodiac, which means it is crossed by the plane of the ecliptic.", infoFont, textBrush, 20, 50);
            cardGraphics.DrawString("Taurus is a large and prominent constellation in the northern ", infoFont, textBrush, 20, 80);
            cardGraphics.DrawString("hemisphere's winter sky. It is one of the oldest constellations,", infoFont, textBrush, 20, 110);
            cardGraphics.DrawString("dating back to at least the Early Bronze Age when it marked the", infoFont, textBrush, 20, 140);
            cardGraphics.DrawString("location of the Sun during the spring equinox.", infoFont, textBrush, 20, 170);
            Thread.Sleep(100);
            textBrush.Color = Color.FromArgb(20, 132, 9, 9);
            cardGraphics.DrawString("Taurus (Latin for 'the Bull') is one of the constellations of the", infoFont, textBrush, 20, 20);
            cardGraphics.DrawString("Zodiac, which means it is crossed by the plane of the ecliptic.", infoFont, textBrush, 20, 50);
            cardGraphics.DrawString("Taurus is a large and prominent constellation in the northern ", infoFont, textBrush, 20, 80);
            cardGraphics.DrawString("hemisphere's winter sky. It is one of the oldest constellations,", infoFont, textBrush, 20, 110);
            cardGraphics.DrawString("dating back to at least the Early Bronze Age when it marked the", infoFont, textBrush, 20, 140);
            cardGraphics.DrawString("location of the Sun during the spring equinox.", infoFont, textBrush, 20, 170);
            Thread.Sleep(100);
            textBrush.Color = Color.FromArgb(30, 132, 9, 9);
            cardGraphics.DrawString("Taurus (Latin for 'the Bull') is one of the constellations of the", infoFont, textBrush, 20, 20);
            cardGraphics.DrawString("Zodiac, which means it is crossed by the plane of the ecliptic.", infoFont, textBrush, 20, 50);
            cardGraphics.DrawString("Taurus is a large and prominent constellation in the northern ", infoFont, textBrush, 20, 80);
            cardGraphics.DrawString("hemisphere's winter sky. It is one of the oldest constellations,", infoFont, textBrush, 20, 110);
            cardGraphics.DrawString("dating back to at least the Early Bronze Age when it marked the", infoFont, textBrush, 20, 140);
            cardGraphics.DrawString("location of the Sun during the spring equinox.", infoFont, textBrush, 20, 170);
            Thread.Sleep(100);
            textBrush.Color = Color.FromArgb(40, 132, 9, 9);
            cardGraphics.DrawString("Taurus (Latin for 'the Bull') is one of the constellations of the", infoFont, textBrush, 20, 20);
            cardGraphics.DrawString("Zodiac, which means it is crossed by the plane of the ecliptic.", infoFont, textBrush, 20, 50);
            cardGraphics.DrawString("Taurus is a large and prominent constellation in the northern ", infoFont, textBrush, 20, 80);
            cardGraphics.DrawString("hemisphere's winter sky. It is one of the oldest constellations,", infoFont, textBrush, 20, 110);
            cardGraphics.DrawString("dating back to at least the Early Bronze Age when it marked the", infoFont, textBrush, 20, 140);
            cardGraphics.DrawString("location of the Sun during the spring equinox.", infoFont, textBrush, 20, 170);
            Thread.Sleep(100);
            textBrush.Color = Color.FromArgb(50, 132, 9, 9);
            cardGraphics.DrawString("Taurus (Latin for 'the Bull') is one of the constellations of the", infoFont, textBrush, 20, 20);
            cardGraphics.DrawString("Zodiac, which means it is crossed by the plane of the ecliptic.", infoFont, textBrush, 20, 50);
            cardGraphics.DrawString("Taurus is a large and prominent constellation in the northern ", infoFont, textBrush, 20, 80);
            cardGraphics.DrawString("hemisphere's winter sky. It is one of the oldest constellations,", infoFont, textBrush, 20, 110);
            cardGraphics.DrawString("dating back to at least the Early Bronze Age when it marked the", infoFont, textBrush, 20, 140);
            cardGraphics.DrawString("location of the Sun during the spring equinox.", infoFont, textBrush, 20, 170);
            Thread.Sleep(100);
            textBrush.Color = Color.FromArgb(60, 132, 9, 9);
            cardGraphics.DrawString("Taurus (Latin for 'the Bull') is one of the constellations of the", infoFont, textBrush, 20, 20);
            cardGraphics.DrawString("Zodiac, which means it is crossed by the plane of the ecliptic.", infoFont, textBrush, 20, 50);
            cardGraphics.DrawString("Taurus is a large and prominent constellation in the northern ", infoFont, textBrush, 20, 80);
            cardGraphics.DrawString("hemisphere's winter sky. It is one of the oldest constellations,", infoFont, textBrush, 20, 110);
            cardGraphics.DrawString("dating back to at least the Early Bronze Age when it marked the", infoFont, textBrush, 20, 140);
            cardGraphics.DrawString("location of the Sun during the spring equinox.", infoFont, textBrush, 20, 170);
            Thread.Sleep(100);
            textBrush.Color = Color.FromArgb(70, 132, 9, 9);
            cardGraphics.DrawString("Taurus (Latin for 'the Bull') is one of the constellations of the", infoFont, textBrush, 20, 20);
            cardGraphics.DrawString("Zodiac, which means it is crossed by the plane of the ecliptic.", infoFont, textBrush, 20, 50);
            cardGraphics.DrawString("Taurus is a large and prominent constellation in the northern ", infoFont, textBrush, 20, 80);
            cardGraphics.DrawString("hemisphere's winter sky. It is one of the oldest constellations,", infoFont, textBrush, 20, 110);
            cardGraphics.DrawString("dating back to at least the Early Bronze Age when it marked the", infoFont, textBrush, 20, 140);
            cardGraphics.DrawString("location of the Sun during the spring equinox.", infoFont, textBrush, 20, 170);
            Thread.Sleep(100);
            textBrush.Color = Color.FromArgb(80, 132, 9, 9);
            cardGraphics.DrawString("Taurus (Latin for 'the Bull') is one of the constellations of the", infoFont, textBrush, 20, 20);
            cardGraphics.DrawString("Zodiac, which means it is crossed by the plane of the ecliptic.", infoFont, textBrush, 20, 50);
            cardGraphics.DrawString("Taurus is a large and prominent constellation in the northern ", infoFont, textBrush, 20, 80);
            cardGraphics.DrawString("hemisphere's winter sky. It is one of the oldest constellations,", infoFont, textBrush, 20, 110);
            cardGraphics.DrawString("dating back to at least the Early Bronze Age when it marked the", infoFont, textBrush, 20, 140);
            cardGraphics.DrawString("location of the Sun during the spring equinox.", infoFont, textBrush, 20, 170);
            Thread.Sleep(100);
            textBrush.Color = Color.FromArgb(90, 132, 9, 9);
            cardGraphics.DrawString("Taurus (Latin for 'the Bull') is one of the constellations of the", infoFont, textBrush, 20, 20);
            cardGraphics.DrawString("Zodiac, which means it is crossed by the plane of the ecliptic.", infoFont, textBrush, 20, 50);
            cardGraphics.DrawString("Taurus is a large and prominent constellation in the northern ", infoFont, textBrush, 20, 80);
            cardGraphics.DrawString("hemisphere's winter sky. It is one of the oldest constellations,", infoFont, textBrush, 20, 110);
            cardGraphics.DrawString("dating back to at least the Early Bronze Age when it marked the", infoFont, textBrush, 20, 140);
            cardGraphics.DrawString("location of the Sun during the spring equinox.", infoFont, textBrush, 20, 170);
            Thread.Sleep(100);
            textBrush.Color = Color.FromArgb(100, 132, 9, 9);
            cardGraphics.DrawString("Taurus (Latin for 'the Bull') is one of the constellations of the", infoFont, textBrush, 20, 20);
            cardGraphics.DrawString("Zodiac, which means it is crossed by the plane of the ecliptic.", infoFont, textBrush, 20, 50);
            cardGraphics.DrawString("Taurus is a large and prominent constellation in the northern ", infoFont, textBrush, 20, 80);
            cardGraphics.DrawString("hemisphere's winter sky. It is one of the oldest constellations,", infoFont, textBrush, 20, 110);
            cardGraphics.DrawString("dating back to at least the Early Bronze Age when it marked the", infoFont, textBrush, 20, 140);
            cardGraphics.DrawString("location of the Sun during the spring equinox.", infoFont, textBrush, 20, 170);
            Thread.Sleep(100);
        }

    }
}
