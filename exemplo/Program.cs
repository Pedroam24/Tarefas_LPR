// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
class program
{
    static void Main()
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
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
        Console.WriteLine("número que ficou no lugar 2: " + numeros[2]);

        foreach (int num in numeros)
        {
            numeros.Remove(4);
            Console.WriteLine("números presente na lista" + numeros[1] + numeros[2] + numeros[3] + numeros[4] + numeros[5] + numeros[6]);

            
        }
    }
   
 
        
    

    
 }
 

//8. Remover todos os números 4

