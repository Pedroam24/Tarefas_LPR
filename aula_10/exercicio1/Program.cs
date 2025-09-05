namespace exercicio1
{
    internal class Program
    { //Fazer um programa para ler os valores da largura e altura de um retângulo.
      //Em seguida, mostrar na tela o valor de suaárea e perímetro.
      
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Digite a largura do retângulo: ");
            retangulo.l = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do retângulo: ");
            retangulo.a = float.Parse(Console.ReadLine());

            retangulo.Metodo1();
        }
    }
}
