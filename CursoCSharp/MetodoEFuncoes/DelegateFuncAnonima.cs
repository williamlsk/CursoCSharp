using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodoEFuncoes
{
    class DelegateFuncAnonima
    {

        delegate string StringOperacao(string s);

        public static void Executar()
        {

            StringOperacao inverter = delegate (string s)
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            };

            Console.WriteLine("C# é show!!");
        }

    }
}
