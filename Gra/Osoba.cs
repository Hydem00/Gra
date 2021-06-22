using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra
{
    class Osoba
    {
        TextBox nazwa;
        ListBox lista;
        int punkty;
        bool ok;

        public Osoba(ListBox lista)
        {
            this.lista = lista;
        }

        public void Nazwa(TextBox nazwa)
        {
            this.nazwa = nazwa;
        }
        public void Punktacja(int pkt)
        {
            punkty = pkt;
        }

        public void Dodaj()
        {
            if (nazwa.Text == "" && punkty == ' ')
            {
                MessageBox.Show("Podaj dane", "Błąd");
            }
            else
                lista.Items.Add(nazwa.Text + " " + punkty);
        }

        public void Edycja()
        {
            if (!ok)
            {
                string[] tekst;
                ok = true;
                lista.SelectedIndex = lista.Items.Count -1;
                if (lista.SelectedIndex == 0)
                {
                    MessageBox.Show("Błąd nie wybrano elementu", "Błąd");
                }
                else
                {
                    tekst = lista.SelectedItem.ToString().Split();
                    nazwa.Text = tekst[0];
                    punkty = int.Parse(tekst[1]);
                }

            }
            else
            {
                var pozycja = 0;
                lista.Items.RemoveAt(0);
                string tekst2 = (nazwa.Text + " " + punkty);
                lista.Items.Insert(pozycja, tekst2);
                nazwa.Clear();
                ok = false;
            }
        }

        public void Usun(int Indeks)
        {
            lista.Items.RemoveAt(Indeks);
        }
    }
}
