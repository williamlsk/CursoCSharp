using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            //Tipos internos
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade : " + idade);

            //pode haver valores negativos
            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols : " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario : " + salario );

            //Mais usados dos inteiros
            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor int :" + menorValorInt);

            //inteiro sem sinal
            uint populacaoBrasileira = 207_600_600;
            Console.WriteLine("Populacao Brasileira: " + populacaoBrasileira);

            //com sinal
            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor Long: " + menorValorLong);

            //sem sinal
            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial: " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preco Computador: " + precoComputador);

            double valorDemercadoDaApple = 1_000_000_000_000.00; // mais usado
            Console.WriteLine("Valor de mercado da Apple: " + valorDemercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra: " + letra);

            string texto = "Seja bem vindo ao curso de C#";
            Console.WriteLine(texto);

        }
    }
}
