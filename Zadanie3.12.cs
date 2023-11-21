using System;
class Program12
{
    static void Main(string[] args)
    {
        //zad 3.12
        int liczba, suma = 0;
        do
        {
            Console.WriteLine("Podaj liczbe (jesli podasz 0 zakoncze sumowanie): ");
            liczba = int.Parse(Console.ReadLine());
            suma += liczba;
        } while (liczba != 0);
        Console.WriteLine($"Suma wynosi: {suma}");
    }
}

