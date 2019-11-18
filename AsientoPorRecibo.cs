using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    class AsientoPorRecibo
    {


        private Asiento asiento;

        public  Asiento Asiento
        {
            get { return asiento; }
            set { asiento = value; }
        }
        private Reserva reserva;

        public  Reserva Reserva
        {
            get { return reserva; }
            set { reserva = value; }
        }
        private List <Aperitivo> aperitivos  ;

        public AsientoPorRecibo(Asiento asiento, Reserva reserva, List<Aperitivo> aperitivos)
        {
            Asiento = asiento;
            Reserva = reserva;
            Aperitivos = aperitivos;
        }

        public List<Aperitivo> Aperitivos
        {
            get { return aperitivos; }
            set { aperitivos = value; }
        }





    }
}
