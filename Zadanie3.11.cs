using System;
class Program11
{
    static void Main(string[] args)
    {
        //zad 3.11
        int suma = 0, ile = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (suma <= 100)
            {
                suma += i;
                ile++;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine($"Nalezy dodac do siebie {ile} liczb.");
    }
}

