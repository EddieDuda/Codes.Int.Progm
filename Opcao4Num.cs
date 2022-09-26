using System;
class  Opcao {
  static void Main() {
     int opcao, num1, num2, num3;
    Console.WriteLine("Olá, escolha entre o numero 1, 2 ou 3");
    opcao = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite um numero inteiro");
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite um numero inteiro");
    num2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite um numero inteiro");
    num3 = int.Parse(Console.ReadLine());
    
    
    switch (opcao) {
        case 1:
            Console.WriteLine($"Sua opção escolhida foi: {num1}");
            break;
        case 2:
            Console.WriteLine($"Sua opção escolhida foi: {num2}");
            break;
        case 3:
            Console.WriteLine($"Sua opção escolhida foi: {num3}");
            break;
        default:
            Console.WriteLine($"A opção desejada é inválida.");
            break;
    }
  }
}
