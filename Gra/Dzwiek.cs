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
    public partial class Dzwiek : Form
    {
        public Dzwiek()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Form1.MediaPlayer.controls.play();
            Form1.MediaPlayer.settings.volume = trackBar1.Value;
        }
    }
}
