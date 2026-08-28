namespace abstracao
{
    public class Jogador
    {
        public string Nome { get; set; }
        public string Posicao { get; set; }
        public int NumeroCamisa { get; set; }
}

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Jogador: {nome}");
            Console.WriteLine($"Posição: {posicao}");
            Console.WriteLine($"Número da Camisa: {numeroCamisa}");
            Console.WriteLine("-------------------------");
        }
    }
}
