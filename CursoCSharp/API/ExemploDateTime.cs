using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.API
{
    class ExemploDateTime
    {
        public static void Executar()
        {
            var dateTime = new DateTime(year: 2030, month: 2, day: 6);
            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            //Sem horas
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            //Com horas
            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);
            Console.WriteLine("Horas: " + diaAtual.Hour);
            Console.WriteLine("Minutos: " + diaAtual.Minute);

            var amanha = diaAtual.AddDays(1);
            Console.WriteLine(amanha);

            var ontem = diaAtual.AddDays(-1);
            Console.WriteLine(ontem);


            Console.WriteLine(diaAtual.ToString("dd"));
            Console.WriteLine(diaAtual.ToString("d"));
            Console.WriteLine(diaAtual.ToString("D"));

            //Dia atual com hora
            Console.WriteLine(diaAtual.ToString("g"));

            //Dia atual com hora e segundos
            Console.WriteLine(diaAtual.ToString("G"));

            
            Console.WriteLine(diaAtual.ToString("dd-MM-yyyy HH:mm"));

        }

    }
}
