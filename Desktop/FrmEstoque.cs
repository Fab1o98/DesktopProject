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

        private void LimparCampos()
        {
            // Percorre todos os controles no formulário
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear(); // Limpa os campos TextBox
                }
                else if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).SelectedIndex = -1; // Limpa a seleção do ComboBox
                }
                else if (ctrl is MaskedTextBox)
                {
                    ((MaskedTextBox)ctrl).Clear(); // Limpa os campos MaskedTextBox
                }
                // Adicione outros tipos de controles que você deseja limpar, se necessário
            }
        }

        private void btnRetiraSaldo_Click(object sender, EventArgs e)
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
                        LimparCampos();
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

        //private void button2_Click(object sender, EventArgs e)
        //{




        //}

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            conexao.Open();

            // Variável para armazenar a consulta SQL
            string mostraDados = "SELECT * FROM Produtos WHERE 1=1"; // Inicia com condição sempre verdadeira

            // Adiciona condições de pesquisa com base na entrada do usuário
            if (int.TryParse(txtCodigo.Text, out int idPesquisa))
            {
                mostraDados += " AND Id = @Id";
            }
            if (!string.IsNullOrWhiteSpace(txtProduto.Text))
            {
                mostraDados += " AND Nome LIKE @Nome";
            }
            if (comboBoxTipoProduto.SelectedItem != null && !string.IsNullOrWhiteSpace(comboBoxTipoProduto.SelectedItem.ToString()))
            {
                mostraDados += " AND Categoria = @Categoria";
            }

            SqlCommand cmd = new SqlCommand(mostraDados, conexao);

            // Adiciona os parâmetros de acordo com os campos preenchidos
            if (int.TryParse(txtCodigo.Text, out idPesquisa))
            {
                cmd.Parameters.AddWithValue("@Id", idPesquisa);
            }
            if (!string.IsNullOrWhiteSpace(txtProduto.Text))
            {
                cmd.Parameters.AddWithValue("@Nome", "%" + txtProduto.Text + "%");
            }
            if (comboBoxTipoProduto.SelectedItem != null && !string.IsNullOrWhiteSpace(comboBoxTipoProduto.SelectedItem.ToString()))
            {
                cmd.Parameters.AddWithValue("@Categoria", comboBoxTipoProduto.SelectedItem.ToString());
            }

            // Executando o comando e preenchendo o DataTable
            SqlDataAdapter exibir = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            exibir.Fill(dt);

            // Verificação de resultados
            if (dt.Rows.Count > 0)
            {
                // Se o usuário forneceu Id, Nome e Tipo, validar correspondência dos dados
                if (int.TryParse(txtCodigo.Text, out idPesquisa) && !string.IsNullOrWhiteSpace(txtProduto.Text) && comboBoxTipoProduto.SelectedItem != null && !string.IsNullOrWhiteSpace(comboBoxTipoProduto.SelectedItem.ToString()))
                {
                    // Verifica se há correspondência de Id, Nome e Tipo
                    DataRow[] resultado = dt.Select($"Id = {idPesquisa} AND Nome LIKE '%{txtProduto.Text}%' AND Categoria = '{comboBoxTipoProduto.SelectedItem}'");

                    // Se não houver correspondência exata, exibe mensagem de erro
                    if (resultado.Length == 0)
                    {
                        MessageBox.Show("Produto não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Exibe os resultados correspondentes
                        dtGridViewEstoque.DataSource = resultado.CopyToDataTable();
                    }
                }
                else
                {
                    // Exibe os resultados caso a busca não envolva todos os campos ou tenha outros critérios
                    dtGridViewEstoque.DataSource = dt;
                }
            }
            else
            {
                // Exibe mensagem caso nenhum produto seja encontrado
                MessageBox.Show("Nenhum produto encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conexao.Close();
        }


        private void btnAdicionarSaldo_Click(object sender, EventArgs e)
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
                        LimparCampos();
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

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            // Obter os valores dos campos
            string codigo = txtCodigo.Text;
            string produto = txtProduto.Text;
            string quantidadeTexto = txtQtd.Text;
            string descricaoProduto = txtDescricaoProduto.Text;
            string precoTexto = textBoxPreco.Text; // Campo de preço
            string tipoProduto = comboBoxTipoProduto.SelectedItem?.ToString(); // Obter o tipo do ComboBox

            // Validação básica para campos vazios
            if (string.IsNullOrWhiteSpace(produto) || string.IsNullOrWhiteSpace(descricaoProduto) ||
                string.IsNullOrWhiteSpace(precoTexto) || string.IsNullOrWhiteSpace(tipoProduto))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios(*). ");
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

            decimal preco;
            if (!decimal.TryParse(precoTexto, out preco) || preco < 0)
            {
                MessageBox.Show("Preço deve ser um número válido e não negativo.");
                return;
            }

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
                    string queryInserir = "INSERT INTO Produtos (Nome, qtd_kg, Descricao, Preco, Categoria) VALUES (@Nome, @qtd_kg, @Descricao, @Preco, @Categoria)";
                    SqlCommand cmdInserir = new SqlCommand(queryInserir, conexao);
                    cmdInserir.Parameters.AddWithValue("@Nome", produto);
                    cmdInserir.Parameters.AddWithValue("@qtd_kg", quantidade);
                    cmdInserir.Parameters.AddWithValue("@Descricao", descricaoProduto);
                    cmdInserir.Parameters.AddWithValue("@Preco", preco);
                    cmdInserir.Parameters.AddWithValue("@Categoria", tipoProduto);
                    cmdInserir.ExecuteNonQuery();
                    LimparCampos();
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


        private void btnExcluirProduto_Click_1(object sender, EventArgs e)
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
                        string queryExcluir = "DELETE FROM Produtos WHERE Id = @Id AND Nome = @Nome ";
                        SqlCommand cmdExcluir = new SqlCommand(queryExcluir, conexao);
                        cmdExcluir.Parameters.AddWithValue("@Id", codigo);
                        cmdExcluir.Parameters.AddWithValue("@Nome", produto);
                        cmdExcluir.ExecuteNonQuery();
                        LimparCampos();
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