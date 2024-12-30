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
    public partial class FrmCadFuncionario : Form
    {
        // Caminho para conexão com o banco de dados. 
        // Comando para passar instrução SQL. 
        // Comando para leitura do banco de dados. 
        SqlConnection conexao = new SqlConnection(@"Data Source=34.171.87.74;Initial Catalog=GREENLIFE_BD;Persist Security Info=True;User ID=sqlserver;Password=Pipizinhobolado@;Encrypt=False");
        SqlCommand comando = new SqlCommand();
        SqlDataReader data;

        //Inicializando Form. 
        public FrmCadFuncionario()
        {
            InitializeComponent();
        }
        // Carregamento do Form.
        private void FrmCadFuncionario_Load(object sender, EventArgs e)
        {

        }
       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        // Botão de cadastrar o formulário no banco de dados. 
        private void btnCadastroFuncionario_Click(object sender, EventArgs e)
        {
            // Verifica se os campos estão vazios. 
            if (string.IsNullOrWhiteSpace(textBoxNomeFuncionario.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBoxCpfFuncionario.Text) ||
                (!radioButtonMasculino.Checked && !radioButtonFeminino.Checked) || 
                string.IsNullOrWhiteSpace(maskedTextBoxIdFuncionario.Text) ||
                comboBoxSetor.SelectedItem == null || 
                string.IsNullOrWhiteSpace(textBoxUsuarioFuncionario.Text) ||
                string.IsNullOrWhiteSpace(textBoxSenhaFuncionario.Text))
            {
                MessageBox.Show("Preencha todos os campos.");
                return; 
            }
            // Verifica se o CPF tem 11 digitos, não contando com "." e "-".
            string cpf = maskedTextBoxCpfFuncionario.Text.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
            {
                MessageBox.Show("O CPF deve conter 11 dígitos.");
                return;
            }

            SqlConnection conexao = new SqlConnection(@"Data Source=34.171.87.74;Initial Catalog=GREENLIFE_BD;Persist Security Info=True;User ID=sqlserver;Password=Pipizinhobolado@;Encrypt=False");

            string inserir = "INSERT INTO Colaboradores(Nome, CPF, Sexo, CodigoFuncionario, Setor, Usuario, Senha) VALUES (@Nome, @CPF, @Sexo, @CodigoFuncionario, @Setor, @Usuario, @Senha)";

            try
            {
                //Inserir dados no banco de dados. 
                SqlCommand conectar = new SqlCommand(inserir, conexao);

                
                string setor = comboBoxSetor.SelectedItem.ToString();
                string selecionaSexo = radioButtonMasculino.Checked ? "Masculino" : "Feminino";

                
                conectar.Parameters.Add(new SqlParameter("@Nome", textBoxNomeFuncionario.Text));
                conectar.Parameters.Add(new SqlParameter("@CPF", maskedTextBoxCpfFuncionario.Text));
                conectar.Parameters.Add(new SqlParameter("@Sexo", selecionaSexo));
                conectar.Parameters.Add(new SqlParameter("@CodigoFuncionario", maskedTextBoxIdFuncionario.Text));
                conectar.Parameters.Add(new SqlParameter("@Setor", setor));
                conectar.Parameters.Add(new SqlParameter("@Usuario", textBoxUsuarioFuncionario.Text));
                conectar.Parameters.Add(new SqlParameter("@Senha", textBoxSenhaFuncionario.Text));

                //Abre conexão.
                conexao.Open();
                //Executa a inserção dos dados. 
                conectar.ExecuteNonQuery();
                //Fecha conexão. 
                conexao.Close();

                MessageBox.Show("Cadastrado com sucesso!");
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + erro);
            }
            finally
            {
                // Fecha conexão total do bloco.
                conexao.Close();
            }
        }
        //Botão voltao ao inicio.
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            // Oculta o Form atual.
            this.Hide();
        }
        // Botão limpar formulário. 
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBoxNomeFuncionario.Clear();
            maskedTextBoxCpfFuncionario.Clear();
            radioButtonMasculino.Checked = false;
            radioButtonFeminino.Checked = false;
            maskedTextBoxIdFuncionario.Clear();
            comboBoxSetor.SelectedIndex = -1;
            textBoxUsuarioFuncionario.Clear();
            textBoxSenhaFuncionario.Clear();
        }
    }
}
