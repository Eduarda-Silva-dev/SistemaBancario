namespace SistemaBancario.Models
{
    //Pilar: Abstração 
    public abstract class ContaBancaria
    {
        //pilar: Encapsulamento: Campo privados protegidos por propriedades publicas 
        private string _numeroConta;
        private decimal _saldo;
        
        //existem 3 tipos de modificadores 
        //public - todos acassem 
        //private - somente a classe acessa 
        //protected - somente a classes filhas

        //propriedades 

        public string NumeroConta
        {
            get => _numeroConta;
            protected set => _numeroConta = value;
        }

        public decimal Saldo
        {
            get => _saldo;
            protected set => _saldo = value < 0?0: value;
        } 

        public string NomeTitular { get; set; }
        public List<string> ExtratoTransacoes { get; set; } = new List<string>();

        //Construtor da clase 
        protected ContaBancaria(string numeroConta,string nomeTitular,decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Saldo = saldoInicial;
            ExtratoTransacoes.Add($"Conta criada com saldo inicial de : R${saldoInicial:F2}");
        }
    }
}
