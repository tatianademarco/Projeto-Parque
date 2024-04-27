namespace Teste
{
    partial class FormEditarVisitacao
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
            comboBoxMonitor = new ComboBox();
            label10 = new Label();
            SIMAcompanhado = new CheckBox();
            checkBox1 = new CheckBox();
            label11 = new Label();
            label5 = new Label();
            comboBoxResponsavel = new ComboBox();
            label4 = new Label();
            button2 = new Button();
            checkBox2NÃO = new CheckBox();
            checkBox2SIM = new CheckBox();
            checkBox1Não = new CheckBox();
            checkBox1SIM = new CheckBox();
            label13 = new Label();
            textObjetivo = new TextBox();
            textPerfil = new TextBox();
            label9 = new Label();
            label8 = new Label();
            textTransporte = new TextBox();
            label7 = new Label();
            label6 = new Label();
            comboBoxTurno = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            dateTimeVisita = new DateTimePicker();
            groupBox1 = new GroupBox();
            button1 = new Button();
            listBoxVisiantes = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(302, 9);
            label1.Name = "label1";
            label1.Size = new Size(149, 28);
            label1.TabIndex = 63;
            label1.Text = "Editar Visitação";
            // 
            // comboBoxMonitor
            // 
            comboBoxMonitor.FormattingEnabled = true;
            comboBoxMonitor.Location = new Point(468, 567);
            comboBoxMonitor.Name = "comboBoxMonitor";
            comboBoxMonitor.Size = new Size(292, 28);
            comboBoxMonitor.TabIndex = 97;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(37, 545);
            label10.Name = "label10";
            label10.Size = new Size(136, 20);
            label10.TabIndex = 93;
            label10.Text = "Foi acompanhado?";
            // 
            // SIMAcompanhado
            // 
            SIMAcompanhado.AutoSize = true;
            SIMAcompanhado.Location = new Point(37, 568);
            SIMAcompanhado.Name = "SIMAcompanhado";
            SIMAcompanhado.Size = new Size(56, 24);
            SIMAcompanhado.TabIndex = 94;
            SIMAcompanhado.Text = "SIM";
            SIMAcompanhado.UseVisualStyleBackColor = true;
            SIMAcompanhado.CheckedChanged += SIMAcompanhado_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(143, 569);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(63, 24);
            checkBox1.TabIndex = 95;
            checkBox1.Text = "NÃO";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(466, 545);
            label11.Name = "label11";
            label11.Size = new Size(147, 20);
            label11.TabIndex = 96;
            label11.Text = "Quem acompanhou?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 145);
            label5.Name = "label5";
            label5.Size = new Size(139, 20);
            label5.TabIndex = 91;
            label5.Text = "Grupo de visitantes:";
            // 
            // comboBoxResponsavel
            // 
            comboBoxResponsavel.FormattingEnabled = true;
            comboBoxResponsavel.Location = new Point(37, 374);
            comboBoxResponsavel.Name = "comboBoxResponsavel";
            comboBoxResponsavel.Size = new Size(292, 28);
            comboBoxResponsavel.TabIndex = 90;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 351);
            label4.Name = "label4";
            label4.Size = new Size(172, 20);
            label4.TabIndex = 89;
            label4.Text = "Responsável pelo grupo:";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(324, 708);
            button2.Name = "button2";
            button2.Size = new Size(120, 50);
            button2.TabIndex = 88;
            button2.Text = "Salvar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox2NÃO
            // 
            checkBox2NÃO.AutoSize = true;
            checkBox2NÃO.Location = new Point(578, 659);
            checkBox2NÃO.Name = "checkBox2NÃO";
            checkBox2NÃO.Size = new Size(63, 24);
            checkBox2NÃO.TabIndex = 87;
            checkBox2NÃO.Text = "NÃO";
            checkBox2NÃO.UseVisualStyleBackColor = true;
            checkBox2NÃO.CheckedChanged += checkBox2NÃO_CheckedChanged;
            // 
            // checkBox2SIM
            // 
            checkBox2SIM.AutoSize = true;
            checkBox2SIM.Location = new Point(468, 659);
            checkBox2SIM.Name = "checkBox2SIM";
            checkBox2SIM.Size = new Size(56, 24);
            checkBox2SIM.TabIndex = 86;
            checkBox2SIM.Text = "SIM";
            checkBox2SIM.UseVisualStyleBackColor = true;
            checkBox2SIM.CheckedChanged += checkBox2SIM_CheckedChanged;
            // 
            // checkBox1Não
            // 
            checkBox1Não.AutoSize = true;
            checkBox1Não.Location = new Point(143, 659);
            checkBox1Não.Name = "checkBox1Não";
            checkBox1Não.Size = new Size(63, 24);
            checkBox1Não.TabIndex = 85;
            checkBox1Não.Text = "NÃO";
            checkBox1Não.UseVisualStyleBackColor = true;
            checkBox1Não.CheckedChanged += checkBox1Não_CheckedChanged;
            // 
            // checkBox1SIM
            // 
            checkBox1SIM.AutoSize = true;
            checkBox1SIM.Location = new Point(37, 659);
            checkBox1SIM.Name = "checkBox1SIM";
            checkBox1SIM.Size = new Size(56, 24);
            checkBox1SIM.TabIndex = 84;
            checkBox1SIM.Text = "SIM";
            checkBox1SIM.UseVisualStyleBackColor = true;
            checkBox1SIM.CheckedChanged += checkBox1SIM_CheckedChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(468, 443);
            label13.Name = "label13";
            label13.Size = new Size(128, 20);
            label13.TabIndex = 83;
            label13.Text = "Objetivo da visita:";
            // 
            // textObjetivo
            // 
            textObjetivo.AutoCompleteCustomSource.AddRange(new string[] { "Conhecer", "Lazer", "Contato com a natureza" });
            textObjetivo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textObjetivo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textObjetivo.Location = new Point(468, 466);
            textObjetivo.Name = "textObjetivo";
            textObjetivo.Size = new Size(292, 27);
            textObjetivo.TabIndex = 82;
            // 
            // textPerfil
            // 
            textPerfil.AutoCompleteCustomSource.AddRange(new string[] { "Família", "Adultos", "Crianças" });
            textPerfil.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textPerfil.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textPerfil.Location = new Point(468, 374);
            textPerfil.Name = "textPerfil";
            textPerfil.Size = new Size(292, 27);
            textPerfil.TabIndex = 81;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(468, 634);
            label9.Name = "label9";
            label9.Size = new Size(108, 20);
            label9.TabIndex = 80;
            label9.Text = "Foi agendado?";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(468, 351);
            label8.Name = "label8";
            label8.Size = new Size(111, 20);
            label8.TabIndex = 79;
            label8.Text = "Perfil do grupo:";
            // 
            // textTransporte
            // 
            textTransporte.AutoCompleteCustomSource.AddRange(new string[] { "Carro", "Jerico", "Moto", "Ônibus", "Van" });
            textTransporte.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textTransporte.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textTransporte.Location = new Point(37, 466);
            textTransporte.Name = "textTransporte";
            textTransporte.Size = new Size(292, 27);
            textTransporte.TabIndex = 78;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 632);
            label7.Name = "label7";
            label7.Size = new Size(166, 20);
            label7.TabIndex = 77;
            label7.Text = "Necessidades especiais:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 443);
            label6.Name = "label6";
            label6.Size = new Size(139, 20);
            label6.TabIndex = 76;
            label6.Text = "Meio de transporte:";
            // 
            // comboBoxTurno
            // 
            comboBoxTurno.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxTurno.FormattingEnabled = true;
            comboBoxTurno.Items.AddRange(new object[] { "Manhã", "Tarde" });
            comboBoxTurno.Location = new Point(468, 79);
            comboBoxTurno.Name = "comboBoxTurno";
            comboBoxTurno.Size = new Size(292, 28);
            comboBoxTurno.TabIndex = 75;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(468, 56);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 74;
            label3.Text = "Turno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 56);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 73;
            label2.Text = "Data:";
            // 
            // dateTimeVisita
            // 
            dateTimeVisita.Location = new Point(37, 79);
            dateTimeVisita.Name = "dateTimeVisita";
            dateTimeVisita.Size = new Size(292, 27);
            dateTimeVisita.TabIndex = 72;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(listBoxVisiantes);
            groupBox1.Location = new Point(24, 125);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(746, 203);
            groupBox1.TabIndex = 92;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(528, 35);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 56;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBoxVisiantes
            // 
            listBoxVisiantes.FormattingEnabled = true;
            listBoxVisiantes.ItemHeight = 20;
            listBoxVisiantes.Location = new Point(201, 35);
            listBoxVisiantes.Name = "listBoxVisiantes";
            listBoxVisiantes.ScrollAlwaysVisible = true;
            listBoxVisiantes.Size = new Size(282, 144);
            listBoxVisiantes.TabIndex = 60;
            // 
            // FormEditarVisitacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 771);
            Controls.Add(comboBoxMonitor);
            Controls.Add(label10);
            Controls.Add(SIMAcompanhado);
            Controls.Add(checkBox1);
            Controls.Add(label11);
            Controls.Add(label5);
            Controls.Add(comboBoxResponsavel);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(checkBox2NÃO);
            Controls.Add(checkBox2SIM);
            Controls.Add(checkBox1Não);
            Controls.Add(checkBox1SIM);
            Controls.Add(label13);
            Controls.Add(textObjetivo);
            Controls.Add(textPerfil);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textTransporte);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBoxTurno);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimeVisita);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FormEditarVisitacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEditarVisitacao";
            FormClosed += FormEditarVisitacao_FormClosed;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox comboBoxMonitor;
        private Label label10;
        private CheckBox SIMAcompanhado;
        private CheckBox checkBox1;
        private Label label11;
        private Label label5;
        public ComboBox comboBoxResponsavel;
        private Label label4;
        private Button button2;
        private CheckBox checkBox2NÃO;
        private CheckBox checkBox2SIM;
        private CheckBox checkBox1Não;
        private CheckBox checkBox1SIM;
        private Label label13;
        private TextBox textObjetivo;
        private TextBox textPerfil;
        private Label label9;
        private Label label8;
        private TextBox textTransporte;
        private Label label7;
        private Label label6;
        private ComboBox comboBoxTurno;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimeVisita;
        private GroupBox groupBox1;
        private Button button1;
        public ListBox listBoxVisiantes;
    }
}