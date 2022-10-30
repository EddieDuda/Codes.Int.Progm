//Lista de Exercícios – Vetores e Matrizes
//Questão 6:
using System;  
public class 2Vetores2Sequencias {  
    public static void Main() {
	int[] B = new int[10];
	
	   
      Console.WriteLine( "Olá usuário");
       int i;
       int[] A = new int[10]; 
       Console.WriteLine( "Digite, por favor, 10 números inteiros:");
       for(i = 0; i < 10; i++){
       A[i] = int.Parse(Console.ReadLine());
       }
    for(i=0; i<10; i++){
        B[i] = A[i];
    }

    Console.Write("\nA Primeira sequência é:\n");
    for(i=0; i<10; i++){
        Console.Write("{0}  ", A[i]);
    }
    Console.Write("\n\nA segunda sequência:\n");
    for(i=0; i<10; i++){
        Console.Write("{0}  ", B[i]);
    }
	       Console.Write("\n\n");
  }
}
