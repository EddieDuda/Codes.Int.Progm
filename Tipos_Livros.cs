using System;
class Tipos_Livros {
  static void Main() {
    int tipo, quantidades1 = 0, quantidades2 = 0, quantidades3 = 0, i = 0;
    double mficcao = 0, mromance = 0, maventura = 0, mtotal;
    double porcentagem;
    string genero;
    
    Console.WriteLine("Bem vindo a livraria!\nPor favor responda nossa pesquisa!");
    Console.WriteLine("OBS:Para acabar com a pesquisa escreva 0 no tipo de livro");
    
    while (i != 1){
        Console.WriteLine("Tipo de livro:\n1 - Ficção \n2 – Romance \n3 –Aventura");
        tipo = int.Parse(Console.ReadLine());
        
        if(tipo == 0){
            break;
        } else if(tipo == 1){
            quantidades1++;
        }else if(tipo == 2){
            quantidades2++;
        }else if(tipo == 3){
            quantidades3++;
        }
        
        Console.WriteLine("Digite seu gênero:\nm-masculino\nf-feminino)");
        genero = Console.ReadLine();
        
        if((genero == "m" || genero == "M") && tipo == 1){
            mficcao++;
        }else if((genero == "m" || genero == "M") && tipo == 2){
            mromance++;
        }else if((genero == "m" || genero == "M") && tipo == 3){
            maventura++;
        }
    }
    
    mtotal = maventura + mromance + mficcao;
    porcentagem = (mromance * 100)/mtotal;
   
    Console.WriteLine($"A porcentagem de pessoas do sexo masculino que compra o tipo romance é {porcentagem}%");
    
    if(quantidades1 > quantidades2 && quantidades1>quantidades3){
        Console.WriteLine("O numero de livros de ficção vendidos foi maior que os outros tipos");  
    }else if(quantidades2 > quantidades1 && quantidades2 > quantidades3){
        Console.WriteLine("O numero de livros de romance vendidos foi maior que os outros tipos");  
    }else if(quantidades3 > quantidades1 && quantidades3 > quantidades2){
        Console.WriteLine("O numero de livros de aventura vendidos foi maior que os outros tipos");  
    }else{
        Console.WriteLine("Todos os tipos venderam igualmente");  
    }

    
  }
}
