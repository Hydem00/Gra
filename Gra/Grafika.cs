using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra
{
    public partial class Grafika : Form
    {
        public Grafika()
        {
            InitializeComponent();          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                
                Properties.Settings.Default.ButtonBackground = colorDialog1.Color;
                Properties.Settings.Default.Save();
                button3.BackColor = Properties.Settings.Default.ButtonBackground;
                //this.BackColor = colorDialog1.Color;
                //panelNaglowek.BackColor = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.MenuBackground = colorDialog1.Color;
                Properties.Settings.Default.Save();
                this.BackColor = Properties.Settings.Default.MenuBackground;
                //this.BackColor = colorDialog1.Color;
                //panelNaglowek.BackColor = colorDialog1.Color;
            }
        }
    }
}
