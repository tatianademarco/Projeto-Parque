namespace Teste
{
    partial class FormTodasAvaliacoes
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
            button6 = new Button();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            monthCalendar1 = new MonthCalendar();
            label1 = new Label();
            button1 = new Button();
            listView1 = new ListView();
            columnCodigo = new ColumnHeader();
            columnData = new ColumnHeader();
            columnNota = new ColumnHeader();
            columnAtendimento = new ColumnHeader();
            SuspendLayout();
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(437, 397);
            button6.Name = "button6";
            button6.Size = new Size(233, 40);
            button6.TabIndex = 83;
            button6.Text = "Cadastrar nova avaliação";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(649, 351);
            button5.Name = "button5";
            button5.Size = new Size(110, 40);
            button5.TabIndex = 82;
            button5.Text = "Vizualizar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(674, 397);
            button3.Name = "button3";
            button3.Size = new Size(85, 40);
            button3.TabIndex = 81;
            button3.Text = "Sair";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(543, 351);
            button2.Name = "button2";
            button2.Size = new Size(100, 40);
            button2.TabIndex = 80;
            button2.Text = "Excluir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(437, 351);
            button4.Name = "button4";
            button4.Size = new Size(100, 40);
            button4.TabIndex = 79;
            button4.Text = "Editar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            monthCalendar1.Location = new Point(462, 53);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 77;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(155, 22);
            label1.Name = "label1";
            label1.Size = new Size(106, 28);
            label1.TabIndex = 84;
            label1.Text = "Avaliações";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(520, 272);
            button1.Name = "button1";
            button1.Size = new Size(150, 40);
            button1.TabIndex = 88;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnCodigo, columnData, columnNota, columnAtendimento });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(22, 53);
            listView1.Name = "listView1";
            listView1.Size = new Size(409, 373);
            listView1.TabIndex = 89;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnCodigo
            // 
            columnCodigo.Text = "Código";
            columnCodigo.Width = 80;
            // 
            // columnData
            // 
            columnData.Text = "Data";
            columnData.Width = 110;
            // 
            // columnNota
            // 
            columnNota.Text = "Indicação";
            columnNota.Width = 100;
            // 
            // columnAtendimento
            // 
            columnAtendimento.Text = "Atendimento";
            columnAtendimento.Width = 120;
            // 
            // FormTodasAvaliacoes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(monthCalendar1);
            Name = "FormTodasAvaliacoes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ybhhhhh";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button6;
        private Button button5;
        private Button button3;
        private Button button2;
        private Button button4;
        private MonthCalendar monthCalendar1;
        private Label label1;
        private Button button1;
        private ListView listView1;
        private ColumnHeader columnData;
        private ColumnHeader columnNota;
        private ColumnHeader columnAtendimento;
        private ColumnHeader columnCodigo;
    }
}