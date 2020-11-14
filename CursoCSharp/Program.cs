using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Váriaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Numeros - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritiméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadorAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadorUnario.Executar},
                
                
                //Estrutura de Controle
                {"Estrutura IF - Estrutura de Controle", EstruturaIf.Executar},
                {"Estrutura IF/Else - Estrutura de Controle", EstruturaIfElse.Executar},
                {"Estrutura IF/ElseIF - Estrutura de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Swith - Estrutura de Controle", EstruturaSwith.Executar},
                {"Estrutura While - Estrutura de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estrutura de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estrutura de Controle", EstruturaFor.Executar},
                {"Estrutura For Each - Estrutura de Controle", EstruturaForEach.Executar},
                {"Estrutura Breack - Estrutura de Controle", EstruturaBreak.Executar},
                {"Estrutura Continue - Estrutura de Controle", EstruturaContinue.Executar},

                //Classes e Metodos
                {"Membros - Classes e Metodos", Membros.Executar}, 
                {"Construtores - Classes e Metodos", Construtores.Executar},
                {"Métodos com Retorno - Classes e Metodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e Metodos", MetodosEstaticos.Executar},
                {"Atibutos Estáticos - Classes e Metodos", AtributosEstaticos.Executar},


            });

            central.SelecionarEExecutar();
        }
    }
}