using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public struct SPonto
    {
        public int X;
        public int Y;
    }

    public class CPonto
    {
        public int X;
        public int Y;
    }

    class StructVsClasse
    {
        public static void Executar()
        {
            SPonto ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto copiaPonto1 = ponto1; // Atribuição por valor
            ponto1.X = 3;
            Console.WriteLine("Ponto 1 X: "+ponto1.X);
            Console.WriteLine("Cópia Ponto 1 X: "+ copiaPonto1.X);

            CPonto ponto2 = new CPonto { X = 1, Y = 3 };
            CPonto copiaCPonto2 = ponto2;
            ponto2.X = 5;
            Console.WriteLine("Ponto 1 X: " + ponto2.X);
            Console.WriteLine("Cópia Ponto 1 X: " + copiaCPonto2.X);

        }
    }
}
