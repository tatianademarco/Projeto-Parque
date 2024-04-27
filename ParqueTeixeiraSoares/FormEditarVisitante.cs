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
    public partial class FormEditarVisitante : Form
    {
        string v;
        void FillComboBoxPais()
        {
            using (SqlConnection sql = new SqlConnection("Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = parque; Data Source = Tati\\SQLEXPRESS"))
            {
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
            }
            }
            public FormEditarVisitante(string z)
        {
            InitializeComponent();
            FillComboBoxPais();

            v = z;
            
            using (SqlConnection sql = new SqlConnection("Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = parque; Data Source = Tati\\SQLEXPRESS"))
            {
                SqlCommand cmd = new SqlCommand("select visitante.data_nasc, visitante.como_soube, visitante.telefone, visitante.email, cidade.nome, pais.nome_pt, estado.uf from cidade join visitante on cidade.id=visitante.id_cidade join pais on pais.id=visitante.id_pais join estado on estado.id=cidade.uf where nome_vis=@nome_vis;", sql);
                cmd.Parameters.Add("@nome_vis", SqlDbType.VarChar).Value = z;
                try
                {
                    sql.Open();
                    SqlDataReader drms = cmd.ExecuteReader();
                    drms.Read();
                    txtNomeVis.Text = z;
                    maskedTextBoxTel.Text = Convert.ToString(drms["telefone"]);
                    textBoxEmail.Text = Convert.ToString(drms["email"]);
                    textBoxComoSoube.Text = Convert.ToString(drms["como_soube"]);
                    maskedTextBoxNasc.Text = Convert.ToString(drms["data_nasc"]);
                    comboUF.Text = Convert.ToString(drms["uf"]);
                    comboBoxCidade.Text = Convert.ToString(drms["nome"]);
                    comboPaís.Text = Convert.ToString(drms["nome_pt"]);
                    drms.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            }

            private void button6_Click(object sender, EventArgs e)
        {
            FormGerenciarVisitantes formVisitante = new FormGerenciarVisitantes();
            formVisitante.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sql = new SqlConnection("Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = parque; Data Source = Tati\\SQLEXPRESS"))
            {
                SqlCommand cmd = new SqlCommand("update visitante set nome_vis=@nome_vis, data_nasc=@data_nasc, email=@email, telefone=@telefone, como_soube=@como_soube, id_cidade=@id_cidade1, id_pais=@id_pais where nome_vis=@nome", sql);
                SqlCommand command = new SqlCommand("select cidade.id from cidade where cidade.nome = @cidade;", sql);
                SqlCommand command2 = new SqlCommand("select pais.id from pais where pais.nome_pt = @pais;", sql);
                cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = v;
                cmd.Parameters.Add("@nome_vis", SqlDbType.VarChar).Value = txtNomeVis.Text;
                cmd.Parameters.Add("@data_nasc", SqlDbType.VarChar).Value = maskedTextBoxNasc.Text;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = textBoxEmail.Text;
                cmd.Parameters.Add("@telefone", SqlDbType.VarChar).Value = maskedTextBoxTel.Text;
                cmd.Parameters.Add("@como_soube", SqlDbType.VarChar).Value = textBoxComoSoube.Text;
                command.Parameters.Add("@cidade", SqlDbType.VarChar).Value = comboBoxCidade.Text;
                command2.Parameters.Add("@pais", SqlDbType.VarChar).Value = comboPaís.Text;
                var editaruser = MessageBox.Show("Tem certeza que deseja fazer alterações no visitante?", "PARQUE TEIXEIRA SOARES - CADASTRO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (editaruser == DialogResult.Yes)
                {
                    if (txtNomeVis.Text != "")
                    {
                        try
                        {
                            sql.Open();
                            command.ExecuteNonQuery();
                            SqlDataReader drms = command.ExecuteReader();
                            if (drms.HasRows == false)
                            {
                                SqlCommand cmd2 = new SqlCommand("insert into cidade(id, nome) values (@id, @nome);", sql);
                                SqlCommand cmd3 = new SqlCommand("select max(id) from cidade;", sql);
                                cmd2.Parameters.Add("@nome", SqlDbType.VarChar).Value = comboBoxCidade.Text;
                                drms.Close();
                                try
                                {
                                    cmd3.ExecuteNonQuery();
                                    SqlDataReader reader = cmd3.ExecuteReader();
                                    while (reader.Read())
                                    {
                                        cmd2.Parameters.Add("@id", SqlDbType.Int).Value = reader.GetInt32(0) + 1;
                                        cmd.Parameters.Add("@id_cidade1", SqlDbType.Int).Value = reader.GetInt32(0) + 1;
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
                                    cmd.Parameters.Add("@id_cidade1", SqlDbType.Int).Value = drms.GetInt32(0);
                                }
                                drms.Close();
                            }
                            command2.ExecuteNonQuery();
                            SqlDataReader drms2 = command2.ExecuteReader();
                            while (drms2.Read())
                            {
                                cmd.Parameters.Add("@id_pais", SqlDbType.Int).Value = drms2.GetInt32(0);
                            }
                            drms2.Close();

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Alterações salvas com sucesso.", "PARQUE TEIXEIRA SOARES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("O nome não pode ficar em branco", "PARQUE TEIXEIRA SOARES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }

            }

            private void comboPaís_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection sql = new SqlConnection("Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = parque; Data Source = Tati\\SQLEXPRESS"))
            {
                SqlCommand cmd = new SqlCommand("select estado.uf from estado inner join pais on estado.pais=pais.id where pais.nome_pt=@pais", sql);
                cmd.Parameters.Add("@pais", SqlDbType.VarChar).Value = comboPaís.Text;
                try
                {
                    sql.Open();
                    SqlDataReader drms = cmd.ExecuteReader();

                    comboUF.Items.Clear();

                    while (drms.Read())
                    {
                        string estado = drms.GetString(0);
                        comboUF.Items.Add(estado);
                    }
                    drms.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            }

            private void comboUF_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection sql = new SqlConnection("Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = parque; Data Source = Tati\\SQLEXPRESS"))
            {
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
                        string cidade = drms.GetString(0);
                        comboBoxCidade.Items.Add(cidade);
                    }
                    drms.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            }
        }
}
