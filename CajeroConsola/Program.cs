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
            Console.WriteLine("1. Buscar cliente." + "\n" + "2. Registrar cliente." + "\n" + "3. Cobrar sin registrar." + "\n" + "4. Clientes Registrados." + "\n");

            DatosCajero operacion = new DatosCajero();

            int op;
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    
                        operacion.BuscarDni();

                    break;
                case 2:
                    Console.WriteLine("Vamos");
                    break;
                case 3:
                    Console.WriteLine("Asi esta bien");
                    break;
                case 4:
                    Console.WriteLine("Terminamos");
                    break;
                default:
                    Console.WriteLine("Oye! oprime una opcion correcta. Hasta Pronto!");
                    break;

            }

            Console.ReadKey();
        }
    }
}
