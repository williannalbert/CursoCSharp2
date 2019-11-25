using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome="Willian";
        public int Idade=22;

        public string Apresentar()
        {
            
            return string.Format("O nome é "+Nome+" e tem "+Idade+" anos");
        }

        public void ApresentarConsole()
        {
            Console.WriteLine(Apresentar()); ;
        }
        public void Zerar()
        {
            Nome = "";
            Idade = 0;
        }
    }
}
