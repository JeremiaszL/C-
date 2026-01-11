using System;
class HelloWorld {
  static void Main() {
   int n;
   Console.WriteLine("Podaj n");
   n = int.Parse(Console.ReadLine());
   
   int i = 0;
   int suma =0;
   
   while(i<n)
   {
       Console.WriteLine(i);
       suma += i;
       i++;
   }
   Console.WriteLine("suma 'i' wynosi");
   Console.WriteLine(suma);
  }
}