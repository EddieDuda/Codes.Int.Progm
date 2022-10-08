using System;
class Conjunto_Impar_Par {
  static void Main() {
    int impares = 0, pares = 0;
    float numero = 0;  
    
    Console.WriteLine("Digite os numeros presentes no seu conjunto \nPara parar de adicionar ao conjunto digite -1");
    
    while (numero != -1){
        Console.WriteLine("Digite um numero inteiro");
        numero = float.Parse(Console.ReadLine());
        
        if(numero == -1){
            break;
        }
        else if(numero % 2 == 0){
            pares++;
        }else{
            impares++;
        }
    }
    
    Console.WriteLine($"A quantidade de numeros pares é {pares}");
    Console.WriteLine($"A quantidade de numeros impares é {impares}");
    
  }
}
