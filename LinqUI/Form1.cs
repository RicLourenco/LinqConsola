using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivrariaLinq;

namespace LinqUI
{
    public partial class Form1 : Form
    {
        List<Aluno> Alunos = ListaDeAlunos.LoadAlunos();
        public Form1()
        {
            InitializeComponent();
            InitCombo();
        }

        private void InitCombo()
        {
            CB_TodosAlunos.DataSource = Alunos;
            CB_TodosAlunos.DisplayMember = "NomeCompleto";

            Listbox_filtro.DataSource = Alunos.Where(x=>x.DisciplinasFeitas > 10).OrderBy(x=>x.PrimeiroNome).ThenBy(x=>x.Apelido).ToList();

            Listbox_filtro.DisplayMember = "NomeCompleto";
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            Aluno AlunoSelecionado = (Aluno)CB_TodosAlunos.SelectedItem;

            AlunoSelecionado.DisciplinasFeitas = Convert.ToInt32(Numeric_DisciplinasFeitas.Value);

            UpdateData();
        }

        private void CB_TodosAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Aluno AlunoSelecionado = (Aluno)CB_TodosAlunos.SelectedItem;

            Numeric_DisciplinasFeitas.Value = AlunoSelecionado.DisciplinasFeitas;
            AlunoSelecionado.DisciplinasFeitas = Convert.ToInt32(Numeric_DisciplinasFeitas.Value);

            UpdateData();
        }

        private void UpdateData()
        {
            Listbox_filtro.DataSource = Alunos.Where(x => x.DisciplinasFeitas > 10).OrderBy(x => x.PrimeiroNome).ThenBy(x => x.Apelido).ToList();
        }
    }
}
