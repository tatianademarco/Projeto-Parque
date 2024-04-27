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
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Teste
{
    public partial class FormFormulárioVisitas : Form
    {
        void FillComboBoxPais()
        {
            SqlConnection sql = new SqlConnection("Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = parque; Data Source = Tati\\SQLEXPRESS");
            SqlCommand cmd = new SqlCommand("select * from pais", sql);

            try
            {
                sql.Open();
                SqlDataReader drms = cmd.ExecuteReader();

                while (drms.Read())
                {
                    string nomePais = drms.GetString("nome_pt");
                    comboPaís.Items.Add(nomePais);
                }
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

        public FormFormulárioVisitas()
        {
            InitializeComponent();
            FillComboBoxPais();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = parque; Data Source = Tati\\SQLEXPRESS");
            SqlCommand cmd = new SqlCommand("insert into visita(data, qtd_pessoas, turno, neces_esp, transporte, perfil_grupo, agendado, responsavel_grupo, objetivo, como_conheceram) values (@data, @qtd_pessoas, @turno, @neces_esp, @transporte, @perfil_grupo, @agendado, @responsavel_grupo, @objetivo, @como_conheceram);select cidade.id from cidade where cidade.nome = @cidade;", sql);
            SqlCommand command = new SqlCommand("select max(id_visita) from visita;", sql);
            SqlCommand cmd2 = new SqlCommand("insert into cidades(id, id_visita) values (@id, @id_visita)", sql);
            cmd.Parameters.Add("data", SqlDbType.Date).Value = dateTimeVisita.Text;
            cmd.Parameters.Add("turno", SqlDbType.VarChar).Value = comboBoxTurno.Text;
            cmd.Parameters.Add("@responsavel_grupo", SqlDbType.VarChar).Value = textBoxResponsavel.Text;
            cmd.Parameters.Add("@qtd_pessoas", SqlDbType.Int).Value = numericPessoas.Text;
            cmd.Parameters.Add("@neces_esp", SqlDbType.VarChar).Value = comboNecessidades.Text;
            cmd.Parameters.Add("@agendado", SqlDbType.VarChar).Value = comboAgendou.Text;
            cmd.Parameters.Add("@transporte", SqlDbType.VarChar).Value = textTransporte.Text;
            cmd.Parameters.Add("@perfil_grupo", SqlDbType.VarChar).Value = textPerfil.Text;
            cmd.Parameters.Add("@objetivo", SqlDbType.VarChar).Value = textObjetivo.Text;
            cmd.Parameters.Add("@como_conheceram", SqlDbType.VarChar).Value = textConheceram.Text;
            cmd.Parameters.Add("@cidade", SqlDbType.VarChar).Value = comboBoxCidade.Text;

            try
            {
                sql.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader drms = cmd.ExecuteReader();
                while (drms.Read())
                {
                    int cidadeId = drms.GetInt32("id");
                    cmd2.Parameters.Add("@id", SqlDbType.Int).Value = cidadeId;
                }
                drms.Close();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int visitaId = reader.GetInt32(0);
                    cmd2.Parameters.Add("@id_visita", SqlDbType.Int).Value = visitaId;
                }
                reader.Close();

                cmd2.ExecuteNonQuery();

                MessageBox.Show("Visitação cadastrada com sucesso.", "PARQUE TEIXEIRA SOARES - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTimeVisita.Text = "";
                comboBoxTurno.Text = "";
                textBoxResponsavel.Text = "";
                numericPessoas.Text = "";
                comboNecessidades.Text = "";
                comboAgendou.Text = "";
                textTransporte.Text = "";
                textPerfil.Text = "";
                textObjetivo.Text = "";
                textConheceram.Text = "";


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

        private void comboPaís_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = parque; Data Source = Tati\\SQLEXPRESS");
            SqlCommand cmd = new SqlCommand("select estado.uf from estado inner join pais on estado.pais=pais.id where pais.nome_pt=@pais", sql);
            cmd.Parameters.Add("@pais", SqlDbType.VarChar).Value = comboPaís.Text;

            try
            {
                sql.Open();
                SqlDataReader drms = cmd.ExecuteReader();

                comboUF.Text = "";
                comboUF.Items.Clear();

                while (drms.Read())
                {
                    {
                        string estado = drms.GetString("uf");
                        comboUF.Items.Add(estado);
                    }
                }
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

        private void comboUF_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = parque; Data Source = Tati\\SQLEXPRESS");
            SqlCommand cmd = new SqlCommand("select cidade.nome from cidade inner join estado on estado.id=cidade.uf where estado.uf=@uf", sql);
            cmd.Parameters.Add("@uf", SqlDbType.VarChar).Value = comboUF.Text;

            try
            {
                sql.Open();
                SqlDataReader drms = cmd.ExecuteReader();

                comboBoxCidade.Text = "";
                comboBoxCidade.Items.Clear();
                while (drms.Read())
                {
                    {
                        string cidade = drms.GetString("nome");

                        comboBoxCidade.Items.Add(cidade);
                    }
                }
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

        private void comboBoxCidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
