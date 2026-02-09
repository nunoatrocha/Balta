using System;
using System.Collections.Generic;

namespace POO_Pratica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Escuteiro e1 = new Escuteiro ("Rita", new DateTime(2010, 8, 10), "Rua de Cima", "Pioneiros", "Pantera");
            Escuteiro e2 = new Escuteiro("Pedro", new DateTime(2011, 4, 1), "Rua de Amanhã tb é dia", "Lobitos", "Azul");
            Escuteiro e3 = new Escuteiro("Ana", new DateTime(2009, 6, 21), "Rua de Não Venhas Tarde", "Caminheiros", "Pedro Alvares Cabral");
            e1.Cumprimenta();
            Dirigente d1 = new Dirigente("Nuno", new DateTime(1979, 11, 11), "Rua de Baixo", "Exploradores", "Lobo","Chefe de Secção");
            d1.Cumprimenta();

            var lista = new List<Escuteiro>();
            lista.Add(e1);
            lista.Add(e2);
            lista.Add(e3);

            foreach (var item in lista)
            {
                if (item.Seccao == "Lobitos")
                    Console.WriteLine(item.Nome);
            }

        }

        public class Pessoa
        {
            // PARAMETROS ----------------------

            public string Nome { get; set; }
            public DateTime DataNascimento { get; set; }
            public string Morada { get; set; }

            public int Idade
            {
                get
                {
                    int idade = DateTime.Now.Year - DataNascimento.Year;

                    if (DateTime.Now.DayOfYear < DataNascimento.DayOfYear)
                        idade--;

                    return idade;
                }
            }

            // METODO CONSTRUTOR ---------------

            public Pessoa(string nome, DateTime datanascimento, string morada)
            {
                Nome = nome;
                DataNascimento = datanascimento;
                Morada = morada;
            }

            //  METODO DA CLASSE PESSOA ----------

            public virtual void Cumprimenta()
            {
                Console.WriteLine($"Olá eu sou o/a {Nome} e tenho {Idade} anos!");
            }
        }

        public class Escuteiro : Pessoa
        {
            public string Seccao { get; set; }
            public string NomeEquipa { get; set; }

            public Escuteiro(string nome, DateTime datanascimento, string morada, string seccao, string nomeEquipa)
                :base(nome, datanascimento, morada )
            {
                Seccao = seccao;
                NomeEquipa = nomeEquipa;
            }

            public override void Cumprimenta()
            {
                Console.WriteLine($"Olá o meu nome é {Nome}, tenho {Idade} e estou nos {Seccao} na equipa {NomeEquipa}");
            }

        }

        public class Dirigente : Escuteiro
        {
            public string Cargo { get; set; }

            public Dirigente(string nome, DateTime datanascimento, string morada, string seccao, string nomeEquipa, string cargo)
                :base(nome, datanascimento, morada, seccao, nomeEquipa)
            {
                Cargo = cargo;
            }

            public override void Cumprimenta()
            {
                Console.WriteLine($"Olá eu sou o {Nome} e sou {Cargo} nos {Seccao}");
            }


        }

    }
}
