using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano)
        {
            this.Modelo = modelo;
            this.Fabricante = fabricante;
            this.Ano = ano;
        }
        public Carro()
        {
        }
    }
    class Construtores
    {

        public static void Executar()
        {
            Carro carro1 = new Carro();
            carro1.Modelo = "Celta";
            carro1.Fabricante = "Chevrolet";
            carro1.Ano = 2004;

            Console.WriteLine(carro1.Modelo + " - " + carro1.Fabricante + " - " + carro1.Ano);

            var carro2 = new Carro("Ka", "Ford", 2018);
            Console.WriteLine(carro2.Modelo + " - " + carro2.Fabricante + " - " + carro2.Ano);

            var carro3 = new Carro()
            {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2015
            };
            Console.WriteLine(carro3.Modelo+" - "+carro3.Fabricante+" - "+carro3.Ano);
        }
    }
}
