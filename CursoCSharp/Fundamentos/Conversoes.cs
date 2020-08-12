using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar() 
        {
            int inteiro = 10;

            //nessa conversão, não há perda de conversão, porque double é maior que int
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            //quando há perda de informação na conversão, deve informar de forma explicita o tipo de conversão.
            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine("Nota truncada {0}", notaTruncada);

            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            //outra forma de Converter é usando a o metodo Convert
            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro);


            //outra forma um pouco mais segura é usando o Try Parce
            Console.WriteLine("Digite o primeiro numero: ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine("Resultado: {0}", numero);

            //outra forma de usar o TryParse
            Console.WriteLine("Digite o segundo numero");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado: {0}", numero2);


        }

    }
}
