using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulandoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Code smell - strings são imutáveis
            string endereco = "Rua X";
            endereco = endereco + ", 123";
            endereco += ", Centro";
            Console.WriteLine(endereco);

            //Boa prática
            Console.WriteLine("\n\n --------------------\n\n");
            var novoEndereco = new StringBuilder("Rua xpto");
            novoEndereco.Append(", 123");
            novoEndereco.Append(", Centro");
            Console.WriteLine(novoEndereco);

            Console.ReadLine();
        }
    }
}
