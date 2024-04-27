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
    public partial class FormAdicionarVisitantes : Form
    {
        FormVisitacao fv;
        void FillListBox()
        {
            string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=parque;Data Source=Tati\\SQLEXPRESS";

            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM visitante";

                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    try
                    {
                        sql.Open();

                        using (SqlDataReader drms = cmd.ExecuteReader())
                        {
                            while (drms.Read())
                            {
                                string nameV = drms.GetString(drms.GetOrdinal("nome_vis"));
                                listBoxVis.Items.Add(nameV);
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

        public FormAdicionarVisitantes(ListBox l, FormVisitacao fvis)
        {
            InitializeComponent();
            FillListBox();

            foreach (var item in l.Items)
            {
                listBoxAdicionados.Items.Add(item);
            }

            fv = fvis;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormVisitante formVisitante = new FormVisitante();
            formVisitante.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxAdicionados.Items.Add(listBoxVis.Items[listBoxVis.SelectedIndex].ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBoxAdicionados.SelectedIndex >= 0)
            {
                listBoxAdicionados.Items.RemoveAt(listBoxAdicionados.SelectedIndex);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=parque;Data Source=Tati\\SQLEXPRESS";

            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                string query = "SELECT nome_vis FROM visitante WHERE UPPER(nome_vis) LIKE @pesquisa";

                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    cmd.Parameters.Add("@pesquisa", SqlDbType.VarChar).Value = textBoxPesquisa.Text + '%';

                    listBoxVis.Items.Clear();

                    try
                    {
                        sql.Open();

                        using (SqlDataReader drms = cmd.ExecuteReader())
                        {
                            if (drms.HasRows == false)
                            {
                                listBoxVis.Items.Add("Nenhum visitante encontrado.");
                            }
                            else
                            {
                                while (drms.Read())
                                {
                                    string resultadosVis = drms.GetString(drms.GetOrdinal("nome_vis"));
                                    listBoxVis.Items.Add(resultadosVis);
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

            fv.listBoxVisiantes.Items.Clear();
            fv.comboBoxResponsavel.Items.Clear();

            foreach (var item in listBoxAdicionados.Items) {
                fv.listBoxVisiantes.Items.Add(item);
                fv.comboBoxResponsavel.Items.Add(item);
            }
        }
    }
}
