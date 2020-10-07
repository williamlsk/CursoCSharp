using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;

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


            });

            central.SelecionarEExecutar();
        }
    }
}