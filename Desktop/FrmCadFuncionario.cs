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
        SqlConnection conexao = new SqlConnection(@"Data Source=34.171.87.74;Initial Catalog=GREENLIFE_BD;Persist Security Info=True;User ID=sqlserver;Password=Pipizinhobolado@;Encrypt=False");
        SqlCommand comando = new SqlCommand();
        SqlDataReader data;

        public FrmCadFuncionario()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCadFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastroFuncionario_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=34.171.87.74;Initial Catalog=GREENLIFE_BD;Persist Security Info=True;User ID=sqlserver;Password=Pipizinhobolado@;Encrypt=False");


            string inserir = "INSERT INTO Colaboradores(Nome, CPF, Sexo, CodigoFuncionario, Setor, Usuario, Senha) VALUES (@Nome, @CPF, @Sexo, @CodigoFuncionario, @Setor, @Usuario, @Senha)";

            try
            {
                SqlCommand conectar = new SqlCommand(inserir, conexao);
                string setor = comboBoxSetor.SelectedItem.ToString();
                string selecionaSexo = "";

                if (radioButtonMasculino.Checked)
                {
                    selecionaSexo = "Masculino";
                }
                else if (radioButtonFeminino.Checked)
                {
                    selecionaSexo = "Feminino";
                }
                else
                {
                    MessageBox.Show("Por favor, selecione o sexo.");
                    return;
                }

                conectar.Parameters.Add(new SqlParameter("@Nome", this.textBoxNomeFuncionario.Text));
                conectar.Parameters.Add(new SqlParameter("@CPF", this.maskedTextBoxCpfFuncionario.Text));
                conectar.Parameters.Add(new SqlParameter("@Sexo", selecionaSexo));
                conectar.Parameters.Add(new SqlParameter("@CodigoFuncionario", this.maskedTextBoxIdFuncionario.Text));
                conectar.Parameters.Add(new SqlParameter("@Setor", setor));
                conectar.Parameters.Add(new SqlParameter("@Usuario", this.textBoxUsuarioFuncionario.Text));
                conectar.Parameters.Add(new SqlParameter("@Senha", this.textBoxSenhaFuncionario.Text));
                
                

                conexao.Open();

                conectar.ExecuteNonQuery();

                conexao.Close();

                MessageBox.Show("Cadastrado com sucesso!");
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + erro);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
