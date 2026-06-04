using System;
class HelloWorld
{
  static void Main() 
  {
    Console.WriteLine("Te encuentras un cofre, ¿lo abres?");
    Console.Write("Presione 1 para abrirlo y 2 para ignorarlo ");
    
    int abrir = Convert.ToInt32(Console.ReadLine());
    
    if (abrir == 1)
    {
        Random random = new Random();
        int oro = random.Next(10,101);
        Console.WriteLine("Abres el cofre y encuentras " + oro + " de oro");
    }
    else
    {
        Console.WriteLine("Ignoras el cofre");
    }
    
  }
}