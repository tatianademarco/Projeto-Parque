using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class FormVisualizarVisitante : Form
    {
        public FormVisualizarVisitante(string v)
        {
            InitializeComponent();

            using (SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=parque;Data Source=Tati\\SQLEXPRESS"))
            {
                string query = "SELECT visita.id_visita, visita.data_visita, visita.turno, visita.responsavel_grupo FROM visita JOIN visitante ON visitante.nome_vis=@nome JOIN visitacao ON visitacao.id_visitante=visitante.id_visitante and visita.id_visita=visitacao.id_visita ORDER BY visita.id_visita DESC;";
                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = v;

                    try
                    {
                        sql.Open();

                        using (SqlDataReader drms = cmd.ExecuteReader())
                        {
                            while (drms.Read())
                            {
                                string[] vis = new string[4];
                                vis[0] = drms.GetInt32(0).ToString();
                                vis[1] = drms.GetDateTime(1).ToString("yyyy-MM-dd");
                                vis[2] = drms.GetString(2);
                                vis[3] = drms.GetString(3);

                                ListViewItem list = new ListViewItem(vis);
                                listView1.Items.Add(list);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    SqlCommand cmd3 = new SqlCommand("SELECT id_pais FROM visitante WHERE nome_vis=@nome", sql);
                    cmd3.Parameters.Add("@nome", SqlDbType.VarChar).Value = v;

                    try
                    {
                        SqlDataReader drms = cmd3.ExecuteReader();
                        drms.Read();
                        string pais = Convert.ToString(drms[0]);
                        drms.Close();

                        string query2;
                        if (pais == "1")
                        {
                            query2 = "SELECT visitante.data_nasc, visitante.como_soube, visitante.telefone, visitante.email, cidade.nome, pais.nome_pt, estado.uf FROM cidade JOIN visitante ON cidade.id = visitante.id_cidade JOIN pais ON pais.id = visitante.id_pais JOIN estado ON estado.id = cidade.uf WHERE nome_vis = @nome_vis;";
                            SqlCommand cmd2 = new SqlCommand(query2, sql);
                            cmd2.Parameters.Add("@nome_vis", SqlDbType.VarChar).Value = v;

                            SqlDataReader drms2 = cmd2.ExecuteReader();
                            if (drms2.Read())
                            {
                                label2.Text = "Nome: " + v;
                                label3.Text = "Telefone: " + Convert.ToString(drms2["telefone"]);
                                label5.Text = "E-mail: " + Convert.ToString(drms2["email"]);
                                label7.Text = "Como soube do parque: " + Convert.ToString(drms2["como_soube"]);
                                label4.Text = "Data de nascimento: " + Convert.ToString(drms2["data_nasc"]);
                                label6.Text = "Cidade: " + Convert.ToString(drms2["nome"]) + " " + Convert.ToString(drms2["uf"]) + " " + Convert.ToString(drms2["nome_pt"]);
                            }
                            drms2.Close();
                        }
                        else
                        {
                            query2 = "SELECT visitante.data_nasc, visitante.como_soube, visitante.telefone, visitante.email, cidade.nome, pais.nome_pt FROM cidade JOIN visitante ON cidade.id = visitante.id_cidade JOIN pais ON pais.id = visitante.id_pais WHERE nome_vis = @nome_vis;";
                            SqlCommand cmd2 = new SqlCommand(query2, sql);
                            cmd2.Parameters.Add("@nome_vis", SqlDbType.VarChar).Value = v;

                            SqlDataReader drms2 = cmd2.ExecuteReader();
                            if (drms2.Read())
                            {
                                label2.Text = "Nome: " + v;
                                label3.Text = "Telefone: " + Convert.ToString(drms2["telefone"]);
                                label5.Text = "E-mail: " + Convert.ToString(drms2["email"]);
                                label7.Text = "Como soube do parque: " + Convert.ToString(drms2["como_soube"]);
                                label4.Text = "Data de nascimento: " + Convert.ToString(drms2["data_nasc"]);
                                label6.Text = "Cidade: " + Convert.ToString(drms2["nome"]) + " " + Convert.ToString(drms2["nome_pt"]);
                            }
                            drms2.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
