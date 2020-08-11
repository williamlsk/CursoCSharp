using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    public class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            //se o valor digitado não for uma string, precisa ser feito um cast, exemplo abaixo.
            Console.WriteLine("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            //Faz com que o salario separado por "," ou "."
            Console.WriteLine("Qual é o seu salario? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome} {idade} R${salario}" );
        }

    }
}
