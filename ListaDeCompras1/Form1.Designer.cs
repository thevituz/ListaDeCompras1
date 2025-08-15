namespace ListaDeCompras1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pibLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNomeDoProduto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.libCompras = new System.Windows.Forms.ListBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pibLogo
            // 
            this.pibLogo.Image = global::ListaDeCompras1.Properties.Resources.Rockettheme_Ecommerce_Basket_256__1_;
            this.pibLogo.Location = new System.Drawing.Point(468, 12);
            this.pibLogo.Name = "pibLogo";
            this.pibLogo.Size = new System.Drawing.Size(80, 84);
            this.pibLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibLogo.TabIndex = 0;
            this.pibLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(573, 49);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(119, 17);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Lista de Compras";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lblNomeDoProduto
            // 
            this.lblNomeDoProduto.AutoSize = true;
            this.lblNomeDoProduto.Location = new System.Drawing.Point(141, 145);
            this.lblNomeDoProduto.Name = "lblNomeDoProduto";
            this.lblNomeDoProduto.Size = new System.Drawing.Size(128, 17);
            this.lblNomeDoProduto.TabIndex = 2;
            this.lblNomeDoProduto.Text = "Nome Do Produto:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 24);
            this.textBox1.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(144, 238);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 27);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // libCompras
            // 
            this.libCompras.FormattingEnabled = true;
            this.libCompras.ItemHeight = 17;
            this.libCompras.Location = new System.Drawing.Point(382, 143);
            this.libCompras.Name = "libCompras";
            this.libCompras.Size = new System.Drawing.Size(404, 378);
            this.libCompras.TabIndex = 5;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(382, 527);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(200, 50);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(588, 527);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(198, 50);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar Lista";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 589);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.libCompras);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNomeDoProduto);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pibLogo);
            this.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Lista de Compras ::";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNomeDoProduto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListBox libCompras;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
    }
}

