using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {

            //Conversão implícita
            int a = 1;// int.MaxValue;
            long b;
            b = a;
            //a = b; --> erro de compilação
            Console.WriteLine("Valor da a: " + a);

            //Conversão explícita
            Int16 c = (short)a;

            //Convert
            string possivelInt = "123";
            int count = Convert.ToInt32(possivelInt);

            //TryParse
            Console.WriteLine("\nDigite um número");
            int numero = 0;
            if (int.TryParse(Console.ReadLine(),out numero))
            {
                Console.WriteLine("Você digitou o número: " + numero);
            }
            else
            {
                Console.WriteLine("Vc não digitou um número");
            }


            Console.ReadLine();

        }
    }
}
