using System;
class Program3
{
    static void Main(string[] args)
    {
        //zad 3.3
        int a, b, c;
        int max;
        Console.WriteLine("Podaj 3 liczby: ");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        max = a;
        if (b > max)
        {
            max = b;
        }
        if (c > max)
        {
            max = c;
        }
        Console.WriteLine($"najwieksza z liczb to {max}");
        /*if(a >= b && a >= c)
        {
            Console.WriteLine($"{a} jest najwieksza liczba");
        } else if(b >= a && b >= c)
        {
            Console.WriteLine($"{b} jest najwieksza liczba");
        } else if(c >= a && c >= b)
        {
            Console.WriteLine($"{c} jest najwieksza liczba");
        }*/
    }
}
