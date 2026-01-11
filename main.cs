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
    if(a+b>c && a+c>b && b+c>a)
    {
        Console.WriteLine("Da się stworzyć trójkąta");
    }
    else
    {
        Console.WriteLine("Nie da się stworzyć trójkąta");
    }
    
  }
}