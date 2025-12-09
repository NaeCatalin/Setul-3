//Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>. 

using System;

class Program
{
    static void Main()
    {
        Console.Write("n =");
        int n = int.Parse(Console.ReadLine());

        int[] vector = new int[n];

        Console.WriteLine("Introduceti elementele vectorului:");
        for (int i = 0; i < n; i++)
        {
            vector[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 1; i < n; i++)
        {
            int key = vector[i];
            int j = i - 1;

            vector[j + 1] = vector[j];

            while (j >= 0 && vector[j] > key)
            {
                vector[j + 1] = vector[j];
                j--;
            }
        vector[j + 1] = key;
       

        }
        Console.WriteLine("Vector sortat este:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(vector[i] + " ");
        }


    }
}
