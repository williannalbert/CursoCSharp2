using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        
        public int Somar(int a, int b)
        {
            return a + b;
        }
        //método estático
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
        //método estático
        public static int Subtrair(int a, int b)
        {
            return a - b;
        }
    }

    class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine(resultado);


            CalculadoraEstatica calcula = new CalculadoraEstatica();
            Console.WriteLine(calcula.Somar(3, 4));
          
        }
    }
}
