using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Linha1
             Linha2
             */

            //Como declarar variáveis
            //String
            string minhaString;
            minhaString = "Minha String";
            Console.WriteLine(minhaString);

            //int -> inteiros
            int v1 = 1;
            int v2, v3 = 3, v4;
            Console.WriteLine("Valor da v3: " + v3);

            //var
            var num1 = 1;

            //Boleano
            bool verdadeiro = true;
            Boolean falso = false;
            var flag = false;

            //Byte
            byte bMin = Byte.MinValue;
            byte bMax = byte.MaxValue;
            Console.WriteLine("Valor do bMin: " + bMin);
            Console.WriteLine("Valor do bMax: " + bMax);

            sbyte byteQualquer1 = sbyte.MinValue;
            sbyte byteQualquer2 = sbyte.MaxValue;
            Console.WriteLine("Valor do byteQualquer1: " + byteQualquer1);
            Console.WriteLine("Valor do byteQualquer2: " + byteQualquer2);

            //int
            var iMin = int.MinValue;
            var iMax = Int32.MaxValue;
            Console.WriteLine("Valor do iMin: " +  iMin);
            Console.WriteLine("Valor do iMax: " +  iMax);

            //long
            var lMin = long.MinValue;
            var lMax = Int64.MinValue;
            Console.WriteLine("Valor do lMin: " + lMin);
            Console.WriteLine("Valor do lMax: " + lMax);

            //short
            var int16Min = short.MinValue;
            var int16Max = Int16.MaxValue;
            Console.WriteLine("Valor do int16Min: " + int16Min);
            Console.WriteLine("Valor do int16Max: " + int16Max);


            //Decimal
            Console.WriteLine("\n\n---------- Números decimais --------\n");
            var fMin = float.MinValue;
            var fMax = Single.MaxValue;
            Console.WriteLine("Valor do fMin: " + fMin);
            Console.WriteLine("Valor do fMax: " + fMax);

            var dMin = decimal.MinValue;
            var dMax = Decimal.MaxValue;
            Console.WriteLine("Valor do dMin: " + dMin);
            Console.WriteLine("Valor do dMax: " + dMax);

            var doubleMin = double.MinValue;
            var doubleMax = Double.MaxValue;
            Console.WriteLine("Valor do doubleMin: " + doubleMin);
            Console.WriteLine("Valor do doubleMax: " + doubleMax);

            Console.WriteLine("\n\n---------- strings --------\n");
            var minhaString2 = "Minha string";
            Console.WriteLine("Valor da minhaString2: " + minhaString2);

            Console.WriteLine("\n\n---------- char --------\n");
            var cMin = char.MinValue;
            var cMax = Char.MaxValue;
            Console.WriteLine("Valor do cMin: " + cMin);
            Console.WriteLine("Valor do cMax: " + cMax);
            Console.WriteLine("Valor do cMin numérico: " + (int)cMax);

            Console.WriteLine("\n\n---------- Data --------\n");
            var dt = new DateTime(1979, 9, 12);
            Console.WriteLine("Valor do dt: " + dt);

            Console.WriteLine("\n\nFim da execução");
            Console.ReadLine();


        }
    }
}
