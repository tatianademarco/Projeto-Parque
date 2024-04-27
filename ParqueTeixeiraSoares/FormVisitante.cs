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
    public partial class FormVisitante : Form
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
                drms.Close();
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
        public FormVisitante()
        {
            InitializeComponent();
            FillComboBoxPais();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    string estado = drms.GetString("uf");
                    comboUF.Items.Add(estado);
                }
                drms.Close();
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
                    string cidade = drms.GetString("nome");

                    comboBoxCidade.Items.Add(cidade);
                }
                drms.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = parque; Data Source = Tati\\SQLEXPRESS");
            SqlCommand cmd = new SqlCommand("insert into visitante(nome_vis, data_nasc, email, telefone, como_soube, id_cidade, id_pais) values (@nome_vis, @data_nasc, @email, @telefone, @como_soube, @id_cidade, @id_pais);", sql);
            SqlCommand command = new SqlCommand("select cidade.id from cidade where cidade.nome = @cidade;", sql);
            SqlCommand command2 = new SqlCommand("select pais.id from pais where pais.nome_pt = @pais;", sql);
            cmd.Parameters.Add("@nome_vis", SqlDbType.VarChar).Value = txtNomeVis.Text;
            cmd.Parameters.Add("@data_nasc", SqlDbType.VarChar).Value = maskedTextBoxNasc.Text;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = textBoxEmail.Text;
            cmd.Parameters.Add("@telefone", SqlDbType.VarChar).Value = maskedTextBoxTel.Text;
            cmd.Parameters.Add("@como_soube", SqlDbType.VarChar).Value = textBoxComoSoube.Text;
            command.Parameters.Add("@cidade", SqlDbType.VarChar).Value = comboBoxCidade.Text;
            command2.Parameters.Add("@pais", SqlDbType.VarChar).Value = comboPaís.Text;

            try
            {
                sql.Open();
                SqlDataReader drms = command.ExecuteReader();
                if (drms.HasRows == false)
                {
                    SqlCommand cmd2 = new SqlCommand("insert into cidade(id, nome, uf) values (@id, @nome, @uf);", sql);
                    SqlCommand cmd3 = new SqlCommand("select max(id) from cidade;", sql);
                    cmd2.Parameters.Add("@nome", SqlDbType.VarChar).Value = comboBoxCidade.Text;
                    cmd2.Parameters.Add("@uf", SqlDbType.Int).Value = 99;
                    drms.Close();
                    try
                    {
                        SqlDataReader reader = cmd3.ExecuteReader();
                        while (reader.Read())
                        {
                            cmd2.Parameters.Add("@id", SqlDbType.Int).Value = reader.GetInt32(0) + 1;
                            cmd.Parameters.Add("@id_cidade", SqlDbType.Int).Value = reader.GetInt32(0) + 1;
                        }
                        reader.Close();

                        cmd2.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    while (drms.Read())
                    {
                        cmd.Parameters.Add("@id_cidade", SqlDbType.Int).Value = drms.GetInt32("id");
                    }
                    drms.Close();
                }
                SqlDataReader drms2 = command2.ExecuteReader();
                while (drms2.Read())
                {
                    cmd.Parameters.Add("@id_pais", SqlDbType.Int).Value = drms2.GetInt32("id");
                }
                drms2.Close();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Visitante cadastrado com sucesso.", "PARQUE TEIXEIRA SOARES - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeVis.Text = "";
                maskedTextBoxNasc.Text = "";
                textBoxEmail.Text = "";
                maskedTextBoxTel.Text = "";
                textBoxComoSoube.Text = "";
                comboBoxCidade.Text = "";
                comboPaís.Text = "";
                comboUF.Text = "";

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
    }
}
