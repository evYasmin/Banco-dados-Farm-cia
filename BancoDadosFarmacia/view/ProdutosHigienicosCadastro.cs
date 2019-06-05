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
    public partial class ProdutosHigienicosCadastro : Form
    {
        public ProdutosHigienicosCadastro()
        {
            InitializeComponent();
        }

        private void lblPreco_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProdutoHigienico produtoHigienico = new ProdutoHigienico();
            produtoHigienico.Nome = txtNome.Text;
            produtoHigienico.Preco = Convert.ToDecimal(txtPreco.Text);
            produtoHigienico.Categoria = cbCategoria.SelectedItem.ToString();
            ProdutoHigienicoRepositorio repositorio = new ProdutoHigienicoRepositorio();
            repositorio.Inserir(produtoHigienico);
            Close();
        }
    }
}
