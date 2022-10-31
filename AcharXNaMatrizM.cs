//Lista de Exercícios – Vetores e Matrizes
//Questão 7:
using System;
public class MatrizM  {  
    public static void Main() {
    
    int i,j,X = 0;
  	int[,] M = new int[3,5];
    Random rnd = new Random(10);
 
       for(i = 0; i < 3; i++){
           
       for(j = 0; j < 5; j++){
        M[i,j] = rnd.Next(100);
      }
    }  
  
    Console.Write("\nA matriz é:\n");
    
    for(i = 0; i < 3; i++){
        Console.Write("\n");
        for(j = 0; j<5;j++)
            Console.Write($"{M[i,j]}\t");
    }
    
    Console.Write("\nPor favor, digite o número que quer pesquisar na matriz:\n ");
    
    X = int.Parse(Console.ReadLine());
    
    bool numeroEncontrado = false;
    int pseudoI = 0;
    int pseudoJ = 0;
    
    for (i = 0; i <3; i++){
        for (j = 0; j <5; j++){
            if(X == M[i,j]){
                pseudoI = i + 1;
                pseudoJ = j + 1;
                numeroEncontrado = true;
                break;
            }
        }
        if (numeroEncontrado) break;
    }
    
    if (numeroEncontrado) Console.WriteLine($"O numero {X} foi encontrado na {pseudoJ}° coluna na {pseudoI}° linha da matriz");
    else Console.WriteLine($"O numero {X} não está na matriz.");
  }  
}
