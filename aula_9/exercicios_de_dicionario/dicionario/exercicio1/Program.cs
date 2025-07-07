namespace exercicio1;
    using System;
    using System.Collections.Generic;   
    

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> alunos = new Dictionary<string, int> { 
            { "Pedro", 17 }, {"Gigi", 18 }, {"luis", 20}, {"Maria", 18}  
            };

            double media = alunos.Values.Sum() / (double)alunos.Count;
           Console.WriteLine("A média de idade dos alunos é: " + media);
        foreach (var students in alunos.Values)
        {
            if (students > media)
            {
                Console.WriteLine(alunos.Key + " é maior que a média de ideade de alunos.");
            }
            else
            {
                Console.WriteLine(alunos.Key + " é menor que a média de idade dos alunos.");
            
        }
        }//fim do main
    }

