using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Teste
{
    public partial class FormTodasAvaliacoes : Form
    {
        void FillListView()
        {
            string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=parque;Data Source=Tati\\SQLEXPRESS";

            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                string query = "SELECT id_avaliacao, data_visita, indicar, atendimento FROM avaliacao ORDER BY id_avaliacao DESC;";

                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    try
                    {
                        sql.Open();

                        using (SqlDataReader drms = cmd.ExecuteReader())
                        {
                            while (drms.Read())
                            {
                                string[] ava = new string[4];
                                ava[0] = drms.GetInt32(0).ToString();
                                ava[1] = drms.GetDateTime(1).ToString("yyyy-MM-dd");
                                ava[2] = drms.GetString(2);
                                ava[3] = drms.GetString(3);

                                ListViewItem list = new ListViewItem(ava);
                                listView1.Items.Add(list);
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

        public FormTodasAvaliacoes()
        {
            InitializeComponent();
            FillListView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormAvaliacao1 formAvaliacao1 = new FormAvaliacao1();
            formAvaliacao1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=parque;Data Source=Tati\\SQLEXPRESS"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT id_avaliacao, data_visita, indicar, atendimento FROM avaliacao WHERE data_visita BETWEEN @datai AND @dataf ORDER BY id_avaliacao DESC;", sql))
                {
                    cmd.Parameters.Add("@datai", SqlDbType.Date).Value = monthCalendar1.SelectionStart;
                    cmd.Parameters.Add("@dataf", SqlDbType.Date).Value = monthCalendar1.SelectionEnd;

                    listView1.Items.Clear();

                    try
                    {
                        sql.Open();

                        using (SqlDataReader drms = cmd.ExecuteReader())
                        {
                            if (drms.HasRows == false)
                            {
                                listView1.Items.Add("Não há visitações nesta data.");
                            }
                            else
                            {
                                while (drms.Read())
                                {
                                    string[] ava = new string[4];
                                    ava[0] = drms.GetInt32(0).ToString();
                                    ava[1] = drms.GetDateTime(1).ToString("yyyy-MM-dd");
                                    ava[2] = drms.GetString(2);
                                    ava[3] = drms.GetString(3);

                                    ListViewItem list = new ListViewItem(ava);
                                    listView1.Items.Add(list);
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=parque;Data Source=Tati\\SQLEXPRESS";

            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                if (listView1.SelectedIndices.Count > 0)
                {
                    string codigo = listView1.SelectedItems[0].Text;

                    string query = "DELETE FROM avaliacao WHERE id_avaliacao=@codigo;";

                    using (SqlCommand cmd = new SqlCommand(query, sql))
                    {
                        cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = int.Parse(codigo);

                        var excluirUser = MessageBox.Show("Tem certeza que deseja excluir a avaliação?", "PARQUE TEIXEIRA SOARES", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                        if (excluirUser == DialogResult.Yes)
                        {
                            listView1.Items.RemoveAt(listView1.SelectedIndices[0]);

                            try
                            {
                                sql.Open();
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Avaliação excluida com sucesso.", "PARQUE TEIXEIRA SOARES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um item da lista.", "PARQUE TEIXEIRA SOARES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                FormVisualizarAvaliacao formVisualizarAvaliacao = new FormVisualizarAvaliacao(Convert.ToInt32(listView1.Items[listView1.SelectedIndices[0]].Text));
                formVisualizarAvaliacao.Show();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um item da lista.", "PARQUE TEIXEIRA SOARES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                FormEditarAvaliacao1 formEditarAvaliacao = new FormEditarAvaliacao1(Convert.ToInt32(listView1.Items[listView1.SelectedIndices[0]].Text));
                formEditarAvaliacao.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um item da lista.", "PARQUE TEIXEIRA SOARES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
