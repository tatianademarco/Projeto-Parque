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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=parque;Data Source=Tati\\SQLEXPRESS";

            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO usuario (nome_user, senha_user) VALUES (@nome_user, @senha_user);", sql))
                {
                    cmd.Parameters.Add("@nome_user", SqlDbType.VarChar).Value = txtNomeUser.Text;
                    cmd.Parameters.Add("@senha_user", SqlDbType.VarChar).Value = txtSenhaUser.Text;

                    if (txtNomeUser.Text != "" && txtSenhaUser.Text != "")
                    {
                        try
                        {
                            sql.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Cadastro efetuado com sucesso.", "PARQUE TEIXEIRA SOARES - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNomeUser.Text = "";
                            txtSenhaUser.Text = "";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, preencha todos os campos", "PARQUE TEIXEIRA SOARES - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
