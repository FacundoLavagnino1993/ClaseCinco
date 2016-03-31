using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Auto 
    {
        public Rueda RuedaUno;
        public Rueda RuedaDos;
        public Rueda RuedaTres;
        public Rueda RuedaCuatro;
        public static string fecha; 

        static Auto()
        {
            Auto.fecha = (new DateTime()).ToString();
        }

        public Auto(string marca)
        {
            this.marca = marca;

        }

         private string marca;
    }
}
