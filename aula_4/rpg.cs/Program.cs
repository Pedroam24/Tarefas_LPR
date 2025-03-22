using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("*************************");
        Console.WriteLine("SEJA BEM VINDO");
        Console.WriteLine("*************************");
        Console.WriteLine("Escolha um personagem para seguir a aventura");
        Console.WriteLine("1 - Guerreiro");
        Console.WriteLine("2 - Mago");
        Console.WriteLine("3 - Arqueiro");
        Console.Write("Digite o número aqui: ");
        
        int classe = int.Parse(Console.ReadLine());
        
        
        if (classe == 1) 
        {
            Console.WriteLine("Habilidades do Guerreiro:");
            Console.WriteLine("- Ataque Pesado");
            Console.WriteLine("- Defesa Total");
            Console.WriteLine("- Rastreamento: pode achar seus inimigos em qualquer lugar");    

        }
        else if (classe == 2) 
        {
            Console.WriteLine("Habilidades do Mago:");
            Console.WriteLine("- Bola de Fogo");
            Console.WriteLine("- Você não passará!: habilidade suprema de defesa do mago");
        }
        else if (classe == 3) 
        {
            Console.WriteLine("Habilidades do Arqueiro:");
            Console.WriteLine("- Tiro Preciso");
            Console.WriteLine("- Disparo triplo");  
            Console.WriteLine("- Audição apurada");    
  
        }
        else 
        {
            Console.WriteLine("Escolha errada :(");
        }
    }
}
