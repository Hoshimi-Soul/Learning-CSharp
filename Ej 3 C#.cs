using System;
class HelloWorld
{
  static void Main() 
  {
    int vidajugador = 100;
    int dañoenemigo = 71;
    
    vidajugador -= dañoenemigo;
    
    Console.WriteLine("El enemigo te golpea por: " +  dañoenemigo);
    Console.ReadLine();
    
    Console.WriteLine("Tu vida: " + vidajugador);
    Console.ReadLine();
    
    if (vidajugador <30)
    {
        vidajugador += 20;
        Console.WriteLine("Te curas con una pocion, tu vida: " + vidajugador);
    }
    
  }
}