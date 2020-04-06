namespace LivrariaLinq
{
    using System;

    public class Aluno
    {
        public string PrimeiroNome { get; set; }
        public string Apelido { get; set; }
        public DateTime DataNascimento { get; set; }
        public int DisciplinasFeitas { get; set; }
        public string NomeCompleto => $"{PrimeiroNome} {Apelido}";
    }
}
