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
        string temp;

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
            {
                lista.Items.Insert(0, nazwa.Text + " " + punkty);
            }
        }

        public void Edycja()
        {
            //if (!ok)
            //{

            //    string[] tekst;
            //    ok = true;
            //    lista.SelectedIndex = 0;
            //        tekst = lista.SelectedItem.ToString().Split();
            //        temp = tekst[0].ToString();
            //        punkty = int.Parse(tekst[1]);


            //}
            //else
            //{
            //    var pozycja = 0;
            //    lista.Items.RemoveAt(0);
            //    string tekst2 = (temp + " " + punkty);
            //    lista.Items.Insert(pozycja, tekst2);
            //    temp.Clear();
            //    ok = false;
            //}

            var pozycja = 0;
            temp = nazwa.Text;
            lista.Items.RemoveAt(0);
                string tekst2 = (temp + " " + punkty);
                lista.Items.Insert(pozycja, tekst2);
                //temp.Clear();
                //ok = false;
        }

        public void Usun(int Indeks)
        {
            lista.Items.RemoveAt(Indeks);
        }
    }
}
