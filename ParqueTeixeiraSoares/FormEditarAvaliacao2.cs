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
using static Teste.FormAvaliacao1;

namespace Teste
{
    public partial class FormEditarAvaliacao2 : Form
    {
        FormEditarAvaliacao1 f1;
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
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Text == f1.salaExpo)
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
        public FormEditarAvaliacao2(ParametrosFormulario parametros, FormEditarAvaliacao1 fa1)
        {
            InitializeComponent();

            this.parametros = parametros;

            f1 = fa1;
            FillForm();
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

            FormEditarAvaliacao3 avaliacao3 = new FormEditarAvaliacao3(parametros, this, f1);
            avaliacao3.Show();
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

        private void checkBox37_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox37.Checked)
            {
                foreach (Control control in groupBox14.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox37)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox38_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox38.Checked)
            {
                foreach (Control control in groupBox14.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox38)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox40_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox40.Checked)
            {
                foreach (Control control in groupBox14.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox40)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox39_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox39.Checked)
            {
                foreach (Control control in groupBox14.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox39)
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
                foreach (Control control in groupBox10.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox9)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                foreach (Control control in groupBox10.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox12)
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
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox11)
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
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox10)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                foreach (Control control in groupBox7.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox5)
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
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox8)
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
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox7)
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
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox6)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked)
            {
                foreach (Control control in groupBox2.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox21)
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
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox24)
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
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox23)
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
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox22)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked) {
                foreach (Control control in groupBox3.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox13)
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
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox16)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked) {
                foreach (Control control in groupBox3.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox15)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
                if (checkBox14.Checked) {
                foreach (Control control in groupBox3.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox14)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked) {
                foreach (Control control in groupBox4.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox17)
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
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox20)
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

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox25.Checked)
            {
                foreach (Control control in groupBox11.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox25)
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
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox26)
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
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox27)
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
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox28)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox32.Checked)
            {
                foreach (Control control in groupBox12.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox32)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox31.Checked)
            {
                foreach (Control control in groupBox12.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox31)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox30.Checked)
            {
                foreach (Control control in groupBox12.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox30)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox29.Checked)
            {
                foreach (Control control in groupBox12.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox29)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox36.Checked)
            {
                foreach (Control control in groupBox13.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox36)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox33.Checked)
            {
                foreach (Control control in groupBox13.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox33)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox34.Checked)
            {
                foreach (Control control in groupBox13.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox34)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox35.Checked)
            {
                foreach (Control control in groupBox13.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked == true && checkBox != checkBox35)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }
    }
}
