namespace Teste
{
    partial class FormVisitante
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
            label2 = new Label();
            button6 = new Button();
            button1 = new Button();
            label4 = new Label();
            txtNomeVis = new TextBox();
            label3 = new Label();
            label1 = new Label();
            textBoxEmail = new TextBox();
            label5 = new Label();
            textBoxComoSoube = new TextBox();
            label6 = new Label();
            comboBoxCidade = new ComboBox();
            comboUF = new ComboBox();
            comboPaís = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            maskedTextBoxTel = new MaskedTextBox();
            maskedTextBoxNasc = new MaskedTextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(238, 3);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(286, 41);
            label2.TabIndex = 35;
            label2.Text = "Cadastrar Visitante";
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(437, 387);
            button6.Margin = new Padding(5, 4, 5, 4);
            button6.Name = "button6";
            button6.Size = new Size(150, 51);
            button6.TabIndex = 34;
            button6.Text = "Sair";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(203, 387);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(150, 51);
            button1.TabIndex = 33;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(491, 65);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(167, 23);
            label4.TabIndex = 31;
            label4.Text = "Data de nascimento:";
            // 
            // txtNomeVis
            // 
            txtNomeVis.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeVis.Location = new Point(80, 92);
            txtNomeVis.Margin = new Padding(5, 4, 5, 4);
            txtNomeVis.Name = "txtNomeVis";
            txtNomeVis.Size = new Size(319, 30);
            txtNomeVis.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(491, 140);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 23);
            label3.TabIndex = 28;
            label3.Text = "Telefone:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(80, 65);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 23);
            label1.TabIndex = 27;
            label1.Text = "Nome:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(80, 168);
            textBoxEmail.Margin = new Padding(5, 4, 5, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(319, 30);
            textBoxEmail.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(80, 141);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 37;
            label5.Text = "E-mail:";
            // 
            // textBoxComoSoube
            // 
            textBoxComoSoube.AutoCompleteCustomSource.AddRange(new string[] { "Internet", "Boca a boca", "Quinto Rancho" });
            textBoxComoSoube.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxComoSoube.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxComoSoube.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxComoSoube.Location = new Point(80, 247);
            textBoxComoSoube.Margin = new Padding(5, 4, 5, 4);
            textBoxComoSoube.Name = "textBoxComoSoube";
            textBoxComoSoube.Size = new Size(319, 30);
            textBoxComoSoube.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(80, 220);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(195, 23);
            label6.TabIndex = 39;
            label6.Text = "Como soube do parque:";
            // 
            // comboBoxCidade
            // 
            comboBoxCidade.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxCidade.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxCidade.FormattingEnabled = true;
            comboBoxCidade.Location = new Point(491, 329);
            comboBoxCidade.Name = "comboBoxCidade";
            comboBoxCidade.Size = new Size(190, 28);
            comboBoxCidade.TabIndex = 46;
            // 
            // comboUF
            // 
            comboUF.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboUF.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboUF.FormattingEnabled = true;
            comboUF.Location = new Point(341, 329);
            comboUF.Name = "comboUF";
            comboUF.Size = new Size(59, 28);
            comboUF.TabIndex = 45;
            comboUF.SelectedIndexChanged += comboUF_SelectedIndexChanged;
            // 
            // comboPaís
            // 
            comboPaís.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboPaís.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboPaís.FormattingEnabled = true;
            comboPaís.Location = new Point(80, 329);
            comboPaís.Name = "comboPaís";
            comboPaís.Size = new Size(151, 28);
            comboPaís.TabIndex = 44;
            comboPaís.SelectedIndexChanged += comboPaís_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(491, 307);
            label12.Name = "label12";
            label12.Size = new Size(67, 23);
            label12.TabIndex = 43;
            label12.Text = "Cidade:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(341, 307);
            label11.Name = "label11";
            label11.Size = new Size(35, 23);
            label11.TabIndex = 42;
            label11.Text = "UF:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(80, 303);
            label10.Name = "label10";
            label10.Size = new Size(44, 23);
            label10.TabIndex = 41;
            label10.Text = "País:";
            // 
            // maskedTextBoxTel
            // 
            maskedTextBoxTel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxTel.Location = new Point(496, 169);
            maskedTextBoxTel.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxTel.Mask = "(99) 0000-0000";
            maskedTextBoxTel.Name = "maskedTextBoxTel";
            maskedTextBoxTel.Size = new Size(186, 30);
            maskedTextBoxTel.TabIndex = 47;
            // 
            // maskedTextBoxNasc
            // 
            maskedTextBoxNasc.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxNasc.Location = new Point(491, 92);
            maskedTextBoxNasc.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxNasc.Mask = "00/00/0000";
            maskedTextBoxNasc.Name = "maskedTextBoxNasc";
            maskedTextBoxNasc.Size = new Size(190, 30);
            maskedTextBoxNasc.TabIndex = 48;
            maskedTextBoxNasc.ValidatingType = typeof(DateTime);
            // 
            // FormVisitante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(maskedTextBoxNasc);
            Controls.Add(maskedTextBoxTel);
            Controls.Add(comboBoxCidade);
            Controls.Add(comboUF);
            Controls.Add(comboPaís);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(textBoxComoSoube);
            Controls.Add(label6);
            Controls.Add(textBoxEmail);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(button6);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(txtNomeVis);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "FormVisitante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormVisitante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button6;
        private Button button1;
        private Label label4;
        private TextBox txtNomeVis;
        private Label label3;
        private Label label1;
        private TextBox textBoxEmail;
        private Label label5;
        private TextBox textBoxComoSoube;
        private Label label6;
        private ComboBox comboBoxCidade;
        private ComboBox comboUF;
        private ComboBox comboPaís;
        private Label label12;
        private Label label11;
        private Label label10;
        private MaskedTextBox maskedTextBoxTel;
        private MaskedTextBox maskedTextBoxNasc;
    }
}