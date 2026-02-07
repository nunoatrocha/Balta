namespace POO_Pratica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var esc = new Escuteiro("Nuno", 46, "Rua de Cima");
            esc.ImprimeNome();
            esc.Cumprimenta();
            Console.WriteLine(esc.Nome);
        }

        public class Pessoa
        {
            public string Nome { get; set; }
            public int Idade { get; set; }
            public string Morada { get; set; }

            public Pessoa(string nome, int idade, string morada )
            {
                Nome = nome;
                Idade = idade;
                Morada = morada;
            }

            public void ImprimeNome()
            {
                Console.WriteLine(Nome);
            }

            public virtual void Cumprimenta()
            {
                Console.WriteLine($"Olá {Nome} => Metodo Pai");
            }
        }

        public class Escuteiro : Pessoa
        {
            public string Seccao { get; set; }
            public string NomeEquipa { get; set; }

            public Escuteiro(string nome, int idade, string morada) 
                : base(nome, idade, morada)
            {
            }

            public override void Cumprimenta()
            {
                base.Cumprimenta();
                Console.WriteLine($"Olá {Nome}!");
            }
        }
    }
}
