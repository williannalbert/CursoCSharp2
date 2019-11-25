using System;
using System.Globalization;

namespace CursoCSharp
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual é o seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine(nome+", qual a sua idade?");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine(nome+", qual o seu salário?");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //função utilizada devido a biblioteca system.globalization

            Console.WriteLine(nome+" possui "+ idade+" anos e o salário é R$"+salario);
        }
    }
}
