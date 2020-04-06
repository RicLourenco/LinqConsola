using System.Windows.Forms;
using LinqBD;
using System.Linq;
using System.Drawing;

namespace LinqUI_2
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            //ListView
            listView1.Columns.Add("ID");
            listView1.Columns.Add("Título");
            listView1.Columns.Add("Categoria");

            //Carregar os filmes
            var lista = from filme in dc.filmes select filme;

            foreach (var filme in lista)
            {
                ListViewItem item = listView1.Items.Add(filme.id.ToString());
                item.SubItems.Add(filme.titulo);
                item.SubItems.Add(filme.categoria);
            }

            for (int i = 0; i <= 2; i++)
            {
                listView1.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            //TreeView
            var outraLista = from categoria in dc.categorias
                             select categoria;

            foreach (var categoria in outraLista)
            {
                treeView1.Nodes.Add(categoria.sigla);
            }

            //Segundo nível da TreeView (filmes)
            var listaFilmes = from filme in dc.filmes
                              orderby filme.titulo
                              select filme;

            string catFilme;

            foreach (var filme in listaFilmes)
            {
                catFilme = filme.categoria;

                foreach (TreeNode node in treeView1.Nodes)
                {
                    if(node.Text == catFilme)
                    {
                        node.Nodes.Add(filme.titulo);
                    }
                }
            }

            //GridView
            dataGridView1.Columns.Add("colID", "ID");
            dataGridView1.Columns.Add("colTitulo", "Título");
            dataGridView1.Columns.Add("colCategoria", "Categoria");

            var outraListaDeFilmes = from filme in dc.filmes
                                     select filme;

            int linha = 0;

            DataGridViewCellStyle estilo = new DataGridViewCellStyle();
            estilo.ForeColor = Color.Red;

            foreach (var filme in outraListaDeFilmes)
            {
                DataGridViewRow registo = new DataGridViewRow();

                dataGridView1.Rows.Add(registo);

                dataGridView1.Rows[linha].Cells[0].Value = filme.id;
                dataGridView1.Rows[linha].Cells[1].Value = filme.titulo;
                dataGridView1.Rows[linha].Cells[2].Value = filme.categoria;

                if((string)dataGridView1.Rows[linha].Cells[2].Value == "FA")
                {
                    dataGridView1.Rows[linha].DefaultCellStyle = estilo;
                }

                linha++;
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
