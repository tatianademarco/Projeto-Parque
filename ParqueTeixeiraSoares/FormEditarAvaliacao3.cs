using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Teste.FormAvaliacao1;
using System.Data.SqlClient;

namespace Teste
{
    public partial class FormEditarAvaliacao3 : Form
    {
        FormEditarAvaliacao2 f2;
        FormEditarAvaliacao1 f1;
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

        public FormEditarAvaliacao3(ParametrosFormulario parametros, FormEditarAvaliacao2 fa2, FormEditarAvaliacao1 fa1)
        {
            InitializeComponent();

            this.parametros = parametros;

            f2 = fa2;

            FillForm();
            f1 = fa1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = parque; Data Source = Tati\\SQLEXPRESS");
            SqlCommand command2 = new SqlCommand("select monitor.id_monitor from monitor where monitor.nome=@nome;", sql);
            SqlCommand cmd = new SqlCommand("UPDATE avaliacao SET data_visita=@data_visita, acompanhado=@acompanhado, jaVisitouPT=@jaVisitouPT, quantas=@quantas," +
                "jaVisitouOutros=@jaVisitouOutros, atendimento=@atendimento, indicar=@indicar, agendado=@agendado," +
            "salaExpo=@salaExpo, video=@video, palestra=@palestra, trilhaPas=@trilhaPas, caminhosGra=@caminhosGra, refugioVale=@refugioVale, passadorMata=@passadorMata," +
            "passeioBel=@passeioBel, trilhoTei=@trilhoTei, estacionamento=@estacionamento, limpezaCentro=@limpezaCentro, atendEspacoConv=@atendEspacoConv," +
            "tranquPass=@tranquPass, condicaoTrilhas=@condicaoTrilhas, conservacao=@conservacao, Guia=@Guia, FariaVoltar=@FariaVoltar, id_monitor=@id_monitor WHERE id_avaliacao=@id;", sql);

            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = f1.id;
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

                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
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

                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
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

                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
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

                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
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

                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
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
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
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

                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
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

                MessageBox.Show("Avaliação alterada com sucesso.", "PARQUE TEIXEIRA SOARES", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                foreach (Control control in groupBox12.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked && checkBox != checkBox4)
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
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked && checkBox != checkBox9)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in groupBox12.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked && checkBox != checkBox5)
                {
                    checkBox.Checked = false;
                }
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                foreach (Control control in groupBox10.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked && checkBox != checkBox12)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                foreach (Control control in groupBox10.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked && checkBox != checkBox11)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                foreach (Control control in groupBox10.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked && checkBox != checkBox10)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                foreach (Control control in groupBox7.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked && checkBox != checkBox8)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                foreach (Control control in groupBox7.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked && checkBox != checkBox7)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                foreach (Control control in groupBox7.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked && checkBox != checkBox6)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox24.Checked)
            {
                foreach (Control control in groupBox2.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked && checkBox != checkBox24)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox23.Checked)
            {
                foreach (Control control in groupBox2.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked && checkBox != checkBox23)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox22.Checked)
            {
                foreach (Control control in groupBox2.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked && checkBox != checkBox22)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
            {
                foreach (Control control in groupBox3.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked && checkBox != checkBox16)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {
                foreach (Control control in groupBox3.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked && checkBox != checkBox15)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
            {
                foreach (Control control in groupBox3.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked && checkBox != checkBox14)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked)
            {
                foreach (Control control in groupBox4.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked && checkBox != checkBox20)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked)
            {
                foreach (Control control in groupBox4.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox19)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked)
            {
                foreach (Control control in groupBox4.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox18)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox26.Checked)
            {
                foreach (Control control in groupBox11.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked && checkBox != checkBox26)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox27.Checked)
            {
                foreach (Control control in groupBox11.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked && checkBox != checkBox27)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox28.Checked)
            {
                foreach (Control control in groupBox11.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked && checkBox != checkBox28)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void FormEditarAvaliacao3_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormTodasAvaliacoes formAv = new FormTodasAvaliacoes();
            formAv.Show();
        }
    }
}
