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
            Graphics cardGraphics = this.CreateGraphics();
            SolidBrush starBrush = new SolidBrush(Color.White);
            Pen linePen = new Pen(Color.LightGray, 2);
            cardGraphics.Clear(Color.Black);

            // Stars
            cardGraphics.FillEllipse(starBrush, 209, 62, 18, 18);
            Thread.Sleep(200);
            cardGraphics.FillEllipse(starBrush, 293, 234, 22, 22);
            Thread.Sleep(200);
            cardGraphics.FillEllipse(starBrush, 321, 211, 12, 12);
            Thread.Sleep(200);
            cardGraphics.FillEllipse(starBrush, 461, 353, 13, 13);
            Thread.Sleep(200);
            cardGraphics.FillEllipse(starBrush, 332, 233, 13, 13);
            Thread.Sleep(200);
            cardGraphics.FillEllipse(starBrush, 352, 372, 15, 15);
            Thread.Sleep(200);
            cardGraphics.FillEllipse(starBrush, 325, 225, 13, 13);
            Thread.Sleep(200);
            cardGraphics.FillEllipse(starBrush, 152, 130, 16, 16);
            Thread.Sleep(200);
            cardGraphics.FillEllipse(starBrush, 374, 300, 16, 16);
            Thread.Sleep(200);
            cardGraphics.FillEllipse(starBrush, 329, 262, 13, 13);
        }
        
    }
}
