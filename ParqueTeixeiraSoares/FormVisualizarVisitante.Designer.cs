namespace Teste
{
    partial class FormVisualizarVisitante
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
            groupBox1 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            columnCodigo = new ColumnHeader();
            columndata = new ColumnHeader();
            columnturno = new ColumnHeader();
            columnHeadernome = new ColumnHeader();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(344, 22);
            label1.Name = "label1";
            label1.Size = new Size(124, 37);
            label1.TabIndex = 0;
            label1.Text = "Visitante";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(43, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(706, 172);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(326, 123);
            label7.Name = "label7";
            label7.Size = new Size(195, 23);
            label7.TabIndex = 5;
            label7.Text = "Como soube do parque:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(28, 123);
            label6.Name = "label6";
            label6.Size = new Size(67, 23);
            label6.TabIndex = 4;
            label6.Text = "Cidade:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(326, 71);
            label5.Name = "label5";
            label5.Size = new Size(67, 25);
            label5.TabIndex = 3;
            label5.Text = "E-mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(326, 28);
            label4.Name = "label4";
            label4.Size = new Size(173, 25);
            label4.TabIndex = 2;
            label4.Text = "Data de Nascimeto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 71);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 1;
            label3.Text = "Telefone:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 28);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 0;
            label2.Text = "Nome:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView1);
            groupBox2.Location = new Point(43, 240);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(706, 255);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Visitas";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnCodigo, columndata, columnturno, columnHeadernome });
            listView1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.FullRowSelect = true;
            listView1.Location = new Point(47, 44);
            listView1.Name = "listView1";
            listView1.Size = new Size(607, 183);
            listView1.TabIndex = 87;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnCodigo
            // 
            columnCodigo.Text = "Código";
            columnCodigo.Width = 90;
            // 
            // columndata
            // 
            columndata.Text = "Data";
            columndata.Width = 140;
            // 
            // columnturno
            // 
            columnturno.Text = "Turno";
            columnturno.Width = 120;
            // 
            // columnHeadernome
            // 
            columnHeadernome.Text = "Responsável";
            columnHeadernome.Width = 250;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(344, 501);
            button3.Name = "button3";
            button3.Size = new Size(119, 40);
            button3.TabIndex = 82;
            button3.Text = "Sair";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FormVisualizarVisitante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 553);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Name = "FormVisualizarVisitante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormVizualizarUsuario";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button3;
        private Label label4;
        private Label label3;
        private Label label2;
        private ListView listView1;
        private ColumnHeader columnCodigo;
        private ColumnHeader columndata;
        private ColumnHeader columnturno;
        private ColumnHeader columnHeadernome;
        private Label label5;
        private Label label7;
        private Label label6;
    }
}