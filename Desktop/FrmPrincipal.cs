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

        private Form frmAtivo;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        SqlConnection conexao = new SqlConnection(@"Data Source=34.171.87.74;Initial Catalog=GREENLIFE_BD;Persist Security Info=True;User ID=EquipeGL;Password=***********;Encrypt=False");
        SqlCommand comando = new SqlCommand();
        //SqlDataReader data; 
       
        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelPrincipal.Controls.Add(frm); 
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {
            if (frmAtivo != null)
                frmAtivo.Close();
            
        }

        private void ActiveButton(Button frmAtivo)
        {
            foreach(Control control in panelPrincipal.Controls) 
                control.ForeColor = Color.WhiteSmoke;

 
        }
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            ActiveButton(btnInicio);
            ActiveFormClose();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            ActiveButton(btnEstoque);
            FormShow(new FrmEstoque()); 
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            ActiveButton(btnPedido);
            FormShow(new FrmPedido());
        }

        private void btnCadFuncionario_Click(object sender, EventArgs e)
        {
            ActiveButton(btnCadFuncionario);
            FormShow(new FrmCadFuncionario());
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            ActiveButton(btnRelatorio);
            FormShow(new FrmRelatorio());   
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnRelatorio_Click_1(object sender, EventArgs e)
        {
            ActiveButton(btnRelatorio); 
            FormShow(new FrmRelatorio());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveButton(btnCadCliente);
            FormShow(new FrmCadCliente());
        }
    }
}
