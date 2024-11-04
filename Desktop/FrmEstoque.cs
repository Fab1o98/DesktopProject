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
    public partial class FrmEstoque : Form
    {
        SqlConnection conexao = new SqlConnection(@"Data Source=34.171.87.74;Initial Catalog=GREENLIFE_BD;Persist Security Info=True;User ID=sqlserver;Password=Pipizinhobolado@;Encrypt=False");
        SqlCommand comando = new SqlCommand();
        SqlDataReader data;

        public FrmEstoque()
        {
            InitializeComponent();
            conexao.Open();
            string mostraDados = "SELECT * FROM Produtos";

            SqlDataAdapter exibir = new SqlDataAdapter(mostraDados, conexao);
            DataTable dt = new DataTable();
            exibir.Fill(dt);
            dtGridViewEstoque.DataSource = dt;

            conexao.Close();
        }

        private void FrmEstoque_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string produto = txtProduto.Text;
            string quantidadeTexto = txtQtd.Text;

            // Validação para garantir que todos os campos estejam preenchidos
            if (string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(produto) || string.IsNullOrWhiteSpace(quantidadeTexto))
            {
                MessageBox.Show("Preencher todos os campos!");
                return;
            }

            int quantidade;
            if (!int.TryParse(quantidadeTexto, out quantidade))
            {
                MessageBox.Show("Quantidade deve ser um número válido.");
                return;
            }

            
            try
            {
                conexao.Open();

                // Verificar se o produto existe no banco de dados com base no Código e Produto
                string queryVerificarProduto = "SELECT qtd_kg FROM Produtos WHERE Id = @Id AND Nome = @Nome";
                SqlCommand cmdVerificarProduto = new SqlCommand(queryVerificarProduto, conexao);
                cmdVerificarProduto.Parameters.AddWithValue("@Id", codigo);
                cmdVerificarProduto.Parameters.AddWithValue("@Nome", produto);

                object resultado = cmdVerificarProduto.ExecuteScalar();

                if (resultado == null)
                {
                    // Produto não encontrado
                    MessageBox.Show("Produto não encontrado.");
                }
                else
                {
                    int saldoAtual = Convert.ToInt32(resultado);

                    // Verificar se a quantidade a ser retirada é menor ou igual ao saldo atual
                    if (quantidade > saldoAtual)
                    {
                        MessageBox.Show("Quantidade a retirar excede o saldo atual.");
                    }
                    else
                    {
                        // Atualizar o saldo no banco de dados
                        string queryAtualizarSaldo = "UPDATE Produtos SET qtd_kg = qtd_kg - @qtd_kg WHERE Id = @Id AND Nome = @Nome";
                        SqlCommand cmdAtualizarSaldo = new SqlCommand(queryAtualizarSaldo, conexao);
                        cmdAtualizarSaldo.Parameters.AddWithValue("@qtd_kg", quantidade);
                        cmdAtualizarSaldo.Parameters.AddWithValue("@Id", codigo);
                        cmdAtualizarSaldo.Parameters.AddWithValue("@Nome", produto);
                        cmdAtualizarSaldo.ExecuteNonQuery();

                        MessageBox.Show("Saldo retirado com sucesso!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {




        }

        private void button6_Click(object sender, EventArgs e)
        {
            conexao.Open();

            // Variável para armazenar a consulta SQL
            string mostraDados;

            // Verificando se a pesquisa é numérica (pesquisa por Id)
            if (int.TryParse(txtCodigo.Text, out int idPesquisa))
            {
                // Consulta SQL para buscar somente pelo Id
                mostraDados = "SELECT * FROM Produtos WHERE Id = @Id";
            }
            else
            {
                // Consulta SQL para buscar pelo nome do produto
                mostraDados = "SELECT * FROM Produtos WHERE Nome LIKE @Nome";
            }


            SqlCommand cmd = new SqlCommand(mostraDados, conexao);

            // Adicionando os parâmetros corretos de acordo com o tipo de pesquisa
            if (int.TryParse(txtCodigo.Text, out idPesquisa))
            {
                // Se for numérico, usamos o Id
                cmd.Parameters.AddWithValue("@Id", idPesquisa);
            }
            else
            {
                // Se não for numérico, usamos o nome (usando LIKE para busca parcial)
                cmd.Parameters.AddWithValue("@Nome", "%" + txtProduto.Text + "%");
            }

            // Executando o comando e preenchendo o DataTable
            SqlDataAdapter exibir = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            exibir.Fill(dt);

            // Verificando se há resultados
            if (dt.Rows.Count > 0)
            {
                // Se o usuário digitou um Id e um Nome, validar se eles correspondem ao mesmo produto
                if (int.TryParse(txtCodigo.Text, out idPesquisa) && !string.IsNullOrWhiteSpace(txtProduto.Text))
                {
                    // Procurar o produto que tenha o Id e o Nome
                    DataRow[] resultado = dt.Select("Id = " + idPesquisa + " AND Nome LIKE '%" + txtProduto.Text + "%'");

                    // Se não houver resultados que correspondam ao Id e ao Nome, exibir erro
                    if (resultado.Length == 0)
                    {
                        MessageBox.Show("Este código não pertence ao produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Exibir o produto correspondente
                        dtGridViewEstoque.DataSource = resultado.CopyToDataTable();
                    }
                }
                else
                {
                    // Se a busca foi feita somente pelo Id, exibir apenas o resultado correspondente
                    dtGridViewEstoque.DataSource = dt;  // Neste caso, dt só deve ter um resultado se o Id foi buscado
                }
            }
            else
            {
                // Se não encontrar resultados, exibir mensagem de erro
                MessageBox.Show("Nenhum produto encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conexao.Close();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string produto = txtProduto.Text;
            string quantidadeTexto = txtQtd.Text;

            // Verificação para garantir que todos os campos estejam preenchidos
            if (string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(produto) || string.IsNullOrWhiteSpace(quantidadeTexto))
            {
                MessageBox.Show("Preencher todos os campos!");
                return;
            }

            int quantidade;
            if (!int.TryParse(quantidadeTexto, out quantidade))
            {
                MessageBox.Show("Quantidade deve ser um número válido.");
                return;
            }

            {
                try
                {
                    conexao.Open();

                    // Verificar se o produto existe no banco de dados com base no Código e Produto
                    string queryVerificarProduto = "SELECT COUNT(*) FROM Produtos WHERE Id = @Id AND Nome = @Nome";
                    SqlCommand cmdVerificarProduto = new SqlCommand(queryVerificarProduto, conexao);
                    cmdVerificarProduto.Parameters.AddWithValue("@Id", codigo);
                    cmdVerificarProduto.Parameters.AddWithValue("@Nome", produto);

                    int produtoExistente = (int)cmdVerificarProduto.ExecuteScalar();

                    if (produtoExistente == 0)
                    {
                        // Produto não encontrado
                        MessageBox.Show("Produto não encontrado.");
                    }
                    else
                    {
                        // Produto encontrado, atualizar a quantidade
                        string queryAtualizarSaldo = "UPDATE Produtos SET qtd_kg = qtd_kg + @qtd_kg WHERE Id = @Id AND Nome = @Nome";
                        SqlCommand cmdAtualizarSaldo = new SqlCommand(queryAtualizarSaldo, conexao);
                        cmdAtualizarSaldo.Parameters.AddWithValue("@qtd_kg", quantidade);
                        cmdAtualizarSaldo.Parameters.AddWithValue("@Id", codigo);
                        cmdAtualizarSaldo.Parameters.AddWithValue("@Nome", produto);
                        cmdAtualizarSaldo.ExecuteNonQuery();

                        MessageBox.Show("Saldo adicionado com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Obter os valores dos campos
            string codigo = txtCodigo.Text;
            string produto = txtProduto.Text;
            string quantidadeTexto = txtQtd.Text;
            string descricaoProduto = txtDescricaoProduto.Text;

            // Validação básica para campos vazios
            if (string.IsNullOrWhiteSpace(produto))
            {
                MessageBox.Show("Preencha os campos Código e Produto.");
                return;
            }

            if (string.IsNullOrWhiteSpace(quantidadeTexto))
            {
                MessageBox.Show("Preencha o campo Quantidade.");
                return;
            }

            int quantidade;
            if (!int.TryParse(quantidadeTexto, out quantidade))
            {
                MessageBox.Show("Quantidade deve ser um número válido.");
                return;
            }


            {
                try
                {
                    conexao.Open();

                    // Verificar se já existe um produto com o mesmo nome no banco de dados
                    string queryVerificarNome = "SELECT COUNT(*) FROM Produtos WHERE Nome = @Nome";
                    SqlCommand cmdVerificarNome = new SqlCommand(queryVerificarNome, conexao);
                    cmdVerificarNome.Parameters.AddWithValue("@Nome", produto);

                    int produtoExistente = (int)cmdVerificarNome.ExecuteScalar();

                    if (produtoExistente > 0)
                    {
                        // Produto com o mesmo nome já existe
                        MessageBox.Show("Esse produto já existe.");
                    }
                    else
                    {
                        // Produto não existe, inserir novo produto no estoque
                        string queryInserir = "INSERT INTO Produtos (Nome, qtd_kg,Descricao) VALUES ( @Nome, @qtd_kg, @Descricao)";
                        SqlCommand cmdInserir = new SqlCommand(queryInserir, conexao);
                        cmdInserir.Parameters.AddWithValue("@Nome", produto);
                        cmdInserir.Parameters.AddWithValue("@qtd_kg", quantidade);
                        cmdInserir.Parameters.AddWithValue("@Descricao", descricaoProduto);
                        cmdInserir.ExecuteNonQuery();

                        MessageBox.Show("Produto inserido e saldo adicionado com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            string codigo = txtCodigo.Text;
            string produto = txtProduto.Text;
            //string quantidadeTexto = txtQtd.Text;

            // Validação básica para campos vazios
            if (string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(produto))
            {
                MessageBox.Show("Preencha os campos Código, Produto.");
                return;
            }

            /*int quantidade;
            if (!int.TryParse(quantidadeTexto, out quantidade))
            {
                MessageBox.Show("Quantidade deve ser um número válido.");
                return;
            }*/


            {
                try
                {
                    conexao.Open();

                    // Verificar se o produto existe no banco de dados com base no Código, Produto e Quantidade
                    string queryVerificarProduto = "SELECT COUNT(*) FROM Produtos WHERE Id = @Id AND Nome = @Nome ";//AND qtd_kg = @qtd_kg
                    SqlCommand cmdVerificarProduto = new SqlCommand(queryVerificarProduto, conexao);
                    cmdVerificarProduto.Parameters.AddWithValue("@Id", codigo);
                    cmdVerificarProduto.Parameters.AddWithValue("@Nome", produto);
                    // cmdVerificarProduto.Parameters.AddWithValue("@qtg_kg", quantidade);

                    int produtoExistente = (int)cmdVerificarProduto.ExecuteScalar();

                    if (produtoExistente == 0)
                    {
                        // Produto não encontrado
                        MessageBox.Show("Produto não encontrado. Verifique os campos Código, Produto e Quantidade.");
                    }
                    else
                    {
                        // Produto encontrado, realizar exclusão
                        string queryExcluir = "DELETE FROM Produtos WHERE Id = @Id AND Nome = @Nome ";//AND qtd_kg = @qtd_kg
                        SqlCommand cmdExcluir = new SqlCommand(queryExcluir, conexao);
                        cmdExcluir.Parameters.AddWithValue("@Id", codigo);
                        cmdExcluir.Parameters.AddWithValue("@Nome", produto);
                        // cmdExcluir.Parameters.AddWithValue("@qtd_kg", quantidade);
                        cmdExcluir.ExecuteNonQuery();

                        MessageBox.Show("Produto excluído com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void btnVoltarEstoque_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}