using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Expendedora
    {
        private List<Lata> latas;
        private string proveedor;
        private int capacidad;
        private double dinero;
        private bool encendida;

        public List<Lata> Latas { get => latas; set => latas = value; }
        public string Proveedor { get => proveedor; set => proveedor = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
        public double Dinero { get => dinero; set => dinero = value; }
        public bool Encendida { get => encendida; set => encendida = value; }

        public Expendedora(string proveedor, int capacidad, double dinero, bool encendida)
        {
            this.latas = new List<Lata>();
            this.proveedor = proveedor;
            this.capacidad = capacidad;
            this.dinero = dinero;
            this.encendida = encendida;
        }

        

        public void AgregarLata(Lata latas)
        {
            //agregar validaciones
            if ((latas.Codigo != "CO1") && (latas.Codigo != "CO2") && (latas.Codigo != "SP1") && (latas.Codigo != "SP2") && (latas.Codigo != "FA1") && (latas.Codigo != "FA2"))
                throw new Exception("Ingrese un código valido");

            this.latas.Add(latas);
        }

        public Lata ExtraerLata(string c, double d)
        {
            if ((c != "CO1") && (c != "CO2") && (c != "SP1") && (c != "SP2") && (c != "FA1") && (c != "FA2"))
                throw new Exception("Ingrese un código valido");

            Lata lata = this.latas.SingleOrDefault(x => x.Codigo == c);//Guardo en memoria una lata con codigo igual al ingresado, es decir, c 

            if (lata != null)
            {
                //**************************************
                if (d<lata.Precio)
                    throw new Exception("El dinero no es suficiente");

                //***************************************
                this.Dinero = this.Dinero + d;

                this.latas.Remove(lata);

                return lata;//PREGUNTA: porque debe retornar un objeto lata?

            }
            else
            {
                throw new Exception("No hay stock para su pedido. ");
            }

        }

        public string GetBalance()
        {

            return Convert.ToString(this.Dinero);
        }

        public int GetCapacidadRestante()
        {
            //return this.capacidad;
            return latas.Count;
        }

        public void EncenderMaquina()
        {

        }

        public bool EstaEncendida()
        {
            return this.encendida;
        }

        
    
    }
}
