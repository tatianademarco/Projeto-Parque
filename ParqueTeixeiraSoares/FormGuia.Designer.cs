﻿namespace Teste
{
    partial class FormGuia
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
            textBoxEmail = new TextBox();
            label5 = new Label();
            label2 = new Label();
            button6 = new Button();
            button1 = new Button();
            txtNomeGuia = new TextBox();
            label3 = new Label();
            label1 = new Label();
            maskedTextBoxTel = new MaskedTextBox();
            SuspendLayout();
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(222, 211);
            textBoxEmail.Margin = new Padding(4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(319, 34);
            textBoxEmail.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(222, 179);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 28);
            label5.TabIndex = 56;
            label5.Text = "E-mail:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(255, 26);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(277, 41);
            label2.TabIndex = 54;
            label2.Text = "Cadastrar Monitor";
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
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNomeGuia
            // 
            txtNomeGuia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeGuia.Location = new Point(222, 121);
            txtNomeGuia.Margin = new Padding(4);
            txtNomeGuia.Name = "txtNomeGuia";
            txtNomeGuia.Size = new Size(319, 34);
            txtNomeGuia.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(222, 276);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 28);
            label3.TabIndex = 48;
            label3.Text = "Telefone:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(222, 89);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 28);
            label1.TabIndex = 47;
            label1.Text = "Nome:";
            // 
            // maskedTextBoxTel
            // 
            maskedTextBoxTel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxTel.Location = new Point(222, 307);
            maskedTextBoxTel.Mask = "(99) 0 0000-0000";
            maskedTextBoxTel.Name = "maskedTextBoxTel";
            maskedTextBoxTel.Size = new Size(319, 34);
            maskedTextBoxTel.TabIndex = 58;
            // 
            // FormGuia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(maskedTextBoxTel);
            Controls.Add(textBoxEmail);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(button6);
            Controls.Add(button1);
            Controls.Add(txtNomeGuia);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "FormGuia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormGuia";
            Load += FormGuia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEmail;
        private Label label5;
        private Label label2;
        private Button button6;
        private Button button1;
        private TextBox txtNomeGuia;
        private Label label3;
        private Label label1;
        private MaskedTextBox maskedTextBoxTel;
    }
}