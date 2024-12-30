namespace Desktop
{
    partial class FrmCadCliente
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
            this.maskedTextBoxTell1 = new System.Windows.Forms.MaskedTextBox();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.btnVoltarCliente = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.maskCnpj = new System.Windows.Forms.MaskedTextBox();
            this.labelCNPJ = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.btnLimparCadastroCliente = new System.Windows.Forms.Button();
            this.maskedTextBoxTellOp = new System.Windows.Forms.MaskedTextBox();
            this.labelTelOp = new System.Windows.Forms.Label();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskedTextBoxTell1
            // 
            this.maskedTextBoxTell1.Location = new System.Drawing.Point(131, 273);
            this.maskedTextBoxTell1.Mask = "(00)00000-0000";
            this.maskedTextBoxTell1.Name = "maskedTextBoxTell1";
            this.maskedTextBoxTell1.Size = new System.Drawing.Size(291, 20);
            this.maskedTextBoxTell1.TabIndex = 39;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(128, 257);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(58, 13);
            this.labelTelefone.TabIndex = 38;
            this.labelTelefone.Text = "Telefone 1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 58);
            this.panel1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Clientes";
            
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Location = new System.Drawing.Point(819, 641);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(74, 28);
            this.btnCadastrarCliente.TabIndex = 36;
            this.btnCadastrarCliente.Text = "Cadastrar";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // btnVoltarCliente
            // 
            this.btnVoltarCliente.Location = new System.Drawing.Point(12, 641);
            this.btnVoltarCliente.Name = "btnVoltarCliente";
            this.btnVoltarCliente.Size = new System.Drawing.Size(87, 28);
            this.btnVoltarCliente.TabIndex = 35;
            this.btnVoltarCliente.Text = "Voltar ao Inicio";
            this.btnVoltarCliente.UseVisualStyleBackColor = true;
            this.btnVoltarCliente.Click += new System.EventHandler(this.btnVoltarCliente_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(128, 313);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 30;
            this.labelEmail.Text = "E-mail";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(131, 329);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(634, 20);
            this.textEmail.TabIndex = 29;
            // 
            // maskCnpj
            // 
            this.maskCnpj.Location = new System.Drawing.Point(131, 204);
            this.maskCnpj.Mask = "00.000.000.0000-00";
            this.maskCnpj.Name = "maskCnpj";
            this.maskCnpj.Size = new System.Drawing.Size(634, 20);
            this.maskCnpj.TabIndex = 28;
            this.maskCnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelCNPJ
            // 
            this.labelCNPJ.AutoSize = true;
            this.labelCNPJ.Location = new System.Drawing.Point(128, 188);
            this.labelCNPJ.Name = "labelCNPJ";
            this.labelCNPJ.Size = new System.Drawing.Size(34, 13);
            this.labelCNPJ.TabIndex = 27;
            this.labelCNPJ.Text = "CNPJ";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(128, 131);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 23;
            this.labelNome.Text = "Nome";
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.Location = new System.Drawing.Point(131, 147);
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.Size = new System.Drawing.Size(634, 20);
            this.textBoxNomeCliente.TabIndex = 22;
            // 
            // btnLimparCadastroCliente
            // 
            this.btnLimparCadastroCliente.Location = new System.Drawing.Point(739, 641);
            this.btnLimparCadastroCliente.Name = "btnLimparCadastroCliente";
            this.btnLimparCadastroCliente.Size = new System.Drawing.Size(74, 28);
            this.btnLimparCadastroCliente.TabIndex = 40;
            this.btnLimparCadastroCliente.Text = "Limpar";
            this.btnLimparCadastroCliente.UseVisualStyleBackColor = true;
            this.btnLimparCadastroCliente.Click += new System.EventHandler(this.btnLimparCadastroCliente_Click);
            // 
            // maskedTextBoxTellOp
            // 
            this.maskedTextBoxTellOp.Location = new System.Drawing.Point(474, 273);
            this.maskedTextBoxTellOp.Mask = "(00)00000-0000";
            this.maskedTextBoxTellOp.Name = "maskedTextBoxTellOp";
            this.maskedTextBoxTellOp.Size = new System.Drawing.Size(291, 20);
            this.maskedTextBoxTellOp.TabIndex = 42;
            // 
            // labelTelOp
            // 
            this.labelTelOp.AutoSize = true;
            this.labelTelOp.Location = new System.Drawing.Point(471, 257);
            this.labelTelOp.Name = "labelTelOp";
            this.labelTelOp.Size = new System.Drawing.Size(58, 13);
            this.labelTelOp.TabIndex = 41;
            this.labelTelOp.Text = "Telefone 2";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(131, 395);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(397, 20);
            this.textBoxEndereco.TabIndex = 43;
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(128, 379);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(53, 13);
            this.labelEndereco.TabIndex = 44;
            this.labelEndereco.Text = "Endereço";
            
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(570, 379);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(19, 13);
            this.labelNumero.TabIndex = 45;
            this.labelNumero.Text = "Nº";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(570, 395);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(195, 20);
            this.textBoxNumero.TabIndex = 46;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(128, 465);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(38, 13);
            this.labelSenha.TabIndex = 50;
            this.labelSenha.Text = "Senha";
            
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(131, 481);
            this.textSenha.Name = "textSenha";
            this.textSenha.PasswordChar = '*';
            this.textSenha.Size = new System.Drawing.Size(388, 20);
            this.textSenha.TabIndex = 49;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(716, 257);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(55, 13);
            this.labelInfo.TabIndex = 51;
            this.labelInfo.Text = "(Opcional)";
            // 
            // FrmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(905, 681);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.maskedTextBoxTellOp);
            this.Controls.Add(this.labelTelOp);
            this.Controls.Add(this.btnLimparCadastroCliente);
            this.Controls.Add(this.maskedTextBoxTell1);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.btnVoltarCliente);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.maskCnpj);
            this.Controls.Add(this.labelCNPJ);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxNomeCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmCadCliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCadCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxTell1;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Button btnVoltarCliente;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.MaskedTextBox maskCnpj;
        private System.Windows.Forms.Label labelCNPJ;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNomeCliente;
        private System.Windows.Forms.Button btnLimparCadastroCliente;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTellOp;
        private System.Windows.Forms.Label labelTelOp;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Label labelInfo;
    }
}