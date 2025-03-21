// See https://aka.ms/new-console-template for more information
using System;

class Program {
    static void Main() {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("DESCOBRINDO SE O NÚMERO É PAR!!!");
        Console.WriteLine("---------------------------------");
        Console.Write("Digite um número: ");
        int number = int.Parse(Console.ReadLine());

        // se a divisão por dois der zero, o numero e par
        if (number % 2 == 0){
            Console.Write(number + " é par");
        }
        else{
            Console.Write(number + " é ímpar");
        }

    }
}

