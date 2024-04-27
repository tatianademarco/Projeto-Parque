namespace Teste
{
    partial class FormFormulárioVisitas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dateTimeVisita = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBoxTurno = new ComboBox();
            textBoxResponsavel = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            numericPessoas = new NumericUpDown();
            textTransporte = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            comboNecessidades = new ComboBox();
            comboAgendou = new ComboBox();
            comboPaís = new ComboBox();
            comboUF = new ComboBox();
            comboBoxCidade = new ComboBox();
            textPerfil = new TextBox();
            textObjetivo = new TextBox();
            textConheceram = new TextBox();
            label13 = new Label();
            label14 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericPessoas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(274, 9);
            label1.Name = "label1";
            label1.Size = new Size(235, 28);
            label1.TabIndex = 0;
            label1.Text = "Formulário de Visitações";
            // 
            // dateTimeVisita
            // 
            dateTimeVisita.Location = new Point(69, 78);
            dateTimeVisita.Name = "dateTimeVisita";
            dateTimeVisita.Size = new Size(292, 27);
            dateTimeVisita.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 55);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 2;
            label2.Text = "Data:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(500, 55);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 3;
            label3.Text = "Turno:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 138);
            label4.Name = "label4";
            label4.Size = new Size(172, 20);
            label4.TabIndex = 4;
            label4.Text = "Responsável pelo grupo:";
            // 
            // comboBoxTurno
            // 
            comboBoxTurno.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxTurno.FormattingEnabled = true;
            comboBoxTurno.Items.AddRange(new object[] { "Manhã", "Tarde" });
            comboBoxTurno.Location = new Point(500, 78);
            comboBoxTurno.Name = "comboBoxTurno";
            comboBoxTurno.Size = new Size(151, 28);
            comboBoxTurno.TabIndex = 5;
            // 
            // textBoxResponsavel
            // 
            textBoxResponsavel.AutoCompleteCustomSource.AddRange(new string[] { "Quinto Rancho" });
            textBoxResponsavel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxResponsavel.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxResponsavel.Location = new Point(69, 161);
            textBoxResponsavel.Name = "textBoxResponsavel";
            textBoxResponsavel.Size = new Size(292, 27);
            textBoxResponsavel.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(500, 138);
            label5.Name = "label5";
            label5.Size = new Size(167, 20);
            label5.TabIndex = 7;
            label5.Text = "Quantidade de pessoas:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 306);
            label6.Name = "label6";
            label6.Size = new Size(139, 20);
            label6.TabIndex = 8;
            label6.Text = "Meio de transporte:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(72, 222);
            label7.Name = "label7";
            label7.Size = new Size(166, 20);
            label7.TabIndex = 9;
            label7.Text = "Necessidades especiais:";
            // 
            // numericPessoas
            // 
            numericPessoas.Location = new Point(500, 161);
            numericPessoas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericPessoas.Name = "numericPessoas";
            numericPessoas.Size = new Size(59, 27);
            numericPessoas.TabIndex = 10;
            numericPessoas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textTransporte
            // 
            textTransporte.AutoCompleteCustomSource.AddRange(new string[] { "Carro", "Jerico", "Moto", "Ônibus", "Van" });
            textTransporte.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textTransporte.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textTransporte.Location = new Point(69, 329);
            textTransporte.Name = "textTransporte";
            textTransporte.Size = new Size(292, 27);
            textTransporte.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(501, 306);
            label8.Name = "label8";
            label8.Size = new Size(111, 20);
            label8.TabIndex = 14;
            label8.Text = "Perfil do grupo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(503, 222);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 15;
            label9.Text = "Agendou:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(69, 463);
            label10.Name = "label10";
            label10.Size = new Size(37, 20);
            label10.TabIndex = 19;
            label10.Text = "País:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(500, 463);
            label11.Name = "label11";
            label11.Size = new Size(29, 20);
            label11.TabIndex = 20;
            label11.Text = "UF:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(588, 463);
            label12.Name = "label12";
            label12.Size = new Size(59, 20);
            label12.TabIndex = 21;
            label12.Text = "Cidade:";
            // 
            // comboNecessidades
            // 
            comboNecessidades.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboNecessidades.FormattingEnabled = true;
            comboNecessidades.Items.AddRange(new object[] { "SIM", "NÃO" });
            comboNecessidades.Location = new Point(69, 245);
            comboNecessidades.Name = "comboNecessidades";
            comboNecessidades.Size = new Size(151, 28);
            comboNecessidades.TabIndex = 22;
            // 
            // comboAgendou
            // 
            comboAgendou.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboAgendou.FormattingEnabled = true;
            comboAgendou.Items.AddRange(new object[] { "SIM", "NÃO" });
            comboAgendou.Location = new Point(500, 245);
            comboAgendou.Name = "comboAgendou";
            comboAgendou.Size = new Size(151, 28);
            comboAgendou.TabIndex = 23;
            // 
            // comboPaís
            // 
            comboPaís.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboPaís.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboPaís.FormattingEnabled = true;
            comboPaís.Location = new Point(69, 486);
            comboPaís.Name = "comboPaís";
            comboPaís.Size = new Size(151, 28);
            comboPaís.TabIndex = 24;
            comboPaís.SelectedIndexChanged += comboPaís_SelectedIndexChanged;
            // 
            // comboUF
            // 
            comboUF.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboUF.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboUF.FormattingEnabled = true;
            comboUF.Location = new Point(500, 486);
            comboUF.Name = "comboUF";
            comboUF.Size = new Size(59, 28);
            comboUF.TabIndex = 25;
            comboUF.SelectedIndexChanged += comboUF_SelectedIndexChanged;
            // 
            // comboBoxCidade
            // 
            comboBoxCidade.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxCidade.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxCidade.FormattingEnabled = true;
            comboBoxCidade.Location = new Point(588, 486);
            comboBoxCidade.Name = "comboBoxCidade";
            comboBoxCidade.Size = new Size(204, 28);
            comboBoxCidade.TabIndex = 26;
            comboBoxCidade.SelectedIndexChanged += comboBoxCidade_SelectedIndexChanged;
            // 
            // textPerfil
            // 
            textPerfil.AutoCompleteCustomSource.AddRange(new string[] { "Família", "Adultos", "Crianças" });
            textPerfil.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textPerfil.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textPerfil.Location = new Point(500, 329);
            textPerfil.Name = "textPerfil";
            textPerfil.Size = new Size(292, 27);
            textPerfil.TabIndex = 27;
            // 
            // textObjetivo
            // 
            textObjetivo.AutoCompleteCustomSource.AddRange(new string[] { "Conhecer", "Lazer", "Contato com a natureza" });
            textObjetivo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textObjetivo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textObjetivo.Location = new Point(69, 411);
            textObjetivo.Name = "textObjetivo";
            textObjetivo.Size = new Size(292, 27);
            textObjetivo.TabIndex = 28;
            // 
            // textConheceram
            // 
            textConheceram.AutoCompleteCustomSource.AddRange(new string[] { "Internet", "Boca a boca", "Quinto Rancho" });
            textConheceram.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textConheceram.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textConheceram.Location = new Point(500, 411);
            textConheceram.Name = "textConheceram";
            textConheceram.Size = new Size(292, 27);
            textConheceram.TabIndex = 29;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(67, 388);
            label13.Name = "label13";
            label13.Size = new Size(128, 20);
            label13.TabIndex = 30;
            label13.Text = "Objetivo da visita:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(498, 388);
            label14.Name = "label14";
            label14.Size = new Size(195, 20);
            label14.TabIndex = 31;
            label14.Text = "Como souberam do parque:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(342, 547);
            button1.Name = "button1";
            button1.Size = new Size(120, 50);
            button1.TabIndex = 32;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormFormulárioVisitas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 621);
            Controls.Add(button1);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(textConheceram);
            Controls.Add(textObjetivo);
            Controls.Add(textPerfil);
            Controls.Add(comboBoxCidade);
            Controls.Add(comboUF);
            Controls.Add(comboPaís);
            Controls.Add(comboAgendou);
            Controls.Add(comboNecessidades);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textTransporte);
            Controls.Add(numericPessoas);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxResponsavel);
            Controls.Add(comboBoxTurno);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimeVisita);
            Controls.Add(label1);
            Name = "FormFormulárioVisitas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormFormulárioVisitas";
            ((System.ComponentModel.ISupportInitialize)numericPessoas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimeVisita;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxTurno;
        private TextBox textBoxResponsavel;
        private Label label5;
        private Label label6;
        private Label label7;
        private NumericUpDown numericPessoas;
        private TextBox textTransporte;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private ComboBox comboNecessidades;
        private ComboBox comboAgendou;
        private ComboBox comboPaís;
        private ComboBox comboUF;
        private ComboBox comboBoxCidade;
        private TextBox textPerfil;
        private TextBox textObjetivo;
        private TextBox textConheceram;
        private Label label13;
        private Label label14;
        private Button button1;
    }
}