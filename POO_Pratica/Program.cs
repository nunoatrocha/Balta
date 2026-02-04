namespace POO_Pratica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var esc = new Escuteiro();
            esc.Nome = "Nuno";
            esc.ImprimeNome();
            esc.Cumprimenta();
            Console.WriteLine(esc.Nome);
        }

        class Pessoa
        {
            public string Nome;
            public int Idade;
            public string Morada;

            public void ImprimeNome()
            {
                Console.WriteLine(Nome);
            }

            public virtual void Cumprimenta()
            {

            }
        }

        class Escuteiro : Pessoa
        {
            string Seccao;
            string NomeEquipa;


            public override void Cumprimenta()
            {
                Console.WriteLine($"Olá {Nome}!");
            }
        }
    }
}
