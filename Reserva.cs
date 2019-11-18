using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    class Reserva
    {
        

        private int numero;

      
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        private string fecha;

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private Cliente cliente;

        public  Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        private List<AsientoPorRecibo> asientos;

        public List<AsientoPorRecibo> Asientos
        {
            get { return asientos; }
            set { asientos = value; }
        }

        private float total;

        public Reserva(int numero, string fecha, Cliente cliente, List<AsientoPorRecibo> asientos, float total)
        {
            Numero = numero;
            Fecha = fecha;
            Cliente = cliente;
            Asientos = asientos;
            Total = total;
        }

        public float Total
        {
            get { return total; }
            set { total = value; }
        }
        


    }
}
