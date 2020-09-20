using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    public class OperadorUnario
    {
        public static void Executar() 
        {

            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo);
            Console.WriteLine(!booleano);


            numero1++; //pós fixado
            Console.WriteLine(numero1);

            --numero1; //pré fixado
            Console.WriteLine(numero1);

            
            Console.WriteLine(numero1++ == --numero2);
            Console.WriteLine($"{numero1} e {numero2}");


        }
    }
}
