using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            //não há a necessidade de converter explicitamente int para double
            Console.WriteLine(quebrado);

            double nota = 9.7;
            //convertendo valor par inteiro de forma explícita
            int notaTruncada = (int)nota;
            Console.WriteLine(notaTruncada);

            Console.WriteLine("Digite sua idade");
            string idade = Console.ReadLine();
            int idadeInteiro = int.Parse(idade);
            Console.WriteLine(idadeInteiro);


            idadeInteiro = Convert.ToInt32(idade);
            Console.WriteLine(idadeInteiro);


            Console.Write("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            //tryparse tentará converter o dado passado na variável, se não conseguir passará o valor zero
            Console.WriteLine("Resultado 1: "+ numero);

            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            //tryparse tentará converter o dado passado na variável, se não conseguir passará o valor zero
            Console.WriteLine("Resultado 2: "+numero2);
        }
    }
}
