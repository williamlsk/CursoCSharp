using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodoEFuncoes
{
    //degate é um tipo
    delegate double Operacao(double x, double y);


    class LambdasDelegate
    {

        public static void Executar()
        {
            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao mult = (x, y) => x * y;

            Console.WriteLine(sum(3,3));
            Console.WriteLine(sub(5, 9));
            Console.WriteLine(mult(3, 5));


        }

    }
}
