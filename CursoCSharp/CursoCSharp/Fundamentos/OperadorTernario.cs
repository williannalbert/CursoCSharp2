using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar()
        {
            var nota = 7.0;
            bool bomComprotamento = true;
            var resultado = nota >= 7.0 && bomComprotamento ? "aprovado" : "reprovado";
            Console.WriteLine(resultado);

        }
    }
}
