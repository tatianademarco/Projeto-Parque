using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class FormRelatórioVisitas : Form
    {
        int? mes = null;
        int? ano = null;
        private DataTable ObterDados()
        {
            string connectionString = "Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = parque; Data Source = Tati\\SQLEXPRESS";
            string query = "SELECT visita.data_visita, visita.turno, monitor.nome, visita.agendado, STRING_AGG(visitante.nome_vis, ', ') AS Visitantes " +
                "FROM visita INNER JOIN visitacao ON visita.id_visita = visitacao.id_visita INNER JOIN " +
                "visitante ON visitante.id_visitante = visitacao.id_visitante INNER JOIN monitor ON monitor.id_monitor = visita.id_monitor " +
                "WHERE  (@Mes IS NULL) AND (@Ano IS NULL) OR (@Mes IS NULL) AND (YEAR(visita.data_visita) = @Ano) OR (@Ano IS NULL) AND (MONTH(visita.data_visita) = @Mes)" +
                "OR (YEAR(visita.data_visita) = @Ano) AND (MONTH(visita.data_visita) = @Mes) " +
                "GROUP BY visita.data_visita, visita.turno, monitor.nome, visita.agendado";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@Ano", SqlDbType.Int).Value = ano.HasValue ? (object)ano.Value : DBNull.Value;
                    command.Parameters.Add("@Mes", SqlDbType.Int).Value = mes.HasValue ? (object)mes.Value : DBNull.Value;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }
        public FormRelatórioVisitas()
        {
            DataTable dataTable = ObterDados();
            InitializeComponent();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Teste.Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dataTable));
            reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox3.Text))
            {
                mes = comboBox3.SelectedIndex;
            }

            if (!string.IsNullOrEmpty(comboBox4.Text))
            {
                ano = int.Parse(comboBox4.Text);
            }
            DataTable dataTable = ObterDados();

            reportViewer1.LocalReport.ReportEmbeddedResource = "Teste.Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dataTable));
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { });
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Mes", mes?.ToString()));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Ano", ano?.ToString()));
            reportViewer1.RefreshReport();
        }
    }
}
