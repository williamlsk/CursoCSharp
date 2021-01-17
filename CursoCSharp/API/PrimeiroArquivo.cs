using System;
using System.IO;

namespace CursoCSharp.API
{

    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                  Environment.OSVersion.Platform == PlatformID.Win32NT)
                  ? Environment.GetEnvironmentVariable("HOME")
                  : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");

            return path.Replace("~", home);
        }
    }
    class PrimeiroArquivo
    {
        public static void Executar()
        {
            //usa ~ para interpretar a home do usuário, no windows tem um comportamento linux e mac são outros
            var path = @"C:/Projetos/primeiro_arquivo.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("Arquivo!");
                }
            }

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("");
                sw.WriteLine("É possível");
                sw.WriteLine("adicionar");
                sw.WriteLine("mais texto");

            }

        }
    }
}
