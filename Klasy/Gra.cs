using GRA_WJP.Ekrany;
using GRA_WJP.Ekrany.Interfejsy;
using GRA_WJP.Enums;
using GRA_WJP.Klasy.Budynki;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GRA_WJP.Klasy
{
    /// <summary>
    /// Klasa odpowiedzialna za logikę rozgrywki, to właśnie tu się większość dzieje
    /// </summary>
    public static class Gra
    {
        /**Pole listy surowca, na której są wykonywane działania za pomocą linq*/
        private static List<Surowiec> Surowce = new List<Surowiec>()
        {
            new Surowiec(200, SurowiecEnum.Drewno),
            new Surowiec(200, SurowiecEnum.Zloto),
            new Surowiec(200, SurowiecEnum.Jedzenie)
        };

        /**Pole listy Budynków (dziedziczących po interfejsie IBudynek), na której są wykonywane
         * działania za pomocą linq*/
        private static List<IBudynek> Budynki = new List<IBudynek>()
        {
            new Dom(1, 200, 200, 160, 160, "Drewno", "Jedzenie"),
            new Tartak(1, 200, 200, 140,140, "Drewno", "Złoto"),
            new Farma(1, 200, 200, 140, 140, "Jedzenie", "Złoto"),
            new Kopalnia(1, 200, 200, 140, "Złoto")
        };

        /**Pole odpowiedzialne za ilość aktualnej populacji gracza*/
        private static int populacja = 100;

        /**Pole odpowiedzialne za numer tury rozgrywanej*/
        private static int tura = 1;

        /**Pole odpowiedzialne za maksymalną dostępną ilość tur na rozgrywkę*/
        private static int maxTura = 50;

        /**Pole odpowiedzialne za numer zdarzenia losowego, które miało miejsce ostatnio, aby 
         zapobiec pojawianiu się tego samego zdarzenia 2 razy z rzędu*/
        private static int zdarzenieWczesniejsze=0;

        /**Pole odpowiedzialne za numer zdarzenia losowego, potrzebne do zapobiegania pojawiania
         * się tego samego zdarzenia 2 razy z rzędu */
        private static int zdarzenie = 0;

        //Start gry
        /**Pole odpowiedzialne za ilość populacji jaką gracz ma na start gry*/
        private static int populacjaStartGry = 100;

        /**Pole odpowiedzialne za numer tury na start gry*/
        private static int turaStartGry = 1;

        /**Pole odpowiedzialne za lvl budynku jaką gracz ma na start gry*/
        private static int lvlStartGry = 1;

        /**Pole odpowiedzialne za ilość surowca jaką gracz ma na start gry*/
        private static int iloscStartGry = 100;

        /**Pole odpowiedzialne za pojemność budynku jaką gracz ma na start gry*/
        private static int pojemnoscStartGry = 200;

        /**Funkcja odpowiedzialna za wysłanie listy surowców, aby można było wykonywać na niej
         * działań*/
        public static List<Surowiec> SurowceList() => Surowce;

       /**Funkcja odpowiedzialna za wyświetlenie okna zarządzania konkretnym surowcem*/
        public static void WyswietlSurowiec(IEkran IOknoRodzic, SurowiecEnum Surowiec)
        {
            new SurowiecForm(IOknoRodzic, Surowce.First(s => s.JakaNazwa() == Surowiec)).ShowDialog();
        }

        /**Funkcja odpowiedzialna za wyświetlenie okna zarządzania konkretnym budynkiem*/
        public static void WyswietlBudynek(IEkran IOknoRodzic, BudynekEnum Budynek)
        {
            new BudynekForm(IOknoRodzic, Budynki.First(b => b.Nazwa == Budynek)).ShowDialog();
        }

        /**Funkcja odpowiedzialna za wysłanie informacji o ilości konkretnego surowca*/
        public static int IloscSurowca(SurowiecEnum surowiec) => Surowce.First(s => s.JakaNazwa()
        == surowiec).IleSurowiec();

        /**Funkcja odpowiedzialna za zwracanie maksymalnej dostępnej pojemności konkretnego 
         * surowca*/
        public static int MaksSurowca(BudynekEnum Budynek) => 
            Budynki.First(b => b.Nazwa == Budynek).pojemnosc;

        /**Funkcja odpowiedzialna za odejmowanie konkretnej ilości od konkretnego surowca*/
        public static void OdejmijSurowiec(SurowiecEnum SurowiecEnum, int Ilosc)
        {
            Surowce.First(s => s.JakaNazwa() == SurowiecEnum).ZwiekszIloscSurowca(-Ilosc);
        }

        /**Funkcja odpowiedzialna za resetowanie wartości gry*/
        public static void ResetGra()
        {
            Surowce.ForEach(s => s.UstawIloscSurowca(iloscStartGry));
            Surowce.ForEach(s => s.UstawIloscPrzydzielonejPopulacji(0));
            Budynki.ForEach(b => b.lvl = lvlStartGry);
            Budynki.ForEach(b => b.pojemnosc = pojemnoscStartGry);
            populacja = populacjaStartGry;
            tura = turaStartGry;
        }

        /**Funkcja odpowiedzialna za przesłania informacji o dostępnej, niepracującej populacji*/
        public static int IleDostepnaPopulacja() => populacja
            - Surowce.Sum(s => s.IlePrzydzielonaPopulacja());

        /**Funkcja odpowiedzialna za przesłanie informacji o ilości aktualnej populacji*/
        public static int IlePopulacja() => populacja;

        /**Funkcja odpowiedzialna za przesłania informacji o numerze aktualnej tury*/
        public static int KtoraTura() => tura;

        /**Funkcja odpowiedzialna za przesłania informacji o maksymalnej turze*/
        public static int IlemaxTur() => maxTura;

        /**Funkcja odpowiedzialna za sprawdzenie czy ma nastąpić następna tura, czy ma nastąpić 
         * koniec gry*/
        public static bool NastepnaTura()
        {
            if (!((tura < maxTura) && (StanGry() == MozliweKonceTuryEnum.NastepnaTura))) return false;

            tura++;
            return true;
        }

        /**Funkcja odpowiedzialna za zmianę ilości surowca na koniec tury, który przyjmuje 2 
         * wartości współczynników*/
        public static int NastepnaTuraZmianaWartosciSurowca(SurowiecEnum Surowiec,
            BudynekEnum Budynek, float WspolczynnikStrat, float WspolczynnikZysku)
        {
            var poprzedniaWartoscSurowca = Surowce.First(s => s.JakaNazwa() == Surowiec)
                .IleSurowiec();

            var dodatkowaIloscSurowca = (int)((Surowce.First(s => s.JakaNazwa() == Surowiec)
                .IlePrzydzielonaPopulacja()* WspolczynnikZysku) - (WspolczynnikStrat * populacja));

            var pojemnoscBudynku = Budynki.First(b => b.Nazwa == Budynek).pojemnosc;

            if ((poprzedniaWartoscSurowca + dodatkowaIloscSurowca) > pojemnoscBudynku)
            {
                Surowce.First(s => s.JakaNazwa() == Surowiec).UstawIloscSurowca(
                    Budynki.First(b => b.Nazwa == Budynek).pojemnosc);

                return pojemnoscBudynku - poprzedniaWartoscSurowca;
            }
            else
            {
                Surowce.First(s => s.JakaNazwa() == Surowiec).ZwiekszIloscSurowca(
                    dodatkowaIloscSurowca);

                if (Surowce.First(s => s.JakaNazwa() == Surowiec).IleSurowiec() < 0) Surowce.
                        First(s => s.JakaNazwa() == Surowiec).UstawIloscSurowca(0);

                return dodatkowaIloscSurowca;
            }
        }

        /**Funkcja odpowiedzialna za zmianę ilości surowca na koniec tura, który przyjmuje 1
         * wartość współczynnika*/
        public static int NastepnaTuraZmianaWartosciSurowca(SurowiecEnum Surowiec, 
            BudynekEnum Budynek, float wspolczynnikZysku)
        {
            var poprzedniaWartoscSurowca = Surowce.First(s => s.JakaNazwa() == Surowiec)
                .IleSurowiec();

            var dodatkowaIloscSurowca = (int)((Surowce.First(s =>
                s.JakaNazwa() == Surowiec).IlePrzydzielonaPopulacja() * wspolczynnikZysku));

            var pojemnoscBudynku = Budynki.First(b => b.Nazwa == Budynek).pojemnosc;

            if ((poprzedniaWartoscSurowca + dodatkowaIloscSurowca) > Budynki
                .First(b => b.Nazwa == Budynek).pojemnosc)
            {
                Surowce.First(s => s.JakaNazwa() == Surowiec).UstawIloscSurowca(pojemnoscBudynku);
                return pojemnoscBudynku - poprzedniaWartoscSurowca;
            }
            else
            {
                Surowce.First(s => s.JakaNazwa() == Surowiec)
                    .ZwiekszIloscSurowca(dodatkowaIloscSurowca);
                return dodatkowaIloscSurowca;
            }
        }

        /**Funkcja odpowiedzialna za przyrost ilości populacji na koniec tury*/
        public static int NastepnaTuraZmianaWartosciPopulacji(SurowiecEnum Surowiec, 
            int Wspolczynnik)
        {
            var populacjaPoprzednia = populacja;
            var dodatkowaPopulacja = (int)(Surowce.First(s => s.JakaNazwa() == Surowiec)
                .IleSurowiec() * Wspolczynnik / 10);

            var pojemnoscBudynku = Budynki.First(b => b.Nazwa == BudynekEnum.Dom).pojemnosc;

            if ((populacja + dodatkowaPopulacja) > pojemnoscBudynku)
            {
                populacja = pojemnoscBudynku;
                return pojemnoscBudynku - populacjaPoprzednia;
            }
            else
            {
                populacja += dodatkowaPopulacja;
                return dodatkowaPopulacja;
            }
        }

        /**Funkcja odpowiedzialna za zwracanie jaki ma nastąpić stan gry na zakończenie tury
         Sprawdzenie warunków przegrania, wygrania gry lub czy ma nastąpić kolejna tura*/
        public static MozliweKonceTuryEnum StanGry()
        {
            if (IlePopulacja() >= 1000) return MozliweKonceTuryEnum.Zwyciestwo;
            else if ((tura >= maxTura) ||
                (Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Jedzenie).IleSurowiec() <= 0) ||
                (Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Drewno).IleSurowiec() <= 0))
                return MozliweKonceTuryEnum.Przegrana;
            else return MozliweKonceTuryEnum.NastepnaTura;
        }

        /**Funkcja odpowiedzialna za generowanie i obsługę losowych zdarzeń z ustawionym 
         * prawdopodobieństwem.
         * Zdarzenie jest również generowane losowo*/
        public static string ZdarzenieLosowe()
        {
            if (tura < 5 || tura > 45)
                return null;

            var szansa = new Random().Next(1, 1000);
            if (szansa > 150)
                return null;
            do
            {
                zdarzenie = new Random().Next(1, 6);
            }
            while (zdarzenieWczesniejsze == zdarzenie);
            zdarzenieWczesniejsze = zdarzenie;
            switch (zdarzenie)
            {      
                case 1:
                    //Spalony Tartak
                    var TartakLvl = Budynki.First(b => b.Nazwa == BudynekEnum.Tartak).lvl;
                    if (TartakLvl > 1)
                    {
                        Budynki.First(b => b.Nazwa == BudynekEnum.Tartak).lvl--;
                        Budynki.First(b => b.Nazwa == BudynekEnum.Tartak).pojemnosc -=
                        Budynki.First(b => b.Nazwa == BudynekEnum.Tartak).pojemnoscLvl;
                    }

                    Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Drewno).UstawIloscSurowca(
                        (int)(Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Drewno)
                        .IleSurowiec() * 0.75));

                    Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Drewno)
                        .UstawIloscPrzydzielonejPopulacji((int)(Surowce.First(s => s.JakaNazwa() 
                        == SurowiecEnum.Drewno).IlePrzydzielonaPopulacja() * 0.85));

                    return "Pożar w Tartaku \n \nTwój Tartak stanął w płomieniach:\n Tracisz 1 lvl budynku \nSpłoneło 30% zgromadzonego drewna." +
                        " \nPrzestaje pracować 15% ludzi \nwcześniej pracujących w Tartaku";

                case 2:
                    //Spalona Farma
                    var FarmaLvl = Budynki.First(b => b.Nazwa == BudynekEnum.Farma).lvl;
                    if (FarmaLvl > 1)
                    {
                        Budynki.First(b => b.Nazwa == BudynekEnum.Farma).lvl--;
                        Budynki.First(b => b.Nazwa == BudynekEnum.Farma).pojemnosc -=
                        Budynki.First(b => b.Nazwa == BudynekEnum.Farma).pojemnoscLvl;
                    }

                    Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Jedzenie).UstawIloscSurowca(
                        (int)(Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Jedzenie)
                        .IleSurowiec() * 0.75));

                    Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Jedzenie)
                        .UstawIloscPrzydzielonejPopulacji((int)(Surowce.First(s => s.JakaNazwa() 
                        == SurowiecEnum.Jedzenie).IlePrzydzielonaPopulacja() * 0.85));

                    return "Pożar na Farmie \n\nNa twojej Farmie wybuchł ogień:\nTracisz 1 lvl budynku \nSpłoneło 30% zgromadzonego jedzenie." +
                        " \nPrzestaje pracować 15% ludzi \nwcześniej pracujących na Farmie";
                case 3:
                    //Spalona Kopalnia
                    var KopalniaLvl = Budynki.First(b => b.Nazwa == BudynekEnum.Kopalnia).lvl;
                    if (KopalniaLvl > 1)
                    {
                        Budynki.First(b => b.Nazwa == BudynekEnum.Kopalnia).lvl--;
                        Budynki.First(b => b.Nazwa == BudynekEnum.Kopalnia).pojemnosc -=
                        Budynki.First(b => b.Nazwa == BudynekEnum.Kopalnia).pojemnoscLvl;
                    }

                    Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Zloto).UstawIloscSurowca(
                        (int)(Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Zloto)
                        .IleSurowiec() * 0.75));

                    Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Zloto)
                        .UstawIloscPrzydzielonejPopulacji((int)(Surowce.First(s => s.JakaNazwa()
                        == SurowiecEnum.Zloto).IlePrzydzielonaPopulacja() * 0.85));

                    return "Pożar w Kopalni \n\nTwoja Kopalnia stanęła w płomieniach:\nTracisz 1 lvl budynku \nSpłoneło 30% zgromadzonego złota." +
                        " \nPrzestaje pracować 15% ludzi \nwcześniej pracujących w Kopalni";
                case 4:
                    //Klęska głodu
                    Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Jedzenie).UstawIloscSurowca(
                        (int)(Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Jedzenie)
                        .IleSurowiec() * 0.5));

                    return "Klęska Głodu \n\nNawiedziła cię klęska głodu:\nTracisz 50% zebranej żywności";

                case 5:
                    //Atak
                    Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Zloto).UstawIloscSurowca(
                         (int)(Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Zloto)
                         .IleSurowiec() * 0.85));

                    Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Jedzenie).UstawIloscSurowca(
                         (int)(Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Jedzenie)
                         .IleSurowiec() * 0.85));

                    Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Drewno).UstawIloscSurowca(
                        (int)(Surowce.First(s => s.JakaNazwa() == SurowiecEnum.Drewno)
                        .IleSurowiec() * 0.85));

                    return "Grabież \n\nTwoja osada została splądrowana:\nTracisz po 15% każdego surowca";
            }
            return null;
        }
    }
}
