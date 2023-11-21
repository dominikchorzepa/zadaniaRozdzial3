using System;
class Program10
{
    static void Main(string[] args)
    {
        //zad 3.10
        int n, silnia = 1;

        Console.WriteLine("Program obliczajacy silnie n!");
        Console.WriteLine("Podaj z jakiej liczby chcesz obliczyc silnie: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            silnia *= i;
        }
        Console.WriteLine($"Silnia = {silnia}");
    }
}
