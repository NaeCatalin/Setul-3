//Modificati un vector prin eliminarea elementelor care se repeta,fara a folosi un alt vector. 

using System;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        int[] v = new int[n];

        Console.WriteLine("Introdu elementele vectorului:");
        for (int i = 0; i < n; i++)
        {
            v[i] = int.Parse(Console.ReadLine());
        }

        int k = 0; 

        for (int i = 0; i < n; i++)
        {
            bool apare = false;

           
            for (int j = 0; j < k; j++)
            {
                if (v[i] == v[j])
                {
                    apare = true;
                    break;
                }
            }

            
            if (!apare)
            {
                v[k] = v[i];
                k++;
            }
        }

        Console.WriteLine("Vectorul fara elemente duplicate este:");
        for (int i = 0; i < k; i++)
        {
            Console.Write(v[i] + " ");
        }
    }
}
