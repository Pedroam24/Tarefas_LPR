using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    class Retangulo
    {
        public float area, perimetro, l , a;
        public void Metodo1()
        {
            area = l * a;
            perimetro = 2 * (l + a);
            Console.WriteLine("A área desse retângulo é: "+ area);
            Console.WriteLine("O perimetro desse retÂngulo é:"+ perimetro );

        }

    }
}
