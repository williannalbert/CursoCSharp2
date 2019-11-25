using System;
//para que sejam buscadas informações de cultura
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));

            //C é valor monetário
            Console.WriteLine(valor.ToString("C"));

            //P de percentual
            Console.WriteLine(valor.ToString("P"));

            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0", cultura));

            int inteiro = 256;

            //D10 completa zeros a esquerdas D+qtd de casas que deseja conter na string
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
