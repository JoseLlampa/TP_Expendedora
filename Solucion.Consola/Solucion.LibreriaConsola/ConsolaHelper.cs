using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaConsola
{
    public static class ConsolaHelper
    {
        public static string PedirString(string msg)
        {
            bool bandera = false;
            string n;
            Console.Write("Ingrese " + msg +": ");
            n = Console.ReadLine();
            
            do
            {
                bandera = false;
                if ((n != "CO1") && (n != "CO2") && (n != "SP1")&& (n != "SP2") && (n != "FA1") && (n != "FA2"))
                {
                    Console.Write("Ingrese un "+msg+" válido: ");
                    n = Console.ReadLine();
                    bandera = true;
                }
                
            } 
            while (bandera);

            return n;
            
        }

        public static int PedirInt(string msg)
        {
            Console.Write("Ingrese " + msg + ": ");

            // se puede validar algo o usar tryparse  o dejar que lo haga el framework
            int c = int.Parse(Console.ReadLine());


            return c;
        }

        public static DateTime PedirFecha(string msg)
        {
            Console.WriteLine("Ingrese fecha " + msg + " solo en este formato YYYY-MM-DD");

            // se puede validar fechas inexistentes o dejar que lo haga el framework
            DateTime f = Convert.ToDateTime(Console.ReadLine());

            return f;
        }

        //devuelve si la validacion está bien o no
        public static bool EsOpcionValida(string input, string opcionesValidas)
        {
            // manejamos expciones
            try
            {
                // validamos algo
                if (string.IsNullOrEmpty(input)  // es nulo o vacío
                    || input.Length > 1          // tiene más de un caracter       
                    || !opcionesValidas.ToUpper().Contains(input.ToUpper())) // no está dentro de las opciones válidas
                {
                    return false;
                }

                return true;
            }
            // podemos capturar más exceptions asi mostramos errpores más personalizados
            // en este caso no nos importa arrojar una ex porque decidimos que el método devuelva T o F
            catch
            {
                // podemos mostrar un error

                return false;
            }
        }

        public static double PedirDouble(string msg)
        {
            Console.Write("Ingrese " + msg + ": ");

            // se puede validar algo o usar tryparse  o dejar que lo haga el framework
            double c = double.Parse(Console.ReadLine());


            return c;
        }

    }
}
