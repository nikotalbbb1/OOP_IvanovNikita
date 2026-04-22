using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_IvanovNikita
{
    public  class Õpetaja : Isik, ITööline, IHindaja
    {
        public string Aine { get; set; }

        public double Tunnitasu { get; set; }

        public int Tunnidkuus { get; set; }

        public Õpetaja() : base()
        {

        }

        public Õpetaja(string nimi, string aine, int tunnitasu) : base(nimi)
        {
            Nimi = nimi;
            Aine = aine;
            Tunnitasu = tunnitasu;
        }


        //public TööTüüp VäljamakseTüüp { get; set; } = TööTüüp.Palk;

        public void Õpeta()
        {
            Console.WriteLine($"{Nimi} õpetab ainet: {Aine}.");
        }
        public override string Kirjelda()
        {
            return $"Mina olen õpetaja {Nimi} ja ma õpetan: {Aine}.";
        }

        public double ArvutaPalk()
        {
            return Tunnitasu * Tunnidkuus;
        }
        public void Hinda(string hinne)
        {
            Console.WriteLine(hinne);
        }
    }
}
