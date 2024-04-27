using Microsoft.CodeAnalysis.VisualBasic.Syntax;
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
using System.Xml.Linq;

namespace Teste
{
    public partial class F_Usuarios : Form
    {
        void FillListBox()
        {
            string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=parque;Data Source=Tati\\SQLEXPRESS";

            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM usuario";

                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    try
                    {
                        sql.Open();

                        using (SqlDataReader drms = cmd.ExecuteReader())
                        {
                            while (drms.Read())
                            {
                                string nameU = drms.GetString(drms.GetOrdinal("nome_user"));
                                listBoxNomeUser.Items.Add(nameU);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }
        public F_Usuarios()
        {
            InitializeComponent();
            FillListBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBoxNomeUser.SelectedIndex != -1)
            {
                string nomeUsuario = listBoxNomeUser.Items[listBoxNomeUser.SelectedIndex].ToString();

                string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=parque;Data Source=Tati\\SQLEXPRESS";

                using (SqlConnection sql = new SqlConnection(connectionString))
                {

                    string query = "DELETE FROM usuario WHERE nome_user = @nome_user";

                    using (SqlCommand cmd = new SqlCommand(query, sql))
                    {
                        cmd.Parameters.Add("@nome_user", SqlDbType.VarChar).Value = nomeUsuario;

                        var excluirUser = MessageBox.Show("Tem certeza que deseja excluir o usuário " + nomeUsuario + "?", "PARQUE TEIXEIRA SOARES - CADASTRO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                        if (excluirUser == DialogResult.Yes)
                        {
                            listBoxNomeUser.Items.RemoveAt(listBoxNomeUser.SelectedIndex);

                            try
                            {
                                sql.Open();
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Usuário excluído com sucesso.", "PARQUE TEIXEIRA SOARES", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um usuário", "PARQUE TEIXEIRA SOARES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxNomeUser.SelectedIndex != -1)
            {
                FormEditarUser formEditarUser = new FormEditarUser(listBoxNomeUser.Items[listBoxNomeUser.SelectedIndex].ToString());
                formEditarUser.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um usuário", "PARQUE TEIXEIRA SOARES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
