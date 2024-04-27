using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Usuarios f_Usuarios = new F_Usuarios();
            f_Usuarios.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVisitante formVisitante = new FormVisitante();
            formVisitante.Show();
        }

        private void pesquisarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 usu = new Form3();
            usu.Show();
        }

        private void meuPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMeuPerfil formMeuPerfil = new FormMeuPerfil();
            formMeuPerfil.Show();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGerenciarVisitantes gerenciarVisitantes = new FormGerenciarVisitantes();
            gerenciarVisitantes.Show();
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormVisitacao formVisitacao = new FormVisitacao();
            formVisitacao.Show();
        }

        private void visitaçõesCadastradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTodasVisitacoes visit = new FormTodasVisitacoes();
            visit.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAvaliacao1 avaliacao1 = new FormAvaliacao1();
            avaliacao1.Show();
        }

        private void visualizarAvaliaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTodasAvaliacoes todasAvaliacoes = new FormTodasAvaliacoes();
            todasAvaliacoes.Show();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormGuia formGuia = new FormGuia();
            formGuia.Show();
        }

        private void monitoresCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTodosMonitores mon = new FormTodosMonitores();
            mon.Show();
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorioCidades formRelatorio = new FormRelatorioCidades();
            formRelatorio.Show();
        }

        private void relatórioVisitaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatórioVisitas formRelatorio = new FormRelatórioVisitas();
            formRelatorio.Show();
        }
    }
}
