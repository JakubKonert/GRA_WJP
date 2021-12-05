using GRA_WJP.Ekrany;
using GRA_WJP.Ekrany.Interfejsy;
using GRA_WJP.Enums;
using GRA_WJP.Klasy;
using GRA_WJP.Klasy.Budynki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRA_WJP.Klasy
{
    public static class Gra
    {
        private static List<Surowiec> Surowce = new List<Surowiec>()
        {
            new Surowiec(200, SurowiecEnum.Drewno),
            new Surowiec(200, SurowiecEnum.Zloto),
            new Surowiec(200, SurowiecEnum.Jedzenie)
        };

        private static List<IBudynek> Budynki = new List<IBudynek>()
        {
            new Dom(1, 200, 200, 150, 150, "Drewno", "Jedzenie"),
            new Tartak(1, 200, 200, 150,150, "Drewno", "Złoto"),
            new Farma(1, 200, 200, 150, 150, "Jedzenie", "Złoto"),
            new Kopalnia(1, 200, 200, 150, "Złoto")
        };

        private static int Populacja = 1000;
        private static int Tura = 1;
        private static int MaxTura = 2;

        //Start gry
        private static int PopulacjaStartGry = 100;
        private static int TuraStartGry = 1;
        private static int lvlStartGry = 1;
        private static int iloscStartGry = 100;
        private static int pojemnoscStartGry = 200;

        //Wyświetlanie okna klasy surowiec dla konretnego surowca (albo jedzenie, albo drewno itd.)
        public static void WyswietlSurowiec(IEkran parent, SurowiecEnum surowiec)
        {
            new SurowiecForm(parent, Surowce.First(s => s.jakaNazwa() == surowiec)).ShowDialog();
        }

        //Wyświetlanie okna klasy budynek dla konretnego budynku (albo farma, albo tartak itd.)
        public static void WyswietlBudynek(IEkran parent, BudynekEnum budynek)
        {
            new BudynekForm(parent, Budynki.First(b => b.nazwa == budynek)).ShowDialog();
        }

        //Funkcja do zwracania aktualnej ilości surowca (w celach jej wyświetlenia)
        public static int IloscSurowca(SurowiecEnum surowiec)
        {
            return Surowce.First(s => s.jakaNazwa() == surowiec).ilosc;
        }

        //Funkcja do zwracania aktualnego lvl danego budynku (w celach jej wyświetlenia)
        public static int LVLBudynku(BudynekEnum budynek)
        {
            return Budynki.First(b => b.nazwa == budynek).lvl;
        }

        //funkcja do zwracania maksymalnej (dla aktualnego lvl budynku) ilosci danego surowca (w celach jej wyświetlenia)
        public static int MaksSurowca(BudynekEnum budynek)
        {
            return Budynki.First(b => b.nazwa == budynek).pojemnosc;
        }

        //odejmowanie surowca dla np. funkcji "Upgrade()" 
        public static void OdejmijSurowiec(SurowiecEnum surowiecEnum, int ilosc)
        {
            Surowce.First(s => s.jakaNazwa() == surowiecEnum).ilosc -= ilosc;
        }
        //cheat mode
        public static void dodajSurowiec(SurowiecEnum surowiecEnum, int ilosc)
        {
            Surowce.First(s => s.jakaNazwa() == surowiecEnum).ilosc += ilosc;
        }


        //Reset wartości gry, aby za każdym razem uruchomienia gry, zaczynać od nowa
        public static void ResetGra()
        {
            Surowce.ForEach(s => s.ilosc = iloscStartGry);
            Surowce.ForEach(s => s.PrzydzielonaPopulacja = 0);
            Budynki.ForEach(b => b.lvl = lvlStartGry);
            Budynki.ForEach(b => b.pojemnosc = pojemnoscStartGry);
            Populacja = PopulacjaStartGry;
            Tura = TuraStartGry;
        }

        //dostęp do zmiennych prywatnych gry (enkapsulacja)
        public static int IleDostepnaPopulacja() => Populacja - Surowce.Sum(s => s.PrzydzielonaPopulacja);
        public static int IlePopulacja() => Populacja;
        public static int ktoraTura() => Tura;
        public static int ilemaxTur() => MaxTura;

        public static bool NastepnaTura()
        {
            //TO DO: zmienic
            if ((Tura < MaxTura) && (czyWygrana() == MozliweKonceTuryEnum.NastepnaTura))
            {
                Tura++;
                return true;
            }
            return false;
        }

        public static int NastepnaTuraZmianaWartosciSurowca(SurowiecEnum surowiec, BudynekEnum budynek,
            float wspolczynnikStrat, float wspolczynnikZysku)
        {
            if ((Surowce.First(s => s.jakaNazwa() == surowiec).ilosc + (int)((Surowce.First(s =>
                s.jakaNazwa() == surowiec).PrzydzielonaPopulacja * wspolczynnikZysku) - (wspolczynnikStrat * Populacja)))
                    > Budynki.First(b => b.nazwa == budynek).pojemnosc)
            {
                var poprzedniaWartoscSurowca = Surowce.First(s => s.jakaNazwa() == surowiec).ilosc;
                Surowce.First(s => s.jakaNazwa() == surowiec).ilosc = Budynki.First(b => b.nazwa == budynek).pojemnosc;
                return Budynki.First(b => b.nazwa == budynek).pojemnosc - poprzedniaWartoscSurowca;
            }
            else
            {
                Surowce.First(s => s.jakaNazwa() == surowiec).ilosc += (int)((Surowce.First(s =>
                    s.jakaNazwa() == surowiec).PrzydzielonaPopulacja * wspolczynnikZysku) - (wspolczynnikStrat * Populacja));
                return (int)((Surowce.First(s => s.jakaNazwa() == surowiec).PrzydzielonaPopulacja
                * wspolczynnikZysku) - (wspolczynnikStrat * Populacja));
            }
        }

        public static int NastepnaTuraZmianaWartosciSurowca(SurowiecEnum surowiec, BudynekEnum budynek,
            float wspolczynnikZysku)
        {
            if ((Surowce.First(s => s.jakaNazwa() == surowiec).ilosc + (int)((Surowce.First(s =>
                s.jakaNazwa() == surowiec).PrzydzielonaPopulacja * wspolczynnikZysku)))
                > Budynki.First(b => b.nazwa == budynek).pojemnosc)
            {
                var poprzedniaWartoscSurowca = Surowce.First(s => s.jakaNazwa() == surowiec).ilosc;
                Surowce.First(s => s.jakaNazwa() == surowiec).ilosc = Budynki.First(b => b.nazwa == budynek).pojemnosc;
                return Budynki.First(b => b.nazwa == budynek).pojemnosc - poprzedniaWartoscSurowca;
            }
            else
            {
                Surowce.First(s => s.jakaNazwa() == surowiec).ilosc += (int)((Surowce.First(s =>
                s.jakaNazwa() == surowiec).PrzydzielonaPopulacja * wspolczynnikZysku));
                return (int)((Surowce.First(s => s.jakaNazwa() == surowiec).PrzydzielonaPopulacja
                    * wspolczynnikZysku));
            }
        }

        public static int NastepnaTuraZmianaWartosciPopulacji(SurowiecEnum surowiec, int wspolczynnik)
        {
            if ((Populacja + ((Surowce.First(s => s.jakaNazwa() == surowiec).ilosc * wspolczynnik) / 10))
                > Budynki.First(b => b.nazwa == BudynekEnum.Dom).pojemnosc)
            {
                var PopulacjaPoprzednia = Populacja;
                Populacja = Budynki.First(b => b.nazwa == BudynekEnum.Dom).pojemnosc;
                return Budynki.First(b => b.nazwa == BudynekEnum.Dom).pojemnosc - PopulacjaPoprzednia;
            }
            else
            {
                Populacja += (Surowce.First(s => s.jakaNazwa() == surowiec).ilosc * wspolczynnik) / 10;
                return (Surowce.First(s => s.jakaNazwa() == surowiec).ilosc * wspolczynnik) / 10;
            }
        }

        //TO DO: zmienic nazwe
        public static MozliweKonceTuryEnum czyWygrana()
        {
            return IlePopulacja() >= 1000 ? MozliweKonceTuryEnum.Zwyciestwo : Tura >= MaxTura ?
                MozliweKonceTuryEnum.Przegrana : MozliweKonceTuryEnum.NastepnaTura;
        }
        public static string ZdarzenieLosowe()
        {
            //np 
            if (Tura < 5 || Tura > 18)
                return null;

            var szansa = new Random().Next(1, 100);
            if (szansa > 20)
                return null;
            var zdarzenie = new Random().Next(0, 6);

            switch (zdarzenie)
            {
                case 1:
                    //return "string"
                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;


            }
            return null;

        }
    }
}
