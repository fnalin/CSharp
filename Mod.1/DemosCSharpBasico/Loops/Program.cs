using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for
            Console.WriteLine("For...");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);
            }

            Console.WriteLine("\n\nFor c/ arrays");
            var nomes = new string[] { "Fabiano", "Priscila", "Raphael", "Isabel"};
            for (int batata = 0; batata < nomes.Length; batata++)
            {
                Console.WriteLine(nomes[batata]);
            }

            Console.WriteLine("\n\nForeach");
            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("\n\nWhile c/ arrays");
            //While (Enquanto)
            var contador = 0;
            while (contador< nomes.Length)
            {
                Console.WriteLine(nomes[contador]);
                contador += 1;
            }

            Console.WriteLine("\n\nDo c/ arrays");
            contador = 0;
            do
            {
                Console.WriteLine(nomes[contador]);
                contador++;
            } while (contador < nomes.Length);


            Console.ReadLine();
        }
    }
}
