using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //area da circunferência
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio*raio;
            Console.WriteLine("Área é "+area);

            bool estaChovendo = true;
            Console.WriteLine(estaChovendo);

            //de zero a 256
            byte idade = 45;
            Console.WriteLine(idade);
            
            //NÚMEROS INTEIROS
            //pode ser negativo (-128)
            sbyte saldoDeGol = sbyte.MinValue;
            Console.WriteLine(saldoDeGol);

            short salario = short.MaxValue;
            Console.WriteLine(salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine(menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine(populacaoBrasileira);

            long menorValorLong = long.MinValue;    
            Console.WriteLine(menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine(populacaoMundial);

            //NÚMEROS REAIS
            float precoComputador = 1299.99f;
            Console.WriteLine(precoComputador);

            double valorDeMercadoApple = 1_000_000_000_000.00;
            Console.WriteLine(valorDeMercadoApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine(distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine(letra);

            string texto = "Texto 0001";
            Console.WriteLine(texto);

        }
    }
}
