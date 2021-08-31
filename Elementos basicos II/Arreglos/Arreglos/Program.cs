using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Parentesco = new string[4];
            Parentesco[0] = "Abuelo";
            Parentesco[1] = "Mamà";
            Parentesco[2] = "Abuela";
            Parentesco[3] = "Hermana";

            string[] nombres = new string[4];
            Parentesco[0] = "Gonzalo";
            Parentesco[1] = "Lorena";
            Parentesco[2] = "Maria";
            Parentesco[3] = "Abigail";

            int[] edad = new int[4];
            edad[0] = 56;
            edad[1] = 35;
            edad[2] = 56;
            edad[3] = 10;

            for (int i = 0; i < Parentesco.Length; i++)
            {
                Console.WriteLine(" Parentesco {0}: {1} ", i, Parentesco[i]);
            }
            for (int i = 0; i < Parentesco.Length; i++)
            {
                Console.WriteLine(" Parentesco {0}: {1} ", i, Parentesco[i]);
            }
            Array.Sort(edad);
            for (int i = 0; i < edad.Length; i++)
            {
                Console.WriteLine(" edad {0}: {1} ", i, edad[i]);
            }
            Console.ReadKey();
        }

    }
}