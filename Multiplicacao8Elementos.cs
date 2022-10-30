//Lista de Exercícios – Vetores e Matrizes
//Questão 1: Fazer um algoritmo que leia um vetor com 8 elementos, e imprima a multiplicação dos elementos lidos.
using System;

namespace Multiplicacao8Elementos
{ 
  public class TestOneArray
  {  
    static void Main()
    {
       int[] elementos = new int[8]; 
       int multiplicação = 1;
    Console.WriteLine( "Digite 8 números inteiros.");
       for(int i = 0; i < 8; i++){
          elementos[i] = int.Parse(Console.ReadLine());
          
          multiplicação = multiplicação * elementos[i];
       }

       Console.Write($"Essa é a  multiplicação dos elementos: {multiplicação}");
       
    }
  }
}
