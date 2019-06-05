namespace view
{
    partial class ProdutoHigienicoEditar
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
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSalvar.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F);
            this.btnSalvar.Location = new System.Drawing.Point(199, 269);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(123, 48);
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
            "Sabonete",
            "Perfume",
            "Shampoo",
            "Cotonete"});
            this.cbCategoria.Location = new System.Drawing.Point(16, 222);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(306, 30);
            this.cbCategoria.TabIndex = 16;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F);
            this.txtNome.Location = new System.Drawing.Point(16, 92);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(306, 30);
            this.txtNome.TabIndex = 15;
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F);
            this.txtPreco.Location = new System.Drawing.Point(16, 150);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(306, 30);
            this.txtPreco.TabIndex = 14;
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
            this.lblCategoria.Location = new System.Drawing.Point(12, 196);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(109, 22);
            this.lblCategoria.TabIndex = 12;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(12, 125);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(65, 22);
            this.lblPreco.TabIndex = 11;
            this.lblPreco.Text = "Preço";
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
            // ProdutoHigienicoEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 350);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCodigo);
            this.Name = "ProdutoHigienicoEditar";
            this.Text = "ProdutoHigienicoEditar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
    }
}