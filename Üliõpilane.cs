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

        public override string Kirjelda()
        {
            return $"{Nimi} õpib {Eriala}s {Kursus} kursusel  Vorm: {Staatus}";
        }
    }
}
