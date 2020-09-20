using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    public class OperadorAtribuicao
    {
        public static void Executar() 
        {

            var num1 = 3;
            num1 = 7;
            num1 += 10; //num1 = num1 + 10
            num1 -= 3; //num1 = num1 - 3
            num1 *= 5;
            num1 /= 2;

            Console.WriteLine(num1);


            int a = 1;
            int b = a; //cópia

            a++;
            b--;

            Console.WriteLine($"{a} e {b}");

            //Conceito atribuição por referencia, d e c apontam para o mesmo espaço de memoria
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;
            d.nome = "Maria";

            Console.WriteLine(c.nome);

        }
    }
}
