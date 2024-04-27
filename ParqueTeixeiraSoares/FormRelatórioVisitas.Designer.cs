namespace Teste
{
    partial class FormRelatórioVisitas
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
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            button1 = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Location = new Point(0, 50);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(800, 400);
            reportViewer1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(476, 11);
            button1.Name = "button1";
            button1.Size = new Size(121, 29);
            button1.TabIndex = 5;
            button1.Text = "Gerar Relatório";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Todos", "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro", " " });
            comboBox2.Location = new Point(291, 10);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(99, 28);
            comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Todos", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040" });
            comboBox1.Location = new Point(70, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(99, 28);
            comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 13);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 2;
            label2.Text = "Mês:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 13);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 1;
            label1.Text = "Ano:";
            // 
            // button2
            // 
            button2.Location = new Point(490, 11);
            button2.Name = "button2";
            button2.Size = new Size(71, 29);
            button2.TabIndex = 10;
            button2.Text = "Filtrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Todos", "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro", " " });
            comboBox3.Location = new Point(305, 10);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(99, 28);
            comboBox3.TabIndex = 9;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Todos", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040" });
            comboBox4.Location = new Point(84, 12);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(99, 28);
            comboBox4.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(260, 13);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 7;
            label3.Text = "Mês:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 13);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 6;
            label4.Text = "Ano:";
            // 
            // FormRelatórioVisitas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(comboBox3);
            Controls.Add(comboBox4);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(reportViewer1);
            Name = "FormRelatórioVisitas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRelatórioVisitas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Button button1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private Button button2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label3;
        private Label label4;
    }
}