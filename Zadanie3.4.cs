using System;
class Program4
{
    static void Main(string[] args)
    {
        //zad 3.4
        double a, b;
        string x;
        Console.WriteLine("Podaj dwie liczby: ");
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());

        do
        {
            Console.WriteLine("Co chcesz z nimi zrobic(+ - * /)? Wpisz 'n' jesli chcesz przerwac");
            x = (Console.ReadLine());
            switch (x)
            {
                case "+":
                    Console.WriteLine($"{a} + {b} = {a + b}");
                    break;
                case "-":
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    break;
                case "*":
                    Console.WriteLine($"{a} * {b} = {a * b}");
                    break;
                case "/":
                    Console.WriteLine($"{a} / {b} = {a / b}");
                    break;
                default:
                    if (x != "n")
                    {
                        Console.WriteLine("Podales zly operator.");
                    }
                    break;
            }
        } while (x != "n");
    }
}
