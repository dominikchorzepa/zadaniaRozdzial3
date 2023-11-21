using System;
class Program6
{
    static void Main(string[] args)
    {
        //zad 3.6
        double waga, wzrost, bmi;
        Console.WriteLine("Podaj swoja wage(kg): ");
        waga = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj swoj wzrost(m): ");
        wzrost = double.Parse(Console.ReadLine());
        bmi = waga / (wzrost * wzrost);
        Console.WriteLine($"Twoje BMI wynosi: {bmi}");

        if (bmi < 18.5)
        {
            Console.WriteLine("Niedowaga");
        }
        else if (bmi > 18.5 && bmi < 24.99)
        {
            Console.WriteLine("Wartosc prawidlowa");
        }
        else if (bmi >= 25)
        {
            Console.WriteLine("Nadwaga");
        }
    }
}
