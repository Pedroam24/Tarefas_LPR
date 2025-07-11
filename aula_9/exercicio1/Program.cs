namespace exercicio1;
    using System;
    using System.Collections.Generic;


internal class Program
{
    static void Main(string[] args)
    {
          Dictionary <string, int> alunos = new Dictionary<string, int> {
            { "Pedro", 17 }, {"Gigi", 18 }, {"luis", 20}, {"Maria", 18}
            };

        double media = alunos.Values.Sum() / (double)alunos.Count;

        Console.WriteLine("A média de idade dos alunos é: " + media);

        int maisVelho = 20, maisNovo = 17;
        foreach (var aluno in alunos)
        {

           /* if (aluno.Value > media)
            {    
                Console.WriteLine("PARA MAIORES QUE A MEDIA");
                Console.WriteLine($" Aluno: {aluno.Key}, idade: {aluno.Value}");
            }
            else if (aluno.Value < media)
            {
                Console.WriteLine("PARA MENORES QUE A MEDIA");
                Console.WriteLine($" Aluno: {aluno.Key}, idade: {aluno.Value}");
            }*/
            if (aluno.Value == maisVelho)
            {
                Console.WriteLine("O aluno mais velho é: " + aluno.Key + " com " + aluno.Value + " anos.");
            }
            else if (aluno.Value == maisNovo)
            {
                Console.WriteLine("O aluno mais novo é: " + aluno.Key + " com " + aluno.Value + " anos.");
            }
            
        }

        

    }//fim do main
}
