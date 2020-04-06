namespace LivrariaLinq
{
    using System.Collections.Generic;
    using System;

    public class ListaDeAlunos
    {
        public static List<Aluno> LoadAlunos()
        {
            List<Aluno> output = new List<Aluno>();

            output.Add(new Aluno
            {
                PrimeiroNome = "Torres",
                Apelido = "Carlos",
                DataNascimento = Convert.ToDateTime("25/2/1970"),
                DisciplinasFeitas = 20
            });

            output.Add(new Aluno
            {
                PrimeiroNome = "Susana",
                Apelido = "Susana",
                DataNascimento = Convert.ToDateTime("31/3/1970"),
                DisciplinasFeitas = 1
            });

            output.Add(new Aluno
            {
                PrimeiroNome = "Susana",
                Apelido = "Sousa",
                DataNascimento = Convert.ToDateTime("1/3/1970"),
                DisciplinasFeitas = 11
            });

            output.Add(new Aluno
            {
                PrimeiroNome = "Sara",
                Apelido = "Jesuita",
                DataNascimento = Convert.ToDateTime("6/3/1970"),
                DisciplinasFeitas = 8
            });

            output.Add(new Aluno
            {
                PrimeiroNome = "Janota",
                Apelido = "Duarte",
                DataNascimento = Convert.ToDateTime("18/2/1970"),
                DisciplinasFeitas = 7
            });

            output.Add(new Aluno
            {
                PrimeiroNome = "Maria",
                Apelido = "Susana",
                DataNascimento = Convert.ToDateTime("23/1/1970"),
                DisciplinasFeitas = 16
            });

            return output;
        }
    }
}
