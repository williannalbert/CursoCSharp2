using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = true;

            var comprouTV50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou TV 50? {0}", comprouTV50);

            var comprouSVT = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou Svt? {0}", comprouSVT);

            var comprouTV32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comrou a Tv 32? {0}", comprouTV32);

            Console.WriteLine("Mais saudável? {0}", !comprouSVT);
        }
    }
}
