using System;

namespace SelectionSort
{
    internal class Program
    {
        static void Main()
        {
            var vetor = new int[] { 4, 1, 5, 3, 2, 9, 7, 6, 8 };

            for (int i = 0; i < vetor.Length; i++)
            {
                var menor = i;

                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[j] < vetor[menor])
                    {
                        menor = j;
                    }
                }

                if (menor != i)
                {
                    int v = vetor[i];
                    int aux = v;

                    vetor[i] = vetor[menor];
                    vetor[menor] = aux;
                }
            }

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);
            }

            Console.ReadLine();
        }
    }
}
