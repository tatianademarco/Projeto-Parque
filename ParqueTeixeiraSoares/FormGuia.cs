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

namespace Teste
{
    public partial class FormGuia : Form
    {
        public FormGuia()
        {
            InitializeComponent();
        }

        private void FormGuia_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = parque; Data Source = Tati\\SQLEXPRESS");
            SqlCommand cmd = new SqlCommand("insert into monitor(nome, email, telefone) values (@nome, @email, @telefone);", sql);
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNomeGuia.Text;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = textBoxEmail.Text;
            cmd.Parameters.Add("@telefone", SqlDbType.VarChar).Value = maskedTextBoxTel.Text;

            if (txtNomeGuia.Text != "")
            {
                try
                {
                    sql.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com sucesso.", "PARQUE TEIXEIRA SOARES - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeGuia.Text = "";
                    textBoxEmail.Text = "";
                    maskedTextBoxTel.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sql.Close();
                }
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos", "PARQUE TEIXEIRA SOARES - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
