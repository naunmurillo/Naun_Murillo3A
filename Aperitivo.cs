using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    class Aperitivo
    {
        public Aperitivo(int nombre)
        {
            Nombre = nombre;
        }

        private int nombre;

        
        public int Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        


    }
}
