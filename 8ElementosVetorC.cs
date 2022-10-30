//Lista de Exercícios – Vetores e Matrizes//
//Questão 2: Fazer um algoritmo que leia dois vetores A e B de 8 elementos cada um e calcula um terceiro vetor C, cujos elementos são resultado da soma dos elementos correspondentes de A e B.//
using System;

namespace VetorC
{ 
  public class TestOneArray
  {  
    static void Main()
    {
       int i;
       int[] A = new int[8]; 
       Console.WriteLine( "Digite 8 números inteiros para A.");
       for(i = 0; i < 8; i++){
       A[i] = int.Parse(Console.ReadLine());
       }
       
        int[] B = new int[8]; 
        Console.WriteLine( "Digite 8 números inteiros para B.");
        for( i = 0; i < 8; i++){
        B[i] = int.Parse(Console.ReadLine());
        } 
        
        int[] C = new int[8];
        for( i = 0; i < 8; i++){
        C[i] = A[i] + B[i];
        Console.WriteLine($"Os elementos do vetor C são: {C[i]}");    
        }

    }
  }
}
