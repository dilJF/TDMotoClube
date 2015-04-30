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

namespace TDMotoClube
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void buttonEntrar_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ADILSON\SQLEXPRESS;Initial Catalog=MOTOCLUBE;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from TB_USUARIO where USUARIO = '" + textBoxUsuario.Text + "' and SENHA = '" + textBoxSenha.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Dashboard principal = new Dashboard();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreto!");
            }
            conn.Close();
        }
    }
}
