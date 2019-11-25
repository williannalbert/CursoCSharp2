using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0]= "Anderson";
            alunos[1]= "Bia";
            alunos[2]= "Carlos";
            alunos[3]= "Daniel";
            alunos[4]= "Emanuele";

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.4, 4.3, 5.5, 8.2, 2.8};
            /*
            foreach (var nota in notas)
            {
                somatorio +=nota;
            }*/

            for (int i=0; i<notas.Length; i++)
            {
                somatorio += notas[i];
            }

            double media = somatorio / notas.Length;
            Console.WriteLine(media);


            char[] letras = { 'A', 'B', 'C', 'D', 'E'};
            string palavras = new string(letras);
            Console.WriteLine(palavras);

        }
    }
}
