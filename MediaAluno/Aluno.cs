using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAluno
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public int N1 { get; set; }
        public int N2 { get; set; }
        public int N3 { get; set; }

        public Aluno() { }

        public Aluno(string nome, int n1, int n2, int n3)
        {
            Nome = nome;
            N1 = n1;
            N2 = n2;
            N3 = n3;
        }

        public int Media()
        {
            return (N1 + N2 + N3) / 3;
        }

        /*Verificando se o aluno passou de ano, para passar a sua média precisa ser maior ou igual a 60*/
        public bool Resultado()
        {
            if (Media() >= 60)
            {
                return true;
            }

            else if (Media() < 60)
            {
                return false;
            }
            return false;
        }

        //Verificando quantos pontos faltou para o aluno passar de ano
        public int Faltou()
        {
            if (Resultado()) { return 0; }

            else 
            {
                return 60 - Media();
            }
            return 0;
        }

        public override string ToString()
        {


            StringBuilder ST = new StringBuilder();
            ST.AppendLine("Nota final: "+Media().ToString("F2"));

            /*Confirmando se o aluno foi aprovado ou não */
            if (Resultado())
            {
                ST.AppendLine("Aprovado");
            }

            else 
            {
                ST.AppendLine("Reprovado");
                ST.AppendLine("Faltou " + Faltou().ToString("F2") + " pontos");
            }

            return ST.ToString();
        }
    }
}
