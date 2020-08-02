using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            var nome = "William";
            Console.WriteLine(nome);

            //Quando houver um valor inferido, precisa inicializar com valor pro compilador identificar
            var idade = 32;
            Console.WriteLine(idade);

            int a;
            a = 3;

            int b = 2;

            Console.WriteLine(a+b);
        }
    }
}
