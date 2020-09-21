using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar() 
        {

            var nota = 7.0;
            bool bomComportamento = true;

             //se a expressão for verdadeita, aprovado, se não, reprovado 
            string resultato = nota >= 7.0 && bomComportamento ? "Aprovado" : "Reprovado";

            Console.WriteLine(resultato);


        }


    }
}
