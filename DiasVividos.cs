using System;
class Dias_Vividos {
  static void Main() {
     string Nome;
     float Idade,Dias;
        
        Console.WriteLine ("Digite seu nome:");
        Nome = Console.ReadLine();
        
        Console.WriteLine ("Digite sua idade:");
        Idade = float.Parse(Console.ReadLine());
       
        Dias = Idade * 365;
        
        Console.WriteLine($"{Nome} você viveu {Dias} dias na Terra até agora.");
  }
}
