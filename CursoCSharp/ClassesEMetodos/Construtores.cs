using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Construtores
    {

        class Carro 
        {
            public string Modelo;
            public string Fabricante;
            public int Ano;
        
            public Carro(string modelo, string fabricante, int ano)
            {
                Modelo = modelo;
                Fabricante = fabricante;
                Ano = ano;
            }

            public Carro()
            {

            }
        
        }

        public static void Executar()
        {
            var carro1 = new Carro();
            carro1.Fabricante = "BMW";
            carro1.Modelo = "3251";
            carro1.Ano = 2017;

            Console.WriteLine($"{carro1.Fabricante} { carro1.Modelo} {carro1.Ano}");

            var carro2 = new Carro("KA", "Ford", 2018);
            Console.WriteLine($"{ carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

            var carro3 = new Carro()
            {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2019
            };
            Console.WriteLine($"{ carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");

        }
    }
}
