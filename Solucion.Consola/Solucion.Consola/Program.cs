using Solucion.LibreriaConsola;
using Solucion.LibreriaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            bool _encendida = true;
            string menu = "1) Ingresar Lata \n2) Extraer Lata \n3) Obtener Balance \n4) Mostrar Stock \nX) Apagar";
            string pantalla = "CO1 - Coca Cola Regular \nCO2 - Coca Cola Zero \nSP1 - Sprite Regular \nSP2 - Sprite Zero \nFA1 - Fanta Regular \nFA2 - Fanta Zero";
            Expendedora expend = new Expendedora("Coca-Cola", 3, 0, _encendida);

            do
            {
                Console.WriteLine("*********************************************");
                Console.WriteLine("                                     _       ");
                Console.WriteLine("  ___ ___   ___ __ _        ___ ___ | | __ _ ");
                Console.WriteLine(@" / __/ _ \ / __/ _` |_____ / __/ _ \| |/ _` |");
                Console.WriteLine("| (_| (_) | (_| (_| |_____| (_| (_) | | (_| |");
                Console.WriteLine(@" \___\___/ \___\__,_|      \___\___/|_|\__,_|");
                Console.WriteLine();

                Console.WriteLine(menu);
                Console.WriteLine();
                Console.WriteLine("*********************************************");
                Console.Write("Elija una opción: ");
                
                try
                {
                    string opcionSeleccionada = Console.ReadLine();

                    if (ConsolaHelper.EsOpcionValida(opcionSeleccionada, "1234X"))
                    {
                        if (opcionSeleccionada.ToUpper() == "X")
                        {
                            _encendida = false;
                            continue;
                        }
                        switch (opcionSeleccionada)
                        {
                            case "1":
                                Console.WriteLine();
                                Console.WriteLine(pantalla);
                                Console.WriteLine();
                                Program.IngresarLata(expend);
                                break;

                            case "2":
                                Console.WriteLine();
                                Console.WriteLine(pantalla);
                                Console.WriteLine();
                                Program.ExtraerLata(expend);
                                break;

                            case "3":
                                Console.WriteLine();
                                Program.ObtenerBalance(expend);
                                break;

                            case "4":
                                Console.WriteLine();
                                Program.MostrarStock(expend);
                                break;

                            default:
                                Console.WriteLine();
                                Console.WriteLine("Opcion invalida");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Opción inválida.");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error durante la ejecución del comando. Por favor intente nuevamente. Mensaje: " + ex.Message);
                }
                
                Console.WriteLine("Ingrese una tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            }
             while (_encendida);

            Console.WriteLine("Ud. seleccionó Apagar. Ingrese una tecla para continuar");
            Console.ReadKey();
        }

        private static void IngresarLata(Expendedora expendedora)
        {
            try
            {
                string c = ConsolaHelper.PedirString("código");
                double p = ConsolaHelper.PedirDouble("precio");
                double v = ConsolaHelper.PedirDouble("volumen");

                Lata lat = new Lata(c, p, v);
                expendedora.AgregarLata(lat);
                Console.WriteLine("Lata ingresada");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en uno de los datos ingresados. " + ex.Message + " Intente nuevamente. \n\n");
                //IngresarLata(expendedora);
            }
        
        }

        private static void ExtraerLata(Expendedora expendedora)
        {
            try
            {
                string c = ConsolaHelper.PedirString("código");
                double d = ConsolaHelper.PedirDouble("dinero");

                expendedora.ExtraerLata(c, d);
                Console.WriteLine("Retire su pedido. ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //ExtraerLata(expendedora);
            }
        }

        private static void ObtenerBalance(Expendedora expendedora)
        {
            Console.WriteLine("El monto acumulado es de $"+expendedora.GetBalance()+". La cantidad de latas son: "+expendedora.GetCapacidadRestante()+" latas");
        }

        private static void MostrarStock(Expendedora expendedora)
        {
            foreach (Lata item in expendedora.Latas)
            {
                string ficha = string.Format("{0} - {1} / $/L {2}", item.Nombre, item.Sabor, item.GetPrecioPorLitro());
                Console.WriteLine(ficha);
            }
            
        }
    }
}
