namespace LinqConsola
{
    using LivrariaLinq;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> Alunos = ListaDeAlunos.LoadAlunos();

            //Ordenar a lista por apelido
            Alunos = Alunos.OrderBy(x => x.Apelido).ToList();

            //Alunos = Alunos.OrderByDescending(x => x.Apelido).ThenByDescending(x => x.DisciplinasFeitas).ToList();

            //Alunos = Alunos.Where(x=>x.DisciplinasFeitas > 10 && x.DataNascimento.Month == 3).ToList();

            foreach (var aluno in Alunos)
            {
                Console.WriteLine($"{aluno.PrimeiroNome} {aluno.Apelido} ({aluno.DataNascimento.ToShortDateString()}) Disciplinas feitas: {aluno.DisciplinasFeitas.ToString()}");
            }

            int TotalDisciplinasFeitas = Alunos.Sum(x=>x.DisciplinasFeitas);

            double MediaDisciplinasFeitas = Alunos.Average(x => x.DisciplinasFeitas);

            Console.WriteLine($"Total de  disciplinas feitas: {TotalDisciplinasFeitas}");
            
            Console.WriteLine($"Média de  disciplinas feitas: {MediaDisciplinasFeitas:N2}");

            TotalDisciplinasFeitas = Alunos.Where(x => x.DataNascimento.Month == 2).Sum(x => x.DisciplinasFeitas);

            MediaDisciplinasFeitas = Alunos.Where(x => x.DataNascimento.Month == 2).Average(x => x.DisciplinasFeitas);

            Console.WriteLine($"Total de  disciplinas feitas dos nascidos no mês de Fevereiro: {TotalDisciplinasFeitas}");

            Console.WriteLine($"Média de  disciplinas feitas dos nascido no mês de Fevereiro: {MediaDisciplinasFeitas:N2}");

            Console.ReadKey();
        }
    }
}
