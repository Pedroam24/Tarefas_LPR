// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
class program {
    static void Main()
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
        //Console.WriteLine(numeros[2]);
        numeros.Add(4);
        Console.Write(numeros[5]);
        numeros.Insert(1, 7);
        bool contem8 = numeros.Contains(8);
        Console.WriteLine(contem8);
        int i = 0;

        foreach (int maior in numeros)
        {

            if (maior > 4)
            {
                Console.WriteLine(i);
                i++;
            }

        }
        i = 0;
        foreach (int vezes in numeros)
        {
            if (vezes == 3)
            {
                i++;
                Console.WriteLine("o 3 aparece " + i);

            }

        }
        numeros.RemoveAt(2);
        Console.WriteLine(numeros[2]);
    }
 }
 
//7. Remover o número 2
//8. Remover todos os números 4

