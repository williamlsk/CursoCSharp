using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodoEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            //Action é sempre void
            Action algoNoConsole = () => {
                Console.WriteLine("Lambda com c#!");
            
            };

            algoNoConsole();

            Func<int> jogarDado = () => {
                Random random = new Random();
                return random.Next(1,7);
            };

            Console.WriteLine(jogarDado());

            //sempre retorna um valor, nesse caso entrada e saida
            Func<int, string> conversorHex = numero => numero.ToString("x");
            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) => String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formatarData(1,1,2019));




        }


    }
}
