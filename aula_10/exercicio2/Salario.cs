using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2
{
    class Salario
    {
        public string nome;
        public double renda, imposto;
        double novaRenda;
        
       public void Metodo1()
        {
            if (renda <= 2000)
            {
                novaRenda = (renda * 0.10)+renda;
            }
            else if (  renda > 2000 && renda <= 3000 ) 
            {
                novaRenda = (renda * 0.15) + renda;
            }
            else
            {
                novaRenda = (renda * 0.20) + renda;
            }
            Console.WriteLine("O novo salario de " + nome + " sera de: " + novaRenda);
        }

    }
}
