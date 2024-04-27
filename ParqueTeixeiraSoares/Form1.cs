using System.Data.SqlClient;
using System.Data;

namespace Teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=parque;Data Source=Tati\\SQLEXPRESS";

            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM usuario WHERE nome_user = @nome_user AND senha_user = @senha_user";

                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    cmd.Parameters.Add("@nome_user", SqlDbType.VarChar).Value = txtLoginNome.Text;
                    cmd.Parameters.Add("@senha_user", SqlDbType.VarChar).Value = txtLoginSenha.Text;

                    try
                    {
                        sql.Open();

                        using (SqlDataReader drms = cmd.ExecuteReader())
                        {
                            if (drms.HasRows == false)
                            {
                                throw new Exception("Usuário ou senha inválido");
                            }

                            drms.Read();

                            Form2 principal = new Form2();
                            principal.Show();
                            this.Visible = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }


        }
    }
}