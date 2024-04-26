using MediaAluno;
using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do aluno: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            Aluno aluno = new Aluno(nome, n1, n2, n3);

            Console.WriteLine(aluno);
        }
    }
}
