namespace Teste
{
    partial class FormTodosMonitores
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
            button2 = new Button();
            button1 = new Button();
            listBoxNomeMon = new ListBox();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12.2F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(512, 222);
            button3.Name = "button3";
            button3.Size = new Size(160, 40);
            button3.TabIndex = 9;
            button3.Text = "Sair";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(128, 40);
            label1.Name = "label1";
            label1.Size = new Size(221, 28);
            label1.TabIndex = 8;
            label1.Text = "Monitores Cadastrados";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(512, 154);
            button2.Name = "button2";
            button2.Size = new Size(160, 40);
            button2.TabIndex = 7;
            button2.Text = "Excluir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(512, 85);
            button1.Name = "button1";
            button1.Size = new Size(160, 40);
            button1.TabIndex = 6;
            button1.Text = "Alterar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBoxNomeMon
            // 
            listBoxNomeMon.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxNomeMon.FormattingEnabled = true;
            listBoxNomeMon.ItemHeight = 23;
            listBoxNomeMon.Location = new Point(128, 85);
            listBoxNomeMon.Name = "listBoxNomeMon";
            listBoxNomeMon.Size = new Size(348, 326);
            listBoxNomeMon.TabIndex = 5;
            // 
            // FormTodosMonitores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBoxNomeMon);
            Name = "FormTodosMonitores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTodosMonitores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Label label1;
        private Button button2;
        private Button button1;
        private ListBox listBoxNomeMon;
    }
}