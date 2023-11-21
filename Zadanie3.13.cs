using System;
class Program13
{
    static void Main(string[] args)
    {
        //zad 3.13
        int n, suma = 0, znak = 1;
        Console.WriteLine("Podaj liczbe n: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            suma += znak * i;
            znak *= -1;
        }
        Console.WriteLine($"Suma szeregu dla n={n} wynosi: {suma}");
    }
}
