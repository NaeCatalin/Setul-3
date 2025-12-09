//Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector.
//Cel mai putin semnificativ coeficient este pe pozitia zero in vector.
//Se cere valoarea polinomului intr-un punct x. 


using System;

class Program
{
    static void Main()
    {
        // Citirea gradului polinomului
        Console.Write("Introdu gradul polinomului n: ");
        int n = int.Parse(Console.ReadLine());

        double[] coef = new double[n + 1];

        // Citirea coeficienților
        for (int i = 0; i <= n; i++)
        {
            Console.Write($"Coeficientul a[{i}]: ");
            coef[i] = double.Parse(Console.ReadLine());
        }

        // Citirea punctului x
        Console.Write("Introdu punctul x: ");
        double x = double.Parse(Console.ReadLine());

        // Evaluarea polinomului folosind metoda lui Horner
        double valoare = coef[n]; // incepem de la coeficientul cel mai semnificativ
        for (int i = n - 1; i >= 0; i--)
        {
            valoare = valoare * x + coef[i];
        }

        // Afișarea rezultatului
        Console.WriteLine($"Valoarea polinomului in punctul x={x} este: {valoare}");
    }
}
