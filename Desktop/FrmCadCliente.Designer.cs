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
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.btnVoltaInicio = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.maskCnpj = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.btnLimparCadastroCliente = new System.Windows.Forms.Button();
            this.maskedTextBoxTellOp = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxUserCliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskedTextBoxTell1
            // 
            this.maskedTextBoxTell1.Location = new System.Drawing.Point(131, 280);
            this.maskedTextBoxTell1.Mask = "(00)00000-0000";
            this.maskedTextBoxTell1.Name = "maskedTextBoxTell1";
            this.maskedTextBoxTell1.Size = new System.Drawing.Size(291, 20);
            this.maskedTextBoxTell1.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(128, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Telefone";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 84);
            this.panel1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Clientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Location = new System.Drawing.Point(819, 641);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(74, 28);
            this.btnCadastrarCliente.TabIndex = 36;
            this.btnCadastrarCliente.Text = "Cadastrar";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnVoltaInicio
            // 
            this.btnVoltaInicio.Location = new System.Drawing.Point(12, 641);
            this.btnVoltaInicio.Name = "btnVoltaInicio";
            this.btnVoltaInicio.Size = new System.Drawing.Size(87, 28);
            this.btnVoltaInicio.TabIndex = 35;
            this.btnVoltaInicio.Text = "Voltar ao Inicio";
            this.btnVoltaInicio.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "E-mail";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(131, 339);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(634, 20);
            this.textEmail.TabIndex = 29;
            // 
            // maskCnpj
            // 
            this.maskCnpj.Location = new System.Drawing.Point(131, 222);
            this.maskCnpj.Mask = "000.000.000.00";
            this.maskCnpj.Name = "maskCnpj";
            this.maskCnpj.Size = new System.Drawing.Size(634, 20);
            this.maskCnpj.TabIndex = 28;
            this.maskCnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskCnpj.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskCnpj_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "CNPJ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nome";
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.Location = new System.Drawing.Point(131, 169);
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
            // 
            // maskedTextBoxTellOp
            // 
            this.maskedTextBoxTellOp.Location = new System.Drawing.Point(474, 280);
            this.maskedTextBoxTellOp.Mask = "(00)00000-0000";
            this.maskedTextBoxTellOp.Name = "maskedTextBoxTellOp";
            this.maskedTextBoxTellOp.Size = new System.Drawing.Size(291, 20);
            this.maskedTextBoxTellOp.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Telefone Opcional ";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(131, 395);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(397, 20);
            this.textBoxEndereco.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Endereço";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(570, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Nº";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(570, 395);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(195, 20);
            this.textBoxNumero.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(177, 444);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Usúario";
            // 
            // textBoxUserCliente
            // 
            this.textBoxUserCliente.Location = new System.Drawing.Point(180, 460);
            this.textBoxUserCliente.Name = "textBoxUserCliente";
            this.textBoxUserCliente.Size = new System.Drawing.Size(388, 20);
            this.textBoxUserCliente.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(177, 500);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Senha";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(180, 516);
            this.textSenha.Name = "textSenha";
            this.textSenha.PasswordChar = '*';
            this.textSenha.Size = new System.Drawing.Size(388, 20);
            this.textSenha.TabIndex = 49;
            // 
            // FrmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(905, 681);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxUserCliente);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.maskedTextBoxTellOp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLimparCadastroCliente);
            this.Controls.Add(this.maskedTextBoxTell1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.btnVoltaInicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.maskCnpj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNomeCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadCliente";
            this.Text = "FrmCadCliente";
            this.Load += new System.EventHandler(this.FrmCadCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxTell1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Button btnVoltaInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.MaskedTextBox maskCnpj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNomeCliente;
        private System.Windows.Forms.Button btnLimparCadastroCliente;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTellOp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxUserCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textSenha;
    }
}