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
    public partial class ComestivelCadastro : Form
    {
        public ComestivelCadastro()
        {
            InitializeComponent();
        }

        private void ComestivelCadastro_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            Comestivel comestivel = new Comestivel();
            comestivel.nome = txtNome.Text;
            comestivel.valor = Convert.ToDecimal(txtValor.Text);
            comestivel.dataVencimento = Convert.ToDateTime(dtpDataVencimento.Text);
            comestivel.quantidade = Convert.ToInt32(txtQuantidade.Text);
            comestivel.marca = txtMarca.Text;

            ComestiveisRepositorio repositorio = new ComestiveisRepositorio();
            repositorio.Inserir(comestivel);
            Close();

        }
    }
}
