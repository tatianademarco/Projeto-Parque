namespace Teste
{
    partial class FormVisualizarVisita
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
            button3 = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            listBoxVisiantes = new ListBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(412, 465);
            button3.Name = "button3";
            button3.Size = new Size(98, 40);
            button3.TabIndex = 86;
            button3.Text = "Sair";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(388, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 37);
            label1.TabIndex = 83;
            label1.Text = "Visitação";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBoxVisiantes);
            groupBox2.Location = new Point(516, 217);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(380, 231);
            groupBox2.TabIndex = 85;
            groupBox2.TabStop = false;
            groupBox2.Text = "Grupo de Visitantes";
            // 
            // listBoxVisiantes
            // 
            listBoxVisiantes.FormattingEnabled = true;
            listBoxVisiantes.ItemHeight = 20;
            listBoxVisiantes.Location = new Point(51, 55);
            listBoxVisiantes.Name = "listBoxVisiantes";
            listBoxVisiantes.ScrollAlwaysVisible = true;
            listBoxVisiantes.Size = new Size(282, 144);
            listBoxVisiantes.TabIndex = 61;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(28, 55);
            label8.Name = "label8";
            label8.Size = new Size(234, 25);
            label8.TabIndex = 87;
            label8.Text = "Monitor que acompanhou:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(512, 123);
            label9.Name = "label9";
            label9.Size = new Size(129, 25);
            label9.TabIndex = 88;
            label9.Text = "Foi agendado:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(28, 123);
            label10.Name = "label10";
            label10.Size = new Size(207, 25);
            label10.TabIndex = 89;
            label10.Text = "Necessidades especiais:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 28);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 0;
            label2.Text = "Data:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 174);
            label3.Name = "label3";
            label3.Size = new Size(217, 25);
            label3.TabIndex = 1;
            label3.Text = "Responsável pelo grupo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(512, 28);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 2;
            label4.Text = "Turno:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(512, 71);
            label5.Name = "label5";
            label5.Size = new Size(142, 25);
            label5.TabIndex = 3;
            label5.Text = "Perfil do grupo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(29, 73);
            label6.Name = "label6";
            label6.Size = new Size(179, 25);
            label6.TabIndex = 4;
            label6.Text = "Meio de transporte:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(29, 116);
            label7.Name = "label7";
            label7.Size = new Size(161, 25);
            label7.TabIndex = 5;
            label7.Text = "Objetivo da visita:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(49, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(847, 172);
            groupBox1.TabIndex = 84;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(49, 217);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(461, 231);
            groupBox3.TabIndex = 90;
            groupBox3.TabStop = false;
            // 
            // FormVisualizarVisita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 517);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Name = "FormVisualizarVisita";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormVisualizarVisita";
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Label label1;
        private GroupBox groupBox2;
        public ListBox listBoxVisiantes;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
    }
}