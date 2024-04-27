namespace Teste
{
    partial class FormEditarVisitante
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
            comboBoxCidade = new ComboBox();
            comboUF = new ComboBox();
            comboPaís = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            textBoxComoSoube = new TextBox();
            label6 = new Label();
            textBoxEmail = new TextBox();
            label5 = new Label();
            label2 = new Label();
            button6 = new Button();
            button1 = new Button();
            label4 = new Label();
            txtNomeVis = new TextBox();
            label3 = new Label();
            label1 = new Label();
            maskedTextBoxNasc = new MaskedTextBox();
            maskedTextBoxTel = new MaskedTextBox();
            SuspendLayout();
            // 
            // comboBoxCidade
            // 
            comboBoxCidade.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxCidade.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxCidade.FormattingEnabled = true;
            comboBoxCidade.Location = new Point(494, 334);
            comboBoxCidade.Name = "comboBoxCidade";
            comboBoxCidade.Size = new Size(190, 28);
            comboBoxCidade.TabIndex = 65;
            // 
            // comboUF
            // 
            comboUF.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboUF.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboUF.FormattingEnabled = true;
            comboUF.Location = new Point(359, 334);
            comboUF.Name = "comboUF";
            comboUF.Size = new Size(59, 28);
            comboUF.TabIndex = 64;
            comboUF.SelectedIndexChanged += comboUF_SelectedIndexChanged;
            // 
            // comboPaís
            // 
            comboPaís.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboPaís.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboPaís.FormattingEnabled = true;
            comboPaís.Location = new Point(99, 334);
            comboPaís.Name = "comboPaís";
            comboPaís.Size = new Size(151, 28);
            comboPaís.TabIndex = 63;
            comboPaís.SelectedIndexChanged += comboPaís_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(494, 311);
            label12.Name = "label12";
            label12.Size = new Size(67, 23);
            label12.TabIndex = 62;
            label12.Text = "Cidade:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(359, 311);
            label11.Name = "label11";
            label11.Size = new Size(35, 23);
            label11.TabIndex = 61;
            label11.Text = "UF:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(99, 308);
            label10.Name = "label10";
            label10.Size = new Size(44, 23);
            label10.TabIndex = 60;
            label10.Text = "País:";
            // 
            // textBoxComoSoube
            // 
            textBoxComoSoube.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxComoSoube.Location = new Point(99, 252);
            textBoxComoSoube.Margin = new Padding(4);
            textBoxComoSoube.Name = "textBoxComoSoube";
            textBoxComoSoube.Size = new Size(319, 30);
            textBoxComoSoube.TabIndex = 59;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(99, 225);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(195, 23);
            label6.TabIndex = 58;
            label6.Text = "Como soube do parque:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(99, 173);
            textBoxEmail.Margin = new Padding(4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(319, 30);
            textBoxEmail.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(99, 146);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 56;
            label5.Text = "E-mail:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(257, 8);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(235, 41);
            label2.TabIndex = 54;
            label2.Text = "Editar Visitante";
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(456, 392);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(150, 50);
            button6.TabIndex = 53;
            button6.Text = "Sair";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(222, 392);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(150, 50);
            button1.TabIndex = 52;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(494, 70);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(167, 23);
            label4.TabIndex = 51;
            label4.Text = "Data de nascimento:";
            // 
            // txtNomeVis
            // 
            txtNomeVis.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeVis.Location = new Point(99, 97);
            txtNomeVis.Margin = new Padding(4);
            txtNomeVis.Name = "txtNomeVis";
            txtNomeVis.Size = new Size(319, 30);
            txtNomeVis.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(494, 145);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 23);
            label3.TabIndex = 48;
            label3.Text = "Telefone:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(99, 70);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 23);
            label1.TabIndex = 47;
            label1.Text = "Nome:";
            // 
            // maskedTextBoxNasc
            // 
            maskedTextBoxNasc.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxNasc.Location = new Point(494, 97);
            maskedTextBoxNasc.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxNasc.Mask = "00/00/0000";
            maskedTextBoxNasc.Name = "maskedTextBoxNasc";
            maskedTextBoxNasc.Size = new Size(190, 30);
            maskedTextBoxNasc.TabIndex = 66;
            maskedTextBoxNasc.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBoxTel
            // 
            maskedTextBoxTel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxTel.Location = new Point(494, 173);
            maskedTextBoxTel.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxTel.Mask = "(99) 0000-0000";
            maskedTextBoxTel.Name = "maskedTextBoxTel";
            maskedTextBoxTel.Size = new Size(186, 30);
            maskedTextBoxTel.TabIndex = 67;
            // 
            // FormEditarVisitante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(maskedTextBoxTel);
            Controls.Add(maskedTextBoxNasc);
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
            Name = "FormEditarVisitante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEditarVisitante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxCidade;
        private ComboBox comboUF;
        private ComboBox comboPaís;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox textBoxComoSoube;
        private Label label6;
        private TextBox textBoxEmail;
        private Label label5;
        private Label label2;
        private Button button6;
        private Button button1;
        private Label label4;
        private TextBox txtNomeVis;
        private Label label3;
        private Label label1;
        private MaskedTextBox maskedTextBoxNasc;
        private MaskedTextBox maskedTextBoxTel;
    }
}