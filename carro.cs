namespace abstracao
{
    public class carro
    {
        //ATRIBUTOS CARACTERISTICAS
        public string Marca;
        public string Modelo;
        public int Ano;    
        public string Cor;

        //METODOS COMPORTAMENTOS
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Carro: {Marca} {Modelo}");
            Console.WriteLine($"Cor: {Cor}, Ano: {Ano}");
            Console.WriteLine("-------------------------");
        }
    }
}