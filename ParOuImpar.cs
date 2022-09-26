using System;
class par_impar {
  static void Main() {
    int numero;
   
    Console.WriteLine("Digite um número");
    numero = int.Parse(Console.ReadLine());
    
    
    if ((numero%2 == 0)) {
        Console.WriteLine($"o numero {numero} é par");
    }
    else{
        Console.WriteLine($"o numero {numero} é impar");
    }    
  }
}
