namespace Teste
{
    partial class Form3
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
            button1 = new Button();
            button6 = new Button();
            label2 = new Label();
            txtSenhaUser = new TextBox();
            txtNomeUser = new TextBox();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(196, 343);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(150, 50);
            button1.TabIndex = 8;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button6
            // 
            button6.Location = new Point(458, 343);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(150, 50);
            button6.TabIndex = 13;
            button6.Text = "Sair";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(345, 52);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 41);
            label2.TabIndex = 14;
            label2.Text = "Usuário";
            // 
            // txtSenhaUser
            // 
            txtSenhaUser.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenhaUser.Location = new Point(292, 229);
            txtSenhaUser.Margin = new Padding(4);
            txtSenhaUser.Name = "txtSenhaUser";
            txtSenhaUser.Size = new Size(288, 30);
            txtSenhaUser.TabIndex = 27;
            // 
            // txtNomeUser
            // 
            txtNomeUser.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeUser.Location = new Point(292, 166);
            txtNomeUser.Margin = new Padding(4);
            txtNomeUser.Name = "txtNomeUser";
            txtNomeUser.Size = new Size(288, 30);
            txtNomeUser.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(196, 233);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 25;
            label3.Text = "Senha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(110, 169);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 23);
            label1.TabIndex = 24;
            label1.Text = "Nome do usuário:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSenhaUser);
            Controls.Add(txtNomeUser);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(button6);
            Controls.Add(button1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button6;
        private Label label2;
        private TextBox txtSenhaUser;
        private TextBox txtNomeUser;
        private Label label3;
        private Label label1;
    }
}