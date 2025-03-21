// See https://aka.ms/new-console-template for more information
using System;

class Program
{
        static void Main()
        {

                Console.WriteLine("Temos a classe Guerreira, Mago e arqueira");
                Console.WriteLine("Escolha um digitando aqui: ");
                Console.ReadLine();
                string Guerreira, Mago, arqueira; = string.Parse(Console.ReadLine());
                
                if (Guerreira)
                {
                        Console.WriteLine("entrou");

                }
                else if (Mago)
                {
                        Console.WriteLine("entrou");

                }
                else if (arqueira)
                {
                        Console.WriteLine("entrou");

                }
                else
                {
                        Console.WriteLine("Não encontrado");

                }


        }

}