using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{

    public class Cliente
    {
        public string Nome;
        readonly DateTime Nascimento;
        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento()
        {
            return string.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month,
                Nascimento.Year);
        }
    }
    class Readonly
    {
        public static void Executar()
        {
            var NovoCliente = new Cliente("Ana Maria", new DateTime(1978, 5, 22));

            Console.WriteLine(NovoCliente.Nome);
            Console.WriteLine(NovoCliente.GetDataDeNascimento());
        }
    }
}
