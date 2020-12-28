using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodoEFuncoes
{
    class UsandoDelegate
    {
        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double MinhaSoma(double x, double y)
        {
            return x + y;
        }

        static void MeuImprimir(double a, double b)
        {
            Console.WriteLine(a + b);
        }

        public static void Executar()
        {
            //precisa haver compatibilidade dos parametros, tipo de retorno 
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(2,3));

            ImprimirSoma op2 = MeuImprimir;
            op2(5.4, 8);

            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(2.5, 3));

            Action<double, double> op4 = MeuImprimir;
            op4(7.7, 23.4);

        }

    }
}
