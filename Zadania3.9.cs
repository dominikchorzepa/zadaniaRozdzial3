using System;
class Program9
{
    static void Main(string[] args)
    {
        //zad 3.9
        int a;
        Console.WriteLine("Podaj liczbe wierszy: ");
        a = int.Parse(Console.ReadLine());

        for (int i = 1; i <= a; i++)
        {
            for (int j = 5; j > i; j--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
