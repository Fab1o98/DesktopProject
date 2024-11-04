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

        SqlConnection bdGreen = new SqlConnection(@"Data Source=34.171.87.74;Initial Catalog=GREENLIFE_BD;Persist Security Info=True;User ID=EquipeGL;Password=Pipizinhobolado@;Encrypt=False");

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        // Botão conectar
        private void button1_Click(object sender, EventArgs e)
        {
           

            string query = "SELECT * FROM Colaboradores WHERE Usuario = '" + textBoxUsuario.Text + "' AND Senha = '" + textBoxSenha.Text + "' ";
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
