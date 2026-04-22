using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace OOP_IvanovNikita
{
    public class Koolihaldus
    {
        // Kapseldatud list
        private List<Isik> inimesed = new List<Isik>();



        public void LisaInimene2(List<Isik> uuedInimesed)
        {
            inimesed.AddRange(uuedInimesed);
            foreach (var isik in inimesed)
            {
                Console.WriteLine($"{uuedInimesed}");
            }
        }

        public void LisaInimene(Isik isik)
        {
            inimesed.Add(isik);
        }

        public void KuvaKõik()
        {
            Console.WriteLine("\n--- KOOLI NIMEKIRI ---");
            foreach (var isik in inimesed)
            {
                // Polümorfism teeb siin imesid! 
                // C# teab ise, kas käivitada Õpetaja või Õpilase Kirjelda() meetod.
                isik.Kirjelda();
            }
        }
        public void OtsiNimeJärgi(string otsitavNimi)
        {
            foreach (var isik in inimesed)
            {
                if (otsitavNimi == isik.Nimi)
                {
                    isik.Kirjelda();
                }
            }
        }
        public void Otsi(int sünniaasta)
        {
            Console.WriteLine($"\nOtsime kedagi, kes on sündinud aastal: {sünniaasta}");
            // Siin eeldame, et lisasime Isik klassile ka Sünniaasta tagasi
            foreach (var isik in inimesed)
            {
                if (sünniaasta == isik.Sünniaasta)
                {
                    isik.Kirjelda();
                }
            }
        }
        public void SalvestaFaili(string failinimi)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(failinimi))
                {
                    foreach (Isik isik in inimesed)
                    {
                        writer.WriteLine(isik.Kirjelda());
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Viga faili kirjutamisel: " + ex.Message);
            }
        }
    }
}
