using System;
class Posto_Gasolina {
  static void Main() {
     string Nome;
     float Valor1,Valor2,Valor3,Media;
        
        Console.WriteLine ("Digite seu nome:");
        Nome = Console.ReadLine();
        
        Console.WriteLine ("Digite valor no primeiro posto:");
        Valor1 = float.Parse(Console.ReadLine());
        
        Console.WriteLine ("Digite valor no segundo posto:");
        Valor2 = float.Parse(Console.ReadLine());
        
        Console.WriteLine ("Digite valor no terceiro posto:");
        Valor3 = float.Parse(Console.ReadLine());
        
        Media = (Valor1 + Valor2 + Valor3) / 3;
        
        Console.WriteLine($"O valor médio da gasolina nos postos em salvador é de: {Media}");
  }
}
