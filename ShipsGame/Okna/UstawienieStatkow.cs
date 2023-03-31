using ShipsGame.Klasy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipsGame.Okna
{
    public partial class UstawienieStatkow : Form
    {
        // współrzędne myszy
        int myszX;
        int myszY;
        // indeks do tablicy z długością statków
        int indexAktualnegoStatku;
        // pole wskazujące na to, jak statek jest ustawiany
        // true - poziomo
        // false - pionowo
        bool poziom;
        bool[] rozmieszczoneStatki = new bool[4];

        public UstawienieStatkow()
        {
            InitializeComponent();
            poziom = true;
            Gra.Uzytkownik = new Gracz();
            Gra.Komputer = new Gracz();
            // index o wartości 0 wskazywać będzie na pierwszy statek do rozmieszczenia
            indexAktualnegoStatku = 0;
            lblNazwaGracza.Visible = false;
            btnDalej.Enabled = false;
        }

        private void planszaGracza_MouseMove(object sender, MouseEventArgs e)
        {
            // zdarzenie będzie wywoływane dopóki wszystkie statki nie będą rozłożone(indeksy od 0 do 3)
            if (indexAktualnegoStatku < rozmieszczoneStatki.Length)
            {
                // ustawiamy współrzędne kursora myszy
                myszX = Koordynaty.PobierzKomorke(e.Location.X);
                myszY = Koordynaty.PobierzKomorke(e.Location.Y);
                // odświeżenie planszy gracza
                planszaGracza.Refresh();
                // jeśli statek ustawiony jest poziomo
                if (poziom)
                {
                    for (int i = 0; i < Gra.RozmiaryStatkow[indexAktualnegoStatku]; i++)
                    {
                        // musimy mieć pewność, że statek nie wyjdzie nam poza planszę
                        if (myszX + i <= Gracz.OSTATNI_INDEX_PLANSZY)
                        {
                            Rysowanie.RysujObramowanie(myszX + i, myszY,
                            indexAktualnegoStatku, planszaGracza);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                // poziom = false, czyli statek ustawiony będzie pionowo
                else
                {
                    for (int i = 0; i < Gra.RozmiaryStatkow[indexAktualnegoStatku]; i++)
                    {
                        // musimy mieć pewność, że statek nie wyjdzie nam poza planszę
                        if (myszY + i <= Gracz.OSTATNI_INDEX_PLANSZY)
                        {
                            Rysowanie.RysujObramowanie(myszX, myszY + i,
                            indexAktualnegoStatku, planszaGracza);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }

        private void btnObrot_Click(object sender, EventArgs e)
        {
            poziom = !poziom;
        }
    }
}
