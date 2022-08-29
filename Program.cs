using System;

namespace lab2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[3, 3] { { 8, 6, 1 }, { 4, 6, 7 }, { 6, 3, 4 } };
            foreach(int i in numeros)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                {
                    numeros[i, j] = i * j;
                    Console.Write(numeros[i, j] + "");

                }
                Console.WriteLine();

            }
            string[,] paises = { { "El Salvador", "Guatemala", "" } { "", "", "" }, { "", "", "" } };
               
        }
    }
}
