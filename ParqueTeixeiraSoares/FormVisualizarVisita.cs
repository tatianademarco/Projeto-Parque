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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Teste
{
    public partial class FormVisualizarVisita : Form
    {
        public FormVisualizarVisita(int v)
        {
            InitializeComponent();

            using (SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=parque;Data Source=Tati\\SQLEXPRESS"))
            {
                string query = "SELECT visita.data_visita, visita.turno, visita.transporte, visita.neces_esp, visita.perfil_grupo, visita.agendado, visita.responsavel_grupo,\r\nvisita.objetivo, monitor.nome, visitante.nome_vis FROM visita JOIN visitacao ON visita.id_visita=@id_visita AND visita.id_visita=visitacao.id_visita\r\nJOIN visitante ON visitante.id_visitante=visitacao.id_visitante JOIN monitor ON monitor.id_monitor=visita.id_monitor;";
                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    cmd.Parameters.Add("@id_visita", SqlDbType.Int).Value = v;

                    try
                    {
                        sql.Open();

                        using (SqlDataReader drms = cmd.ExecuteReader())
                        {
                            while (drms.Read())
                            {
                                listBoxVisiantes.Items.Add(drms.GetString("nome_vis"));
                                label2.Text = "Data: " + drms.GetDateTime(drms.GetOrdinal("data_visita")).ToString("dd/MM/yyyy");
                                label3.Text = "Responsável pelo grupo: " + Convert.ToString(drms["responsavel_grupo"]);
                                label5.Text = "Perfil do grupo: " + Convert.ToString(drms["perfil_grupo"]);
                                label7.Text = "Objetivo da visita: " + Convert.ToString(drms["objetivo"]);
                                label4.Text = "Turno: " + Convert.ToString(drms["turno"]);
                                label6.Text = "Meio de transporte: " + Convert.ToString(drms["transporte"]);
                                label8.Text = "Monitor que acompanhou: " + Convert.ToString(drms["nome"]);

                                if (Convert.ToString(drms["agendado"]) == "False")
                                {
                                    label9.Text = "Foi agendado: NÃO";
                                }
                                else
                                {
                                    label9.Text = "Foi agendado: SIM";
                                }
                                if (Convert.ToString(drms["neces_esp"]) == "False")
                                {
                                    label10.Text = "Necessidades Especiais: NÃO";
                                }
                                else
                                {
                                    label10.Text = "Necessidades Especiais: SIM";
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

        private void label2_Click(object sender, EventArgs e)
        {

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
