using System;
class Sequencia_de_Fibonacci {
  static void Main() {
    int numeros, i;  
    int sequencia1 = 1, soma = 1, sequencia2 = 0;
    Console.WriteLine("Digite a quantidade de numeros da Sequencia de Fibonacci que você deseja descobrir:");
    numeros = int.Parse(Console.ReadLine());
    for (i = 1; i <= numeros; i++){
        
        Console.WriteLine(soma);        
        soma = sequencia1 + sequencia2;
        sequencia2 = sequencia1;
        sequencia1 = soma;
        
    }
    
  }
}
