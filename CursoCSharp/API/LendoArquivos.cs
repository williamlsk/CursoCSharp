using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CursoCSharp.API
{
    class LendoArquivos
    {
        public static void Executar()
        {
            var path = @"C:/Projetos/lendo_arquivos.txt";

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Produto;Preco;Qtde");
                sw.WriteLine("Caneta Bic Preta;3.59;89");
                sw.WriteLine("Borracha Branca;2+89;27");
            }
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    //le o arquivo completamente
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
