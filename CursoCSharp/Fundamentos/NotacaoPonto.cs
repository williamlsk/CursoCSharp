using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            //cada ponto, exibe novos metodos que estão ligados a variável 
            var saudacao = "olá".ToUpper().Insert(3, " World").Replace("World", "Mundo");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            //Conceito de linguagem
            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
