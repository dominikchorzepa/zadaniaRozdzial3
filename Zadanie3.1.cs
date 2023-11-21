using System;
class Program1
{
    static void Main(string[] args)
    {
        //zad 3.1
        int rok;
        Console.WriteLine("Podaj mi rok sprawdze, czy jest przestepny: ");
        rok = int.Parse(Console.ReadLine());
        if (rok % 4 == 0 && rok % 100 != 0)
        {
            Console.WriteLine($"{rok} jest przestepny");
        }
        else if (rok % 400 == 0)
        {
            Console.WriteLine($"{rok} jest przestepny");
        }
        else
        {
            Console.WriteLine($"{rok} nie jest przestepny");
        }
    }
}
