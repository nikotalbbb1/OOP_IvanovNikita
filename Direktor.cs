using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_IvanovNikita
{
    public class Direktor : Õpetaja
    {
        public double Lisatasu { get; set; }
        
        public virtual double ArvutaPalk()
        {
            return base.ArvutaPalk()+Lisatasu;
        }

    }


    
}
