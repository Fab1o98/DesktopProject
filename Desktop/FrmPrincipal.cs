using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Desktop
{
    public partial class FrmPrincipal : Form
    {
        // Variavel para armazenar o formulario ativo.
        private Form frmAtivo;

        //Inicialização do componente do Form.
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        // Caminho para conectar com o banco de dados. 
        SqlConnection conexao = new SqlConnection(@"Data Source=34.171.87.74;Initial Catalog=GREENLIFE_BD;Persist Security Info=True;User ID=EquipeGL;Password=***********;Encrypt=False");
        SqlCommand comando = new SqlCommand();
        
        //Função para mostrar o Form que esta ativo.  
        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelPrincipal.Controls.Add(frm); 
            frm.BringToFront();
            frm.Show();
        }
        //Função para fechar o Form que não está ativo.
        private void ActiveFormClose()
        {
            if (frmAtivo != null)
                frmAtivo.Close();
            
        }
        //Função para mostrar o Form que está ativo no menu, qual estiver ativo irá ficar com a cor "WhiteSmoke".
        private void ActiveButton(Button frmAtivo)
        {
            foreach(Control control in panelPrincipal.Controls) 
                control.ForeColor = Color.WhiteSmoke;

 
        }
        //Panel principal.
        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
        //Botão inicio está conectado ao Form principal. 
        private void btnInicio_Click(object sender, EventArgs e)
        {
            ActiveButton(btnInicio);
            ActiveFormClose();
            
        }
        // Botão de menu, ligado ao Form Estoque. 
        private void btnEstoque_Click(object sender, EventArgs e)
        {
            ActiveButton(btnEstoque);
            FormShow(new FrmEstoque());
            
        }
        // Botão menu, ligado ao Form de cadastro de funcionario.
        private void btnCadFuncionario_Click(object sender, EventArgs e)
        {
            ActiveButton(btnCadFuncionario);
            FormShow(new FrmCadFuncionario());
        }
       
        //private void btnRelatorio_Click(object sender, EventArgs e)
        //{
        //    ActiveButton(btnRelatorio);
        //    FormShow(new FrmRelatorio());   
        //}


        // Botão para sair do sistema.
        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Função de carregamento. 
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
        // Botão menu, ligado ao Form de relatório.
        private void btnRelatorio_Click_1(object sender, EventArgs e)
        {
            ActiveButton(btnRelatorio); 
            FormShow(new FrmRelatorio());
        }
        //Botão menu, ligado ao Form de cadastrod e cliente. 
        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            ActiveButton(btnCadCliente);
            FormShow(new FrmCadCliente());
        }
        //Função de confirmação de Janela.
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            DialogResult resultado = MessageBox.Show(
            "Tem certeza que deseja fechar a janela?",
            "Confirmação de Fechamento",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            // Verifica a resposta do usuário.
            if (resultado == DialogResult.No)
            {
                // Cancela o fechamento do formulário se o usuário escolher "Não".
                e.Cancel = true;
            }
               // Se o usuário escolher "Sim", o formulário será fechado normalmente.
        
        }
    }
}
