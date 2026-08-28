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

    //EXERCICIO 3
    namespace abstracao
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                contabancaria conta1 = new contabancaria();
                conta1.Titular = "João Silva";
                conta1.NumeroConta = "12345-6";
                conta1.Saldo = "1500.00";
                contabancaria conta2 = new contabancaria();
                conta2.Titular = "Maria Souza";
                conta2.NumeroConta = "98765-4";
                conta2.Saldo = "2500.00";
                Console.WriteLine("Informações da Conta 1:");
                conta1.ExibirInformacoes();
                Console.WriteLine("\nInformações da Conta 2:");
                conta2.ExibirInformacoes();
            }
        }
    }
        //EXERCICIO 3
        namespace Abstracao
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                contabancaria conta1 = new contabancaria();
                conta1.Titular = "João Silva";
                conta1.NumeroConta = "12345-6";
                conta1.Saldo = "1500.00";

                contabancaria conta2 = new contabancaria();
                conta2.Titular = "Maria Souza";
                conta2.NumeroConta = "98765-4";
                conta2.Saldo = "2500.00";

                Console.WriteLine("Informações da Conta 1:");
                conta1.ExibirInformacoes();

                Console.WriteLine("\nInformações da Conta 2:");
                conta2.ExibirInformacoes();
            }
        }
    }

            //EXERCICIO 4
            using System;

            namespace Futebol
      {
        internal class Program
        {
            static void Main(string[] args)
            {
             
                Time meuTime = new Time();

                meuTime.NomeDoTime = "Flamengo";

             
                Jogador jogador1 = new Jogador();
                jogador1.Nome = "Gabriel";
                jogador1.Posicao = "Atacante";
                jogador1.NumeroCamisa = 10;

                Jogador jogador2 = new Jogador();
                jogador2.Nome = "João";
                jogador2.Posicao = "Meio-campo";
                jogador2.NumeroCamisa = 8;

                Jogador jogador3 = new Jogador();
                jogador3.Nome = "Pedro";
                jogador3.Posicao = "Atacante";
                jogador3.NumeroCamisa = 9;

               
                meuTime.AdicionarJogador(jogador1);
                meuTime.AdicionarJogador(jogador2);
                meuTime.AdicionarJogador(jogador3);

               
                Console.WriteLine("Time: " + meuTime.NomeDoTime);
                meuTime.ListarJogadores();

                Console.ReadLine();
            }
        }
    }


    Console.ReadKey();
        }
    }
}
