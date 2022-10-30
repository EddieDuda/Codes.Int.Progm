//Lista de Exercícios – Vetores e Matrizes
//Questão 5:
using System;
class valorN {
  static void Main() {
    int i = 0, N = 0, posicao = 0;
    int[] vetor = new int[100];
    Console.WriteLine($"Olá usuario ");
    for(i = 0; i < 10; i++){
        Console.WriteLine($"Por Favor digite o {i + 1}° elemento do vetor");
        vetor[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("\nAgora digite um numero inteiro:");
    N = int.Parse(Console.ReadLine());
    
    for (i = 0; i <= 10; i++){
        if(N == vetor[i]){
            posicao = i;
            Console.WriteLine( $"\nO numero {N} está presente no vetor e sua posição é {posicao}");
            break;
        }
    }
    if(posicao != i){
        Console.WriteLine($"\nQue pena, numero o {N} não está presente no vetor");
    }
  }
}
