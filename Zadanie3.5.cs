using System;
class Program5
{
    static void Main(string[] args)
    {
        //zad 3.5
        int a, b, c, delta;
        Console.WriteLine("Podaj wspolczynniki rownania a, b, c: ");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        delta = (b * b) - (4 * a * c);
        Console.WriteLine(delta);
        if (delta > 0)
        {
            Console.WriteLine("Rownanie ma dwa pierwiastki");
        }
        else if (delta == 0)
        {
            Console.WriteLine("Rownanie ma jeden pierwiastek");
        }
        else
        {
            Console.WriteLine("Rownanie nie ma pierwiastkow");
        }
    }
}
