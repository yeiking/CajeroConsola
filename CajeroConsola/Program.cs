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

            DBCajeroConsola db = new DBCajeroConsola();
            string CadenaDni;
            switch (Console.Read())
            {
                case '1':
                    Console.WriteLine("Ingresa el DNI:");
                    CadenaDni = Console.ReadLine();
                    
                    var searchDNI = from dni in db.TblCliente
                                    where dni.Dni == CadenaDni
                                    select dni;

                    foreach (var item in searchDNI)
                    {
                         
                        Console.WriteLine(item.Dni+" "+item.NombreCliente);
                    }

                        break;
                case '2':
                    Console.WriteLine("Vamos");
                    break;
                case '3':
                    Console.WriteLine("Asi esta bien");
                    break;
                case '4':
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
