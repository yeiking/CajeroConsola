using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroConsola
{
    public class Program
    {
        static void Main(string[] args)


        {
            Console.WriteLine("CAJERO WEB 2.0. || " + DateTime.Now + "\n");
            Console.WriteLine("Selecciona una opcion:" + "\n");
            Console.WriteLine("1. Search client." + "\n" + "2. Register client." + "\n" + "3. Charge without registering." + "\n");

            DatosCajero operacion = new DatosCajero();

            int op;
            op = int.Parse(Console.ReadLine());


            switch (op)
            {
                case 1:

                    operacion.BuscarDni();
                    operacion.BuscarProducto();

                    break;
                case 2:
                    operacion.RegistrarCliente();

                    break;
                case 3:
                    operacion.BuscarProducto();
                    break;

                default:
                    Console.WriteLine("Oye! oprime una opcion correcta. Hasta Pronto!");
                    break;

            }

            Console.ReadKey();
        }
    }
}
