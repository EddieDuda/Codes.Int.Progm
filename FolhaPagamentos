using System;
class Folha_Pagamentos {
  static void Main() {
    string Nome;
    double Num_Inscricao;
    double SalarioHExtras,SalarioBruto,INSS,SalarioLiquido;
    double SalarioHNormais = 1200;
    double Classe = 1;
    
    Console.WriteLine ("Digite o seu nome:");
    Nome = Console.ReadLine();
    
    Console.WriteLine ("Digite seu número de inscrição:");
    Num_Inscricao = double.Parse(Console.ReadLine());
    
    SalarioHExtras = SalarioHNormais * 0.3;
    
    SalarioBruto = (SalarioHNormais + SalarioHExtras) * 1.3;
    
    INSS = SalarioBruto * 0.11;
    
    SalarioLiquido = SalarioBruto - INSS;
    
    Console.WriteLine($"Número de incrição: {Num_Inscricao}");
    Console.WriteLine($"Nome: {Nome}");
    Console.WriteLine($"Sálario Horas Normais: {SalarioHNormais}");
    Console.WriteLine($"Salário Horas Extras: {SalarioHExtras}");
    Console.WriteLine($"Dedução INSS: {INSS}");
    Console.WriteLine($"Salário Liquído: {SalarioLiquido}");
  }
}
