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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Teste
{
    public partial class FormVisitacao : Form
    {
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
        public FormVisitacao()
        {
            InitializeComponent();
            FillComboBoxMonitor();
        }

        private void textBoxResponsavel_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormVisitacao_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdicionarVisitantes adicionarVisitantes = new FormAdicionarVisitantes(listBoxVisiantes, this);
            adicionarVisitantes.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = parque; Data Source = Tati\\SQLEXPRESS");
            SqlCommand cmd = new SqlCommand("insert into visita(data_visita, turno, neces_esp, transporte, perfil_grupo, agendado, responsavel_grupo, objetivo, id_monitor) values (@data, @turno, @neces_esp, @transporte, @perfil_grupo, @agendado, @responsavel_grupo, @objetivo, @id_monitor);", sql);
            SqlCommand command = new SqlCommand("select max(id_visita) from visita;", sql);
            SqlCommand command2 = new SqlCommand("select visitante.id_visitante from visitante where visitante.nome_vis=@nome_vis;", sql);
            SqlCommand cmd2 = new SqlCommand("insert into visitacao(id_visita, id_visitante) values (@id_visita, @id_visitante)", sql);
            SqlCommand command3 = new SqlCommand("select monitor.id_monitor from monitor where monitor.nome=@nome;", sql);
            cmd.Parameters.Add("@data", SqlDbType.Date).Value = dateTimeVisita.Text;
            cmd.Parameters.Add("@turno", SqlDbType.VarChar).Value = comboBoxTurno.Text;
            cmd.Parameters.Add("@responsavel_grupo", SqlDbType.VarChar).Value = comboBoxResponsavel.Text;
            cmd.Parameters.Add("@neces_esp", SqlDbType.Bit).Value = checkBox1SIM.Checked;
            cmd.Parameters.Add("@agendado", SqlDbType.Bit).Value = checkBox2SIM.Checked;
            cmd.Parameters.Add("@transporte", SqlDbType.VarChar).Value = textTransporte.Text;
            cmd.Parameters.Add("@perfil_grupo", SqlDbType.VarChar).Value = textPerfil.Text;
            cmd.Parameters.Add("@objetivo", SqlDbType.VarChar).Value = textObjetivo.Text;
            if (comboBoxMonitor.SelectedIndex == -1)
            {
                command3.Parameters.Add("@nome", SqlDbType.VarChar).Value = "Sem Monitor";
            }
            else
            {
                command3.Parameters.Add("@nome", SqlDbType.VarChar).Value = comboBoxMonitor.Text;
            }
           

            try
            {
                sql.Open();
                SqlDataReader drms3 = command3.ExecuteReader();
                while (drms3.Read())
                {
                    int monitorId = drms3.GetInt32(0);
                    cmd.Parameters.Add("@id_monitor", SqlDbType.Int).Value = monitorId;
                }
                drms3.Close();
                cmd.ExecuteNonQuery();

                SqlDataReader drms2 = command.ExecuteReader();
                while (drms2.Read())
                {
                    int visitaId = drms2.GetInt32(0);
                    cmd2.Parameters.Add("@id_visita", SqlDbType.VarChar).Value = visitaId;
                }
                drms2.Close();

                foreach (var item in listBoxVisiantes.Items)
                {
                    command2.Parameters.Clear();

                    SqlParameter parameterToRemove = null;
                    foreach (SqlParameter parameter in cmd2.Parameters)
                    {
                        if (parameter.ParameterName == "@id_visitante")
                        {
                            parameterToRemove = parameter;
                            break;
                        }
                    }

                    if (parameterToRemove != null)
                    {
                        cmd2.Parameters.Remove(parameterToRemove);
                    }

                    command2.Parameters.Add("@nome_vis", SqlDbType.VarChar).Value = item;
                    SqlDataReader drms = command2.ExecuteReader();
                    while (drms.Read())
                    {
                        int visitanteId = drms.GetInt32("id_visitante");
                        cmd2.Parameters.Add("@id_visitante", SqlDbType.VarChar).Value = visitanteId;
                    }
                    drms.Close();

                    cmd2.ExecuteNonQuery();
                }

                MessageBox.Show("Visitação cadastrada com sucesso.", "PARQUE TEIXEIRA SOARES - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTimeVisita.Text = "";
                comboBoxTurno.Text = "";
                textTransporte.Text = "";
                textPerfil.Text = "";
                textObjetivo.Text = "";
                comboBoxResponsavel.Text = "";
                checkBox1SIM.Checked = false;
                checkBox2SIM.Checked = false;
                checkBox1Não.Checked = false;
                checkBox2NÃO.Checked = false;
                checkBox1.Checked = false;
                SIMAcompanhado.Checked = false;
                comboBoxMonitor.Text = "";
                listBoxVisiantes.Items.Clear();
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

        private void checkBox1SIM_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1SIM.Checked)
            {
                checkBox1Não.Checked = false;
            }
        }

        private void checkBox2SIM_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2SIM.Checked)
            {
                checkBox2NÃO.Checked = false;
            }
        }

        private void checkBox2NÃO_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2NÃO.Checked)
            {
                checkBox2SIM.Checked = false;
            }
        }

        private void checkBox1Não_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1Não.Checked)
            {
                checkBox1SIM.Checked = false;
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
    }
}
