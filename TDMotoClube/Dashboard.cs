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
            //this.tB_MOTO_CLUBETableAdapter.Fill(this.MOTOCLUBESet.TB_MOTO_CLUBE);
            listaGridView();
            buttonExcluir.Hide();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool verificaCampos()
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

        private bool verificaCamposPesquisa()
        {
            if (textBoxNomeMotoClube.TextLength == 0 && textBoxPresidente.TextLength == 0)
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

        private string retornaEstado()
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
            desabilitaExcluir();
            if (verificaCampos() == true)
            {
                int trofeu = retornaTrofeu();
                string estado = retornaEstado();
                SqlConnection conn = new SqlConnection(@"Data Source=ADILSON\SQLEXPRESS;Initial Catalog=MOTOCLUBE;Integrated Security=True");
                conn.Open();
                try
                {
                    if (pesquisar(textBoxNomeMotoClube.Text, textBoxPresidente.Text) == true)
                    {
                        SqlCommand cmd = new SqlCommand(@"UPDATE TB_MOTO_CLUBE SET TELEFONE ='" + textBoxTelefone.Text + "', EMAIL ='" + textBoxEmail.Text + "', ENDERECO ='" + textBoxEnedereco.Text + "', COMPLEMENTO ='" + textBoxComplemento.Text + "', BAIRRO ='" + textBoxBairro.Text + "', CIDADE ='" + textBoxCidade.Text + "', ESTADO ='" + estado + "', TROFEU ='" + trofeu + "' WHERE NOME ='" + textBoxNomeMotoClube.Text + "' AND PRESIDENTE ='" + textBoxPresidente.Text + "'", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Moto Clube Editado Com Sucesso");
                        listaGridView();
                        pesquisar(textBoxNomeMotoClube.Text, textBoxPresidente.Text);
                    }
                    else
                    {
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
                        MessageBox.Show("Registro Incluído com Sucesso!");
                        limpar();
                    }
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
            desabilitaExcluir();
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
            listaGridView();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void formatarGridView(DataGridView dataGrid)
        {
            dataGrid.Columns[1].Visible = false;
            dataGrid.Columns[1].ReadOnly = true;
            dataGrid.Columns[2].ReadOnly = true;
            dataGrid.Columns[3].ReadOnly = true;
            dataGrid.Columns[4].ReadOnly = true;
            dataGrid.Columns[5].ReadOnly = true;
            dataGrid.Columns[6].ReadOnly = true;
            dataGrid.Columns[7].ReadOnly = true;
            dataGrid.Columns[8].ReadOnly = true;
            dataGrid.Columns[9].ReadOnly = true;
            dataGrid.Columns[10].ReadOnly = true;
            dataGrid.Columns[11].ReadOnly = true;
        }

        private void listaGridView()
        {
            string comandoSQL = "SELECT ID, NOME, PRESIDENTE, TELEFONE, EMAIL, ENDERECO, COMPLEMENTO, BAIRRO, CIDADE, ESTADO, TROFEU FROM TB_MOTO_CLUBE";
            SqlConnection conn = new SqlConnection(@"Data Source=ADILSON\SQLEXPRESS;Initial Catalog=MOTOCLUBE;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand(comandoSQL, conn);
            try
            {
                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dAdapter.Fill(dt);
                dataGridViewDashboard.DataSource = dt;
                formatarGridView(dataGridViewDashboard);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Carregar a Lista");
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void habilitaExcluir()
        {
            buttonExcluir.Show();
            buttonExcluir.Enabled = true;
        }

        private void desabilitaExcluir()
        {
            buttonExcluir.Hide();
            buttonExcluir.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewDashboard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            for (int i = 0; i < dataGridViewDashboard.Rows.Count; i++)
            {
                if (rowIndex != -1)
                {
                    dataGridViewDashboard.Rows[i].Cells["ColumnCheckEdit"].Value = false;
                }
            }

            if (e.RowIndex >= 0)
            {
                habilitaExcluir();
                DataGridViewRow row = this.dataGridViewDashboard.Rows[e.RowIndex];
                dataGridViewDashboard.Rows[rowIndex].Cells["ColumnCheckEdit"].Value = true;
                int id = (int)row.Cells["ID"].Value;
                textBoxNomeMotoClube.Text = row.Cells["NOME"].Value.ToString();
                textBoxPresidente.Text = row.Cells["PRESIDENTE"].Value.ToString();
                textBoxTelefone.Text = row.Cells["TELEFONE"].Value.ToString();
                textBoxEmail.Text = row.Cells["EMAIL"].Value.ToString();
                textBoxEnedereco.Text = row.Cells["ENDERECO"].Value.ToString();
                textBoxComplemento.Text = row.Cells["COMPLEMENTO"].Value.ToString();
                textBoxBairro.Text = row.Cells["BAIRRO"].Value.ToString();
                textBoxCidade.Text = row.Cells["CIDADE"].Value.ToString();
                comboBoxEstado.SelectedItem = row.Cells["ESTADO"].Value.ToString();
                checkBoxTrofeu.Checked = (bool)row.Cells["TROFEU"].Value;
            }
        }

        private bool pesquisar(string nome, string presidente)
        {
            bool retornoPesquisa = false;
            string stringSQL = null;
            if (nome != "" && presidente != "")
            {
                stringSQL = "SELECT ID, NOME, PRESIDENTE, TELEFONE, EMAIL, ENDERECO, COMPLEMENTO, BAIRRO, CIDADE, ESTADO, TROFEU FROM TB_MOTO_CLUBE WHERE NOME = '" + nome + "' AND PRESIDENTE = '" + presidente + "'";
            }
            else if (nome != "" && presidente == "")
            {
                stringSQL = "SELECT ID, NOME, PRESIDENTE, TELEFONE, EMAIL, ENDERECO, COMPLEMENTO, BAIRRO, CIDADE, ESTADO, TROFEU FROM TB_MOTO_CLUBE WHERE NOME = '" + nome + "'";
            }
            else if (nome == "" && presidente != "")
            {
                stringSQL = "SELECT ID, NOME, PRESIDENTE, TELEFONE, EMAIL, ENDERECO, COMPLEMENTO, BAIRRO, CIDADE, ESTADO, TROFEU FROM TB_MOTO_CLUBE WHERE PRESIDENTE = '" + presidente + "'";
            }
            SqlConnection conn = new SqlConnection(@"Data Source=ADILSON\SQLEXPRESS;Initial Catalog=MOTOCLUBE;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(stringSQL, conn);
            conn.Open();
            try
            {
                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dAdapter.Fill(dt);
                dataGridViewDashboard.DataSource = dt;
                formatarGridView(dataGridViewDashboard);
                if (dataGridViewDashboard.RowCount > 0)
                {
                    retornoPesquisa = true;
                }
                else
                {
                    MessageBox.Show("A pesquisa não retornou resultado!");
                    retornoPesquisa = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro na Pesquisa!");
                throw;
            }
            finally
            {
                conn.Close();
            }
            return retornoPesquisa;
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            desabilitaExcluir();
            if (verificaCamposPesquisa() == true)
            {
                pesquisar(textBoxNomeMotoClube.Text, textBoxPresidente.Text);
            }
            else
            {
                MessageBox.Show("Campos Obrigatórios Não Preenchidos");
            }

        }

        private void textBoxTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Digite o telefone sem espaço");
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Digite o telefone apenas com números");
            }
        }

        private void excluir()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ADILSON\SQLEXPRESS;Initial Catalog=MOTOCLUBE;Integrated Security=True");
            conn.Open();
            foreach (DataGridViewRow item in dataGridViewDashboard.Rows)
            {
                if (dataGridViewDashboard.Rows[item.Index].Cells["ColumnCheckEdit"].Selected)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand(@"DELETE FROM TB_MOTO_CLUBE WHERE ID ='" + item.Cells["ID"].Value + "'", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Moto Clube Excluído Com Sucesso");
                        limpar();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro ao Deletar Registro");
                        throw;
                    }
                }                
            }
            conn.Close();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            excluir();
        }
    }
}
