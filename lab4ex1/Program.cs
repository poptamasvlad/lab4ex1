using System;

namespace lab4ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Scrieti un program care va citi un vector de intregi de dimensiune n de la tastaura. Scrieti o
            functie care va inversa elementele vectorului, apelati-o si afisati-I rezultatul */

            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            for(int i = 0; i<n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Vectorul este: " + string.Join(" ", InversVector(n, vector)));

            static int[] InversVector(int n, int[] vector)
            {
                int[] vector2 = new int[n];
                int j = 0;
                for(int i = n-1; i>=0; i--)
                {
                    vector2[j] = vector[i];
                    j++;
                }

                return vector2;
            }

        }
    }
}
