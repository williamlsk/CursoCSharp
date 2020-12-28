using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{

    sealed class SemFilho
    { 
        public double ValorDaFortuna()
        {
            return 1_407_033.65;
        } 
    }

    //class SouFilho : SemFilho
    //{

    //}

    class Avo 
    { 
        public virtual bool HontarNomeFamilia()
        {
            return true;
        }
    
    }

    class Pai : Avo
    {
        public sealed override bool HontarNomeFamilia()
        {
            return true;
        }
    }

    class FilhoRebelde : Pai
    {
        //public override bool HontarNomeFamilia()
        //{
        //    return false;
        //}
    }


    class Sealed
    {

        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filhoRebelde = new FilhoRebelde();
            Console.WriteLine(filhoRebelde.HontarNomeFamilia());

        }

    }
}
