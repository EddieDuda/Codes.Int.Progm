using System;
class ConverterReal {
  static void Main() {
    double real, dolar, libra, euro;
    int converter;
    Console.WriteLine("Insira o valor em real:");
    real = double.Parse(Console.ReadLine());
    Console.WriteLine("Deseja converter para: 1-Dolar, 2-Euro, 3-Libra");
    converter = int.Parse(Console.ReadLine());
    
    switch(converter){
        case 1:
            dolar = real / 4.00;
            Console.WriteLine($"{dolar} dolares");
            break;
        case 2:
            euro = real / 4.72;
            Console.WriteLine($"{euro} euros");
            break;
        case 3:
            libra = real / 6.15;
            Console.WriteLine($"{libra} libras");
            break;
        default:
            Console.WriteLine("converção não disponivel"); 
            break;
    }
  }
}
