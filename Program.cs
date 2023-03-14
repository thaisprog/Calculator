using System;

namespace Program
{
  class Program 
  {

   static void Main(string[] args) 
   {
      Menu();
       
   }

   static void Menu () {

    Console.Clear();
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Multiplicação");   
    Console.WriteLine("5 - Sair");

    Console.WriteLine("------");
    Console.WriteLine("Selecione uma opção");

    short res = short.Parse(Console.ReadLine());

    switch(res) {

      case 1: Soma(); break;
      case 2: Subtracao(); break;
      case 3: Divisao(); break;
      case 4: Multiplicacao(); break;
      case 5: System.Environment.Exit(0); break; ///sair da aplicação.
      default: Menu(); break;

    }


   }

   static void Soma() {

       Console.Clear();
       Console.WriteLine("Primeiro Valor");
       float v1 = float.Parse(Console.ReadLine());

       Console.WriteLine("Segundo Valor");
       float v2 = float.Parse(Console.ReadLine());

       Console.WriteLine("");

       var resultado = v1 + v2;
       Console.WriteLine($"O Resultado da Soma é {resultado}");
       Console.ReadKey();

   }

   static void Subtracao() {
     Console.Clear();
     Console.WriteLine("Primeiro Valor");
     float v1 = float.Parse(Console.ReadLine());


     Console.WriteLine("Segundo Valor");
     float v2 = float.Parse(Console.ReadLine());

     Console.WriteLine("");

     float resultado = v1 - v2;
     Console.WriteLine($"O Resultado da Subtração é {resultado}");
     Console.ReadKey();


   }

   static void Divisao() {

  Console.Clear();
  Console.WriteLine("Primeiro Valor");
  float v1 = float.Parse(Console.ReadLine());

  Console.WriteLine("Segundo Valor");
  float v2 = float.Parse(Console.ReadLine());

  Console.WriteLine("");

  var resultado = v1 / v2;
  Console.WriteLine($"O resultado da divisão é  {resultado}");

   }


   static void Multiplicacao() {
    
    Console.Clear();
   
    Console.WriteLine("Primeiro valor:");
    float v1 =  float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo Valor:");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1 * v2;
    Console.WriteLine($"O resultado da multiplicação é {resultado}");
    Console.ReadKey();

   }
   
  }


}