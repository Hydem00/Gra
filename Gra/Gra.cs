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
    public partial class Gra : Form
    {
        private Form1 _form1;
        int x, y;
        int end = 3;
        int i = 0;
        int w = -1;
        int spr = 1;

        Button[,] pola_button;
        List<Button> podswietlony = new List<Button>();
        //List<Button> wybrany = new List<Button>();

        public Gra(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
            buttonDalej.Hide();
            panelGra.Enabled = false;
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
            //if (podswietlony.Any() && wybrany.Any())
            //{
            //    SprawdzWynik();
            //}

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

        }

        private void SprawdzWynik(int w)
        {
            spr++;
            try
            {
                if (wybrany[w] == podswietlony[w])
                {
                MessageBox.Show("Są równe", "Dobrze");
                }
                else
                {
                MessageBox.Show("Nope", "Źle");
                this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Nope", "Źle");
                this.Close();
            }

            if(spr == end)
            {
                buttonDalej.Enabled = true;
                panelGra.Enabled = false;
                MessageBox.Show("Dobrze, możesz przejść dalej", "Dobrze");
            }
                     
        }
    }
}
