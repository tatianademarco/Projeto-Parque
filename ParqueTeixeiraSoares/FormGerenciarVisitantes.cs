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
    public partial class FormGerenciarVisitantes : Form

    {
        void FillListBox()
        {
            SqlConnection sql = new SqlConnection("Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = parque; Data Source = Tati\\SQLEXPRESS");
            SqlCommand cmd = new SqlCommand("select * from visitante ORDER BY visitante.id_visitante DESC;", sql);

            try
            {
                sql.Open();
                SqlDataReader drms = cmd.ExecuteReader();

                while (drms.Read())
                {
                    string nameV = drms.GetString("nome_vis");
                    listBoxVis.Items.Add(nameV);
                }
                drms.Close();
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
        public FormGerenciarVisitantes()
        {
            InitializeComponent();
            FillListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxVis.SelectedIndex != -1)
            {
                FormEditarVisitante formEditarVisitante = new FormEditarVisitante(listBoxVis.Items[listBoxVis.SelectedIndex].ToString());
                formEditarVisitante.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um visitante.", "PARQUE TEIXEIRA SOARES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormVisitante formVisitante = new FormVisitante();
            formVisitante.Show();
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
                if (listBoxVis.SelectedIndex != -1)
                {
                    string nomeVis = listBoxVis.Items[listBoxVis.SelectedIndex].ToString();

                    string query = "delete from visitante where nome_vis=@nome_vis";
                    string query2 = "SELECT visitacao.id_visitacao FROM visitacao JOIN visitante ON visitante.nome_vis = @nome_vis WHERE visitacao.id_visitante=visitante.id_visitante;";

                    using (SqlCommand command = new SqlCommand(query2, sql))
                    {
                        command.Parameters.Add("@nome_vis", SqlDbType.VarChar).Value = nomeVis;

                        try
                        {
                            sql.Open();

                            SqlDataReader drms = command.ExecuteReader();

                            if (drms.HasRows == true)
                            {
                                MessageBox.Show("Visitante não pode ser excluído pois já está vinculado a uma visita.", "PARQUE TEIXEIRA SOARES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                drms.Close();
                            }
                            else
                            {
                                drms.Close();
                                using (SqlCommand cmd = new SqlCommand(query, sql))
                                {
                                    cmd.Parameters.Add("@nome_vis", SqlDbType.VarChar).Value = nomeVis;

                                    var excluirUser = MessageBox.Show("Tem certeza que deseja excluir o Visitante " + nomeVis + "?", "PARQUE TEIXEIRA SOARES", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                                    if (excluirUser == DialogResult.Yes)
                                    {
                                        listBoxVis.Items.RemoveAt(listBoxVis.SelectedIndex);

                                        cmd.ExecuteNonQuery();
                                        MessageBox.Show("Visitante excluído com sucesso.", "PARQUE TEIXEIRA SOARES", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Por favor, selecione um visitante", "PARQUE TEIXEIRA SOARES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=parque;Data Source=Tati\\SQLEXPRESS"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT nome_vis FROM visitante WHERE UPPER(nome_vis) LIKE @pesquisa ORDER BY visitante.id_visitante DESC;", sql))
                {
                    cmd.Parameters.Add("@pesquisa", SqlDbType.VarChar).Value = textBoxPesquisa.Text + '%';

                    listBoxVis.Items.Clear();

                    try
                    {
                        sql.Open();

                        using (SqlDataReader drms = cmd.ExecuteReader())
                        {
                            if (drms.HasRows == false)
                            {
                                listBoxVis.Items.Add("Nenhum visitante encontrado.");
                            }
                            else
                            {
                                while (drms.Read())
                                {
                                    string resultadosVis = drms.GetString(drms.GetOrdinal("nome_vis"));
                                    listBoxVis.Items.Add(resultadosVis);
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

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBoxVis.SelectedIndex != -1)
            {
                FormVisualizarVisitante formVisualizarVisitante = new FormVisualizarVisitante(listBoxVis.Items[listBoxVis.SelectedIndex].ToString());
                formVisualizarVisitante.Show();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um visitante", "PARQUE TEIXEIRA SOARES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
