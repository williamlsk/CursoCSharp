using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CursoCSharp.API
{
    class ExemploFileInfo
    {
        public static void ExcluirSeExistir(params string[] caminhos)
        {
            foreach (var caminho in caminhos)
            {
                FileInfo arquivo = new FileInfo(caminho);
                if (arquivo.Exists)
                {
                    arquivo.Delete();
                }
            }
        }

        public static void Executar()
        {
            var caminhoOrigem = @"C:/Projetos/arq_origem.txt";
            var caminhoDestino = @"C:/Projetos/arq_origem.txt";
            var caminhoCopia = @"C:/Projetos/arq_copia.txt";

            ExcluirSeExistir(caminhoDestino, caminhoCopia);

            using (StreamWriter sw = File.CreateText(caminhoOrigem))
            {
                sw.WriteLine("Arquivo Original");
            }

            FileInfo origem = new FileInfo(caminhoOrigem);
            Console.WriteLine(origem.Name);
            Console.WriteLine(origem.IsReadOnly);
            Console.WriteLine(origem.FullName);
            Console.WriteLine(origem.Extension);
            Console.WriteLine(origem.DirectoryName);


            origem.CopyTo(caminhoCopia);
            origem.MoveTo(caminhoDestino);

        }


    }
}
