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
    public partial class ProdutoHigienicoEditar : Form
    {
        public ProdutoHigienicoEditar()
        {
            InitializeComponent();
        }

        public ProdutoHigienicoEditar(ProdutoHigienico produtoHigienico)
        {
            InitializeComponent();
            txtCodigo.Text = Convert.ToString(produtoHigienico.Id);
            txtNome.Text = produtoHigienico.Nome;
            txtPreco.Text = Convert.ToString(produtoHigienico.Preco);
            cbCategoria.SelectedItem = produtoHigienico.Categoria;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProdutoHigienico produtoHigienico = new ProdutoHigienico();
            produtoHigienico.Id = Convert.ToInt32(txtCodigo.Text);
            produtoHigienico.Nome = txtNome.Text;
            produtoHigienico.Preco = Convert.ToDecimal(txtPreco.Text);
            produtoHigienico.Categoria = cbCategoria.SelectedItem.ToString();
            ProdutoHigienicoRepositorio repositorio = new ProdutoHigienicoRepositorio();
            repositorio.Atualizar(produtoHigienico);

            MessageBox.Show("Editado com sucesso.");
            Close();
        }
    }
}
