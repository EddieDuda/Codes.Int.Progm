using System;
class Propriedade3025 {
  static void Main() {
    int numero, n1, n2, soma, multiplicacao;
    
    Console.WriteLine("Olá, digite um numero entre 1000 e 9999");
    numero = int.Parse(Console.ReadLine());
    
    n1 = numero/100;
    n2 = numero%100;
    soma = n1 + n2;
    multiplicacao = soma * soma;
  
    
    if (multiplicacao == numero) {
        Console.WriteLine("Esse numero possui a mesma propriedade que 3025");
    }
    else{
        Console.WriteLine("Esse numero não possui a mesma propriedade que  3025");
    }    
  }
}
