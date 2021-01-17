using System;
using System.Collections.Generic;
using System.IO;

namespace CursoCSharp.API
{
    class Diretorios
    {
        public static void Executar()
        {
            var novoDir = @"C:/PastaCSharp";
            var novoDirDestino = @"C:/PastaCSharpDestino";
            var dirProjeto = @"E:/Projetos/CursoCSharp/CursoCSharp";

            if (Directory.Exists(novoDir))
            {
                //True ou false pra excluir de forma recursiva
                Directory.Delete(novoDir, true);
            }

            if (Directory.Exists(novoDirDestino))
            {
                //True ou false pra excluir de forma recursiva
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("=== Pastas ==========");
            var pastas = Directory.GetDirectories(dirProjeto);

            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("\n\n== Arquivos ===========");
            var arquivos = Directory.GetFiles(dirProjeto);

            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n\n== Raiz ========");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));


            Directory.Move(novoDir, novoDirDestino);

        }
    }
}
