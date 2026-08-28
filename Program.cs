namespace abstracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CRIANDO O OBJETO INSTANCIAÇÂO
            carro meuFusca = new carro();
            meuFusca.Marca = "Volkswagen";
            meuFusca.Modelo = "Fusca";
            meuFusca.Ano = 1970;
            meuFusca.Cor = "Azul";

            carro carroVizinho = new carro();
            carroVizinho.Marca = "Chevrolet";
            carroVizinho.Modelo = "Corsa";
            carroVizinho.Ano = 2005;
            carroVizinho.Cor = "Prata";


            Console.WriteLine("Informações do carro:");
            meuFusca.ExibirInformacoes();

            Console.WriteLine("Informações do carro do vizinho:");
            carroVizinho.ExibirInformacoes();


            //EXERCICIO 1
            Produtos produto1 = new Produtos();

            produto1.Nome = "Notebook";
            produto1.Preco = 3500.00;
            produto1.QuantidadeEstoque = 10;


            Produtos produto2 = new Produtos();

            produto2.Nome = "Celular";
            produto2.Preco = 1800.00;
            produto2.QuantidadeEstoque = 25;


            //EXERCICIO 2
           namespace Abstracao
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Aluno Aluno = new Aluno();

                Console.WriteLine("Nome Completo:");
                Aluno.Nome = Console.ReadLine();
                Console.WriteLine("Número de Matrícula:");
                Aluno.Matricula = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("1ª Nota:");
                Aluno.Nota1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("2ª Nota:");
                Aluno.Nota2 = Convert.ToDouble(Console.ReadLine());

                Aluno.CalcularMedia();
            }
        }
    }


    Console.ReadKey();
        }
    }
}
