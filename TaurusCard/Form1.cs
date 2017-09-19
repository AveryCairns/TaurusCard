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
            Pen linePen = new Pen(Color.White, 2);
            SolidBrush starBrush = new SolidBrush(Color.White);
            SolidBrush textBrush = new SolidBrush(Color.Brown);
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);

            //title
            cardGraphics.DrawString("Taurus", titleFont, textBrush, 15, 110);
            cardGraphics.DrawString("Greeting", titleFont, textBrush, 15, 140);
            cardGraphics.DrawString("Card", titleFont, textBrush, 15, 170);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            // cardGraphics.Clear(Color.Black);
        }
        
    }
}
