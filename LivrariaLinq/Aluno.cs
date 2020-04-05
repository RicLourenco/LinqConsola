namespace LivrariaLinq
{
    using System;

    public class Aluno
    {
        public string PrimeirNome { get; set; }
        public string Apelido { get; set; }
        public DateTime DataNascimento { get; set; }
        public int DisciplinasFeitas { get; set; }
        public string NomeCompleto => $"{PrimeirNome} {Apelido}";
    }
}
