using System;
class HelloWorld {
  static void Main() {
      int a,b,c;
    Console.WriteLine("Podaj bok a:");
    a = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj bok b:");
    b = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj bok c:");
    c = int.Parse(Console.ReadLine());
    if (a*a+b*b == c*c)
    {
        Console.WriteLine("Da się stworzyć trójkąt prostokątny");
    }
    else
    {
        Console.WriteLine("Nie da się stworzyć trójkąta prostokątnego");
    }
    
  }
}