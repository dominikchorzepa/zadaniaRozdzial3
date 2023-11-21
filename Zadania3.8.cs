using System;
class Program8
{
    static void Main(string[] args)
    {
        //zad 3.8
        double srednia;
        Console.WriteLine("Podaj swoja srednia ocen: ");
        srednia = double.Parse(Console.ReadLine());

        if (srednia >= 2 && srednia <= 3.99)
        {
            Console.WriteLine("Przysluguje ci 0.00zl stypendium.");
        }
        else if (srednia >= 4.00 && srednia <= 4.79)
        {
            Console.WriteLine("Przysluguje ci 350.00zl stypendium.");
        }
        else if (srednia >= 4.80 && srednia <= 5.00)
        {
            Console.WriteLine("Przysluguje ci 550.00zl stypendium.");
        }
        else
        {
            Console.WriteLine("Podales zbyt mala/duza srednia!");
        }
    }
}
