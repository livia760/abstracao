namespace abstracao
{
    using System;
    using System.Collections.Generic;

    public class Time
    {
        public string NomeDoTime { get; set; }
        public List<Jogador> ListaDeJogadores { get; set; }

        public Time()
        {
            ListaDeJogadores = new List<Jogador>();
        }

        public void AdicionarJogador(Jogador jogador)
        {
            ListaDeJogadores.Add(jogador);
        }

        public void ListarJogadores()
        {
            Console.WriteLine("Jogadores do time:");

            foreach (Jogador jogador in ListaDeJogadores)
            {
                Console.WriteLine("Nome: " + jogador.Nome);
                Console.WriteLine("Posição: " + jogador.Posicao);
                Console.WriteLine();
            }
        }
    }
}