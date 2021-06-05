using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WidocznoscPaneli();

            string path = Path.GetFullPath(@"..\..\Resources\Simple - Patrick Patrikios (online-audio-converter.com).wav");

            MediaPlayer.URL = path;

            MediaPlayer.settings.setMode("loop", true);

            MediaPlayer.controls.play();
            axWindowsMediaPlayer1.Hide();

        }


        public static WMPLib.WindowsMediaPlayer MediaPlayer = new WMPLib.WindowsMediaPlayer();

        private void WidocznoscPaneli()
        {
            StartPanel.Visible = false;
            OpcjePanel.Visible = false;
        }

        private void SchowajOpcje()
        {
            if(StartPanel.Visible == true)
            {
                StartPanel.Visible = false;
            }
            if(OpcjePanel.Visible == true)
            {
                OpcjePanel.Visible = false;
            }
        }

        private void PokazOpcje(Panel opcje)
        {
            if(opcje.Visible == false)
            {
                SchowajOpcje();
                opcje.Visible = true;
            }
            else
            {
                opcje.Visible = false;
            }
        }

        #region Start
        private void StartButton_Click(object sender, EventArgs e)
        {
            PokazOpcje(StartPanel);
        }
        
        private void WielkoscPlanszy_ValueChanged(object sender, EventArgs e)
        {

        }
        
        private void ZatwierdzButton_Click(object sender, EventArgs e)
        {
            Gra graj = new Gra();
            graj.ShowDialog();
            System.Media.SoundPlayer dzwiek = new System.Media.SoundPlayer(@"C:\Users\barte\Desktop\2 semestr inf\Metodologia Programowania\Projekty\ProjektGry\Gra\Gra\Resources\Frisbee Throw (online-audio-converter.com).wav");
            dzwiek.Play();
        }
        #endregion

        #region Opcje
        private void OpcjeButton_Click(object sender, EventArgs e)
        {
            PokazOpcje(OpcjePanel);
        }

        private void DzwiekButton_Click(object sender, EventArgs e)
        {
            SchowajOpcje();
            Dzwiek UstawieniaDzwieku = new Dzwiek();
            UstawieniaDzwieku.ShowDialog();
        }

        private void GrafikaButton_Click(object sender, EventArgs e)
        {
            SchowajOpcje();
            Grafika UstawieniaGraficzne = new Grafika();
            UstawieniaGraficzne.ShowDialog();
        }

        private void InstrukcjaButton_Click(object sender, EventArgs e)
        {
            SchowajOpcje();
            Instrukcja InstrukcjaGry = new Instrukcja();
            InstrukcjaGry.ShowDialog();
        }

        #endregion

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
