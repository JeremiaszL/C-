using System;

class program

{
    static void Main()
    {
        Console.Write("Podaj promień: ");
        double r = double.Parse(Console.ReadLine());
        double pole = 3.14 * r * r;
        double obwod = 2 * 3.14 * r;
        Console.WriteLine("Pole koła: ");
        Console.WriteLine(pole);
        Console.WriteLine("Obwód koła: ");
        Console.WriteLine(obwod);
    }
}