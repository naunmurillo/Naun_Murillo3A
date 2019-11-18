using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    class Cliente
    {
        private string identificacion;

        public  string Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }

           
        }
        private  string nombre;

        public  string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private List<Reserva> reservas;

        public Cliente(string identificacion, string nombre, List<Reserva> reservas)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Reservas = reservas;
        }

        public  List<Reserva> Reservas
        {
            get { return reservas; }
            set { reservas = value; }
        }


    }
}
