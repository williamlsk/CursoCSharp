using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Enumeradores
    {

        public enum Genero
        {
            Acao,
            Aventura,
            Terror,
            Animacao,
            Comedia
        };
        public class Filme
        {
            public string Titulo;
            public Genero GeneroDoFilme;
        }
        public static void Executar()
        {
            int id = (int)Genero.Animacao;

            Console.WriteLine(id);

            var filmePraFamilia = new Filme();
            filmePraFamilia.Titulo = "Sharkinado 17";
            filmePraFamilia.GeneroDoFilme = Genero.Comedia;

            Console.WriteLine("{0} e {1}!", filmePraFamilia.Titulo, filmePraFamilia.GeneroDoFilme);


        }

    }
}
