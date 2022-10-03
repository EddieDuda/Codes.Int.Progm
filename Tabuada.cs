using System;
namespace SampleWhile
{
	public class Tabuada 
  {	
		static void Main(string[] args)
		{
      int numero, Produto, i;
      Console.WriteLine ("Digite um número inteiro:");
      numero = int.Parse(Console.ReadLine());
      
      for (i = 1; i <=10; i++){
      
       Produto = numero * i;
       Console.WriteLine ($"{Produto}");
      }  
  
	 
   } 
  }
}
