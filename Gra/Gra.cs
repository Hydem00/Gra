using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Gra
{
    public partial class Gra : Form
    {
        private Form1 _form1;
        public int punkty = 0;
        public string naz;
        Osoba osoba;
        int x, y;
        int end = 3;
        int i = 0;
        int w;
        int spr;

        Button[,] pola_button;
        List<Button> podswietlony = new List<Button>();
        List<Button> wybrany = new List<Button>();

        public Gra(Form1 form1, TextBox nazwa)
        {
            InitializeComponent();
            _form1 = form1;
            buttonDalej.Hide();
            panelGra.Enabled = false;
            //listBox1.DataSource = File.OpenWrite("C:/Users/barte/Desktop/es.txt");
            osoba = new Osoba(listBox1);
            osoba.Nazwa(nazwa);
            naz = nazwa.ToString();
            osoba.Dodaj();
            
        }

        void GenerujButtony(Panel panelGry, Button[,] buttony, int rozmiar)
        {

            int nr = 0;

            for (int i = 0; i < rozmiar; i++)
            {
                for (int j = 0; j < rozmiar; j++)
                {

                    buttony[i, j] = new Button();
                    buttony[i, j].BackColor = Color.White;
                    buttony[i, j].FlatStyle = FlatStyle.Flat;
                    buttony[i, j].FlatAppearance.BorderColor = Color.DarkGray;
                    buttony[i, j].FlatAppearance.BorderSize = 3;
                    buttony[i, j].Location = new Point(5 + j * 52, 20 + i * 52);
                    buttony[i, j].Size = new Size(50, 50);
                    buttony[i, j].TabIndex = nr++;
                    buttony[i, j].Click += button_click;
                    panelGry.Controls.Add(buttony[i, j]);
                }
            }
            panelGry.Text = rozmiar.ToString() + "x" + rozmiar.ToString();

        }

        void button_click(object sender, EventArgs e)
        {
            x = ((Button)sender).TabIndex / (int)_form1.wielkosc + 1;
            y = ((Button)sender).TabIndex % (int)_form1.wielkosc + 1;
            label1.Text = string.Format("x={0} y={1}", x, y);

            w++;

            wybrany.Add(pola_button[x - 1, y - 1]);

            SprawdzWynik(w);

        }

        private void buttonRozpocznij_Click(object sender, EventArgs e)
        {
            pola_button = new Button[_form1.wielkosc, _form1.wielkosc];

            GenerujButtony(panelGra, pola_button, _form1.wielkosc);

            buttonRozpocznij.Hide();

            buttonDalej.Show();

        }

        public void wait(int milliseconds)
        {
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void LosoweGuziki()
        {
            Random rnd = new Random();
            do
            {
                i++;

                podswietlony.Add(pola_button[rnd.Next(_form1.wielkosc), rnd.Next(_form1.wielkosc)]);

            } while (i != end);

            end++;
        }

        private void buttonDalej_Click(object sender, EventArgs e)
        {
            switch (_form1.poziom_trudnosci)
            {
                case "łatwy":

                    w = -1;
                    spr = 1;
                    wybrany.Clear();

                    buttonDalej.Enabled = false;
                    panelGra.Enabled = false;
                    LosoweGuziki();

                    foreach (var guzik in podswietlony)
                    {
                        guzik.BackColor = Color.White;
                        wait(800);
                        guzik.BackColor = Color.Yellow;
                        wait(800);
                        guzik.BackColor = Color.White;
                    }
                    panelGra.Enabled = true;

                    break;

                case "średni":

                    w = -1;
                    spr = 1;
                    wybrany.Clear();

                    buttonDalej.Enabled = false;
                    panelGra.Enabled = false;
                    LosoweGuziki();

                    foreach (var guzik in podswietlony)
                    {
                        guzik.BackColor = Color.White;
                        wait(500);
                        guzik.BackColor = Color.Yellow;
                        wait(500);
                        guzik.BackColor = Color.White;
                    }
                    panelGra.Enabled = true;

                    break;

                case "trudny":

                    w = -1;
                    spr = 1;
                    wybrany.Clear();

                    buttonDalej.Enabled = false;
                    panelGra.Enabled = false;
                    LosoweGuziki();

                    foreach (var guzik in podswietlony)
                    {
                        guzik.BackColor = Color.White;
                        wait(200);
                        guzik.BackColor = Color.Yellow;
                        wait(200);
                        guzik.BackColor = Color.White;
                    }
                    panelGra.Enabled = true;

                    break;

            }
            //w = -1;
            //spr = 1;
            //wybrany.Clear();

            //buttonDalej.Enabled = false;
            //panelGra.Enabled = false;
            //LosoweGuziki();

            //foreach (var guzik in podswietlony)
            //{
            //    guzik.BackColor = Color.White;
            //    wait(800);
            //    guzik.BackColor = Color.Yellow;
            //    wait(800);
            //    guzik.BackColor = Color.White;
            //}
            //panelGra.Enabled = true;

        }

        private void Zapisz_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Tekstowy|*.txt";
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            using (StreamWriter zapis = new StreamWriter(saveFileDialog1.FileName))
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    zapis.WriteLine((string)listBox1.Items[i]);
                }
            }
        }

        private void SprawdzWynik(int w)
        {
            spr++;
            try
            {
                if (wybrany[w] == podswietlony[w])
                {
                    punkty++;
                    osoba.Punktacja(punkty);
                    osoba.Edycja();
                    wybrany[w].BackColor = Color.Green;
                    wait(100);
                    wybrany[w].BackColor = Color.White;
                }
                else
                {
                    wybrany[w].BackColor = Color.Red;
                    MessageBox.Show("GAME OVER", "Źle");
                    spr = 1;
                    this.Close();
                }
            }
            catch
            {
                wybrany[w].BackColor = Color.Red;
                MessageBox.Show("GAME OVER", "Źle");
                spr = 1;
                this.Close();
            }

            if (spr == end)
            {
                buttonDalej.Enabled = true;
                panelGra.Enabled = false;
                MessageBox.Show("Dobrze, możesz przejść dalej", "Dobrze");
            }

        }
    }
}
