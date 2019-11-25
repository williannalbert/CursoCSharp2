using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {

            bool bomComportamento = false;
            string entrada;


            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento (s/n): ");
            entrada = Console.ReadLine();
            //if (entrada == "s" || entrada == "S")

            //    bomComportamento = true;
            bomComportamento = entrada == "s" || entrada == "S";
            bomComportamento = entrada.ToLower() == "s";
            if (nota >= 9 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra!");
            }
        }
    }
}
