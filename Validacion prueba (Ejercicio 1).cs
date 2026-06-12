using System;
class HelloWorld 
{
  static void Main() 
  {

    int nivel; 
    while (!int.TryParse(Console.ReadLine(), out nivel)|| nivel <=0)
    {
        Console.WriteLine("Nivel invalido");
        
        Console.WriteLine("Por favor escriba su nivel: " );
        
        
    }
    
    if (nivel >= 1 && nivel <5)
    {
        Console.WriteLine("Novato");
    }
    else if (nivel >=5 && nivel <=10)
    {
        Console.WriteLine("Aventurero");
    }
    else if (nivel >=11 && nivel <=20)
    {
        Console.WriteLine("Guerrero");
    }
    else if (nivel >= 21)
    {
        Console.WriteLine("Leyenda");
    }
    else
    {
        Console.Write("");
    }
    
  }
}