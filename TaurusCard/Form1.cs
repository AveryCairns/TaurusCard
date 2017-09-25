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
            // Clear screen and set up gramphics
            BackgroundImage = null;
            Refresh();

            Graphics cardGraphics = this.CreateGraphics();
            SolidBrush starBrush = new SolidBrush(Color.White);
            Pen linePen = new Pen(Color.LightGray, 2);
            cardGraphics.Clear(Color.Black);

            // Set up sound players
            SoundPlayer dingPlayer = new SoundPlayer(Properties.Resources.ding);
            SoundPlayer clickPlayer = new SoundPlayer(Properties.Resources.click);

            // Stars
            cardGraphics.FillEllipse(starBrush, 209, 62, 18, 18);
            //clickPlayer.Play();
            //Thread.Sleep(700);
            cardGraphics.FillEllipse(starBrush, 293, 234, 22, 22);
            //dingPlayer.Play();
            //Thread.Sleep(700);
            cardGraphics.FillEllipse(starBrush, 321, 211, 12, 12);
            //clickPlayer.Play();
            //Thread.Sleep(700);
            cardGraphics.FillEllipse(starBrush, 461, 353, 13, 13);
            //dingPlayer.Play();
            //Thread.Sleep(700);
            cardGraphics.FillEllipse(starBrush, 332, 233, 13, 13);
            //clickPlayer.Play();
            //Thread.Sleep(700);
            cardGraphics.FillEllipse(starBrush, 352, 372, 15, 15);
            //dingPlayer.Play();
            //Thread.Sleep(700);
            cardGraphics.FillEllipse(starBrush, 325, 225, 13, 13);
            //clickPlayer.Play();
            //Thread.Sleep(700);
            cardGraphics.FillEllipse(starBrush, 152, 130, 16, 16);
            //clickPlayer.Play();
            //Thread.Sleep(700);
            cardGraphics.FillEllipse(starBrush, 374, 300, 16, 16);
            //dingPlayer.Play();
            //Thread.Sleep(700);
            cardGraphics.FillEllipse(starBrush, 329, 262, 13, 13);
            //clickPlayer.Play();
            //Thread.Sleep(700);
            cardGraphics.FillEllipse(starBrush, 336, 253, 12, 12);
            //dingPlayer.Play();
            //Thread.Sleep(700);
            cardGraphics.FillEllipse(starBrush, 409, 456, 20, 20);
            //clickPlayer.Play();
            //Thread.Sleep(700);
            cardGraphics.FillEllipse(starBrush, 297, 160, 14, 14);
            //dingPlayer.Play();
            //Thread.Sleep(1000);

            cardGraphics.DrawLine(linePen, 223, 77, 299, 162);
            cardGraphics.DrawLine(linePen, 307, 170, 325, 215);
            cardGraphics.DrawLine(linePen, 329, 222, 331, 226);
            cardGraphics.DrawLine(linePen, 340, 244, 342, 254);
            cardGraphics.DrawLine(linePen, 312, 250, 333, 265);
            cardGraphics.DrawLine(linePen, 165, 141, 297, 241);
            cardGraphics.DrawLine(linePen, 341, 269, 376, 302);
            cardGraphics.DrawLine(linePen, 388, 310, 462, 356);

        }

    }
}
