using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{

    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;


        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else
            {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;

        }

        //modificador virutal, informa que o método pode ser sobrescrito
        public virtual int Acelerar()
        {
            return AlterarVelocidade(5);

        }

        public int Frear()
        {
            return AlterarVelocidade(-5);
        }
    }
    public class Uno : Carro
    {
        //quando usado base(), chama o método construtor da classe pai
        public Uno() : base(200)
        {

        }
    }

    public class Ferrari : Carro
    {
        //quando usado base(), chama o método construtor da classe pai
        public Ferrari() : base(350)
        {

        }

        public override int Acelerar()
        {
            return AlterarVelocidade(15);
        }

        //Oculta o método da classe pai
        public new int Frear()
        {
            return AlterarVelocidade(-15);
        }

    }



    class Heranca
    {
        public static void Executar()
        {

            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());


            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());

            Console.WriteLine("Ferrari com o tipo Carro...");
            Carro carro3 = new Ferrari();
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            carro3 = new Uno();//Polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }

    }
}
