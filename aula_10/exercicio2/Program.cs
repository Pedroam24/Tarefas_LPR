using Microsoft.VisualBasic;

namespace exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salario info = new Salario();
            Console.WriteLine("Entre com o seu nome: ");
            info.nome = Console.ReadLine();
            Console.WriteLine("Entre com a sua renda: ");
            info.renda = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o seu imposto atual: ");
            double imposto = double.Parse(Console.ReadLine());

            info.Metodo1();

        }
    }
}
