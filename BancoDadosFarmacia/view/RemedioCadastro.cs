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
    public partial class RemedioCadastro : Form
    {
        public RemedioCadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Remedio remedio = new Remedio();
            remedio.Nome = txtNome.Text;
            remedio.Categoria = cbCategoria.SelectedItem.ToString();
            remedio.Generico = rbSimGenerico.Checked;
            remedio.ContraIndicacoes = rtbContraIndicacoes.Text;
            remedio.Bula = rtbBula.Text;
            remedio.Faixa = cbFaixa.SelectedItem.ToString();
            remedio.PrecisaReceita = rbSimReceita.Checked;
            remedio.Solido = rbSimSolido.Checked;

            RemedioRepositorio repositorio = new RemedioRepositorio();
            repositorio.Inserir(remedio);
            Close();
            


        }
    }
}
