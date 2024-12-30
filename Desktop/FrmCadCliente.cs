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
        //Caminho para conexão com o banco de dados. 
        //Comando para executar comandos SQL.
        //Comando de leitura.
        SqlConnection conexao = new SqlConnection(@"Data Source=34.171.87.74;Initial Catalog=GREENLIFE_BD;Persist Security Info=True;User ID=sqlserver;Password=Pipizinhobolado@;Encrypt=False");
        SqlCommand comando = new SqlCommand();
        SqlDataReader data;

        //Inicializa componente. 
        public FrmCadCliente()
        {
            InitializeComponent();
        }

      
        //Botão de cadastro de cliente. 
        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            //Verifica se os campos estão vazios ou em branco. 
            if (string.IsNullOrWhiteSpace(textBoxNomeCliente.Text) ||
                string.IsNullOrWhiteSpace(maskCnpj.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBoxTell1.Text) ||
                string.IsNullOrWhiteSpace(textBoxEndereco.Text) ||
                string.IsNullOrWhiteSpace(textBoxNumero.Text) ||
                string.IsNullOrWhiteSpace(textEmail.Text) ||
                string.IsNullOrWhiteSpace(textSenha.Text))
            {
                MessageBox.Show("Digite os campos necessários.");
                return; 
            }
            //Verifica se o CNPJ tem 14 digitos, ignorando "-" e ".". 
            string cnpj = maskCnpj.Text.Replace(".","").Replace("-", "");
            if (cnpj.Length != 14)
                MessageBox.Show("O CNPJ deve conter 14 digitos.");

            //String para inserir os dados no banco de dados.
            string inserir = "INSERT INTO Cadastro(Nome, CNPJ, Telefone, TelefoneOpcional, Endereço, Numero, Email, Senha) VALUES (@Nome, @CNPJ, @Telefone, @TelefoneOpcional, @Endereço, @Numero, @Email, @Senha)";

            try
            {
                //Inserindo os dados no banco de dados. 
                SqlCommand conectar = new SqlCommand(inserir, conexao);

                conectar.Parameters.Add(new SqlParameter("@Nome",this.textBoxNomeCliente.Text));
                conectar.Parameters.Add(new SqlParameter("@CNPJ", this.maskCnpj.Text));
                conectar.Parameters.Add(new SqlParameter("@Telefone", this.maskedTextBoxTell1.Text));
                conectar.Parameters.Add(new SqlParameter("@TelefoneOpcional", this.maskedTextBoxTellOp.Text));
                conectar.Parameters.Add(new SqlParameter("@Endereço", this.textBoxEndereco.Text));
                conectar.Parameters.Add(new SqlParameter("@Numero", this.textBoxNumero.Text));
                conectar.Parameters.Add(new SqlParameter("@Email", this.textEmail.Text));
                conectar.Parameters.Add(new SqlParameter("@Senha", this.textSenha.Text));
                //Abre conexão. 
                conexao.Open();
                //Executa o comando de inserir os dados. 
                conectar.ExecuteNonQuery();
                //Fecha a conexão.
                conexao.Close();

                MessageBox.Show("Cadastrado com sucesso!");
            }
            catch (SqlException Erro)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + Erro);
            }
            finally {
                //Fecha toda a conexão se ainda continuar aberta.
                conexao.Close(); 
            }
        }

        // Carregamento do Form
        private void FrmCadCliente_Load(object sender, EventArgs e)
        {

        }

        
        //Botão voltar ao inicio. 
        private void btnVoltarCliente_Click(object sender, EventArgs e)
        {
            //Oculta form atual. 
            this.Hide();
        }
        //Botão Limpar campos de preenchimento. 
        private void btnLimparCadastroCliente_Click(object sender, EventArgs e)
        {
            textBoxNomeCliente.Clear();
            maskCnpj.Clear();
            maskedTextBoxTell1.Clear();
            maskedTextBoxTellOp.Clear();
            textEmail.Clear();
            textBoxEndereco.Clear();
            textBoxNumero.Clear();
            textSenha.Clear();
        }

       
    }
}
