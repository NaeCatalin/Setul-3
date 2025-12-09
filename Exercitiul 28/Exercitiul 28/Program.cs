//Quicksort. Sortati un vector folosind metoda QuickSort. 

using System;

class Program
{
    static void Main()
    {
        // Citirea dimensiunii vectorului
        Console.Write("Introdu dimensiunea vectorului: ");
        int n = int.Parse(Console.ReadLine());

        int[] v = new int[n];

        // Citirea elementelor
        Console.WriteLine("Introdu elementele vectorului:");
        for (int i = 0; i < n; i++)
            v[i] = int.Parse(Console.ReadLine());

        // Apelarea QuickSort
        QuickSort(v, 0, n - 1);

        // Afișarea vectorului sortat
        Console.WriteLine("Vectorul sortat este:");
        Console.WriteLine(string.Join(" ", v));
    }

    static void QuickSort(int[] v, int st, int dr)
    {
        if (st < dr)
        {
            int p = Partition(v, st, dr); // poziția pivotului
            QuickSort(v, st, p - 1);      // sortăm partea stângă
            QuickSort(v, p + 1, dr);      // sortăm partea dreaptă
        }
    }

    static int Partition(int[] v, int st, int dr)
    {
        int pivot = v[dr];  // pivotul este ultimul element
        int i = st - 1;

        for (int j = st; j < dr; j++)
        {
            if (v[j] <= pivot)
            {
                i++;
                (v[i], v[j]) = (v[j], v[i]);  // swap
            }
        }

        // mutăm pivotul la locul lui
        (v[i + 1], v[dr]) = (v[dr], v[i + 1]);
        return i + 1;
    }
}

