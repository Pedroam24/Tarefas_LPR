using System;
using System.Collections.Generic;
class program
{
    static void Main()
    {
        List<string> nomes = new();

        Console.WriteLine("digite a quantidade de nomes da sua lista: ");
        int quant = int.Parse(Console.ReadLine());

        for (int i = 0; i <= quant; i++)
        {
            Console.WriteLine("Digite o " + i + 1 + "° nome ");
            nomes.Add(Console.ReadLine()); 
            

        }
            


    }
}