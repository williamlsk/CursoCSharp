using System;
using System.Collections.Generic;
using System.Text;
using Encapsulamento;

namespace CursoCSharp.OO
{

    public class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("FilhoNaoReconhecido...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            //Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoDeFamilia);
            //Console.WriteLine(UsaMuitoPhotoShop);

        }
    }

    public class AmigoDistante
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("AmigoDistante....");
            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDoolho);
            //Console.WriteLine(amiga.NumeroCelular);
            //Console.WriteLine(amiga.JeitoDeFalar);
            //Console.WriteLine(amiga.SegredoDeFamilia);
            //Console.WriteLine(amiga.UsaMuitoPhotoshop);
        }

    }


    class Encapsulamento
    {
        public static  void Executar()
        {
            SubCelebridade sub = new SubCelebridade();

            sub.MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new FilhoReconhecido().MeusAcessos();
            
            new AmigoProximo().MeusAcessos();
            new AmigoDistante().MeusAcessos();

        }

    }
}
