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

        Button[,] pola_button;

        public Gra(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
            
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pola_button = new Button[_form1.wielkosc, _form1.wielkosc];

            GenerujButtony(panelGra, pola_button, _form1.wielkosc);

            buttonRozpocznij.Hide();
        }
    }
}
