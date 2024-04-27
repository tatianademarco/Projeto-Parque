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
    public partial class FormEditarMonitor : Form
    {
        string n;
        public FormEditarMonitor(string m)
        {
            InitializeComponent();

            n = m;

            using (SqlConnection sql = new SqlConnection("Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = parque; Data Source = Tati\\SQLEXPRESS"))
            {
                SqlCommand cmd = new SqlCommand("select email, telefone from monitor where nome=@nome;", sql);
                cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = m;
                try
                {
                    sql.Open();
                    SqlDataReader drms = cmd.ExecuteReader();
                    drms.Read();
                    txtNomeGuia.Text = m;
                    maskedTextBoxTel.Text = Convert.ToString(drms["telefone"]);
                    textBoxEmail.Text = Convert.ToString(drms["email"]);
                    drms.Close();
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
                SqlCommand cmd = new SqlCommand("update monitor set nome=@nome, email=@email, telefone=@telefone where nome=@nome1;", sql);
                cmd.Parameters.Add("@nome1", SqlDbType.VarChar).Value = n;
                cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNomeGuia.Text;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = textBoxEmail.Text;
                cmd.Parameters.Add("@telefone", SqlDbType.VarChar).Value = maskedTextBoxTel.Text;

                var editarguia = MessageBox.Show("Tem certeza que deseja fazer alterações no monitor?", "PARQUE TEIXEIRA SOARES", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (editarguia == DialogResult.Yes)
                {
                    if (txtNomeGuia.Text != "")
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
                        MessageBox.Show("O nome não pode ficar em branco", "PARQUE TEIXEIRA SOARES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            FormTodosMonitores mon = new FormTodosMonitores();
            mon.Show();
        }
    }
}
