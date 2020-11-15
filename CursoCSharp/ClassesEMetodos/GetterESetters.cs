using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class GetterESetters
    {
        public class Moto
        {
            private string Marca;
            private string Modelo;
            private uint Cilindrada;


            public Moto(string marca, string modelo, uint cilindrada) 
            {
                //Marca = marca;
                //Modelo = modelo;
                //Cilindrada = cilindrada;

                SetMarca(marca);
                SetModelo(modelo);
                SetCilindrada(cilindrada);

            }

            public Moto() { }

            public string GetMarca()
            {
                return Marca;
            }
            public void SetMarca(string marca)
            {
                Marca = marca;
            }

            public string GetModelo()
            {
                return Modelo;
            }
            public void SetModelo(string modelo)
            {
                Modelo = modelo;
            }

            public uint GetCilindrada()
            {
                return Cilindrada;
            }
            public void SetCilindrada(uint cilindrada)
            {

                //if (cilindrada > 0)
                //{
                //    Cilindrada = cilindrada;
                //} 

                //Cilindrada = Math.Abs(Cilindrada);

                Cilindrada = cilindrada;
            }

        }

        public static void Executar()
        {
            var moto1 = new Moto("Kawasaki", "Nina ZX6R", 636);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());


            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(150);

            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() + " " + moto2.GetCilindrada());

        }
    }
}
