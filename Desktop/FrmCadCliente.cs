using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class FrmCadCliente : Form
    {
        SqlConnection conexao = new SqlConnection(@"Data Source=34.171.87.74;Initial Catalog=GREENLIFE_BD;Persist Security Info=True;User ID=sqlserver;Password=Pipizinhobolado@;Encrypt=False");
        SqlCommand comando = new SqlCommand();
        SqlDataReader data;
        public FrmCadCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNomeCliente.Text) ||
                string.IsNullOrWhiteSpace(maskCnpj.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBoxTell1.Text) ||
                string.IsNullOrWhiteSpace(textBoxEndereco.Text) ||
                string.IsNullOrWhiteSpace(textBoxNumero.Text) ||
                string.IsNullOrWhiteSpace(textEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxUserCliente.Text) ||
                string.IsNullOrWhiteSpace(textSenha.Text))
            {
                MessageBox.Show("Digite os campos necessários.");
                return; 
            }

            SqlConnection conexao = new SqlConnection(@"Data Source=34.171.87.74;Initial Catalog=GREENLIFE_BD;Persist Security Info=True;User ID=sqlserver;Password=Pipizinhobolado@;Encrypt=False");


            string inserir = "INSERT INTO Cadastro(Nome, CNPJ, Telefone, TelefoneOpcional, Endereço, Numero, Email, Usuario, Senha) VALUES (@Nome, @CNPJ, @Telefone, @TelefoneOpcional, @Endereço, @Numero, @Email, @Usuario, @Senha)";

            try
            {
                SqlCommand conectar = new SqlCommand(inserir, conexao);

                conectar.Parameters.Add(new SqlParameter("@Nome",this.textBoxNomeCliente.Text));
                conectar.Parameters.Add(new SqlParameter("@CNPJ", this.maskCnpj.Text));
                conectar.Parameters.Add(new SqlParameter("@Telefone", this.maskedTextBoxTell1.Text));
                conectar.Parameters.Add(new SqlParameter("@TelefoneOpcional", this.maskedTextBoxTellOp.Text));
                conectar.Parameters.Add(new SqlParameter("@Endereço", this.textBoxEndereco.Text));
                conectar.Parameters.Add(new SqlParameter("@Numero", this.textBoxNumero.Text));
                conectar.Parameters.Add(new SqlParameter("@Email", this.textEmail.Text));
                conectar.Parameters.Add(new SqlParameter("@Usuario", this.textBoxUserCliente.Text));
                conectar.Parameters.Add(new SqlParameter("@Senha", this.textSenha.Text));

                conexao.Open();

                conectar.ExecuteNonQuery();

                conexao.Close();

                MessageBox.Show("Cadastrado com sucesso!");
            }
            catch (SqlException Erro)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + Erro);
            }
            finally {
                conexao.Close(); 
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadCliente_Load(object sender, EventArgs e)
        {

        }

        private void maskCnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnVoltarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLimparCadastroCliente_Click(object sender, EventArgs e)
        {
            textBoxNomeCliente.Clear();
            maskCnpj.Clear();
            maskedTextBoxTell1.Clear();
            maskedTextBoxTellOp.Clear();
            textEmail.Clear();
            textBoxEndereco.Clear();
            textBoxNumero.Clear();
            textBoxUserCliente.Clear();
            textSenha.Clear();
        }

       
    }
}
