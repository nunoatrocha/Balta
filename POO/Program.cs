using System.ComponentModel.DataAnnotations;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objeto é sempre um Tipode Refeência : só armazena o endereço dos dados

            var pagamentoCR = new PagamentoPrestacoes();
            pagamentoCR.Pagar();
            pagamentoCR.Vencimento = DateTime.Now;
            pagamentoCR.NumeroPrestacao = "123456789";
            
            var pagamento = new Pagamento();
            pagamento.Vencimento = DateTime.Now;

            Console.WriteLine(pagamento.DataPagamento);
        }

        public class Pagamento
        {
            // Propriedades - (Variáveis)

            public DateTime Vencimento { get; set; }
            public DateTime _dataPagaemnto { get; private set; }

            private DateTime _dataPagamento;

            public DateTime DataPagamento
            {
                get 
                {
                    Console.WriteLine("A imprimir o valor");
                    return _dataPagamento; 
                }
                set 
                {
                    Console.WriteLine("A alterar o valor");
                    _dataPagamento = value;
                } 
            }

            public Morada MoradaEnvio;

            // Eventos - (Funções) 

            public virtual void Pagar()
            {

            }
                
            private void Receber() { }

            protected void Saldo() { }
        }

        public class PagamentoPrestacoes : Pagamento
        {
            public string NumeroPrestacao;

            public override void Pagar()
            {
                // Regra só pagamento a prestações
            }
        }

        public class PagamentoCartaoDeCredito : Pagamento
        {
            public string NumeroCartao;

            public override void Pagar()
            {
                // Regra só pagamento com o cartão de crédito
            }
        }

        public class Morada
        {
            public string CodigoPostal;
        }
    }
}
