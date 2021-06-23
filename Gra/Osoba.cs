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
        string nazwa;
        ListBox lista;
        int punkty;
        int wielkosc_planszy;
        string poziom_trudnosci;
        string temp;

        public Osoba(ListBox lista)
        {
            this.lista = lista;
        }

        public void Nazwa(string nazwa)
        {
            this.nazwa = nazwa;
        }

        public void Poziom_Trudnosci(string poziom_trudnosci)
        {
            this.poziom_trudnosci = poziom_trudnosci;
        }

        public void Wielkosc_Planszy(int wielkosc_planszy)
        {
            this.wielkosc_planszy = wielkosc_planszy;
        }

        public void Punktacja(int pkt)
        {
            punkty = pkt;
        }

        public void Dodaj()
        {
            if (nazwa == "" && punkty == ' ')
            {
                MessageBox.Show("Podaj dane", "Błąd");
            }
            else
            {
                lista.Items.Insert(0, nazwa + "\t" + punkty + "\t" + wielkosc_planszy+"x"+wielkosc_planszy + "\t" + poziom_trudnosci);
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
            temp = nazwa;
            lista.Items.RemoveAt(0);
                string tekst2 = (temp + "\t" + punkty + "\t" + wielkosc_planszy + "x" + wielkosc_planszy + "\t" + poziom_trudnosci);
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
