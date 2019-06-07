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
    public partial class ComestivelEditar : Form
    {
        public ComestivelEditar()
        {
            InitializeComponent();
        }

        public ComestivelEditar(Comestivel comestivel)
        {
            InitializeComponent();
            txtCodigo.Text = comestivel.id.ToString();
            txtNome.Text = comestivel.nome;
            txtValor.Text = Convert.ToString(comestivel.valor);
            dtpDataVencimento.Text = comestivel.dataVencimento.ToString();
            txtQuantidade.Text = Convert.ToString(comestivel.quantidade);
            txtMarca.Text = comestivel.marca;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Comestivel comestivel = new Comestivel();
            comestivel.id = Convert.ToInt32(txtCodigo.Text);
            comestivel.nome = txtNome.Text;
            comestivel.valor = Convert.ToDecimal(txtValor.Text);
            comestivel.dataVencimento = Convert.ToDateTime(dtpDataVencimento.Text);
            comestivel.quantidade = Convert.ToInt32(txtQuantidade.Text);
            comestivel.marca = txtMarca.Text;


            ComestiveisRepositorio repositorio = new ComestiveisRepositorio();
            repositorio.Atualizar(comestivel);

            MessageBox.Show("Editado com sucesso. ");
            Close();

        }

        private void ComestivelEditar_Load(object sender, EventArgs e)
        {

        }
    }
}
