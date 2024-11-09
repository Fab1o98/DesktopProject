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
    public partial class FrmRelatorio : Form
    {
        public FrmRelatorio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltarRelatorio_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxRelatorio.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um tipo de relatório.");
                return;
            }

            // String de conexão com o banco de dados
            SqlConnection conexao = new SqlConnection(@"Data Source=34.171.87.74;Initial Catalog=GREENLIFE_BD;Persist Security Info=True;User ID=sqlserver;Password=Pipizinhobolado@;Encrypt=False");
            string query = "";

            // Define a query SQL com base na seleção do ComboBox
            string opcaoSelecionada = comboBoxRelatorio.SelectedItem.ToString().Trim();
            if (opcaoSelecionada == "Relatório de produtos com saldo em estoque")
            {
                query = "SELECT * FROM Produtos WHERE qtd_kg > 0";
            }
            else if (opcaoSelecionada == "Relatório de produtos com o saldo zerado em estoque")
            {
                query = "SELECT * FROM Produtos WHERE qtd_kg = 0";
            }
            else
            {
                MessageBox.Show("Opção de relatório inválida.");
                return;
            }

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conexao);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Verifica se há dados para exibir
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum produto encontrado para o relatório selecionado.");
                }

                // Exibe os dados no DataGridView
                dataGridViewRelatorio.DataSource = dataTable;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao buscar os dados: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
