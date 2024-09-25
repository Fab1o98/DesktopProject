using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Desktop
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        SqlConnection bdGreen = new SqlConnection(@"Data Source=34.151.243.209;Initial Catalog=GREENLIFE_BD;User ID=gustavo;Password=Italia20@;Encrypt=True;TrustServerCertificate=True");

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        // Botão conectar
        private void button1_Click(object sender, EventArgs e)
        {
            //bdGreen.Open();
            //string query = "SELECT * FROM Usuarios WHERE nome = @usuario AND senha = @senha";
            //SqlCommand cmd = new SqlCommand(query, bdGreen);
            //cmd.Parameters.AddWithValue("@usuario", textBoxUsuario.Text);
            //cmd.Parameters.AddWithValue("@senha", textBoxSenha.Text);
            //SqlDataAdapter dp = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //dp.Fill(dt);

            string query = "SELECT * FROM Usuarios WHERE nome = '" + textBoxUsuario.Text + "' AND senha = '" + textBoxSenha.Text + "' ";
            SqlDataAdapter dp = new SqlDataAdapter(query,bdGreen);  
            DataTable dt = new DataTable();
            dp.Fill(dt);

            if (dt.Rows.Count  == 1)
            {
                FrmPrincipal principal = new FrmPrincipal();
                this.Hide();
                principal.Show();
                bdGreen.Close();
            }
            else
            {
                MessageBox.Show("Usuario/Senha incorretos.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUsuario.Text = "";
                textBoxSenha.Text = "";
                textBoxUsuario.Select(); 
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
