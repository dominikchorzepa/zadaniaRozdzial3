using System;
class Program7
{
    static void Main(string[] args)
    {
        //zad 3.7
        Console.WriteLine("Wpisz nr dnia tygodnia");
        int dzien = int.Parse(Console.ReadLine());

        switch (dzien)
        {
            case 1:
                Console.WriteLine("Poniedzialek");
                break;
            case 2:
                Console.WriteLine("Wtorek");
                break;
            case 3:
                Console.WriteLine("Sroda");
                break;
            case 4:
                Console.WriteLine("Czwartek");
                break;
            case 5:
                Console.WriteLine("Piatek");
                break;
            case 6:
                Console.WriteLine("Sobota");
                break;
            case 7:
                Console.WriteLine("Niedziela");
                break;
            default:
                Console.WriteLine("Nie ma takiego dnia tygodnia!");
                break;
        }
    }
}
