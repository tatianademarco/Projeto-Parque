using Microsoft.Reporting.WinForms;
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
    public partial class FormRelatorioCidades : Form
    {
        private DataTable ObterDados()
        {
            string connectionString = "Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = parque; Data Source = Tati\\SQLEXPRESS"; // Substitua pela sua própria string de conexão
            string query = "SELECT cidade.nome, estado.uf, pais.nome_pt, COUNT(cidade.id) AS quantidade\r\nFROM     cidade INNER JOIN\r\n                  estado ON cidade.uf = estado.id INNER JOIN\r\n                  visitante ON visitante.id_cidade = cidade.id INNER JOIN\r\n                  pais ON pais.id = visitante.id_pais\r\nGROUP BY cidade.nome, estado.uf, pais.nome_pt";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public FormRelatorioCidades()
        {
            DataTable dataTable = ObterDados();
            InitializeComponent();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Teste.Report2.rdlc";

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dataTable));

            reportViewer1.RefreshReport();
        }
    }
}
