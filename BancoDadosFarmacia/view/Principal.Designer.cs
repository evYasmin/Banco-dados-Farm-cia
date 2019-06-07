namespace view
{
    partial class Principal
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
            this.btnProdutorHigienicos = new System.Windows.Forms.Button();
            this.btnRemedio = new System.Windows.Forms.Button();
            this.btnComestiveis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProdutorHigienicos
            // 
            this.btnProdutorHigienicos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnProdutorHigienicos.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F);
            this.btnProdutorHigienicos.Location = new System.Drawing.Point(12, 12);
            this.btnProdutorHigienicos.Name = "btnProdutorHigienicos";
            this.btnProdutorHigienicos.Size = new System.Drawing.Size(222, 118);
            this.btnProdutorHigienicos.TabIndex = 18;
            this.btnProdutorHigienicos.Text = "Produtos Higienicos";
            this.btnProdutorHigienicos.UseVisualStyleBackColor = false;
            this.btnProdutorHigienicos.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnRemedio
            // 
            this.btnRemedio.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRemedio.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F);
            this.btnRemedio.Location = new System.Drawing.Point(12, 260);
            this.btnRemedio.Name = "btnRemedio";
            this.btnRemedio.Size = new System.Drawing.Size(222, 118);
            this.btnRemedio.TabIndex = 19;
            this.btnRemedio.Text = "Remédios";
            this.btnRemedio.UseVisualStyleBackColor = false;
            this.btnRemedio.Click += new System.EventHandler(this.btnRemedios_Click);
            // 
            // btnComestiveis
            // 
            this.btnComestiveis.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnComestiveis.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F);
            this.btnComestiveis.Location = new System.Drawing.Point(12, 136);
            this.btnComestiveis.Name = "btnComestiveis";
            this.btnComestiveis.Size = new System.Drawing.Size(222, 118);
            this.btnComestiveis.TabIndex = 20;
            this.btnComestiveis.Text = "Comestíveis";
            this.btnComestiveis.UseVisualStyleBackColor = false;
            this.btnComestiveis.Click += new System.EventHandler(this.button1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 404);
            this.Controls.Add(this.btnComestiveis);
            this.Controls.Add(this.btnRemedio);
            this.Controls.Add(this.btnProdutorHigienicos);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProdutorHigienicos;
        private System.Windows.Forms.Button btnRemedio;
        private System.Windows.Forms.Button btnComestiveis;
    }
}