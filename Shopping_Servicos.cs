using System;
class Shopping_Servicos {
  static void Main() {
    int idade, i = 0, objetivo, quantidadesf = 0, quantidadesm = 0;
    int compras = 0, servicos = 0, lazer = 0, alimentacao = 0, totalobjetivo;
    float porcentagem;
    string nome, sexo;
    
    Console.WriteLine("Bem vindo ao shopping! \nPor favor, responda nossa pesquisa!");
    Console.WriteLine("OBS:Para acabar com a pesquisa escreva fim ao inves de seu nome.");
    
    while (i != 1){
        Console.WriteLine("Digite seu nome:");
        nome = Console.ReadLine();
        if(nome == "fim"){
            break;
        }
        Console.WriteLine("Digite sua idade:");
        idade = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite seu genero: (masculino ou feminino)");
        sexo = Console.ReadLine();
        if(sexo == "masculino"){
            quantidadesm++;
        }else{
            quantidadesf++;
        }
        Console.WriteLine("Digite o código do  objetivo da sua visita:");
        Console.WriteLine("010 - Compras\n020 - Serviços (Banco, correio,etc.)\n030 -  Lazer (Cinema, jogos,etc.)\n040 -  Alimentação (restaurantes e lanchonetes)");
        objetivo = int.Parse(Console.ReadLine());
        
        if(objetivo == 010){
            compras++;
        }else if(objetivo == 020){
            servicos++;
        }else if(objetivo == 030){
            lazer++;
        }else if(objetivo == 040){
            alimentacao++;
        }
    }
    
    totalobjetivo = compras + servicos + lazer + alimentacao;
    porcentagem = (servicos * 100)/totalobjetivo;
    Console.WriteLine($"A porcentagem de pessoas que escolheu Serviços é {porcentagem}%.");
    
    if(quantidadesf > quantidadesm){
        Console.WriteLine("O numero de Mulheres frequentando o Shopping foi maior que o de Homens.");  
    }else{
        Console.WriteLine("O numero de Homens frequentando o Shopping foi maior que o de Mulheres.");  
    }

    
  }
}
