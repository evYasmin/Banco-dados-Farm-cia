namespace view
{
    partial class RemedioCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblGenerico = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNaoGenerico = new System.Windows.Forms.RadioButton();
            this.rbSimGenerico = new System.Windows.Forms.RadioButton();
            this.rtbContraIndicacoes = new System.Windows.Forms.RichTextBox();
            this.lblContraIndicacoes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbBula = new System.Windows.Forms.RichTextBox();
            this.cbFaixa = new System.Windows.Forms.ComboBox();
            this.lblFaixa = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbNaoReceita = new System.Windows.Forms.RadioButton();
            this.rbSimReceita = new System.Windows.Forms.RadioButton();
            this.lblPrecisaReceita = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbNaoSolido = new System.Windows.Forms.RadioButton();
            this.rbSimSolido = new System.Windows.Forms.RadioButton();
            this.lblSolido = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSalvar.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F);
            this.btnSalvar.Location = new System.Drawing.Point(532, 315);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(130, 44);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F);
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Alopático",
            "Homeopático",
            "Similar",
            "Genérico",
            "de Referênca",
            "Manipulado"});
            this.cbCategoria.Location = new System.Drawing.Point(16, 163);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(306, 30);
            this.cbCategoria.TabIndex = 16;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F);
            this.txtNome.Location = new System.Drawing.Point(12, 92);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(306, 30);
            this.txtNome.TabIndex = 15;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F);
            this.txtCodigo.Location = new System.Drawing.Point(16, 34);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(306, 30);
            this.txtCodigo.TabIndex = 13;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(12, 137);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(109, 22);
            this.lblCategoria.TabIndex = 12;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 67);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(54, 22);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Nome";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(12, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(32, 22);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.Text = "Id";
            // 
            // lblGenerico
            // 
            this.lblGenerico.AutoSize = true;
            this.lblGenerico.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerico.Location = new System.Drawing.Point(6, 0);
            this.lblGenerico.Name = "lblGenerico";
            this.lblGenerico.Size = new System.Drawing.Size(120, 22);
            this.lblGenerico.TabIndex = 18;
            this.lblGenerico.Text = "É generico";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNaoGenerico);
            this.groupBox1.Controls.Add(this.rbSimGenerico);
            this.groupBox1.Controls.Add(this.lblGenerico);
            this.groupBox1.Location = new System.Drawing.Point(16, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 85);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rbNaoGenerico
            // 
            this.rbNaoGenerico.AutoSize = true;
            this.rbNaoGenerico.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNaoGenerico.Location = new System.Drawing.Point(155, 34);
            this.rbNaoGenerico.Name = "rbNaoGenerico";
            this.rbNaoGenerico.Size = new System.Drawing.Size(61, 26);
            this.rbNaoGenerico.TabIndex = 20;
            this.rbNaoGenerico.TabStop = true;
            this.rbNaoGenerico.Text = "Não";
            this.rbNaoGenerico.UseVisualStyleBackColor = true;
            // 
            // rbSimGenerico
            // 
            this.rbSimGenerico.AutoSize = true;
            this.rbSimGenerico.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSimGenerico.Location = new System.Drawing.Point(6, 34);
            this.rbSimGenerico.Name = "rbSimGenerico";
            this.rbSimGenerico.Size = new System.Drawing.Size(61, 26);
            this.rbSimGenerico.TabIndex = 19;
            this.rbSimGenerico.TabStop = true;
            this.rbSimGenerico.Text = "Sim";
            this.rbSimGenerico.UseVisualStyleBackColor = true;
            // 
            // rtbContraIndicacoes
            // 
            this.rtbContraIndicacoes.Location = new System.Drawing.Point(16, 340);
            this.rtbContraIndicacoes.Name = "rtbContraIndicacoes";
            this.rtbContraIndicacoes.Size = new System.Drawing.Size(306, 72);
            this.rtbContraIndicacoes.TabIndex = 20;
            this.rtbContraIndicacoes.Text = "";
            // 
            // lblContraIndicacoes
            // 
            this.lblContraIndicacoes.AutoSize = true;
            this.lblContraIndicacoes.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraIndicacoes.Location = new System.Drawing.Point(12, 315);
            this.lblContraIndicacoes.Name = "lblContraIndicacoes";
            this.lblContraIndicacoes.Size = new System.Drawing.Size(197, 22);
            this.lblContraIndicacoes.TabIndex = 21;
            this.lblContraIndicacoes.Text = "Contra Indicações";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Bula";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rtbBula
            // 
            this.rtbBula.Location = new System.Drawing.Point(16, 452);
            this.rtbBula.Name = "rtbBula";
            this.rtbBula.Size = new System.Drawing.Size(306, 72);
            this.rtbBula.TabIndex = 22;
            this.rtbBula.Text = "";
            this.rtbBula.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // cbFaixa
            // 
            this.cbFaixa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFaixa.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F);
            this.cbFaixa.FormattingEnabled = true;
            this.cbFaixa.Items.AddRange(new object[] {
            "Preta",
            "Vermelha",
            "Amarela",
            "Branca"});
            this.cbFaixa.Location = new System.Drawing.Point(356, 34);
            this.cbFaixa.Name = "cbFaixa";
            this.cbFaixa.Size = new System.Drawing.Size(306, 30);
            this.cbFaixa.TabIndex = 25;
            // 
            // lblFaixa
            // 
            this.lblFaixa.AutoSize = true;
            this.lblFaixa.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaixa.Location = new System.Drawing.Point(352, 10);
            this.lblFaixa.Name = "lblFaixa";
            this.lblFaixa.Size = new System.Drawing.Size(65, 22);
            this.lblFaixa.TabIndex = 24;
            this.lblFaixa.Text = "Faixa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbNaoReceita);
            this.groupBox2.Controls.Add(this.rbSimReceita);
            this.groupBox2.Controls.Add(this.lblPrecisaReceita);
            this.groupBox2.Location = new System.Drawing.Point(356, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 85);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // rbNaoReceita
            // 
            this.rbNaoReceita.AutoSize = true;
            this.rbNaoReceita.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNaoReceita.Location = new System.Drawing.Point(155, 34);
            this.rbNaoReceita.Name = "rbNaoReceita";
            this.rbNaoReceita.Size = new System.Drawing.Size(61, 26);
            this.rbNaoReceita.TabIndex = 20;
            this.rbNaoReceita.TabStop = true;
            this.rbNaoReceita.Text = "Não";
            this.rbNaoReceita.UseVisualStyleBackColor = true;
            // 
            // rbSimReceita
            // 
            this.rbSimReceita.AutoSize = true;
            this.rbSimReceita.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSimReceita.Location = new System.Drawing.Point(6, 34);
            this.rbSimReceita.Name = "rbSimReceita";
            this.rbSimReceita.Size = new System.Drawing.Size(61, 26);
            this.rbSimReceita.TabIndex = 19;
            this.rbSimReceita.TabStop = true;
            this.rbSimReceita.Text = "Sim";
            this.rbSimReceita.UseVisualStyleBackColor = true;
            // 
            // lblPrecisaReceita
            // 
            this.lblPrecisaReceita.AutoSize = true;
            this.lblPrecisaReceita.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecisaReceita.Location = new System.Drawing.Point(6, 0);
            this.lblPrecisaReceita.Name = "lblPrecisaReceita";
            this.lblPrecisaReceita.Size = new System.Drawing.Size(175, 22);
            this.lblPrecisaReceita.TabIndex = 18;
            this.lblPrecisaReceita.Text = "Precisa Receita";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbNaoSolido);
            this.groupBox3.Controls.Add(this.rbSimSolido);
            this.groupBox3.Controls.Add(this.lblSolido);
            this.groupBox3.Location = new System.Drawing.Point(356, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 85);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // rbNaoSolido
            // 
            this.rbNaoSolido.AutoSize = true;
            this.rbNaoSolido.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNaoSolido.Location = new System.Drawing.Point(155, 34);
            this.rbNaoSolido.Name = "rbNaoSolido";
            this.rbNaoSolido.Size = new System.Drawing.Size(61, 26);
            this.rbNaoSolido.TabIndex = 20;
            this.rbNaoSolido.TabStop = true;
            this.rbNaoSolido.Text = "Não";
            this.rbNaoSolido.UseVisualStyleBackColor = true;
            // 
            // rbSimSolido
            // 
            this.rbSimSolido.AutoSize = true;
            this.rbSimSolido.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSimSolido.Location = new System.Drawing.Point(6, 34);
            this.rbSimSolido.Name = "rbSimSolido";
            this.rbSimSolido.Size = new System.Drawing.Size(61, 26);
            this.rbSimSolido.TabIndex = 19;
            this.rbSimSolido.TabStop = true;
            this.rbSimSolido.Text = "Sim";
            this.rbSimSolido.UseVisualStyleBackColor = true;
            // 
            // lblSolido
            // 
            this.lblSolido.AutoSize = true;
            this.lblSolido.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolido.Location = new System.Drawing.Point(6, 0);
            this.lblSolido.Name = "lblSolido";
            this.lblSolido.Size = new System.Drawing.Size(98, 22);
            this.lblSolido.TabIndex = 18;
            this.lblSolido.Text = "É sólido";
            // 
            // RemedioCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 539);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbFaixa);
            this.Controls.Add(this.lblFaixa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbBula);
            this.Controls.Add(this.lblContraIndicacoes);
            this.Controls.Add(this.rtbContraIndicacoes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCodigo);
            this.Name = "RemedioCadastro";
            this.Text = "RemedioCadastro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblGenerico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNaoGenerico;
        private System.Windows.Forms.RadioButton rbSimGenerico;
        private System.Windows.Forms.RichTextBox rtbContraIndicacoes;
        private System.Windows.Forms.Label lblContraIndicacoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbBula;
        private System.Windows.Forms.ComboBox cbFaixa;
        private System.Windows.Forms.Label lblFaixa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbNaoReceita;
        private System.Windows.Forms.RadioButton rbSimReceita;
        private System.Windows.Forms.Label lblPrecisaReceita;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbNaoSolido;
        private System.Windows.Forms.RadioButton rbSimSolido;
        private System.Windows.Forms.Label lblSolido;
    }
}