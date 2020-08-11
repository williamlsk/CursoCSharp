using System;
using System.Globalization

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar() 
        {
            double valor = 15.175;

            //formatando com uma casa decimal, faz arredondamento do valor.
            Console.WriteLine(valor.ToString("F1"));

            //transformando em moeda
            Console.WriteLine(valor.ToString("C"));

            //percentagem
            Console.WriteLine(valor.ToString("P"));

            //quantas casas decimais
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("pt-BR");

            //exibe sem casa decimal em pt-BR
            Console.WriteLine(valor.ToString("C0", cultura));

            //colocando 0 a esquerda, usa D+quantidade de caracteres desejada
            int inteiros = 256;
            Console.WriteLine(inteiros.ToString("D10"));


        }
    }
}
