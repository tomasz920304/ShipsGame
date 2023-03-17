using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipsGame.Klasy
{
    internal class Gracz
    {
        public string Nazwa;
        // zestaw wszystkich pól gracza
        // -1 - pole puste
        // 0-3 - pole statku o długości +1
        public int[,] Plansza;
        // pola odkryte w trakcie gry
        public bool[,] OdkrytePola;
        // zestaw statków gracza
        public int[] Flota;
        public int LiczbaStatkowDoZatopienia;
        public static int ROZMIAR_PLANSZY = 10;
        public static int OSTATNI_INDEX_PLANSZY = ROZMIAR_PLANSZY - 1;

        public Gracz()
        {
            // ustawiono cztery statki od 1-4 pól
            Flota = new int[] { 1, 2, 3, 4 };
            // plansza 10x10
            Plansza = new int[ROZMIAR_PLANSZY, ROZMIAR_PLANSZY];
            OdkrytePola = new bool[ROZMIAR_PLANSZY, ROZMIAR_PLANSZY];
            // liczba statków do zatopienia
            LiczbaStatkowDoZatopienia = Flota.Length;
            for (int i = 0; i < ROZMIAR_PLANSZY; i++)
            {
                for (int j = 0; j < ROZMIAR_PLANSZY; j++)
                {
                    // każda z komórek jest na początku pusta (-1)
                    Plansza[i, j] = -1;
                    // każda z komórek jest na początku nieodkryt
                    OdkrytePola[i, j] = false;
                }
            }
        }
    }
}       

