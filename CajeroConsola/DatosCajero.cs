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
            Console.WriteLine("Enter DNI:");
            string CadenaDni = Console.ReadLine();
            Console.WriteLine("----------CUSTOMER:----------");

            if (CadenaDni != null)
            {
                var searchDNI = from dni in db.TblCliente
                                where dni.Dni == CadenaDni
                                select dni;

                foreach (var item in searchDNI)
                {

                    Console.WriteLine("DNI:" + item.Dni + "\n" + "NAME:" + item.NombreCliente + "\n" + "-----------------------------");
                }
            }
        }

        public void BuscarProducto()
        {
            Console.WriteLine("Now write the product code:");
            string CadenaPro = Console.ReadLine();
            Console.WriteLine("----------PRODUCT:-----------");

            if (CadenaPro != null)
            {
                var searchPro = from cod in db.TblProducto
                                where cod.CodProducto == CadenaPro
                                select cod;

                foreach (var item in searchPro)
                {
                    Console.WriteLine("CODE:" + item.CodProducto + " " + "NAME:" + item.NombreProducto + "\n" + "TOTAL TO PAY:" + item.PrecioP + "\n" + "THANKS FOR YOUR PURCHASE!");
                }
            }
        }

        public void RegistrarCliente()
        {
            TblCliente AddCustumer = new TblCliente();
            Console.WriteLine("Write the customer's name:");
            string Name = Console.ReadLine();
            AddCustumer.NombreCliente = Name;

            Console.WriteLine("Write the customer's Dni:");
            string Dni = Console.ReadLine();
            AddCustumer.Dni = Dni;

            Console.WriteLine("Write the customer's phone number:");
            string Phone = Console.ReadLine();
            AddCustumer.Telefono = Phone;

            Console.WriteLine("Write the customer's address:");
            string Address = Console.ReadLine();
            AddCustumer.Direccion = Address;

            db.TblCliente.Add(AddCustumer);
            db.SaveChanges();

            Console.Write("Thanks for registering!");

        }


    }
}
