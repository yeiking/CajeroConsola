using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroConsola
{
    public class DatosCajero
    {

        DBCajeroConsola db = new DBCajeroConsola();
        //string CadenaDni;
        public void BuscarDni()
        {
            Console.WriteLine("Ingresa el DNI:");
            string CadenaDni = Console.ReadLine();
            Console.WriteLine();

            if (CadenaDni != null)
            {
                var searchDNI = from dni in db.TblCliente
                                where dni.Dni == CadenaDni
                                select dni;

                foreach (var item in searchDNI)
                {

                    Console.WriteLine(item.Dni + " " + item.NombreCliente);
                }
            }
        }




    }
}
