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
    public partial class FormEditarUser : Form
    {
        string u;
        public FormEditarUser(string v)
        {
            InitializeComponent();
            u = v;
            using (SqlConnection sql = new SqlConnection("Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = parque; Data Source = Tati\\SQLEXPRESS"))
            {
                SqlCommand cmd = new SqlCommand("select * from usuario where nome_user=@nome_user", sql);
                cmd.Parameters.Add("@nome_user", SqlDbType.VarChar).Value = v;
                try
                {
                    sql.Open();
                    using (SqlDataReader drms = cmd.ExecuteReader())
                    {
                        if (drms.Read())
                        {
                            txtNomeUser.Text = Convert.ToString(drms["nome_user"]);
                            txtSenhaUser.Text = Convert.ToString(drms["senha_user"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sql = new SqlConnection("Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = parque; Data Source = Tati\\SQLEXPRESS"))
            {
                SqlCommand cmd = new SqlCommand("update usuario set nome_user=@nome_user, senha_user=@senha_user where nome_user=@nome", sql);
                cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = u;
                cmd.Parameters.Add("@nome_user", SqlDbType.VarChar).Value = txtNomeUser.Text;
                cmd.Parameters.Add("@senha_user", SqlDbType.VarChar).Value = txtSenhaUser.Text;
                var editaruser = MessageBox.Show("Tem certeza que deseja fazer alterações no usuário?", "PARQUE TEIXEIRA SOARES", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (editaruser == DialogResult.Yes)
                {
                    if (txtNomeUser.Text != "" & txtSenhaUser.Text != "")
                    {
                        try
                        {
                            sql.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Alterações salvas com sucesso.", "PARQUE TEIXEIRA SOARES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhum campo pode ficar em branco", "PARQUE TEIXEIRA SOARES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            F_Usuarios formUser = new F_Usuarios();
            formUser.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboPerfilUser_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void txtSenhaUser_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNomeUser_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void FormEditarUser_Load(object sender, EventArgs e)
        {

        }
    }
}
