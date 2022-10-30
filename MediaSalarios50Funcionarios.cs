//Lista de Exercícios – Vetores e Matrizes
//Questão 3:

using System;

namespace 50Funcionarios
{ 
  public class TestOneArray
  {  
    static void Main()
    {
       int[] Salarios = new int[50]; 
       int QuantidadeFuncionarios = 50;
       int SomaSalarios = 0;
       double MediaSalarios;
        
        Console.WriteLine("Olá, por favor digite o sálario dos funcionarios:");
       for(int i = 0; i < QuantidadeFuncionarios; i++){
          Salarios[i] = int.Parse(Console.ReadLine());
          //Console.Write("{0}\t", Salarios[i]);
          SomaSalarios = SomaSalarios + Salarios[i];
       }
        MediaSalarios = SomaSalarios / QuantidadeFuncionarios;
        for(int i = 0; i < QuantidadeFuncionarios; i++){
          if (Salarios[i] > MediaSalarios)
          Console.Write($"\nEsse sálario {Salarios[i]} é maior do que a média:{MediaSalarios}\n");
       }
       
       
    }
  }
}
