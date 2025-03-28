
using System;
class program
{
   static void Main()
   {
    int soma = 0, num, result;
    Console.Write("Digite um número:");
    num = int.Parse(Console.ReadLine());
    result = num * num;
    Console.WriteLine("o número ao quadrado é:" + result);
    while (result > 0)
    {
    soma+=result % 10;
    result/=10;
    }
    Console.WriteLine("A soma de cada algaritimo do seu numero elevado ao quadrado é: "+ soma);
  }
}