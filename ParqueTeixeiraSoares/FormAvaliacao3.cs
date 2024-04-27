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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static Teste.FormAvaliacao1;
using CheckBox = System.Windows.Forms.CheckBox;

namespace Teste
{
    public partial class FormAvaliacao3 : Form
    {
        FormAvaliacao2 f2;
        FormAvaliacao1 f1;
        private ParametrosFormulario parametros;

        void FillForm()
        {
            foreach (Control control in groupBox12.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Text == f2.estacionamento)
                {
                    checkBox.Checked = true;
                    break;
                }
            }

            foreach (Control control in groupBox10.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Text == f2.centroVis)
                {
                    checkBox.Checked = true;
                    break;
                }
            }

            foreach (Control control in groupBox7.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Text == f2.atendimento)
                {
                    checkBox.Checked = true;
                    break;
                }

            }

            foreach (Control control in groupBox2.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Text == f2.tranquilidade)
                {
                    checkBox.Checked = true;
                    break;
                }
            }

            foreach (Control control in groupBox3.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Text == f2.condicoes)
                {
                    checkBox.Checked = true;
                    break;
                }
            }

            foreach (Control control in groupBox4.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Text == f2.conservacao)
                {
                    checkBox.Checked = true;
                    break;
                }
            }

            foreach (Control control in groupBox11.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Text == f2.guia)
                {
                    checkBox.Checked = true;
                    break;
                }
            }
            textBox2.Text = f2.fariaVoltar;
        }
        public FormAvaliacao3(ParametrosFormulario parametros, FormAvaliacao2 fa2, FormAvaliacao1 fa1)
        {
            InitializeComponent();

            this.parametros = parametros;

            f2 = fa2;

            FillForm();
            f1 = fa1;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox5.Checked = false;
                checkBox9.Checked = false;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox4.Checked = false;
                checkBox9.Checked = false;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                checkBox10.Checked = false;
                checkBox11.Checked = false;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                checkBox10.Checked = false;
                checkBox12.Checked = false;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                checkBox12.Checked = false;
                checkBox11.Checked = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                checkBox6.Checked = false;
                checkBox7.Checked = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                checkBox6.Checked = false;
                checkBox8.Checked = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                checkBox8.Checked = false;
                checkBox7.Checked = false;
            }
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox24.Checked)
            {
                checkBox23.Checked = false;
                checkBox22.Checked = false;
            }
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox23.Checked)
            {
                checkBox24.Checked = false;
                checkBox22.Checked = false;
            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox22.Checked)
            {
                checkBox23.Checked = false;
                checkBox24.Checked = false;
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
            {
                checkBox15.Checked = false;
                checkBox14.Checked = false;
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {
                checkBox16.Checked = false;
                checkBox14.Checked = false;
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
            {
                checkBox15.Checked = false;
                checkBox16.Checked = false;
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked)
            {
                checkBox19.Checked = false;
                checkBox18.Checked = false;
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked)
            {
                checkBox20.Checked = false;
                checkBox18.Checked = false;
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked)
            {
                checkBox19.Checked = false;
                checkBox20.Checked = false;
            }
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox26.Checked)
            {
                checkBox27.Checked = false;
                checkBox28.Checked = false;
            }
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox27.Checked)
            {
                checkBox26.Checked = false;
                checkBox28.Checked = false;
            }
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox28.Checked)
            {
                checkBox27.Checked = false;
                checkBox26.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection sql = new SqlConnection("Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = parque; Data Source = Tati\\SQLEXPRESS");
            SqlCommand command2 = new SqlCommand("select monitor.id_monitor from monitor where monitor.nome=@nome;", sql);
            SqlCommand cmd = new SqlCommand("insert into avaliacao(data_visita, acompanhado, jaVisitouPT, quantas, jaVisitouOutros, atendimento, indicar, agendado," +
            "salaExpo, video, palestra, trilhaPas, caminhosGra, refugioVale, passadorMata, passeioBel, trilhoTei, estacionamento, limpezaCentro, atendEspacoConv," +
            "tranquPass, condicaoTrilhas, conservacao, Guia, FariaVoltar, id_monitor) values (@data_visita, @acompanhado, @jaVisitouPT, @quantas, @jaVisitouOutros," +
            "@atendimento, @indicar, @agendado, @salaExpo, @video, @palestra, @trilhaPas, @caminhosGra, @refugioVale, @passadorMata, @passeioBel, @trilhoTei," +
            "@estacionamento, @limpezaCentro, @atendEspacoConv, @tranquPass, @condicaoTrilhas, @conservacao, @Guia, @FariaVoltar, @id_monitor);", sql);

            command2.Parameters.Add("@nome", SqlDbType.VarChar).Value = parametros.nome;
            cmd.Parameters.Add("@FariaVoltar", SqlDbType.VarChar).Value = textBox2.Text;
            cmd.Parameters.Add("@data_visita", SqlDbType.Date).Value = parametros.data;
            cmd.Parameters.Add("@acompanhado", SqlDbType.Bit).Value = parametros.acompanhado;
            cmd.Parameters.Add("@jaVisitouPT", SqlDbType.Bit).Value = parametros.jaVisitouPT;
            cmd.Parameters.Add("@quantas", SqlDbType.VarChar).Value = parametros.quantas;
            cmd.Parameters.Add("@jaVisitouOutros", SqlDbType.Bit).Value = parametros.jaVisitouOutros;
            cmd.Parameters.Add("@agendado", SqlDbType.Bit).Value = parametros.agendado;
            cmd.Parameters.Add("@atendimento", SqlDbType.VarChar).Value = parametros.atendimento;
            cmd.Parameters.Add("@indicar", SqlDbType.VarChar).Value = parametros.indicar;

            cmd.Parameters.Add("@salaExpo", SqlDbType.VarChar).Value = parametros.salaExpo;
            cmd.Parameters.Add("@video", SqlDbType.VarChar).Value = parametros.video;
            cmd.Parameters.Add("@palestra", SqlDbType.VarChar).Value = parametros.palestra;
            cmd.Parameters.Add("@trilhaPas", SqlDbType.VarChar).Value = parametros.trilhaPas;
            cmd.Parameters.Add("@caminhosGra", SqlDbType.VarChar).Value = parametros.caminhosGra;
            cmd.Parameters.Add("@refugioVale", SqlDbType.VarChar).Value = parametros.refugioVale;
            cmd.Parameters.Add("@passadorMata", SqlDbType.VarChar).Value = parametros.passadorMata;
            cmd.Parameters.Add("@passeioBel", SqlDbType.VarChar).Value = parametros.passeioBel;
            cmd.Parameters.Add("@trilhoTei", SqlDbType.VarChar).Value = parametros.trilhoTei;


            foreach (Control control in groupBox12.Controls)
            {
                SqlParameter parameterToRemove = null;
                foreach (SqlParameter parameter in cmd.Parameters)
                {
                    if (parameter.ParameterName == "@estacionamento")
                    {
                        parameterToRemove = parameter;
                        break;
                    }
                }

                if (parameterToRemove != null)
                {
                    cmd.Parameters.Remove(parameterToRemove);
                }

                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    cmd.Parameters.Add("@estacionamento", SqlDbType.VarChar).Value = control.Text;
                    break;
                }
                else
                {
                    cmd.Parameters.Add("@estacionamento", SqlDbType.VarChar).Value = "";
                }
            }

            foreach (Control control in groupBox10.Controls)
            {
                SqlParameter parameterToRemove = null;
                foreach (SqlParameter parameter in cmd.Parameters)
                {
                    if (parameter.ParameterName == "@limpezaCentro")
                    {
                        parameterToRemove = parameter;
                        break;
                    }
                }

                if (parameterToRemove != null)
                {
                    cmd.Parameters.Remove(parameterToRemove);
                }

                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    cmd.Parameters.Add("@limpezaCentro", SqlDbType.VarChar).Value = control.Text;
                    break;
                }
                else
                {
                    cmd.Parameters.Add("@limpezaCentro", SqlDbType.VarChar).Value = "";
                }
            }

            foreach (Control control in groupBox7.Controls)
            {
                SqlParameter parameterToRemove = null;
                foreach (SqlParameter parameter in cmd.Parameters)
                {
                    if (parameter.ParameterName == "@atendEspacoConv")
                    {
                        parameterToRemove = parameter;
                        break;
                    }
                }

                if (parameterToRemove != null)
                {
                    cmd.Parameters.Remove(parameterToRemove);
                }

                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    cmd.Parameters.Add("@atendEspacoConv", SqlDbType.VarChar).Value = control.Text;
                    break;
                }
                else
                {
                    cmd.Parameters.Add("@atendEspacoConv", SqlDbType.VarChar).Value = "";
                }
            }

            foreach (Control control in groupBox2.Controls)
            {
                SqlParameter parameterToRemove = null;
                foreach (SqlParameter parameter in cmd.Parameters)
                {
                    if (parameter.ParameterName == "@tranquPass")
                    {
                        parameterToRemove = parameter;
                        break;
                    }
                }

                if (parameterToRemove != null)
                {
                    cmd.Parameters.Remove(parameterToRemove);
                }

                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    cmd.Parameters.Add("@tranquPass", SqlDbType.VarChar).Value = control.Text;
                    break;
                }
                else
                {
                    cmd.Parameters.Add("@tranquPass", SqlDbType.VarChar).Value = "";
                }
            }

            foreach (Control control in groupBox3.Controls)
            {
                SqlParameter parameterToRemove = null;
                foreach (SqlParameter parameter in cmd.Parameters)
                {
                    if (parameter.ParameterName == "@condicaoTrilhas")
                    {
                        parameterToRemove = parameter;
                        break;
                    }
                }

                if (parameterToRemove != null)
                {
                    cmd.Parameters.Remove(parameterToRemove);
                }

                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    cmd.Parameters.Add("@condicaoTrilhas", SqlDbType.VarChar).Value = control.Text;
                    break;
                }
                else
                {
                    cmd.Parameters.Add("@condicaoTrilhas", SqlDbType.VarChar).Value = "";
                }
            }

            foreach (Control control in groupBox4.Controls)
            {
                SqlParameter parameterToRemove = null;
                foreach (SqlParameter parameter in cmd.Parameters)
                {
                    if (parameter.ParameterName == "@conservacao")
                    {
                        parameterToRemove = parameter;
                        break;
                    }
                }

                if (parameterToRemove != null)
                {
                    cmd.Parameters.Remove(parameterToRemove);
                }
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    cmd.Parameters.Add("@conservacao", SqlDbType.VarChar).Value = control.Text;
                    break;
                }
                else
                {
                    cmd.Parameters.Add("@conservacao", SqlDbType.VarChar).Value = "";
                }
            }

            foreach (Control control in groupBox11.Controls)
            {
                SqlParameter parameterToRemove = null;
                foreach (SqlParameter parameter in cmd.Parameters)
                {
                    if (parameter.ParameterName == "@Guia")
                    {
                        parameterToRemove = parameter;
                        break;
                    }
                }

                if (parameterToRemove != null)
                {
                    cmd.Parameters.Remove(parameterToRemove);
                }

                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    cmd.Parameters.Add("@Guia", SqlDbType.VarChar).Value = control.Text;
                    break;
                }
                else
                {
                    cmd.Parameters.Add("@Guia", SqlDbType.VarChar).Value = "";
                }
            }
            try
            {
                sql.Open();

                SqlDataReader drms2 = command2.ExecuteReader();
                while (drms2.Read())
                {
                    int monitorId = drms2.GetInt32(0);
                    cmd.Parameters.Add("@id_monitor", SqlDbType.Int).Value = monitorId;
                }
                drms2.Close();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Avaliação cadastrada com sucesso.", "PARQUE TEIXEIRA SOARES - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Close();
            }
            this.Close();
            f2.Close();
            f1.Close();
            FormAvaliacao1 formAvaliacao = new FormAvaliacao1();
            formAvaliacao.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupBox12.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
                {
                    f2.estacionamento = control.Text;
                    break;
                }
                else
                {
                    f2.estacionamento = "";
                }
            }
            foreach (Control control in groupBox10.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
                {
                    f2.centroVis = control.Text;
                    break;
                }
                else
                {
                    f2.centroVis = "";
                }
            }

            foreach (Control control in groupBox7.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
                {
                    f2.atendimento = control.Text;
                    break;
                }
                else
                {
                    f2.atendimento = "";
                }

            }

            foreach (Control control in groupBox2.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
                {
                    f2.tranquilidade = control.Text;
                    break;
                }
                else
                {
                    f2.tranquilidade = "";
                }
            }

            foreach (Control control in groupBox3.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
                {
                    f2.condicoes = control.Text;
                    break;
                }
                else
                {
                    f2.condicoes = "";
                }
            }

            foreach (Control control in groupBox4.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
                {
                    f2.conservacao = control.Text;
                    break;
                }
                else
                {
                    f2.conservacao = "";
                }
            }

            foreach (Control control in groupBox11.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
                {
                    f2.guia = control.Text;
                    break;
                }
                else
                {
                    f2.guia = "";
                }
            }

            f2.fariaVoltar = textBox2.Text;

            this.Close();
        }
    }
}

