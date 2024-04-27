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
    public partial class FormVisualizarAvaliacao : Form
    {
        public FormVisualizarAvaliacao(int a)
        {
            InitializeComponent();

            using (SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=parque;Data Source=Tati\\SQLEXPRESS"))
            {
                string query = "SELECT avaliacao.data_visita, avaliacao.quantas, avaliacao.jaVisitouOutros," +
                    "avaliacao.atendimento, avaliacao.indicar, avaliacao.agendado, avaliacao.salaExpo," +
                    "avaliacao.video, avaliacao.palestra, avaliacao.trilhaPas, avaliacao.caminhosGra," +
                    "avaliacao.refugioVale, avaliacao.passadorMata, avaliacao.passeioBel, avaliacao.trilhoTei," +
                    "avaliacao.estacionamento, avaliacao.limpezaCentro, avaliacao.atendEspacoConv, avaliacao.tranquPass," +
                    "avaliacao.condicaoTrilhas, avaliacao.conservacao, avaliacao.Guia, avaliacao.FariaVoltar, monitor.nome" +
                    " FROM avaliacao JOIN monitor ON monitor.id_monitor=avaliacao.id_monitor WHERE avaliacao.id_avaliacao=@id;";
                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = a;

                    try
                    {
                        sql.Open();

                        using (SqlDataReader drms = cmd.ExecuteReader())
                        {
                            while (drms.Read())
                            {
                                label29.Text = drms.GetDateTime(drms.GetOrdinal("data_visita")).ToString("dd/MM/yyyy");
                                label37.Text = Convert.ToString(drms["quantas"]);
                                label36.Text = Convert.ToString(drms["nome"]);
                                label38.Text = Convert.ToString(drms["indicar"]);
                                label39.Text = Convert.ToString(drms["atendimento"]);
                                label40.Text = Convert.ToString(drms["salaExpo"]);
                                label41.Text = Convert.ToString(drms["video"]);
                                label42.Text = Convert.ToString(drms["palestra"]);
                                label43.Text = Convert.ToString(drms["trilhaPas"]);
                                label45.Text = Convert.ToString(drms["caminhosGra"]);
                                label46.Text = Convert.ToString(drms["refugioVale"]);
                                label44.Text = Convert.ToString(drms["passadorMata"]);
                                label47.Text = Convert.ToString(drms["trilhoTei"]);
                                label48.Text = Convert.ToString(drms["passeioBel"]);
                                label49.Text = Convert.ToString(drms["limpezaCentro"]);
                                label50.Text = Convert.ToString(drms["estacionamento"]);
                                label51.Text = Convert.ToString(drms["tranquPass"]);
                                label52.Text = Convert.ToString(drms["atendEspacoConv"]);
                                label53.Text = Convert.ToString(drms["conservacao"]);
                                label54.Text = Convert.ToString(drms["condicaoTrilhas"]);
                                label55.Text = Convert.ToString(drms["Guia"]);
                                label56.Text = Convert.ToString(drms["FariaVoltar"]);

                                if (Convert.ToString(drms["agendado"]) == "False")
                                {
                                    label34.Text = "NÃO";
                                }
                                else
                                {
                                    label34.Text = "SIM";
                                }
                                if (Convert.ToString(drms["jaVisitouOutros"]) == "False")
                                {
                                    label35.Text = "NÃO";
                                }
                                else
                                {
                                    label35.Text = "SIM";
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
    }
}
