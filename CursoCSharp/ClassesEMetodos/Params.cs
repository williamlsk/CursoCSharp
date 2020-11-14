using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Params
    {
        //conjunto de parametros 
        public static void Recpcionar(params string[] pessoas)
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine("Olá {0}", pessoa);
            }
        }

        public static void Executar()
        {
            Recpcionar("Pedro", "Manu", "Ste", "Carol", "Bia");
        }
    }
}
