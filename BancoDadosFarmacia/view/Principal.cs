﻿using System;
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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProdutoHigienicoLista produtoHigienicoLista = new ProdutoHigienicoLista();
            produtoHigienicoLista.ShowDialog(); 
        }

        private void btnRemedios_Click(object sender, EventArgs e)
        {

        }
    }
}
