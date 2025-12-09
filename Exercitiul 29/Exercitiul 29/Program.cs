// MergeSort. Sortati un vector folosind metoda MergeSort.


using System;

class Program
{
    static void Main()
    {
        // Citirea dimensiunii vectorului
        Console.Write("Introdu dimensiunea vectorului: ");
        int n = int.Parse(Console.ReadLine());

        int[] v = new int[n];

        // Citirea elementelor vectorului
        Console.WriteLine("Introdu elementele vectorului:");
        for (int i = 0; i < n; i++)
            v[i] = int.Parse(Console.ReadLine());

        // Apelarea metodei MergeSort
        MergeSort(v, 0, n - 1);

        // Afisarea vectorului sortat
        Console.WriteLine("Vectorul sortat este:");
        Console.WriteLine(string.Join(" ", v));
    }

    static void MergeSort(int[] v, int st, int dr)
    {
        if (st < dr)
        {
            int mij = (st + dr) / 2;

            // Sortăm jumătatea stângă
            MergeSort(v, st, mij);

            // Sortăm jumătatea dreaptă
            MergeSort(v, mij + 1, dr);

            // Îmbinăm cele două jumătăți
            Merge(v, st, mij, dr);
        }
    }

    static void Merge(int[] v, int st, int mij, int dr)
    {
        int n1 = mij - st + 1;
        int n2 = dr - mij;

        int[] left = new int[n1];
        int[] right = new int[n2];

        // Copiem elementele în vectorii auxiliari
        for (int i = 0; i < n1; i++)
            left[i] = v[st + i];

        for (int j = 0; j < n2; j++)
            right[j] = v[mij + 1 + j];

        int p1 = 0, p2 = 0, k = st;

        // Interclasăm vectorii left și right în v
        while (p1 < n1 && p2 < n2)
        {
            if (left[p1] <= right[p2])
            {
                v[k++] = left[p1++];
            }
            else
            {
                v[k++] = right[p2++];
            }
        }

        // Copiem eventualele elemente rămase
        while (p1 < n1)
            v[k++] = left[p1++];

        while (p2 < n2)
            v[k++] = right[p2++];
    }
}

