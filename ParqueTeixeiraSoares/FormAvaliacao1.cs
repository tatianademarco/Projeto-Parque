using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
    public partial class FormAvaliacao1 : Form
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
        public FormAvaliacao1()
        {
            InitializeComponent();
            FillComboBoxMonitor();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox32.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox29.Checked = false;
                checkBox30.Checked = false;
                checkBox31.Checked = false;
                checkBox15.Checked = false;
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

            FormAvaliacao2 avaliacao2 = new FormAvaliacao2(parametros, this);
            avaliacao2.Show();
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
                checkBox9.Checked = false;
                checkBox32.Checked = false;
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

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                checkBox32.Checked = false;
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

        public class ParametrosFormulario
        {
            public string nome { get; set; }
            public string quantas { get; set; }
            public string data { get; set; }

            public bool acompanhado { get; set; }
            public bool jaVisitouPT { get; set; }

            public bool jaVisitouOutros { get; set; }
            public bool agendado { get; set; }

            public string indicar { get; set; }
            public string atendimento { get; set; }

            public string salaExpo { get; set; }
            public string video { get; set; }
            public string palestra { get; set; }

            public string trilhaPas { get; set; }
            public string caminhosGra { get; set; }

            public string refugioVale { get; set; }
            public string passadorMata { get; set; }

            public string passeioBel { get; set; }
            public string trilhoTei { get; set; }
        }

        private void comboBoxMonitor_SelectedIndexChanged(object sender, EventArgs e)
        {

    }
    }
}
