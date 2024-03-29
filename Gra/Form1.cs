﻿using System;
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
        public int wielkosc;
        public string poziom_trudnosci;
        string path = Path.GetFullPath(@"..\..\Resources\Simple - Patrick Patrikios (online-audio-converter.com).wav");

        public Form1()
        {
            InitializeComponent();

            WidocznoscPaneli();

            UstawienieRadio();

            UstawieniaAudio();

            UstawieniaPlanszy();

            textBox1.MaxLength = 8;

        }

        void UstawienieRadio()
        {
            RadioLatwy.Checked = true;
        }

        void UstawieniaPlanszy()
        {
            WielkoscPlanszy.Minimum = 2;
            WielkoscPlanszy.Value = 2;
            WielkoscPlanszy.Maximum = 10;
        }

        void UstawieniaAudio()
        {
            MediaPlayer.URL = path;

            MediaPlayer.settings.setMode("loop", true);

            MediaPlayer.controls.play();

            MediaPlayer.settings.volume = 10;

            axWindowsMediaPlayer1.Hide();
        }

        public void Audio()
        {
            var audio = new System.Media.SoundPlayer("..\\..\\Resources\\Click.wav");
            audio.Play();
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
            Audio();
            PokazOpcje(StartPanel);
        }
        
        private void WielkoscPlanszy_ValueChanged(object sender, EventArgs e)
        {
            wielkosc = (int)WielkoscPlanszy.Value;
        }

        protected void ZatwierdzButton_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Podaj nazwę", "Błąd");
            }
            else
            {
            Audio();
            var graj = new Gra(this, textBox1);
                //Gra graj = new Gra(WielkoscPlanszy);

                try { graj.ShowDialog(); }
                catch { MessageBox.Show("Taki gracz już istnieje", "Błąd"); }


            
            //System.Media.SoundPlayer dzwiek = new System.Media.SoundPlayer(@"C:\Users\barte\Desktop\2 semestr inf\Metodologia Programowania\Projekty\ProjektGry\Gra\Gra\Resources\Frisbee Throw (online-audio-converter.com).wav");
            //dzwiek.Play();
            }   
        }
        #endregion

        #region Opcje
        private void OpcjeButton_Click(object sender, EventArgs e)
        {
            Audio();
            PokazOpcje(OpcjePanel);
        }

        private void DzwiekButton_Click(object sender, EventArgs e)
        {
            Audio();
            SchowajOpcje();
            Dzwiek UstawieniaDzwieku = new Dzwiek();
            UstawieniaDzwieku.ShowDialog();
        }

        private void GrafikaButton_Click(object sender, EventArgs e)
        {
            Audio();
            SchowajOpcje();
            Grafika UstawieniaGraficzne = new Grafika();
            UstawieniaGraficzne.ShowDialog();
        }

        private void InstrukcjaButton_Click(object sender, EventArgs e)
        {
            Audio();
            SchowajOpcje();
            Instrukcja InstrukcjaGry = new Instrukcja();
            InstrukcjaGry.ShowDialog();
        }

        #endregion

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Audio();
            Application.Exit();
        }

        private void RadioLatwy_CheckedChanged(object sender, EventArgs e)
        {
            poziom_trudnosci = RadioLatwy.Text;
        }

        private void RadioSredni_CheckedChanged(object sender, EventArgs e)
        {
            poziom_trudnosci = RadioSredni.Text;
        }

        private void RadioTrudny_CheckedChanged(object sender, EventArgs e)
        {
            poziom_trudnosci = RadioTrudny.Text;
        }
    }
}
