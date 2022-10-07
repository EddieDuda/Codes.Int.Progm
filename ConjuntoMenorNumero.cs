using System;
class MenorNumero {
  static void Main() {
    int menornumero = 100000;
    int numero = 1;  
    
    Console.WriteLine("Digite os números do seu conjunto: \nPara parar de adicionar números ao conjunto digite 0");
    
    while (numero != 0){
        Console.WriteLine("Digite um número inteiro");
        numero = int.Parse(Console.ReadLine());
        
        if(numero == 0){
            break;
        }
        else if(numero < menornumero){
            menornumero = numero;
        }
    }
    
    Console.WriteLine($"o menor numero do conjunto é {menornumero}"); 
    
  }
}
