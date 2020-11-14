using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAcessarAtributos
    {
        //como alterar a variavel a?
        int a = 10;

        public static void Executar()
        {
            
            DesafioAcessarAtributos desafioAcessarAtributos = new DesafioAcessarAtributos();

            desafioAcessarAtributos.a = 5;

            Console.WriteLine(desafioAcessarAtributos.a);

            
        }
    }
}
