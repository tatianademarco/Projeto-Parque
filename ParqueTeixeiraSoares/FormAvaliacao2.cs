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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static Teste.FormAvaliacao1;

namespace Teste
{
    public partial class FormAvaliacao2 : Form
    {
        FormAvaliacao1 f1;
        private ParametrosFormulario parametros;
        public string estacionamento { get; set; }
        public string centroVis { get; set; }
        public string atendimento { get; set; }
        public string tranquilidade { get; set; }
        public string condicoes { get; set; }
        public string conservacao { get; set; }
        public string guia { get; set; }
        public string fariaVoltar { get; set; }

        void FillForm()
        {
            foreach (Control control in groupBox14.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Text==f1.salaExpo)
                {
                    checkBox.Checked = true;
                    break;
                }
            }

            foreach (Control control in groupBox10.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Text == f1.video)
                {
                    checkBox.Checked = true;
                    break;
                }
            }

            foreach (Control control in groupBox7.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Text == f1.palestra)
                {
                    checkBox.Checked = true;
                    break;
                }

            }

            foreach (Control control in groupBox2.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Text == f1.trilhaPas)
                {
                    checkBox.Checked = true;
                    break;
                }
            }

            foreach (Control control in groupBox3.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Text == f1.caminhosGra)
                {
                    checkBox.Checked = true;
                    break;
                }
            }

            foreach (Control control in groupBox4.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Text == f1.refugioVale)
                {
                    checkBox.Checked = true;
                    break;
                }
            }

            foreach (Control control in groupBox11.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Text == f1.passadorMata)
                {
                    checkBox.Checked = true;
                    break;
                }
            }

            foreach (Control control in groupBox12.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Text == f1.passeioBel)
                {
                    checkBox.Checked = true;
                    break;
                }
            }

            foreach (Control control in groupBox13.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Text == f1.trilhoTei)
                {
                    checkBox.Checked = true;
                    break;
                }
            }
            estacionamento = f1.estacionamento;
            fariaVoltar = f1.fariaVoltar;
            guia = f1.guia;
            condicoes = f1.condicoes;
            conservacao = f1.conservacao;
            centroVis = f1.centroVis;
            atendimento = f1.atendimento;
            tranquilidade = f1.tranquilidade;
        }

        public FormAvaliacao2(ParametrosFormulario parametros, FormAvaliacao1 fa1)
        {
            InitializeComponent();

            this.parametros = parametros;

            f1 = fa1;
            FillForm();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (Control control in groupBox14.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
                {
                    parametros.salaExpo = control.Text;
                    break;
                }
                else
                {
                    parametros.salaExpo = "";
                }
            }

            foreach (Control control in groupBox10.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
                {
                    parametros.video = control.Text;
                    break;
                }
                else
                {
                    parametros.video = "";
                }
            }

            foreach (Control control in groupBox7.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
                {
                    parametros.palestra = control.Text;
                    break;
                }
                else
                {
                    parametros.palestra = "";
                }

            }

            foreach (Control control in groupBox2.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
                {
                    parametros.trilhaPas = control.Text;
                    break;
                }
                else
                {
                    parametros.trilhaPas = "";
                }
            }

            foreach (Control control in groupBox3.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
                {
                    parametros.caminhosGra = control.Text;
                    break;
                }
                else
                {
                    parametros.caminhosGra = "";
                }
            }

            foreach (Control control in groupBox4.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
                {
                    parametros.refugioVale = control.Text;
                    break;
                }
                else
                {
                    parametros.refugioVale = "";
                }
            }

            foreach (Control control in groupBox11.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
                {
                    parametros.passadorMata = control.Text;
                    break;
                }
                else
                {
                    parametros.passadorMata = "";
                }
            }

            foreach (Control control in groupBox12.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
                {
                    parametros.passeioBel = control.Text;
                    break;
                }
                else
                {
                    parametros.passeioBel = "";
                }
            }

            foreach (Control control in groupBox13.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
                {
                    parametros.trilhoTei = control.Text;
                    break;
                }
                else
                {
                    parametros.trilhoTei = "";
                }
            }

            FormAvaliacao3 avaliacao3 = new FormAvaliacao3(parametros, this, f1);
            avaliacao3.Show();
        }

        private void checkBox37_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox37.Checked)
            {
                checkBox38.Checked = false;
                checkBox39.Checked = false;
                checkBox40.Checked = false;
            }
        }

        private void checkBox38_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox38.Checked)
            {
                checkBox37.Checked = false;
                checkBox39.Checked = false;
                checkBox40.Checked = false;
            }
        }

        private void checkBox40_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox40.Checked)
            {
                checkBox38.Checked = false;
                checkBox39.Checked = false;
                checkBox37.Checked = false;
            }
        }

        private void checkBox39_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox39.Checked)
            {
                checkBox38.Checked = false;
                checkBox37.Checked = false;
                checkBox40.Checked = false;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox9.Checked = false;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                checkBox10.Checked = false;
                checkBox9.Checked = false;
                checkBox12.Checked = false;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                checkBox9.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox5.Checked = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                checkBox6.Checked = false;
                checkBox5.Checked = false;
                checkBox8.Checked = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                checkBox5.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked)
            {
                checkBox22.Checked = false;
                checkBox23.Checked = false;
                checkBox24.Checked = false;
            }
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox24.Checked)
            {
                checkBox22.Checked = false;
                checkBox23.Checked = false;
                checkBox21.Checked = false;
            }
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox23.Checked)
            {
                checkBox22.Checked = false;
                checkBox21.Checked = false;
                checkBox24.Checked = false;
            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox22.Checked)
            {
                checkBox21.Checked = false;
                checkBox23.Checked = false;
                checkBox24.Checked = false;
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
            {
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox13.Checked = false;
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {
                checkBox14.Checked = false;
                checkBox13.Checked = false;
                checkBox16.Checked = false;
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
            {
                checkBox13.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked)
            {
                checkBox18.Checked = false;
                checkBox19.Checked = false;
                checkBox20.Checked = false;
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked)
            {
                checkBox18.Checked = false;
                checkBox19.Checked = false;
                checkBox17.Checked = false;
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked)
            {
                checkBox18.Checked = false;
                checkBox17.Checked = false;
                checkBox20.Checked = false;
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked)
            {
                checkBox17.Checked = false;
                checkBox19.Checked = false;
                checkBox20.Checked = false;
            }
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox25.Checked)
            {
                checkBox26.Checked = false;
                checkBox27.Checked = false;
                checkBox28.Checked = false;
            }
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox26.Checked)
            {
                checkBox25.Checked = false;
                checkBox27.Checked = false;
                checkBox28.Checked = false;
            }
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox27.Checked)
            {
                checkBox26.Checked = false;
                checkBox25.Checked = false;
                checkBox28.Checked = false;
            }
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox28.Checked)
            {
                checkBox26.Checked = false;
                checkBox27.Checked = false;
                checkBox25.Checked = false;
            }
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox32.Checked)
            {
                checkBox29.Checked = false;
                checkBox30.Checked = false;
                checkBox31.Checked = false;
            }
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox31.Checked)
            {
                checkBox29.Checked = false;
                checkBox30.Checked = false;
                checkBox32.Checked = false;
            }
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox30.Checked)
            {
                checkBox29.Checked = false;
                checkBox32.Checked = false;
                checkBox31.Checked = false;
            }
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox29.Checked)
            {
                checkBox32.Checked = false;
                checkBox30.Checked = false;
                checkBox31.Checked = false;
            }
        }

        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox36.Checked)
            {
                checkBox33.Checked = false;
                checkBox34.Checked = false;
                checkBox35.Checked = false;
            }
        }

        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox33.Checked)
            {
                checkBox36.Checked = false;
                checkBox34.Checked = false;
                checkBox35.Checked = false;
            }
        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox34.Checked)
            {
                checkBox33.Checked = false;
                checkBox36.Checked = false;
                checkBox35.Checked = false;
            }
        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox35.Checked)
            {
                checkBox33.Checked = false;
                checkBox34.Checked = false;
                checkBox36.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupBox14.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
                {
                    f1.salaExpo = control.Text;
                    break;
                }
                else
                {
                    f1.salaExpo = "";
                }
            }
            foreach (Control control in groupBox10.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
                {
                    f1.video = control.Text;
                    break;
                }
                else
                {
                    f1.video = "";
                }
            }

            foreach (Control control in groupBox7.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
                {
                    f1.palestra = control.Text;
                    break;
                }
                else
                {
                    f1.palestra = "";
                }

            }

            foreach (Control control in groupBox2.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
                {
                    f1.trilhaPas = control.Text;
                    break;
                }
                else
                {
                    f1.trilhaPas = "";
                }
            }

            foreach (Control control in groupBox3.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
                {
                    f1.caminhosGra = control.Text;
                    break;
                }
                else
                {
                    f1.caminhosGra = "";
                }
            }

            foreach (Control control in groupBox4.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
                {
                    f1.refugioVale = control.Text;
                    break;
                }
                else
                {
                    f1.refugioVale = "";
                }
            }

            foreach (Control control in groupBox11.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
                {
                    f1.passadorMata = control.Text;
                    break;
                }
                else
                {
                    f1.passadorMata = "";
                }
            }

            foreach (Control control in groupBox12.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
                {
                    f1.passeioBel = control.Text;
                    break;
                }
                else
                {
                    f1.passeioBel = "";
                }
            }

            foreach (Control control in groupBox13.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
                {
                    f1.trilhoTei = control.Text;
                    break;
                }
                else
                {
                    f1.trilhoTei = "";
                }
            }

            f1.estacionamento = estacionamento;
            f1.fariaVoltar = fariaVoltar;
            f1.guia = guia;
            f1.condicoes = condicoes;
            f1.conservacao = conservacao;
            f1.centroVis = centroVis;
            f1.atendimento = atendimento;
            f1.tranquilidade = tranquilidade;

            this.Close();
        }
    }
}
