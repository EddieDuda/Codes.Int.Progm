//Lista de Exercícios – Vetores e Matrizes
//Questão 7:
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
        for (i = 0; i <3; i++){
        for (j = 0; j <5; j++){
          if(X == M[i,j]){
            Console.WriteLine($"O numero {X} foi encontrado na {j + 1}° coluna na {i + 1}° linha da matriz");
            break;
              }else{
               Console.WriteLine($"O numero {X} não está na matriz.");
               break;
               }
        }
    }
  }  
}
