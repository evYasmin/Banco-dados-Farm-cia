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
    public partial class RemedioEditar : Form
    {
        public RemedioEditar()
        {
            InitializeComponent();
        }

        public RemedioEditar(Remedio remedio)
        {
            InitializeComponent();
            txtNome.Text = remedio.Nome;
            cbCategoria.SelectedItem = remedio.Categoria;
            if (remedio.PrecisaReceita)
            {
                rbSimReceita.Checked = true;
            }
            else
            {
                rbNaoReceita.Checked = true;
            }
            if (remedio.Generico)
            {
                rbSimGenerico.Checked = true;
            }
            else
            {
                rbNaoGenerico.Checked = true;
            }
            if (remedio.Solido)
            {
                rbSimSolido.Checked = true;
            }
            else
            {
                rbNaoSolido.Checked = true;
            }
            rtbBula.Text = remedio.Bula;
            rtbContraIndicacoes.Text = remedio.ContraIndicacoes;
            cbFaixa.SelectedItem = remedio.Faixa;
            txtCodigo.Text = remedio.Id.ToString();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Remedio remedio = new Remedio();
            remedio.Id = Convert.ToInt32(txtCodigo.Text);
            remedio.Nome = txtNome.Text;
            remedio.Categoria = cbCategoria.SelectedItem.ToString();
            remedio.Generico = rbSimGenerico.Checked;
            remedio.ContraIndicacoes = rtbContraIndicacoes.Text;
            remedio.Bula = rtbBula.Text;
            remedio.Faixa = cbFaixa.SelectedItem.ToString();
            remedio.PrecisaReceita = rbSimReceita.Checked;
            remedio.Solido = rbSimSolido.Checked;

            RemedioRepositorio repositorio = new RemedioRepositorio();
            repositorio.Atualizar(remedio);

            MessageBox.Show("Editado com sucesso.");
            Close();
        }

        private void RemedioEditar_Load(object sender, EventArgs e)
        {

        }
    }
}
