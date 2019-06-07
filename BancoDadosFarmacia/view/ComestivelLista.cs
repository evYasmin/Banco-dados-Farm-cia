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
    public partial class ComestivelLista : Form
    {

        public ComestivelLista()
        {
            InitializeComponent();
        }

        private void ComestivelLista_Load(object sender, EventArgs e)
        {


        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            ComestiveisRepositorio repositorio = new ComestiveisRepositorio();
            repositorio.Apagar(id);

            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ComestivelCadastro cadastro = new ComestivelCadastro();
            cadastro.ShowDialog();
        }

        private void AtualizarTabela()
        {
            ComestiveisRepositorio repositorio = new ComestiveisRepositorio();
            List<Comestivel> comestiveis = repositorio.Obtertodos();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < comestiveis.Count; i++)
            {
                Comestivel comestivel = comestiveis[i];
                dataGridView1.Rows.Add(
                    new object[]
                    {
                        comestivel.id , comestivel.nome , comestivel.valor , comestivel.quantidade , comestivel.marca
                    }
                    );
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            ComestiveisRepositorio repositorio = new ComestiveisRepositorio();
            Comestivel comestivel = repositorio.ObterPeloId(id);

            ComestivelEditar comestivelEditar = new ComestivelEditar(comestivel);
            comestivelEditar.ShowDialog();


        }

        private void ComestivelLista_Activated(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            ComestiveisRepositorio repositorio = new ComestiveisRepositorio();
            Comestivel comestivel = repositorio.ObterPeloId(id);

            ComestivelEditar comestivelEditar = new ComestivelEditar(comestivel);
            comestivelEditar.ShowDialog();

        }
    }
}
