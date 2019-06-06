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
            this.btnRemedios = new System.Windows.Forms.Button();
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
            // btnRemedios
            // 
            this.btnRemedios.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRemedios.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F);
            this.btnRemedios.Location = new System.Drawing.Point(254, 12);
            this.btnRemedios.Name = "btnRemedios";
            this.btnRemedios.Size = new System.Drawing.Size(222, 118);
            this.btnRemedios.TabIndex = 19;
            this.btnRemedios.Text = "Remedios";
            this.btnRemedios.UseVisualStyleBackColor = false;
            this.btnRemedios.Click += new System.EventHandler(this.btnRemedios_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 317);
            this.Controls.Add(this.btnRemedios);
            this.Controls.Add(this.btnProdutorHigienicos);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProdutorHigienicos;
        private System.Windows.Forms.Button btnRemedios;
    }
}