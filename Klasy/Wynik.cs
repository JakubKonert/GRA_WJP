using System;

namespace GRA_WJP.Klasy
{
    /// <summary>
    /// Klasa odpowiedzialna za zapisywanie danych dotyczących wyniku w obiekcie
    /// </summary>
    class Wynik
    {
        /**Konstruktor klasy odpowiedzialny za przypisanie danych do pól konretnego obiektu*/
        public Wynik(string nazwa, DateTime Data, int ktoraTura)
        {
            this.nazwa = nazwa;
            this.Data = Data;
            this.ktoraTura = ktoraTura;
        }

        /**Pole przyjmujące jako wartość nazwę wprowadzoną przez użytkownika*/
        private String nazwa { get; }

        /**Pole przyjmujące jako wartość dokładną datę wygranej rozgrywki użytkownika*/
        private DateTime Data { get; }

        /**Pole przyjmujące jako wartość turę wygrania rozgrywki przez użytkownika*/
        private int ktoraTura { get; }

        /**Funkcja odpowiedzialna za dostęp do wartości pola "ktoraTura"*/
        public int KtoraTuraNumer() => ktoraTura;

        /**Funkcja odpowiedzialna za dostęp do wartości pola "nazwa"*/
        public String JakaNazwa() => nazwa;

        /**Funkcja odpowiedzialna za dostęp do wartości pola "Data"*/
        public DateTime JakaData() => Data;
    }
}
