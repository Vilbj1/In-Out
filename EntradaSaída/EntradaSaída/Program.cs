using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaSaída
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Maria e ");
            Console.WriteLine("Joao");

            //int letra = Console.Read();
            string texto = Console.ReadLine();

            Console.WriteLine(texto);
            
            Console.ReadKey();
        }
    }
}
