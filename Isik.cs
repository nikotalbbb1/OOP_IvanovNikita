using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_IvanovNikita
{
    public abstract class Isik
    {
        //public string Nimi;
        //public int Vanus;

        public static int InimesteKoguarv = 0;

        public void Tervita()
        {
            if (sünniaasta == 0)
            {
                Console.WriteLine("viga");
            }
            else
            {
              Console.WriteLine($"Tere! Mina olen {Nimi} ja ma olen {Vanus} aastat vana, olen sündinud {Sünniaasta}.");
            }
        }

        public Isik()
        {

        }

        public Isik(string nimi)
        {
            Nimi = nimi;
            InimesteKoguarv++;
        }
        public abstract string Kirjelda();

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
        public int Vanus =>sünniaasta==0 ? 0: DateTime.Now.Year - sünniaasta;

        // Abstraktne meetod – sisu puudub, alamklassid PEAVAD selle ise looma
        
    }
}
