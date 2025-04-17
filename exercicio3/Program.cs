using System;
using System.Net;
using System.Runtime.CompilerServices;

class aula7
{
    
    static void Main()
    {
        string nome1= "",nome2="",nome3="",nome4="",nome5="",poder1="",poder2="",poder3="",poder4="",poder5="";
     int escolha = 0, ponto1 = 0,ponto2 = 0,ponto3 = 0,ponto4 = 0,ponto5 = 0, pontuacaoTotal = 0, x = 0;

       menuPrincipal( ref  nome1,ref  nome2,ref  nome3,ref  nome4,ref  nome5,ref  poder1,ref  poder2,
            ref  poder3,ref  poder4,ref  poder5,  ref ponto1, ref ponto2, ref ponto3, ref ponto4, ref ponto5, ref  pontuacaoTotal, ref x, ref escolha);
    }

    static void CadastrarHeroi(ref string nome1,ref string nome2,ref string nome3,
    ref string nome4,ref string nome5,ref string poder1,ref string poder2,
    ref string poder3,ref string poder4,ref string poder5, ref int ponto1, 
    ref int ponto2, ref int ponto3, ref int ponto4, ref int ponto5)
    {
       
        Console.WriteLine("=== Cadastro dos Heróis ===");

        Console.Write("Nome do herói 1: ");
        nome1 = Console.ReadLine();
        Console.Write("Poder: ");
        poder1 = Console.ReadLine();
        Console.Write("Pontuação: ");
        ponto1 = int.Parse(Console.ReadLine());

        Console.Write("Nome do herói 2: ");
        nome2 = Console.ReadLine();
        Console.Write("Poder: ");
        poder2 = Console.ReadLine();
        Console.Write("Pontuação: ");
        ponto2 = int.Parse(Console.ReadLine());

        Console.Write("Nome do herói 3: ");
        nome3 = Console.ReadLine();
        Console.Write("Poder: ");
        poder3 = Console.ReadLine();
        Console.Write("Pontuação: ");
        ponto3 = int.Parse(Console.ReadLine());

        Console.Write("Nome do herói 4: ");
        nome4 = Console.ReadLine();
        Console.Write("Poder: ");
        poder4 = Console.ReadLine();
        Console.Write("Pontuação: ");
        ponto4 = int.Parse(Console.ReadLine());

        Console.Write("Nome do herói 5: ");
        nome5 = Console.ReadLine();
        Console.Write("Poder: ");
        poder5 = Console.ReadLine();
        Console.Write("Pontuação: ");
        ponto5 = int.Parse(Console.ReadLine());

    }

static void SelecionarEquipe(ref string nome1,ref string nome2,ref string nome3,
    ref string nome4,ref string nome5,ref string poder1,ref string poder2,
    ref string poder3,ref string poder4,ref string poder5, ref int ponto1, 
    ref int ponto2, ref int ponto3, ref int ponto4, ref int ponto5, ref int pontuacaoTotal, ref int escolha){
     Console.WriteLine("\n=== Selecione sua equipe (3 heróis) ===");

        for (int i = 1; i <= 3; i++)
        {
            
            Console.Write($"Digite o número do herói #{i}: ");
             escolha = int.Parse(Console.ReadLine());

            Console.WriteLine("**Herói escolhido:**");

            if (escolha == 1){
                Console.WriteLine($"{nome1} - {poder1} - Pontuação: {ponto1}");
            pontuacaoTotal += ponto1;
            }
            else if (escolha == 2){
                Console.WriteLine($"{nome2} - {poder2} - Pontuação: {ponto2}");
              pontuacaoTotal += ponto2;
              }
            else if (escolha == 3){
                Console.WriteLine($"{nome3} - {poder3} - Pontuação: {ponto3}");
              pontuacaoTotal += ponto3;
              }
            else if (escolha == 4){
                Console.WriteLine($"{nome4} - {poder4} - Pontuação: {ponto4}");
              pontuacaoTotal += ponto4;
              }
            else if (escolha == 5){
                Console.WriteLine($"{nome5} - {poder5} - Pontuação: {ponto5}");
              pontuacaoTotal += ponto5;
              }
             else
                Console.WriteLine("Herói inválido.");
             
        }
}
    static void calcularPontuacaoTotal(ref int pontuacaoTotal){
        Console.WriteLine("pontuação total da sua esquipe é de: "+pontuacaoTotal);
    }
    static void exibirEquipe(ref string nome1,ref string nome2,ref string nome3,
    ref string nome4,ref string nome5,ref string poder1,ref string poder2,
    ref string poder3,ref string poder4,ref string poder5, ref int ponto1, 
    ref int ponto2, ref int ponto3, ref int ponto4, ref int ponto5, ref int pontuacaoTotal, ref int escolha ){
         
         if (escolha == 1)
                Console.WriteLine($"{nome1} - {poder1} - Pontuação: {ponto1}");

            else if (escolha == 2)
                Console.WriteLine($"{nome2} - {poder2} - Pontuação: {ponto2}");

            else if (escolha == 3)
                Console.WriteLine($"{nome3} - {poder3} - Pontuação: {ponto3}");
 
            else if (escolha == 4)
                Console.WriteLine($"{nome4} - {poder4} - Pontuação: {ponto4}");
  
            else if (escolha == 5)
                Console.WriteLine($"{nome5} - {poder5} - Pontuação: {ponto5}");
 
        calcularPontuacaoTotal(ref pontuacaoTotal);

    }
    static void menuPrincipal(ref string nome1,ref string nome2,ref string nome3,
    ref string nome4,ref string nome5,ref string poder1,ref string poder2,
    ref string poder3,ref string poder4,ref string poder5, ref int ponto1, 
    ref int ponto2, ref int ponto3, ref int ponto4, ref int ponto5, ref int pontuacaoTotal, ref int x, ref int escolha){
        
       do {
        Console.WriteLine("*****SEJA BEM VINDO AO MENU*****");
        Console.WriteLine("1-Cadastrar herói");
        Console.WriteLine("2-Escolher equipe");
        Console.WriteLine("3-Exibir tudo");
        Console.WriteLine("4-Sair");

        Console.WriteLine("\nDigite o numero para nos dizer qual parte voce que ir:");
       
        x = int.Parse(Console.ReadLine());
        if (x == 1){
            CadastrarHeroi(ref  nome1,ref  nome2,ref  nome3,ref  nome4,ref  nome5,ref  poder1,ref  poder2,
            ref  poder3,ref  poder4,ref  poder5,  ref ponto1, ref ponto2, ref ponto3 , ref ponto4, ref ponto5 );
        }
        else if (x == 2){
           SelecionarEquipe(ref  nome1,ref  nome2,ref  nome3, ref  nome4,ref  nome5,ref  poder1,ref  poder2,
             ref  poder3,ref  poder4,ref  poder5,  ref ponto1, ref ponto2, ref ponto3, ref ponto4, ref ponto5, ref  pontuacaoTotal,
             ref escolha);
           calcularPontuacaoTotal(ref pontuacaoTotal); 
        }
        else if (x == 3){
            exibirEquipe(ref  nome1,ref  nome2,ref  nome3,ref  nome4,ref  nome5,ref  poder1,ref  poder2,
            ref  poder3,ref  poder4,ref  poder5,  ref ponto1, ref ponto2, ref ponto3, ref ponto4, ref ponto5, ref  pontuacaoTotal,
             ref escolha);
        }

        if  (ponto1 == 0 && ponto2 == 0 && ponto3 == 0 && ponto4 == 0 && ponto5 == 0){
            Console.WriteLine("VOCÊ TEM QUE CADASTRAR O HERÓI PRIMEIRO EM 'CADASTRE O HERÓI'");
        }
        
        }while(x !=4);
        
    }

}
