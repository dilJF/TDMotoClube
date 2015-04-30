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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MOTOCLUBESet.TB_MOTO_CLUBE' table. You can move, or remove it, as needed.
            this.tB_MOTO_CLUBETableAdapter.Fill(this.MOTOCLUBESet.TB_MOTO_CLUBE);
            listaGridView();

        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Boolean verificaCampos()
        {
            if (textBoxNomeMotoClube.TextLength == 0 || textBoxPresidente.TextLength == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private int retornaTrofeu()
        {
            int valor = 0;
            if (checkBoxTrofeu.Checked)
            {
                valor = 1;
            }
            else
            {
                valor = 0;
            }
            return valor;
        }

        private String retornaEstado()
        {
            if (comboBoxEstado.SelectedIndex != -1)
            {
                Object estadoSelecionado = comboBoxEstado.SelectedItem;
                return estadoSelecionado.ToString();
            }
            return "";
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (verificaCampos() == true)
            {
                int trofeu = retornaTrofeu();
                String estado = retornaEstado();
                try
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=ADILSON\SQLEXPRESS;Initial Catalog=MOTOCLUBE;Integrated Security=True");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[TB_MOTO_CLUBE]
                       ([NOME]
                       ,[PRESIDENTE]
                       ,[TELEFONE]
                       ,[EMAIL]
                       ,[ENDERECO]
                       ,[COMPLEMENTO]
                       ,[BAIRRO]
                       ,[CIDADE]
                       ,[ESTADO]
                       ,[TROFEU])
                        VALUES('" + textBoxNomeMotoClube.Text +
                           "','" + textBoxPresidente.Text +
                           "','" + textBoxTelefone.Text +
                           "','" + textBoxEmail.Text +
                           "','" + textBoxEnedereco.Text +
                           "','" + textBoxComplemento.Text +
                           "','" + textBoxBairro.Text +
                           "','" + textBoxCidade.Text +
                           "','" + estado +
                           "','" + trofeu +
                           "')", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Registro Incluído com Sucesso!");
                    limpar();
                    listaGridView();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro no Registro!");
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Campos Obrigatórios Não Preenchidos");
            }
        }

        private void limpar()
        {
            textBoxNomeMotoClube.Text = "";
            textBoxPresidente.Text = "";
            textBoxTelefone.Text = "";
            textBoxEmail.Text = "";
            textBoxEnedereco.Text = "";
            textBoxComplemento.Text = "";
            textBoxBairro.Text = "";
            textBoxCidade.Text = "";
            comboBoxEstado.SelectedIndex = -1;
            checkBoxTrofeu.Checked = false;
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void listaGridView()
        {
            string comandoSQL = "SELECT NOME, PRESIDENTE, TELEFONE, EMAIL, CIDADE, ESTADO, TROFEU FROM TB_MOTO_CLUBE";
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=ADILSON\SQLEXPRESS;Initial Catalog=MOTOCLUBE;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand(comandoSQL, conn);
                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dAdapter.Fill(dt);
                dataGridViewDashboard.DataSource = dt;
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Carregar a Lista");
                throw;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0){
                DataGridViewRow row = this.dataGridViewDashboard.Rows[e.RowIndex];
                textBoxNomeMotoClube.Text = row.Cells["NOME"].Value.ToString();
                textBoxPresidente.Text = row.Cells["PRESIDENTE"].Value.ToString();
                textBoxTelefone.Text = row.Cells["TELEFONE"].Value.ToString();
                textBoxEmail.Text = row.Cells["EMAIL"].Value.ToString();
                textBoxCidade.Text = row.Cells["CIDADE"].Value.ToString();
                comboBoxEstado.SelectedItem = row.Cells["ESTADO"].Value.ToString();
            }
        }
    }
}
