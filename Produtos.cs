namespace abstracao
{
    public class Produtos
    {
        public string Nome;
        public double Preco;
        public int QuantidadeEstoque;


        public void ExibirInformacoes()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Preço: R$ " + Preco);
            Console.WriteLine("Quantidade em estoque: " + QuantidadeEstoque);
        }
    }
}
