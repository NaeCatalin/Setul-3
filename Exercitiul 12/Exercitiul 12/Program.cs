//Sortare selectie. Implementati algoritmul de sortare <Selection Sort>. 

using System;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        int[] vector = new int[n];

        Console.WriteLine("Introduceti elementele vectorului:");
        for (int i = 0; i < n; i++)
        {
            vector[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (vector[j] < vector[minIndex])
                {
                    minIndex = j;
                }
            }
            // Schimbare elemente
            int temp = vector[i];
            vector[i] = vector[minIndex];
            vector[minIndex] = temp;
        }
        Console.WriteLine("Vectorul sortat este:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(vector[i] + " ");
        }
    }
}
            
