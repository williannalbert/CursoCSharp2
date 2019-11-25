using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa person = new Pessoa();
            /*            person.Nome = "Willian";
                        person.Idade = 22;

                        Console.WriteLine(person.Nome+" tem "+person.Idade+" anos.");*/

            person.ApresentarConsole();
        }
    }
}
