using GRA_WJP.Ekrany;
using GRA_WJP.Ekrany.Interfejsy;
using GRA_WJP.Enums;
using GRA_WJP.Klasy.Budynki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GRA_WJP.Klasy
{
    public static class Gra
    {
        //trzymanie wszystkich surowcow w liscie, pozniejsze latwiejsze operowanie na nich za pomoca linq
        private static List<Surowiec> Surowce = new List<Surowiec>()
        {
            new Surowiec(200, SurowiecEnum.Drewno),
            new Surowiec(200, SurowiecEnum.Zloto),
            new Surowiec(200, SurowiecEnum.Jedzenie)
        };

        //trzymanie wszystkich budynkow w liscie, pozniejsze latwiejsze operowanie na nich za pomoca linq
        private static List<IBudynek> Budynki = new List<IBudynek>()
        {
            new Dom(1, 200, 200, 130, 130, "Drewno", "Jedzenie"),
            new Tartak(1, 200, 200, 130,130, "Drewno", "Złoto"),
            new Farma(1, 200, 200, 130, 130, "Jedzenie", "Złoto"),
            new Kopalnia(1, 200, 200, 130, "Złoto")
        };

        private static int Populacja = 100;
        private static int Tura = 1;
        private static int MaxTura = 50;
        private static int ZdarzenieWczesniejsze=0;
        private static int Zdarzenie=0;

        //Start gry
        private static int PopulacjaStartGry = 100;
        private static int TuraStartGry = 1;
        private static int LvlStartGry = 1;
        private static int IloscStartGry = 100;
        private static int PojemnoscStartGry = 200;

        //wysłanie informacji o stanie surowcow
        public static List<Surowiec> SurowceList() => Surowce;

        //Wyświetlanie okna klasy surowiec dla konretnego surowca (albo jedzenie, albo drewno itd.)
        public static void WyswietlSurowiec(IEkran IOknoRodzic, SurowiecEnum Surowiec)
        {
            new SurowiecForm(IOknoRodzic, Surowce.First(s => s.JakaNazwa() == Surowiec)).ShowDialog();
        }

        //Wyświetlanie okna klasy budynek dla konretnego budynku (albo farma, albo tartak itd.)
        public static void WyswietlBudynek(IEkran IOknoRodzic, BudynekEnum Budynek)
        {
            new BudynekForm(IOknoRodzic, Budynki.First(b => b.Nazwa == Budynek)).ShowDialog();
        }

        //Funkcja do zwracania aktualnej ilości surowca (w celach jej wyświetlenia)
        public static int IloscSurowca(SurowiecEnum surowiec) => Surowce.First(s => s.JakaNazwa() == surowiec).IleSurowiec();

        //Funkcja do zwracania aktualnego lvl danego budynku (w celach jej wyświetlenia)
        public static int LVLBudynku(BudynekEnum Budynek) => Budynki.First(b => b.Nazwa == Budynek).Lvl;

        //funkcja do zwracania maksymalnej (dla aktualnego lvl budynku) ilosci danego surowca (w celach jej wyświetlenia)
        public static int MaksSurowca(BudynekEnum Budynek) => Budynki.First(b => b.Nazwa == Budynek).Pojemnosc;

        //odejmowanie surowca dla np. funkcji "Upgrade()" 
        public static void OdejmijSurowiec(SurowiecEnum SurowiecEnum, int Ilosc)
        {
            Surowce.First(s => s.JakaNazwa() == SurowiecEnum).ZwiekszIloscSurowca(-Ilosc);
        }
        public static void DodajSurowiec(SurowiecEnum SurowiecEnum, int Ilosc)
        {
            Surowce.First(s => s.JakaNazwa() == SurowiecEnum).ZwiekszIloscSurowca(Ilosc);
        }


        //Reset wartości gry, aby za każdym razem uruchomienia gry, zaczynać od nowa
        public static void ResetGra()
        {
            Surowce.ForEach(s => s.UstawIloscSurowca(IloscStartGry));
            Surowce.ForEach(s => s.UstawIloscPrzydzielonejPopulacji(0));
            Budynki.ForEach(b => b.Lvl = LvlStartGry);
            Budynki.ForEach(b => b.Pojemnosc = PojemnoscStartGry);
            Populacja = PopulacjaStartGry;
            Tura = TuraStartGry;
        }

        //dostęp do zmiennych prywatnych gry (enkapsulacja)
        public static int IleDostepnaPopulacja() => Populacja - Surowce.Sum(s => s.IlePrzydzielonaPopulacja());
        public static int IlePopulacja() => Populacja;
        public static int KtoraTura() => Tura;
        public static int IlemaxTur() => MaxTura;

        //sprawdzenie czy moze nastapic nastepna tura, jesli tak zwieksz nr tury o 1 i zwroc ze TAK nastepnatura
        public static bool NastepnaTura()
        {
            if (!((Tura < MaxTura) && (StanGry() == MozliweKonceTuryEnum.NastepnaTura))) return false;

            Tura++;
            return true;
        }

        //funkcja obslugujaca zmiane surowca po zakonczeniu tury (2 zmienne)
        public static int NastepnaTuraZmianaWartosciSurowca(SurowiecEnum Surowiec, BudynekEnum Budynek,
            float WspolczynnikStrat, float WspolczynnikZysku)
        {
            var PoprzedniaWartoscSurowca = Surowce.First(s => s.JakaNazwa() == Surowiec).IleSurowiec();
            var DodatkowaIloscSurowca = (int)((Surowce.First(s => s.JakaNazwa() == Surowiec).IlePrzydzielonaPopulacja()
                * WspolczynnikZysku) - (WspolczynnikStrat * Populacja));

            var PojemnoscBudynku = Budynki.First(b => b.Nazwa == Budynek).Pojemnosc;

            if ((PoprzedniaWartoscSurowca + DodatkowaIloscSurowca) > PojemnoscBudynku)
            {
                Surowce.First(s => s.JakaNazwa() == Surowiec).UstawIloscSurowca(Budynki.First(b => b.Nazwa == Budynek).Pojemnosc);
                return PojemnoscBudynku - PoprzedniaWartoscSurowca;
            }
            else
            {
                Surowce.First(s => s.JakaNazwa() == Surowiec).ZwiekszIloscSurowca(DodatkowaIloscSurowca);
                if (Surowce.First(s => s.JakaNazwa() == Surowiec).IleSurowiec() < 0) Surowce.First(s => s.JakaNazwa() == Surowiec).
                        UstawIloscSurowca(0);
                return DodatkowaIloscSurowca;
            }
        }

        //funkcja obslugujaca zmiane surowca po zakonczeniu tury (1 zmienna (zloto nie ma wspolczynnika strat)) 
        public static int NastepnaTuraZmianaWartosciSurowca(SurowiecEnum Surowiec, BudynekEnum Budynek,
            float wspolczynnikZysku)
        {
            var PoprzedniaWartoscSurowca = Surowce.First(s => s.JakaNazwa() == Surowiec).IleSurowiec();
            var DodatkowaIloscSurowca = (int)((Surowce.First(s =>
                s.JakaNazwa() == Surowiec).IlePrzydzielonaPopulacja() * wspolczynnikZysku));

            var PojemnoscBudynku = Budynki.First(b => b.Nazwa == Budynek).Pojemnosc;

            if ((PoprzedniaWartoscSurowca + DodatkowaIloscSurowca) > Budynki.First(b => b.Nazwa == Budynek).Pojemnosc)
            {
                Surowce.First(s => s.JakaNazwa() == Surowiec).UstawIloscSurowca(PojemnoscBudynku);
                return PojemnoscBudynku - PoprzedniaWartoscSurowca;
            }
            else
            {
                Surowce.First(s => s.JakaNazwa() == Surowiec).ZwiekszIloscSurowca(DodatkowaIloscSurowca);
                return DodatkowaIloscSurowca;
            }
        }

        //funkcja odpowiedzialna za zmiane ilosci populacji po zakonczeniu tury (zalezy od ilosci jedzenia)
        public static int NastepnaTuraZmianaWartosciPopulacji(SurowiecEnum Surowiec, int Wspolczynnik)
        {
            var PopulacjaPoprzednia = Populacja;
            var DodatkowaPopulacja = (int)(Surowce.First(s => s.JakaNazwa() == Surowiec).IleSurowiec() * Wspolczynnik / 10);
            var PojemnoscBudynku = Budynki.First(b => b.Nazwa == BudynekEnum.Dom).Pojemnosc;

            if ((Populacja + DodatkowaPopulacja) > PojemnoscBudynku)
            {
                Populacja = PojemnoscBudynku;
                return PojemnoscBudynku - PopulacjaPoprzednia;
            }
            else
            {
                Populacja += DodatkowaPopulacja;
                return DodatkowaPopulacja;
            }
        }

        //3 stany gry, wygrana, przegrana lub kolejna tura
        public static MozliweKonceTuryEnum StanGry()
        {
            if (IleDostepnaPopulacja() >= 1000) return MozliweKonceTuryEnum.Zwyciestwo;
            else if ((Tura >= MaxTura) ||
                (Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Jedzenie).IleSurowiec() <= 0) ||
                (Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Drewno).IleSurowiec() <= 0))
                return MozliweKonceTuryEnum.Przegrana;
            else return MozliweKonceTuryEnum.NastepnaTura;
        }

        //generowanie i obsluga zdarzenia losowego, najpierw losowanie 25% na wystapienia zdarzenia
        //potem losowanie zdarzenia 1 z 5 dostepnych
        //zwraca string zawierajacego opis zdarzenia, ktory jest wypisywany w odpowiednim labelu
        //string wpisany prosto w kod
        // <3 LINQ
        public static string ZdarzenieLosowe()
        {
            if (Tura < 5 || Tura > 45)
                return null;

            var Szansa = new Random().Next(1, 100);
            if (Szansa > 15)
                return null;
            do
            {
                Zdarzenie = new Random().Next(1, 6);
            }
            while (ZdarzenieWczesniejsze == Zdarzenie);
            ZdarzenieWczesniejsze = Zdarzenie;
            switch (Zdarzenie)
            {      
                case 1:
                    //Spalony Tartak
                    var TartakLvl = Budynki.First(b => b.Nazwa == BudynekEnum.Tartak).Lvl;
                    if (TartakLvl > 1)
                    {
                        Budynki.First(b => b.Nazwa == BudynekEnum.Tartak).Lvl--;
                        Budynki.First(b => b.Nazwa == BudynekEnum.Tartak).Pojemnosc -=
                        Budynki.First(b => b.Nazwa == BudynekEnum.Tartak).PojemnoscLvl;
                    }

                    Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Drewno).UstawIloscSurowca(
                        (int)(Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Drewno).IleSurowiec() * 0.75));

                    Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Drewno).UstawIloscPrzydzielonejPopulacji((int)(
                         Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Drewno).IlePrzydzielonaPopulacja() * 0.85));

                    return "Pożar w Tartaku \n \nTwój Tartak stanął w płomieniach:\n Tracisz 1 lvl budynku \nSpłoneło 30% zgromadzonego drewna." +
                        " \nPrzestaje pracować 15% ludzi \nwcześniej pracujących w Tartaku";

                case 2:
                    //Spalona Farma
                    var FarmaLvl = Budynki.First(b => b.Nazwa == BudynekEnum.Farma).Lvl;
                    if (FarmaLvl > 1)
                    {
                        Budynki.First(b => b.Nazwa == BudynekEnum.Farma).Lvl--;
                        Budynki.First(b => b.Nazwa == BudynekEnum.Farma).Pojemnosc -=
                            Budynki.First(b => b.Nazwa == BudynekEnum.Farma).PojemnoscLvl;
                    }

                    Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Jedzenie).UstawIloscSurowca(
                        (int)(Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Jedzenie).IleSurowiec() * 0.75));

                    Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Jedzenie).UstawIloscPrzydzielonejPopulacji((int)(
                         Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Jedzenie).IlePrzydzielonaPopulacja() * 0.85));

                    return "Pożar na Farmie \n\nNa twojej Farmie wybuchł ogień:\nTracisz 1 lvl budynku \nSpłoneło 30% zgromadzonego jedzenie." +
                        " \nPrzestaje pracować 15% ludzi \nwcześniej pracujących na Farmie";
                case 3:
                    //Spalona Kopalnia
                    var KopalniaLvl = Budynki.First(b => b.Nazwa == BudynekEnum.Kopalnia).Lvl;
                    if (KopalniaLvl > 1)
                    {
                        Budynki.First(b => b.Nazwa == BudynekEnum.Kopalnia).Lvl--;
                        Budynki.First(b => b.Nazwa == BudynekEnum.Kopalnia).Pojemnosc -=
                        Budynki.First(b => b.Nazwa == BudynekEnum.Kopalnia).PojemnoscLvl;
                    }

                    Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Zloto).UstawIloscSurowca(
                        (int)(Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Zloto).IleSurowiec() * 0.75));

                    Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Zloto).UstawIloscPrzydzielonejPopulacji((int)(
                         Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Zloto).IlePrzydzielonaPopulacja() * 0.85));

                    return "Pożar w Kopalni \n\nTwoja Kopalnia stanęła w płomieniach:\nTracisz 1 lvl budynku \nSpłoneło 30% zgromadzonego złota." +
                        " \nPrzestaje pracować 15% ludzi \nwcześniej pracujących w Kopalni";
                case 4:
                    //Klęska głodu
                    Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Jedzenie).UstawIloscSurowca(
                        (int)(Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Jedzenie).IleSurowiec() * 0.5));

                    return "Klęska Głodu \n\nNawiedziła cię klęska głodu:\nTracisz 50% zebranej żywności";

                case 5:
                    //Atak
                    Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Zloto).UstawIloscSurowca(
                         (int)(Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Zloto).IleSurowiec() * 0.85));

                    Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Jedzenie).UstawIloscSurowca(
                         (int)(Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Jedzenie).IleSurowiec() * 0.85));

                    Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Drewno).UstawIloscSurowca(
                        (int)(Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Drewno).IleSurowiec() * 0.85));

                    return "Grabież \n\nTwoja osada została splądrowana:\nTracisz po 15% każdego surowca";
            }
            return null;
        }
    }
}
