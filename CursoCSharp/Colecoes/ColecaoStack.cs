using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecaoStack
    {
        public static void Executar()
        {
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14);

            foreach (var item in pilha)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}");

            foreach (var item in pilha)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine($"\nPeek: {pilha.Peek()}");
            Console.WriteLine(pilha.Count);

        }
    }
}
