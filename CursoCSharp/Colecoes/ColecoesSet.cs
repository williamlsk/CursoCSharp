using System;
using System.Collections.Generic;
using System.Text;
using static CursoCSharp.Colecoes.ColecoesList;

namespace CursoCSharp.Colecoes
{
    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of thrones", 49.9);

            var carrinho = new HashSet<Produto>();

            carrinho.Add(livro);
            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporada Game of Thrones", 99.9),
                new Produto("Poster", 10),
                new Produto("Poster", 10)
            };

            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);

            //carrinho.RemoveAt(3);

            foreach (var item in carrinho)
            {
                //Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            //o List aceita elementos iguais 
            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            //Console.WriteLine(carrinho.LastIndexOf(livro));
        }

    }
}
