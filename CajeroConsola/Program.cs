using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CAJERO WEB 2.0. || "+DateTime.Now+ "\n");
            Console.WriteLine("Selecciona una opcion:"+ "\n");
            Console.WriteLine("1. Buscar cliente." + "\n" + "2. Registrar cliente." + "\n" + "3. Cobrar sin registrar." + "\n" + "4. Clientes Registrados.");


            Console.ReadKey();
        }
    }
}
