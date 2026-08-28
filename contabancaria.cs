namespace abstracao
{
    internal class contabancaria
    {
        public string Titular;
        public string NumeroConta;
        public string Saldo;


        public void ExibirInformacoes()
        {
            Console.WriteLine("Titular: " + Titular);
            Console.WriteLine("Número da Conta: " + NumeroConta);
            Console.WriteLine("Saldo: R$ " + Saldo);
        }

    }


}
