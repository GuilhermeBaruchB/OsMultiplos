using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual numero voce deseja ver os múltiplos");
            int numero = int.Parse(Console.ReadLine());


            for (int i = numero; i <= 100; i += numero)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
