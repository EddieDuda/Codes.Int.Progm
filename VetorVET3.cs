//Lista de Exercícios – Vetores e Matrizes
//Questão 4: Leia dois vetores VET1 e VET2, ambos com 10 elementos cada, sendo que só devem ser aceitos valores em ordem crescente. Após gere e imprima o vetor VET3, resultado da intercalação de VET1 e VET2.
using System;

namespace VET3
{ 
  public class TestOneArray
  {  
    static void Main()
    {
       

    int[] VET1 = {1,2,3,4,5,6,7,8,9,10};
    int[] VET2 = {20,21,22,23,24,25,26,27,28,29}; 
    int[] VET3 = new int[20];    
       for (int i = 0, j = 0; i < 10; i++) {
           VET3[j++] = VET1[i];
           Console.WriteLine($"Os elementos do vetor VET3 são: { VET3[j-1]}");    
           VET3[j++] = VET2[i];
            Console.WriteLine($"Os elementos do vetor VET3 são: { VET3[j-1]}");
        }
        
    }
  }
}
