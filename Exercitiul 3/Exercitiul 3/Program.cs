//Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai
//mare element al vectorului.
//Pentru extra-credit realizati programul efectuand 3n/2 comparatii
//(in cel mai rau caz). 

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("n =");
        int n = int.Parse(Console.ReadLine());

        int[] v = new int[n];
        Console.WriteLine("Introduceti elementele vectorului:");
        for (int i = 0; i < n; i++)
            v[i] = int.Parse(Console.ReadLine());

        int min = v[0], max = v[0];
        int minPos = 0, maxPos = 0;
        
        for (int i = 1 ; i < n; i++) 
        {
            
            if (v[i] <min)
            {
                min = v[i];
                minPos = i;
            }
            else if (v[i] > max)
            {
                max = v[i];
                maxPos = i;
            }
        }
        Console.WriteLine("Pozitia minima:" + minPos);
        Console.WriteLine("Pozitia Maxima:" + maxPos);

    }
}
