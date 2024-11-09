namespace Desktop
{
    partial class FrmCadFuncionario
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNomeFuncionario = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.radioButtonFeminino = new System.Windows.Forms.RadioButton();
            this.labelCPF = new System.Windows.Forms.Label();
            this.maskedTextBoxCpfFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.textBoxUsuarioFuncionario = new System.Windows.Forms.TextBox();
            this.labelNomeUsuario = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBoxSenhaFuncionario = new System.Windows.Forms.TextBox();
            this.labelSetor = new System.Windows.Forms.Label();
            this.comboBoxSetor = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastroFuncionario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maskedTextBoxIdFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.labelCodFuncionario = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Funcionarios";
            // 
            // textBoxNomeFuncionario
            // 
            this.textBoxNomeFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxNomeFuncionario.Location = new System.Drawing.Point(100, 154);
            this.textBoxNomeFuncionario.Name = "textBoxNomeFuncionario";
            this.textBoxNomeFuncionario.Size = new System.Drawing.Size(683, 20);
            this.textBoxNomeFuncionario.TabIndex = 1;
            // 
            // labelNome
            // 
            this.labelNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(97, 138);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(636, 199);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(31, 13);
            this.labelSexo.TabIndex = 3;
            this.labelSexo.Text = "Sexo";
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Location = new System.Drawing.Point(639, 215);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMasculino.TabIndex = 4;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // radioButtonFeminino
            // 
            this.radioButtonFeminino.AutoSize = true;
            this.radioButtonFeminino.Location = new System.Drawing.Point(718, 215);
            this.radioButtonFeminino.Name = "radioButtonFeminino";
            this.radioButtonFeminino.Size = new System.Drawing.Size(67, 17);
            this.radioButtonFeminino.TabIndex = 5;
            this.radioButtonFeminino.TabStop = true;
            this.radioButtonFeminino.Text = "Feminino";
            this.radioButtonFeminino.UseVisualStyleBackColor = true;
            this.radioButtonFeminino.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // labelCPF
            // 
            this.labelCPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(97, 198);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(27, 13);
            this.labelCPF.TabIndex = 7;
            this.labelCPF.Text = "CPF";
            // 
            // maskedTextBoxCpfFuncionario
            // 
            this.maskedTextBoxCpfFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.maskedTextBoxCpfFuncionario.Location = new System.Drawing.Point(100, 214);
            this.maskedTextBoxCpfFuncionario.Mask = "000-000-000-00";
            this.maskedTextBoxCpfFuncionario.Name = "maskedTextBoxCpfFuncionario";
            this.maskedTextBoxCpfFuncionario.Size = new System.Drawing.Size(466, 20);
            this.maskedTextBoxCpfFuncionario.TabIndex = 8;
            // 
            // textBoxUsuarioFuncionario
            // 
            this.textBoxUsuarioFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxUsuarioFuncionario.Location = new System.Drawing.Point(248, 401);
            this.textBoxUsuarioFuncionario.Name = "textBoxUsuarioFuncionario";
            this.textBoxUsuarioFuncionario.Size = new System.Drawing.Size(381, 20);
            this.textBoxUsuarioFuncionario.TabIndex = 9;
            // 
            // labelNomeUsuario
            // 
            this.labelNomeUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNomeUsuario.AutoSize = true;
            this.labelNomeUsuario.Location = new System.Drawing.Point(246, 385);
            this.labelNomeUsuario.Name = "labelNomeUsuario";
            this.labelNomeUsuario.Size = new System.Drawing.Size(89, 13);
            this.labelNomeUsuario.TabIndex = 10;
            this.labelNomeUsuario.Text = "Nome de Usuario";
            // 
            // labelSenha
            // 
            this.labelSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(245, 442);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(41, 13);
            this.labelSenha.TabIndex = 11;
            this.labelSenha.Text = "Senha ";
            // 
            // textBoxSenhaFuncionario
            // 
            this.textBoxSenhaFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSenhaFuncionario.Location = new System.Drawing.Point(248, 458);
            this.textBoxSenhaFuncionario.Name = "textBoxSenhaFuncionario";
            this.textBoxSenhaFuncionario.Size = new System.Drawing.Size(381, 20);
            this.textBoxSenhaFuncionario.TabIndex = 12;
            this.textBoxSenhaFuncionario.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // labelSetor
            // 
            this.labelSetor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSetor.AutoSize = true;
            this.labelSetor.Location = new System.Drawing.Point(99, 312);
            this.labelSetor.Name = "labelSetor";
            this.labelSetor.Size = new System.Drawing.Size(35, 13);
            this.labelSetor.TabIndex = 13;
            this.labelSetor.Text = "Setor ";
            // 
            // comboBoxSetor
            // 
            this.comboBoxSetor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxSetor.FormattingEnabled = true;
            this.comboBoxSetor.Items.AddRange(new object[] {
            "Administrativo",
            "Operacional"});
            this.comboBoxSetor.Location = new System.Drawing.Point(102, 328);
            this.comboBoxSetor.Name = "comboBoxSetor";
            this.comboBoxSetor.Size = new System.Drawing.Size(686, 21);
            this.comboBoxSetor.TabIndex = 14;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 641);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(87, 28);
            this.btnVoltar.TabIndex = 17;
            this.btnVoltar.Text = "Voltar ao Inicio";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCadastroFuncionario
            // 
            this.btnCadastroFuncionario.Location = new System.Drawing.Point(819, 641);
            this.btnCadastroFuncionario.Name = "btnCadastroFuncionario";
            this.btnCadastroFuncionario.Size = new System.Drawing.Size(74, 28);
            this.btnCadastroFuncionario.TabIndex = 18;
            this.btnCadastroFuncionario.Text = "Cadastrar";
            this.btnCadastroFuncionario.UseVisualStyleBackColor = true;
            this.btnCadastroFuncionario.Click += new System.EventHandler(this.btnCadastroFuncionario_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 63);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // maskedTextBoxIdFuncionario
            // 
            this.maskedTextBoxIdFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.maskedTextBoxIdFuncionario.Location = new System.Drawing.Point(102, 272);
            this.maskedTextBoxIdFuncionario.Name = "maskedTextBoxIdFuncionario";
            this.maskedTextBoxIdFuncionario.Size = new System.Drawing.Size(683, 20);
            this.maskedTextBoxIdFuncionario.TabIndex = 21;
            // 
            // labelCodFuncionario
            // 
            this.labelCodFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCodFuncionario.AutoSize = true;
            this.labelCodFuncionario.Location = new System.Drawing.Point(99, 256);
            this.labelCodFuncionario.Name = "labelCodFuncionario";
            this.labelCodFuncionario.Size = new System.Drawing.Size(101, 13);
            this.labelCodFuncionario.TabIndex = 20;
            this.labelCodFuncionario.Text = "Código Funcionário ";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(739, 641);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(74, 28);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FrmCadFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(905, 681);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.maskedTextBoxIdFuncionario);
            this.Controls.Add(this.labelCodFuncionario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCadastroFuncionario);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.comboBoxSetor);
            this.Controls.Add(this.labelSetor);
            this.Controls.Add(this.textBoxSenhaFuncionario);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelNomeUsuario);
            this.Controls.Add(this.textBoxUsuarioFuncionario);
            this.Controls.Add(this.maskedTextBoxCpfFuncionario);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.radioButtonFeminino);
            this.Controls.Add(this.radioButtonMasculino);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxNomeFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmCadFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmCadFuncionario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCadFuncionario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNomeFuncionario;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.RadioButton radioButtonFeminino;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpfFuncionario;
        private System.Windows.Forms.TextBox textBoxUsuarioFuncionario;
        private System.Windows.Forms.Label labelNomeUsuario;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox textBoxSenhaFuncionario;
        private System.Windows.Forms.Label labelSetor;
        private System.Windows.Forms.ComboBox comboBoxSetor;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadastroFuncionario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxIdFuncionario;
        private System.Windows.Forms.Label labelCodFuncionario;
        private System.Windows.Forms.Button btnLimpar;
    }
}