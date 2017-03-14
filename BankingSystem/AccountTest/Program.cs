using BankingModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hago esto para que salga en rojo
            string nombre1 = "Jaime Huaman";
            int edad = 21;
            Account micuenta = new Account();
            micuenta.Name = "Victor Monzón";
            micuenta.Edad = 21;

            Console.WriteLine("Este es el nombre = {0} y esta es la edad = {1}", micuenta.Name, micuenta.Edad);

            Account micuenta2 = new Account("Enzo Velarde",20);

            Console.WriteLine("Este es el nombre = {0} y esta es la edad = {1}", micuenta2.Name, micuenta2.Edad);
            micuenta2.Name = nombre1;
            micuenta2.Edad= edad;

            Console.WriteLine("Este es el nombre = {0} y esta es la edad = {1}", micuenta2.Name, micuenta2.Edad);
        }
    }
}
