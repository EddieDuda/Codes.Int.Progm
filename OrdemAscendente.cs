using System;
class ordem_ascend {
  static void Main() {
    int numero1, numero2;
    
    Console.WriteLine("Digite o primeiro numero");
    numero1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo numero");
    numero2 = int.Parse(Console.ReadLine());
    
    if (numero1 < numero2) {
        Console.WriteLine($"{numero1}, {numero2}");
    }
    else{
        Console.WriteLine($"{numero2}, {numero1}");
    }    
  }
}
