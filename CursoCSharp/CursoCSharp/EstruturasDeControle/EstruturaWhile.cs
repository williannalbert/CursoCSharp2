using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);

            Boolean numeroEncontrado = false;
            int tentativaRestante = 5;

            int tentativas = 0;

            while (tentativaRestante > 0 && !numeroEncontrado)
            {
                Console.WriteLine("insira seu palpite");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativaRestante--;
                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Número encontrado em {0} tentativas", tentativas);
                    Console.BackgroundColor = corAnterior;
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Menor.. Tente novamente!");
                    Console.WriteLine("Tentativas restantes {0}", tentativaRestante);
                }
                else
                {
                    Console.WriteLine("Maior... Tente novamente!");
                    Console.WriteLine("tentativas restantes {0}", tentativaRestante);
                }

            }
        }
    }
}
