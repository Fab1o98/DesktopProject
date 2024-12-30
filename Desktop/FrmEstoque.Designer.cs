namespace Desktop
{
    partial class FrmEstoque
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
            this.dtGridViewEstoque = new System.Windows.Forms.DataGridView();
            this.btnAdicionarSaldo = new System.Windows.Forms.Button();
            this.btnRetiraSaldo = new System.Windows.Forms.Button();
            this.btnVoltarEstoque = new System.Windows.Forms.Button();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.labelProduto = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.comboBoxTipoProduto = new System.Windows.Forms.ComboBox();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelPreco = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewEstoque)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridViewEstoque
            // 
            this.dtGridViewEstoque.AllowUserToAddRows = false;
            this.dtGridViewEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridViewEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridViewEstoque.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGridViewEstoque.Location = new System.Drawing.Point(12, 252);
            this.dtGridViewEstoque.Name = "dtGridViewEstoque";
            this.dtGridViewEstoque.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtGridViewEstoque.Size = new System.Drawing.Size(877, 382);
            this.dtGridViewEstoque.TabIndex = 4;
            // 
            // btnAdicionarSaldo
            // 
            this.btnAdicionarSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarSaldo.Location = new System.Drawing.Point(662, 89);
            this.btnAdicionarSaldo.Name = "btnAdicionarSaldo";
            this.btnAdicionarSaldo.Size = new System.Drawing.Size(98, 29);
            this.btnAdicionarSaldo.TabIndex = 7;
            this.btnAdicionarSaldo.Text = "Adicionar Saldo";
            this.btnAdicionarSaldo.UseVisualStyleBackColor = true;
            this.btnAdicionarSaldo.Click += new System.EventHandler(this.btnAdicionarSaldo_Click);
            // 
            // btnRetiraSaldo
            // 
            this.btnRetiraSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRetiraSaldo.Location = new System.Drawing.Point(792, 88);
            this.btnRetiraSaldo.Name = "btnRetiraSaldo";
            this.btnRetiraSaldo.Size = new System.Drawing.Size(98, 30);
            this.btnRetiraSaldo.TabIndex = 8;
            this.btnRetiraSaldo.Text = "Retirar Saldo";
            this.btnRetiraSaldo.UseVisualStyleBackColor = true;
            this.btnRetiraSaldo.Click += new System.EventHandler(this.btnRetiraSaldo_Click);
            // 
            // btnVoltarEstoque
            // 
            this.btnVoltarEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltarEstoque.AutoSize = true;
            this.btnVoltarEstoque.Location = new System.Drawing.Point(15, 640);
            this.btnVoltarEstoque.Name = "btnVoltarEstoque";
            this.btnVoltarEstoque.Size = new System.Drawing.Size(94, 29);
            this.btnVoltarEstoque.TabIndex = 9;
            this.btnVoltarEstoque.Text = "Voltar ao Inicio";
            this.btnVoltarEstoque.UseVisualStyleBackColor = true;
            this.btnVoltarEstoque.Click += new System.EventHandler(this.btnVoltarEstoque_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProduto.Location = new System.Drawing.Point(18, 89);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(336, 20);
            this.txtProduto.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.Location = new System.Drawing.Point(552, 134);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(83, 21);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // labelCodigo
            // 
            this.labelCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(19, 118);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(40, 13);
            this.labelCodigo.TabIndex = 12;
            this.labelCodigo.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo.Location = new System.Drawing.Point(19, 134);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(162, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // labelProduto
            // 
            this.labelProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProduto.AutoSize = true;
            this.labelProduto.Location = new System.Drawing.Point(15, 73);
            this.labelProduto.Name = "labelProduto";
            this.labelProduto.Size = new System.Drawing.Size(44, 13);
            this.labelProduto.TabIndex = 14;
            this.labelProduto.Text = "Produto";
            // 
            // txtQtd
            // 
            this.txtQtd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQtd.Location = new System.Drawing.Point(370, 88);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(265, 20);
            this.txtQtd.TabIndex = 6;
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Location = new System.Drawing.Point(367, 72);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(62, 13);
            this.labelQuantidade.TabIndex = 19;
            this.labelQuantidade.Text = "Quantidade";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(15, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 49);
            this.panel1.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(381, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Estoque";
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirProduto.Location = new System.Drawing.Point(792, 124);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(98, 30);
            this.btnExcluirProduto.TabIndex = 22;
            this.btnExcluirProduto.Text = "Excluir Produto ";
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click_1);
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovoProduto.Location = new System.Drawing.Point(662, 124);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(98, 31);
            this.btnNovoProduto.TabIndex = 23;
            this.btnNovoProduto.Text = "Novo Produto";
            this.btnNovoProduto.UseVisualStyleBackColor = true;
            this.btnNovoProduto.Click += new System.EventHandler(this.btnNovoProduto_Click);
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Location = new System.Drawing.Point(17, 184);
            this.txtDescricaoProduto.Multiline = true;
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(871, 58);
            this.txtDescricaoProduto.TabIndex = 24;
            
            // 
            // labelDescricao
            // 
            this.labelDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(16, 168);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(110, 13);
            this.labelDescricao.TabIndex = 25;
            this.labelDescricao.Text = "Descrição do Produto";
            
            // 
            // comboBoxTipoProduto
            // 
            this.comboBoxTipoProduto.FormattingEnabled = true;
            this.comboBoxTipoProduto.Items.AddRange(new object[] {
            "Legumes",
            "Verduras",
            "Frutas"});
            this.comboBoxTipoProduto.Location = new System.Drawing.Point(203, 134);
            this.comboBoxTipoProduto.Name = "comboBoxTipoProduto";
            this.comboBoxTipoProduto.Size = new System.Drawing.Size(151, 21);
            this.comboBoxTipoProduto.TabIndex = 26;
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPreco.Location = new System.Drawing.Point(370, 134);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(162, 20);
            this.textBoxPreco.TabIndex = 27;
            // 
            // labelTipo
            // 
            this.labelTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(200, 118);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(28, 13);
            this.labelTipo.TabIndex = 28;
            this.labelTipo.Text = "Tipo";
            // 
            // labelPreco
            // 
            this.labelPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPreco.AutoSize = true;
            this.labelPreco.Location = new System.Drawing.Point(367, 118);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(35, 13);
            this.labelPreco.TabIndex = 29;
            this.labelPreco.Text = "Preço";
            // 
            // FrmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(905, 681);
            this.Controls.Add(this.labelPreco);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.textBoxPreco);
            this.Controls.Add(this.comboBoxTipoProduto);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.txtDescricaoProduto);
            this.Controls.Add(this.btnNovoProduto);
            this.Controls.Add(this.btnExcluirProduto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.labelQuantidade);
            this.Controls.Add(this.labelProduto);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.btnVoltarEstoque);
            this.Controls.Add(this.btnRetiraSaldo);
            this.Controls.Add(this.btnAdicionarSaldo);
            this.Controls.Add(this.dtGridViewEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmEstoque";
            this.Text = "FrmEstoque";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewEstoque)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridViewEstoque;
        private System.Windows.Forms.Button btnAdicionarSaldo;
        private System.Windows.Forms.Button btnRetiraSaldo;
        private System.Windows.Forms.Button btnVoltarEstoque;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label labelProduto;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Button btnNovoProduto;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.ComboBox comboBoxTipoProduto;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelPreco;
    }
}