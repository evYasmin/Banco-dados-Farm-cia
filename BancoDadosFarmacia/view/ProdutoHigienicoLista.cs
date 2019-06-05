using Model;
using Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace view
{
    public partial class ProdutoHigienicoLista : Form
    {
        public ProdutoHigienicoLista()
        {
            InitializeComponent();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            ProdutoHigienicoRepositorio repositorio = new ProdutoHigienicoRepositorio();
            repositorio.Apagar(id);

            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ProdutosHigienicosCadastro cadastro = new ProdutosHigienicosCadastro();
            cadastro.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(
                dataGridView1.CurrentRow.Cells[0].Value);
            ProdutoHigienicoRepositorio repositorio = new ProdutoHigienicoRepositorio();
            ProdutoHigienico produtoHigienico = repositorio.ObterPeloId(id);

            ProdutoHigienicoEditar produtoHigienicoEditar = new ProdutoHigienicoEditar(produtoHigienico);
            produtoHigienicoEditar.ShowDialog();

        }

        private void AtualizarTabela()
        {
            ProdutoHigienicoRepositorio repositorio = new ProdutoHigienicoRepositorio();
            List<ProdutoHigienico> produtoHigienicos = repositorio.ObterTodos();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < produtoHigienicos.Count; i++)
            {
                ProdutoHigienico produtoHigienico = produtoHigienicos[i];
                dataGridView1.Rows.Add(
                    new object[] {
                        produtoHigienico.Id , produtoHigienico.Nome,
                        produtoHigienico.Categoria
                    });
            }
        }

        private void ProdutoHigienicoLista_Load(object sender, EventArgs e)
        {

        }

        private void ProdutoHigienicoLista_Activated(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
