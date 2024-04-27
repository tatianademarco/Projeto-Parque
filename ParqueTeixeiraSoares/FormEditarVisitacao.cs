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
    public partial class FormEditarVisitacao : Form
    {
        int id;
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
        public FormEditarVisitacao(int v)
        {
            InitializeComponent();

            FillComboBoxMonitor();

            using (SqlConnection sql = new SqlConnection("Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = parque; Data Source = Tati\\SQLEXPRESS"))
            {
                SqlCommand cmd = new SqlCommand("select visita.data_visita, visita.turno, visita.neces_esp, visita.transporte, visita.perfil_grupo, visita.agendado, visita.responsavel_grupo, visita.objetivo, visitante.nome_vis, monitor.nome from visita join visitacao\r\non visita.id_visita=@id_visita and visitacao.id_visita=@id_visita join visitante on visitacao.id_visitante=visitante.id_visitante join monitor on monitor.id_monitor=visita.id_monitor;", sql);
                cmd.Parameters.Add("@id_visita", SqlDbType.Int).Value = v;
                try
                {
                    sql.Open();
                    SqlDataReader drms = cmd.ExecuteReader();
                    drms.Read();
                    dateTimeVisita.Text = Convert.ToString(drms["data_visita"]);
                    comboBoxTurno.Text = Convert.ToString(drms["turno"]);
                    comboBoxResponsavel.Text = Convert.ToString(drms["responsavel_grupo"]);
                    textPerfil.Text = Convert.ToString(drms["perfil_grupo"]);
                    textTransporte.Text = Convert.ToString(drms["transporte"]);
                    textObjetivo.Text = Convert.ToString(drms["objetivo"]);
                    checkBox1SIM.Checked = Convert.ToBoolean(drms["neces_esp"]);
                    string monitor = Convert.ToString(drms["nome"]);
                    if (monitor == "Sem Monitor")
                    {
                        checkBox1.Checked = true;
                        comboBoxMonitor.Enabled = false;
                    }
                    else
                    {
                        SIMAcompanhado.Checked = true;
                        comboBoxMonitor.Text = monitor;
                    }
                    if (checkBox1SIM.Checked == false)
                    {
                        checkBox1Não.Checked = true;
                    }
                    checkBox2SIM.Checked = Convert.ToBoolean(drms["agendado"]);
                    if (checkBox2SIM.Checked == false)
                    {
                        checkBox2NÃO.Checked = true;
                    }
                    drms.Close();
                    SqlDataReader drms2 = cmd.ExecuteReader();
                    while (drms2.Read())
                    {
                        listBoxVisiantes.Items.Add(Convert.ToString(drms2["nome_vis"]));
                    }
                    drms2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            foreach (var item in listBoxVisiantes.Items)
            {
                comboBoxResponsavel.Items.Add(item);
            }

            id = v;
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

        private void checkBox1SIM_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1SIM.Checked)
            {
                checkBox1Não.Checked = false;
            }
        }

        private void checkBox1Não_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1Não.Checked)
            {
                checkBox1SIM.Checked = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdicionarVisitantes2 adicionarVisitantes2 = new FormAdicionarVisitantes2(listBoxVisiantes, this);
            adicionarVisitantes2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = parque; Data Source = Tati\\SQLEXPRESS");
            SqlCommand cmd = new SqlCommand("update visita set data_visita=@data, turno=@turno, neces_esp=@neces_esp, transporte=@transporte, perfil_grupo=@perfil_grupo, agendado=@agendado, responsavel_grupo=@responsavel_grupo, objetivo=@objetivo, id_monitor=@id_monitor where id_visita=@id_visita; DELETE FROM visitacao WHERE id_visita=@id_visita;", sql);
            SqlCommand command2 = new SqlCommand("select visitante.id_visitante from visitante where visitante.nome_vis=@nome_vis;", sql);
            SqlCommand cmd2 = new SqlCommand("insert into visitacao(id_visita, id_visitante) values (@id_visita, @id_visitante);", sql);
            SqlCommand command3 = new SqlCommand("select monitor.id_monitor from monitor where monitor.nome=@nome;", sql);
            cmd.Parameters.Add("@id_visita", SqlDbType.Int).Value = id;
            cmd2.Parameters.Add("@id_visita", SqlDbType.Int).Value = id;
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

                MessageBox.Show("Visitação atualizada com sucesso.", "PARQUE TEIXEIRA SOARES", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void FormEditarVisitacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormTodasVisitacoes formVisitacao = new FormTodasVisitacoes();
            formVisitacao.Show();
        }
    }
}
