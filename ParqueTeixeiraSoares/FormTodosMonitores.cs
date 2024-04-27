using System;
using System.Collections;
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
    public partial class FormTodosMonitores : Form
    {
        void FillListBox()
        {
            string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=parque;Data Source=Tati\\SQLEXPRESS";

            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM monitor";

                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    try
                    {
                        sql.Open();

                        using (SqlDataReader drms = cmd.ExecuteReader())
                        {
                            while (drms.Read())
                            {
                                string nameM = drms.GetString(drms.GetOrdinal("nome"));
                                listBoxNomeMon.Items.Add(nameM);
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
        public FormTodosMonitores()
        {
            InitializeComponent();
            FillListBox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=parque;Data Source=Tati\\SQLEXPRESS";

            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                if (listBoxNomeMon.SelectedIndex != -1)
                {
                    string nomeMonitor = listBoxNomeMon.Items[listBoxNomeMon.SelectedIndex].ToString();

                string query = "DELETE FROM monitor WHERE nome = @nome";
                string query2 = "SELECT avaliacao.id_avaliacao, visita.id_visita FROM avaliacao JOIN monitor ON avaliacao.id_monitor=monitor.id_monitor JOIN visita ON visita.id_monitor=monitor.id_monitor WHERE monitor.nome = @nome;";

                using (SqlCommand command = new SqlCommand(query2, sql))
                {

                    command.Parameters.Add("@nome", SqlDbType.VarChar).Value = nomeMonitor;

                    try
                    {
                        sql.Open();

                        SqlDataReader drms = command.ExecuteReader();

                        if (drms.HasRows == true)
                        {
                            MessageBox.Show("Monitor não pode ser excluído pois já está vinculado a uma visita.", "PARQUE TEIXEIRA SOARES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            drms.Close();
                        }
                        else
                        {
                            drms.Close();
                            using (SqlCommand cmd = new SqlCommand(query, sql))
                            {
                                cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nomeMonitor;

                                var excluirMon = MessageBox.Show("Tem certeza que deseja excluir o Monitor " + nomeMonitor + "?", "PARQUE TEIXEIRA SOARES", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                                if (excluirMon == DialogResult.Yes)
                                {
                                    listBoxNomeMon.Items.RemoveAt(listBoxNomeMon.SelectedIndex);

                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Monitor excluído com sucesso.", "PARQUE TEIXEIRA SOARES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um monitor.", "PARQUE TEIXEIRA SOARES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxNomeMon.SelectedIndex != -1)
            {
                FormEditarMonitor formEditarMonitor = new FormEditarMonitor(listBoxNomeMon.Items[listBoxNomeMon.SelectedIndex].ToString());
                formEditarMonitor.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um monitor.", "PARQUE TEIXEIRA SOARES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}