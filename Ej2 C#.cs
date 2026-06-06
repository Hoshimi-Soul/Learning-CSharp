using System;
class HelloWorld
{
  static void Main() 
  {
    Random random = new Random();
    
    int vidademuñeco = 50;
    
    Console.WriteLine("Aparece un muñeco de entrenamiento");
    Console.ReadLine();
    
    while (vidademuñeco >0)
    {
        int dañojugador = random.Next(5, 16);
        int critico = random.Next(1,11);
        
        if (critico == 8)
        {
            Console.WriteLine("\n¡Das un golpe critico!");
            dañojugador *= 2;
        }
        
        vidademuñeco -= dañojugador;
        
        Console.WriteLine("\nPegas al muñeco de entrenamiento por: " + dañojugador);
        
        if (vidademuñeco >0)
        {
            Console.WriteLine("\nLa vida del muñeco de entrenamiento es: " + vidademuñeco);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("\nLa vida del muñeco de entrenamiento es 0");
        }
        
    }
    
    Console.WriteLine("\n¡Derrotaste al muñeco de entrenamiento!");
    
  }
}