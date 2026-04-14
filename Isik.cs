using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_IvanovNikita
{
    public class Isik
    {
        //public string Nimi;
        //public int Vanus;

        public void Tervita()
        {
            Console.WriteLine($"Tere! Mina olen {Nimi} ja ma olen {Vanus} aastat vana, olen sündinud {Sünniaasta}.");
        }
        // Privaatne väli - otse ligi ei saa
        private int sünniaasta;

        // Avalik omadus (Property) automaatse get/set logikaga
        public string Nimi { get; set; }

        // Kontrollitud omadus
        public int Sünniaasta
        {
            get { return sünniaasta; }
            set
            {
                if (value > 1900 && value <= DateTime.Now.Year)
                    sünniaasta = value;
                else
                    Console.WriteLine("Vigane sünniaasta!");
            }
        }

        // Arvutatud omadus (ainult lugemiseks / getter)
        public int Vanus => DateTime.Now.Year - sünniaasta;
    }
}
