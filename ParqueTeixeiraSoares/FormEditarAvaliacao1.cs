using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
using static Teste.FormAvaliacao1;

namespace Teste
{
    public partial class FormEditarAvaliacao1 : Form
    {
        public string salaExpo { get; set; }
        public string video { get; set; }
        public string palestra { get; set; }

        public string trilhaPas { get; set; }
        public string caminhosGra { get; set; }

        public string refugioVale { get; set; }
        public string passadorMata { get; set; }

        public string passeioBel { get; set; }
        public string trilhoTei { get; set; }

        public string estacionamento { get; set; }
        public string centroVis { get; set; }
        public string atendimento { get; set; }
        public string tranquilidade { get; set; }
        public string condicoes { get; set; }
        public string conservacao { get; set; }
        public string guia { get; set; }
        public string fariaVoltar { get; set; }

        public int id { get; set; }

        void FillComboBoxMonitor()
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
                                string nome = drms.GetString(drms.GetOrdinal("nome"));
                                comboBoxMonitor.Items.Add(nome);
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
        public FormEditarAvaliacao1(int a)
        {
            InitializeComponent();
            FillComboBoxMonitor();

            id = a;

            using (SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=parque;Data Source=Tati\\SQLEXPRESS"))
            {
                string query = "SELECT avaliacao.data_visita, avaliacao.quantas, avaliacao.jaVisitouOutros," +
                    "avaliacao.atendimento, avaliacao.indicar, avaliacao.agendado, avaliacao.jaVisitouPT, avaliacao.salaExpo," +
                    "avaliacao.video, avaliacao.palestra, avaliacao.trilhaPas, avaliacao.caminhosGra," +
                    "avaliacao.refugioVale, avaliacao.passadorMata, avaliacao.passeioBel, avaliacao.trilhoTei," +
                    "avaliacao.estacionamento, avaliacao.limpezaCentro, avaliacao.atendEspacoConv, avaliacao.tranquPass," +
                    "avaliacao.condicaoTrilhas, avaliacao.conservacao, avaliacao.Guia, avaliacao.FariaVoltar," +
                    "avaliacao.acompanhado, monitor.nome FROM avaliacao JOIN monitor " +
                    "ON monitor.id_monitor=avaliacao.id_monitor WHERE avaliacao.id_avaliacao=@id;";

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
                                dateTimeVisita.Text = drms.GetDateTime(drms.GetOrdinal("data_visita")).ToString("dd/MM/yyyy");
                                numericUpDown1.Text = Convert.ToString(drms["quantas"]);
                                comboBoxMonitor.Text = Convert.ToString(drms["nome"]);
                                salaExpo = Convert.ToString(drms["salaExpo"]);
                                video = Convert.ToString(drms["video"]);
                                palestra = Convert.ToString(drms["palestra"]);
                                trilhaPas = Convert.ToString(drms["trilhaPas"]);
                                caminhosGra = Convert.ToString(drms["caminhosGra"]);
                                refugioVale = Convert.ToString(drms["refugioVale"]);
                                passadorMata = Convert.ToString(drms["passadorMata"]);
                                trilhoTei = Convert.ToString(drms["trilhoTei"]);
                                passeioBel = Convert.ToString(drms["passeioBel"]);
                                centroVis = Convert.ToString(drms["limpezaCentro"]);
                                estacionamento = Convert.ToString(drms["estacionamento"]);
                                tranquilidade = Convert.ToString(drms["tranquPass"]);
                                atendimento = Convert.ToString(drms["atendEspacoConv"]);
                                conservacao = Convert.ToString(drms["conservacao"]);
                                condicoes = Convert.ToString(drms["condicaoTrilhas"]);
                                guia = Convert.ToString(drms["Guia"]);
                                fariaVoltar = Convert.ToString(drms["FariaVoltar"]);

                                if (Convert.ToString(drms["agendado"]) == "False")
                                {
                                    checkBox4.Checked = true;
                                }
                                else
                                {
                                    checkBox3.Checked = true;
                                }
                                if (Convert.ToString(drms["jaVisitouOutros"]) == "False")
                                {
                                    checkBox5.Checked = true;
                                }
                                else
                                {
                                    checkBox6.Checked = true;
                                }
                                if (Convert.ToString(drms["jaVisitouPT"]) == "False")
                                {
                                    checkBox7.Checked = true;
                                }
                                else
                                {
                                    checkBox8SIM.Checked = true;
                                }
                                if (Convert.ToString(drms["acompanhado"]) == "False")
                                {
                                    checkBox1.Checked = true;
                                }
                                else
                                {
                                    SIMAcompanhado.Checked = true;
                                }
                                foreach (Control control in groupBox11.Controls)
                                {
                                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Text == Convert.ToString(drms["atendimento"]))
                                    {
                                        checkBox.Checked = true;
                                        break;
                                    }
                                }
                                foreach (Control control in groupBox12.Controls)
                                {
                                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Text == Convert.ToString(drms["indicar"]))
                                    {
                                        checkBox.Checked = true;
                                        break;
                                    }
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

        private void button1_Click(object sender, EventArgs e)
        {
            ParametrosFormulario parametros = new ParametrosFormulario();
            if (comboBoxMonitor.SelectedIndex == -1)
            {
                parametros.nome = "Sem Monitor";
            }
            else
            {
                parametros.nome = comboBoxMonitor.Text;
            }

            parametros.quantas = numericUpDown1.Text;
            parametros.data = dateTimeVisita.Text;

            parametros.acompanhado = SIMAcompanhado.Checked;
            parametros.jaVisitouPT = checkBox8SIM.Checked;

            parametros.jaVisitouOutros = checkBox6.Checked;
            parametros.agendado = checkBox3.Checked;

            foreach (Control control in groupBox11.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    parametros.atendimento = control.Text;
                    break;
                }
                else
                {
                    parametros.atendimento = "";
                }
            }

            foreach (Control control in groupBox12.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    parametros.indicar = control.Text;
                    break;
                }
                else
                {
                    parametros.indicar = "";
                }
            }

            FormEditarAvaliacao2 avaliacao2 = new FormEditarAvaliacao2(parametros, this);
            avaliacao2.Show();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox4.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox3.Checked = false;
            }
        }

        private void SIMAcompanhado_CheckedChanged(object sender, EventArgs e)
        {
            if (SIMAcompanhado.Checked)
            {
                checkBox1.Checked = false;
                comboBoxMonitor.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SIMAcompanhado.Checked = false;
                comboBoxMonitor.Enabled = false;
                comboBoxMonitor.Text = "Sem Monitor";
            }
        }

        private void checkBox8SIM_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8SIM.Checked)
            {
                checkBox7.Checked = false;
                numericUpDown1.Enabled = true;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                checkBox8SIM.Checked = false;
                numericUpDown1.Enabled = false;
                numericUpDown1.Value = 0;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                checkBox5.Checked = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox6.Checked = false;
            }
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox25.Checked)
            {
                checkBox26.Checked = false;
                checkBox27.Checked = false;
                checkBox28.Checked = false;
            }
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox26.Checked)
            {
                checkBox25.Checked = false;
                checkBox27.Checked = false;
                checkBox28.Checked = false;
            }
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox27.Checked)
            {
                checkBox26.Checked = false;
                checkBox25.Checked = false;
                checkBox28.Checked = false;
            }
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox28.Checked)
            {
                checkBox26.Checked = false;
                checkBox27.Checked = false;
                checkBox25.Checked = false;
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox29.Checked = false;
                checkBox30.Checked = false;
                checkBox31.Checked = false;
                checkBox32.Checked = false;
            }
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox32.Checked)
            {
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox29.Checked = false;
                checkBox30.Checked = false;
                checkBox31.Checked = false;
                checkBox15.Checked = false;
            }
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox31.Checked)
            {
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox29.Checked = false;
                checkBox30.Checked = false;
                checkBox32.Checked = false;
                checkBox15.Checked = false;
            }
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox30.Checked)
            {
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox29.Checked = false;
                checkBox32.Checked = false;
                checkBox31.Checked = false;
                checkBox15.Checked = false;
            }
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox29.Checked)
            {
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox32.Checked = false;
                checkBox30.Checked = false;
                checkBox31.Checked = false;
                checkBox15.Checked = false;
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
            {
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox32.Checked = false;
                checkBox29.Checked = false;
                checkBox30.Checked = false;
                checkBox31.Checked = false;
                checkBox15.Checked = false;
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox32.Checked = false;
                checkBox14.Checked = false;
                checkBox29.Checked = false;
                checkBox30.Checked = false;
                checkBox31.Checked = false;
                checkBox15.Checked = false;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox32.Checked = false;
                checkBox11.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox29.Checked = false;
                checkBox30.Checked = false;
                checkBox31.Checked = false;
                checkBox15.Checked = false;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox32.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox29.Checked = false;
                checkBox30.Checked = false;
                checkBox31.Checked = false;
                checkBox15.Checked = false;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                foreach (Control control in groupBox12.Controls)
                {
                    if (control is CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox10)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                foreach (Control control in groupBox12.Controls)
                {
                    if (control is CheckBox checkBox && checkBox.Checked && checkBox != checkBox9)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }
    }
}
