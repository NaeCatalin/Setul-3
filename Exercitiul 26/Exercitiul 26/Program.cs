//Se dau doua numere naturale foarte mari
//(cifrele unui numar foarte mare sunt stocate intr-un vector - fiecare cifra pe cate o pozitie).
//Se cere sa se determine suma, diferenta si produsul a doua astfel de numere. 


using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    // Adunarea a două numere mari
    static List<int> Add(List<int> a, List<int> b)
    {
        List<int> result = new List<int>();
        int n = a.Count;
        int m = b.Count;
        int carry = 0;

        int i = n - 1;
        int j = m - 1;

        while (i >= 0 || j >= 0 || carry != 0)
        {
            int sum = carry;
            if (i >= 0) sum += a[i--];
            if (j >= 0) sum += b[j--];
            result.Add(sum % 10);
            carry = sum / 10;
        }

        result.Reverse();
        return result;
    }

    // Scăderea a două numere mari (a >= b)
    static List<int> Subtract(List<int> a, List<int> b)
    {
        List<int> result = new List<int>();
        int n = a.Count;
        int m = b.Count;
        int borrow = 0;

        int i = n - 1;
        int j = m - 1;

        while (i >= 0)
        {
            int diff = a[i] - borrow - (j >= 0 ? b[j] : 0);
            if (diff < 0)
            {
                diff += 10;
                borrow = 1;
            }
            else
            {
                borrow = 0;
            }
            result.Add(diff);
            i--;
            j--;
        }

        result.Reverse();

        // Eliminăm zerourile de la început
        while (result.Count > 1 && result[0] == 0)
            result.RemoveAt(0);

        return result;
    }

    // Înmulțirea a două numere mari
    static List<int> Multiply(List<int> a, List<int> b)
    {
        int n = a.Count;
        int m = b.Count;
        int[] prod = new int[n + m];

        for (int i = n - 1; i >= 0; i--)
        {
            int carry = 0;
            for (int j = m - 1; j >= 0; j--)
            {
                int temp = prod[i + j + 1] + a[i] * b[j] + carry;
                prod[i + j + 1] = temp % 10;
                carry = temp / 10;
            }
            prod[i] += carry;
        }

        List<int> result = prod.ToList();

        // Eliminăm zerourile de la început
        while (result.Count > 1 && result[0] == 0)
            result.RemoveAt(0);

        return result;
    }

    static void Main()
    {
        // Citirea primului număr
        Console.Write("Introdu primul numar foarte mare: ");
        string s1 = Console.ReadLine().Trim();
        List<int> num1 = s1.Select(c => c - '0').ToList();

        // Citirea celui de-al doilea număr
        Console.Write("Introdu al doilea numar foarte mare: ");
        string s2 = Console.ReadLine().Trim();
        List<int> num2 = s2.Select(c => c - '0').ToList();

        // Suma
        List<int> suma = Add(num1, num2);
        Console.WriteLine("Suma: " + string.Join("", suma));

        // Diferența (presupunem num1 >= num2)
        List<int> diferenta = Subtract(num1, num2);
        Console.WriteLine("Diferenta: " + string.Join("", diferenta));

        // Produsul
        List<int> produs = Multiply(num1, num2);
        Console.WriteLine("Produs: " + string.Join("", produs));
    }
}
