using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluxos
{
    class Program
    {
        static void Main(string[] args)
        {
            //if else
            var campeaoDosCampeoes = "Corinthians";
            if (campeaoDosCampeoes == "Corinthians")
            {
                Console.WriteLine("campeaoDosCampeoes está corretíssima");
            }
            else {
                Console.WriteLine("campeaoDosCampeoes está errada");
            }

            //if else if else
            Console.WriteLine("\n\n\n ------------");
            campeaoDosCampeoes = "Parmeira";
            if (campeaoDosCampeoes == "Corinthians")
            {
                Console.WriteLine("campeaoDosCampeoes está corretíssima");
            }
            else if (campeaoDosCampeoes == "Parmeira")
            {
                Console.WriteLine("Não tem mundial!");
            }
            else
            {
                Console.WriteLine("campeaoDosCampeoes está errada");
            }

            Console.WriteLine("\n\n\n ------------");
            //switch
            campeaoDosCampeoes = "São Paulo";
            switch (campeaoDosCampeoes)
            {
                case "Corinthians":
                    Console.WriteLine("campeaoDosCampeoes está corretíssima");
                    Console.WriteLine("...");
                    Console.WriteLine("...");
                    break;
                case "Parmeira":
                    Console.WriteLine("Não tem mundial!");
                    break;
                case "São Paulo":
                    Console.WriteLine("Na na ni nanão");
                    break;
                default:
                    Console.WriteLine("campeaoDosCampeoes está errada");
                    break;
            }

            //Ternário
            Console.WriteLine("\n\n\n ------------");
            Console.WriteLine(campeaoDosCampeoes=="Corinthians"?"Tá certo":"Tá errado");



            Console.ReadLine();
        }
    }
}
