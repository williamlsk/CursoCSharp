using CursoCSharp.ClassesEMetodos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesIgualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2;

            //comparação de referencia de memoria
            Console.WriteLine(p1==p2);
            Console.WriteLine(p3 == p2);

            //compara endereço de memoria
            Console.WriteLine(p1.Equals(p2));
        }
    }
}
