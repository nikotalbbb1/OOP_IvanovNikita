using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_IvanovNikita
{
    public class Üliõpilane : Õpilane
    {
        public string Eriala { get; set; }

        public int Kursus { get; set; }

        public Õppevorm Staatus { get; set; }

        public override void Kirjelda()
        {
            Console.WriteLine($"{Nimi} õpib {Eriala}s. {Kursus} kursusel  Vorm: {Staatus}");
        }
    }
}
