using System;
class Program2
{
    static void Main(string[] args)
    {
        //zad 3.2
        int a, b;
        Console.WriteLine("Podaj dwie liczby calkowite: ");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        if (a % b == 0)
        {
            Console.WriteLine($"Liczba {b} jest dzielnikiem {a}");
        }
        else
        {
            Console.WriteLine($"Liczba {b} nie jest dzielnikiem {a}");
        }
    }
}
