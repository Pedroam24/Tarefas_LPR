using System;
using System.Net;
using System.Runtime.CompilerServices;

class aula7
{
    
    static void Main()
    {
        string nome1= "",nome2="",nome3="",nome4="",nome5="",poder1="",poder2="",poder3="",poder4="",poder5="", equipeNome1 ="", equipeNome2 = "", equipeNome3 = "", equipePoder1 = "", equipePoder2 = "", equipePoder3 = "";
     int escolha = 0, ponto1 = 0,ponto2 = 0,ponto3 = 0,ponto4 = 0,ponto5 = 0, pontuacaoTotal = 0, x = 0, equipePonto1 = 0, equipePonto2 = 0, equipePonto3 = 0;

       menuPrincipal(ref  nome1,ref  nome2,ref  nome3,ref  nome4,ref  nome5,ref  poder1,ref  poder2,
            ref  poder3 ,ref  poder4,ref  poder5,  ref ponto1, ref ponto2, ref ponto3, ref ponto4, ref ponto5, ref pontuacaoTotal, ref x, ref escolha, ref equipeNome1, ref equipeNome2, ref equipeNome3, ref equipePoder1, 
            ref equipePoder2, ref equipePoder3, ref equipePonto1, ref equipePonto2, ref equipePonto3);
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
    ref int ponto2, ref int ponto3, ref int ponto4, ref int ponto5, ref int pontuacaoTotal, ref int escolha,
    ref string equipeNome1, ref string equipeNome2,  ref string equipeNome3,  ref string equipePoder1,  ref string equipePoder2,
    ref string equipePoder3, ref int equipePonto1, ref int equipePonto2, ref int equipePonto3){
     Console.WriteLine("\n=== Selecione sua equipe (3 heróis) ===");

        for (int i = 1; i <= 3; i++)
        {
            
            Console.Write($"Digite o número do herói #{i}: ");
             escolha = int.Parse(Console.ReadLine());

            Console.WriteLine("**Herói escolhido:**");

            if (escolha == 1){
                if (i == 1)
        {
            equipeNome1 = nome1;
            equipePoder1 = poder1;
            equipePonto1 = ponto1;
        }
        else if (i == 2)
        {
            equipeNome2 = nome1;
            equipePoder2 = poder1;
            equipePonto2 = ponto1;
        }
        else
        {
            equipeNome3 = nome1;
            equipePoder3 = poder1;
            equipePonto3 = ponto1;
        }
                Console.WriteLine($"{nome1} - {poder1} - Pontuação: {ponto1}");
            pontuacaoTotal += ponto1;
            }
            
            else if (escolha == 2){
                if (i == 1)
        {
            equipeNome1 = nome2;
            equipePoder1 = poder2;
            equipePonto1 = ponto2;
        }
        else if (i == 2)
        {
            equipeNome2 = nome2;
            equipePoder2 = poder2;
            equipePonto2 = ponto2;
        }
        else
        {
            equipeNome3 = nome2;
            equipePoder3 = poder2;
            equipePonto3 = ponto2;
                
              }
              Console.WriteLine($"{nome2} - {poder2} - Pontuação: {ponto2}");
              pontuacaoTotal += ponto2;
              }

            else if (escolha == 3){
                if (i == 1)
        {
            equipeNome1 = nome3;
            equipePoder1 = poder3;
            equipePonto1 = ponto3;
        }
        else if (i == 2)
        {
            equipeNome2 = nome3;
            equipePoder2 = poder3;
            equipePonto2 = ponto3;
        }
        else
        {
            equipeNome3 = nome3;
            equipePoder3 = poder3;
            equipePonto3 = ponto3;
        }
              Console.WriteLine($"{nome3} - {poder3} - Pontuação: {ponto3}");
              pontuacaoTotal += ponto3;
              }

            else if (escolha == 4){
                if (i == 1)
        {
            equipeNome1 = nome4;
            equipePoder1 = poder4;
            equipePonto1 = ponto4;
        }
        else if (i == 2)
        {
            equipeNome2 = nome4;
            equipePoder2 = poder4;
            equipePonto2 = ponto4;
        }
        else
        {
            equipeNome3 = nome4;
            equipePoder3 = poder4;
            equipePonto3 = ponto4;
        }
        Console.WriteLine($"{nome4} - {poder4} - Pontuação: {ponto4}");
            pontuacaoTotal += ponto4;
              }

            else if (escolha == 5){  if (i == 1)
        {
            equipeNome1 = nome5;
            equipePoder1 = poder5;
            equipePonto1 = ponto5;
        }
        else if (i == 2)
        {
            equipeNome2 = nome5;
            equipePoder2 = poder5;
            equipePonto2 = ponto5;
        }
        else
        {
            equipeNome3 = nome5;
            equipePoder3 = poder5;
            equipePonto3 = ponto5;
        }
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
    ref int ponto2, ref int ponto3, ref int ponto4, ref int ponto5, ref int pontuacaoTotal, ref int escolha,
    ref string equipeNome1, ref string equipeNome2,  ref string equipeNome3,  ref string equipePoder1,  ref string equipePoder2,
    ref string equipePoder3, ref int equipePonto1, ref int equipePonto2, ref int equipePonto3 ){
         
          Console.WriteLine("\n=== Equipe Selecionada ===");
    Console.WriteLine("Herói 1: " + equipeNome1 + " | Poder: " + equipePoder1 + " | Pontuação: " + equipePonto1);
    Console.WriteLine("Herói 2: " + equipeNome2 + " | Poder: " + equipePoder2 + " | Pontuação: " + equipePonto2);
    Console.WriteLine("Herói 3: " + equipeNome3 + " | Poder: " + equipePoder3 + " | Pontuação: " + equipePonto3);
 
        calcularPontuacaoTotal(ref pontuacaoTotal);


    }


    static void menuPrincipal(ref string nome1, ref string nome2, ref string nome3,
ref string nome4, ref string nome5, ref string poder1, ref string poder2,
ref string poder3, ref string poder4, ref string poder5, ref int ponto1, 
ref int ponto2, ref int ponto3, ref int ponto4, ref int ponto5, ref int pontuacaoTotal,
ref int x, ref int escolha, ref string equipeNome1, ref string equipeNome2, ref string equipeNome3,
ref string equipePoder1, ref string equipePoder2, ref string equipePoder3,
ref int equipePonto1, ref int equipePonto2, ref int equipePonto3){
        
       do {
        Console.WriteLine("*****SEJA BEM VINDO AO MENU*****");
        Console.WriteLine("1-Cadastrar herói");
        Console.WriteLine("2-Escolher equipe");
        Console.WriteLine("3-Exibir tudo");
        Console.WriteLine("4-Sair");

        Console.WriteLine("\nDigite o número para nos dizer qual parte você que ir:");
       
        x = int.Parse(Console.ReadLine());
        if (x == 1){
            CadastrarHeroi(ref  nome1,ref  nome2,ref  nome3,ref  nome4,ref  nome5,ref  poder1,ref  poder2,
            ref  poder3,ref  poder4,ref  poder5,  ref ponto1, ref ponto2, ref ponto3 , ref ponto4, ref ponto5 );
            Console.WriteLine("CADASTRO FEITO COM SUCESSO");   
        }
        else if (x == 2){
           SelecionarEquipe(ref  nome1,ref  nome2,ref  nome3,ref  nome4,ref  nome5,ref  poder1,ref  poder2,
            ref  poder3,ref  poder4,ref  poder5,  ref ponto1, ref ponto2, ref ponto3, ref ponto4, ref ponto5, ref  pontuacaoTotal,
             ref escolha, ref equipeNome1, ref equipeNome2, ref equipeNome3, ref equipePoder1, 
            ref equipePoder2, ref equipePoder3, ref equipePonto1, ref equipePonto2, ref equipePonto3);
           
           calcularPontuacaoTotal(ref pontuacaoTotal); 
        }
          else if (x == 3){
            exibirEquipe(ref  nome1,ref  nome2,ref  nome3,ref  nome4,ref  nome5,ref  poder1,ref  poder2,
            ref  poder3,ref  poder4,ref  poder5,  ref ponto1, ref ponto2, ref ponto3, ref ponto4, ref ponto5, ref  pontuacaoTotal,
            ref escolha, ref equipeNome1, ref equipeNome2, ref equipeNome3, ref equipePoder1, 
            ref equipePoder2, ref equipePoder3, ref equipePonto2, ref equipePonto3, ref pontuacaoTotal);
        }
        
        

        if  (ponto1 == 0 && ponto2 == 0 && ponto3 == 0 && ponto4 == 0 && ponto5 == 0){
            Console.WriteLine("VOCÊ TEM QUE CADASTRAR O HERÓI PRIMEIRO EM 'CADASTRE O HERÓI'");
        }
        
        }while(x !=4);
        
    }

   
}
