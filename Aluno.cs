namespace Abistruacao

{

    internal class Aluno

    {

        public string nome = Console.ReadLine();

        public int matricula = int.Parse(Console.ReadLine());

        public double nota1 = double.Parse(Console.ReadLine());

        public double nota2 = double.Parse(Console.ReadLine());


        public void calcularMedia()

        {

            double media = (nota1 + nota2) / 2;

            Console.WriteLine($"Média do aluno {nome} (Matrícula: {matricula}): {media}");

        }

    }

}