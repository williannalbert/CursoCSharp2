using System;
using System.Collections.Generic;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Fundamentos;
using CursoCSharp.Colecoes;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variaveis e constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto- Fundamentos", Notacao.Executar},
                {"Lendo dados- Fundamentos", LendoDados.Executar},
                {"Formatando Número- Fundamentos", FormatandoNumero.Executar},
                {"Conversões- Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos- Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais- Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos- Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuicao- Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários- Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternário- Fundamentos", OperadorTernario.Executar},
                //Estruturas de controle
                { "Estrutura If- Esruturas de controle", EstruturaIf.Executar},
                { "Estrutura IfElse- Esruturas de controle", EstruturaIfElse.Executar},
                { "Estrutura IfElseIf- Esruturas de controle", EstruturaIfElseIf.Executar},
                { "Estrutura Switch- Esruturas de controle", EstruturaSwitch.Executar},
                { "Estrutura While- Esruturas de controle", EstruturaWhile.Executar},
                //Classes e métodos
                { "Membros- Classes e Métodos", Membros.Executar},
                { "Contrutores- Classes e Métodos", Construtores.Executar},
                { "Métodos com retorno- Classes e Métodos", MetodosComRetorno.Executar},
                { "Métodos Estáticos- Classes e Métodos", MetodosEstaticos.Executar},
                { "Atributos Estáticos- Classes e Métodos", AtributosEstaticos.Executar},
                { "Desafio Atributo- Classes e Métodos", DesafioAtributo.Executar},
                { "Params- Classes e Métodos", Params.Executar},
                { "Parametros Nomeados- Classes e Métodos", ParametrosNomeados.Executar},
                { "Get Set- Classes e Métodos", GetSet.Executar},
                { "Props- Classes e Métodos", Props.Executar},
                { "Readonly- Classes e Métodos", Readonly.Executar},
                { "Enum- Classes e Métodos", ExemploEnum.Executar},
                { "Struct- Classes e Métodos", ExemploStruct.Executar},
                { "Struct Vs Classe- Classes e Métodos", StructVsClasse.Executar},

                //Coleções
                { "Array - Coleções", Colecoes.Array.Executar},
                { "ColeçõesList - Coleções", ColecoesList.Executar},
                { "ColeçõesArrayList - Coleções", ColecoesArrayList.Executar},
                { "ColeçõesSet - Coleções", ColecoesSet.Executar},
                //{ "ColeçõesQueue - Coleções", ColecoesQueue.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}



