using System;
class Fatorial {
  static void Main() {
    int numero, i;  
    
    Console.WriteLine("Digite o numero para saber o seu fatorial");
    numero = int.Parse(Console.ReadLine());
    
    int produto = numero;
    for (i = numero - 1; i >= 1; i--){
        
        produto = produto * i;
        
    }
    
    Console.WriteLine($"O fatorial de {numero} é {produto}");
    
  }
}
