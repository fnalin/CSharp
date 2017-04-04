using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1;
            array1 = new int[5];
            array1[0] = 1;
            array1[1] = 2;
            array1[2] = 3;
            array1[3] = 4;
            array1[4] = 5;
            //array1[5] = 6; Estoura uma exceção

            Console.WriteLine("Primeiro item do array1: " + array1[0]);

            var array2 = new int[3] { 1, 2, 3 };
            Console.WriteLine("Segundo item do array2: " + array1[1]);

            //Forma mais usada
            string[] nomes = { "Fabiano", "Priscila", "Raphael"};
            Console.WriteLine("Último nome: " + nomes[nomes.Length-1]);

            //Arrays Multidimensionais
            var array3 = new int[,] { { 1,2,3}, {4,5,6 } };
            Console.WriteLine("array3[0,1:]" + array3[0,0]);

            //Jagged --> Irregular
            int[][] jaggedArray = new int[2][];
            jaggedArray[0] = new int[] { 1, 2, 3, 4 };
            jaggedArray[1] = new int[] { 2, 3, 4 };

            Console.ReadLine();
        }
    }
}
