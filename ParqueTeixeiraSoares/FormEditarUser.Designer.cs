namespace Teste
{
    partial class FormEditarUser
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
            txtSenhaUser = new TextBox();
            txtNomeUser = new TextBox();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(346, 68);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 41);
            label2.TabIndex = 26;
            label2.Text = "Usuário";
            label2.Click += label2_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(442, 327);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(150, 50);
            button6.TabIndex = 25;
            button6.Text = "Sair";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(169, 327);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(150, 50);
            button1.TabIndex = 24;
            button1.Text = "Atualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtSenhaUser
            // 
            txtSenhaUser.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenhaUser.Location = new Point(248, 231);
            txtSenhaUser.Margin = new Padding(4);
            txtSenhaUser.Name = "txtSenhaUser";
            txtSenhaUser.Size = new Size(319, 30);
            txtSenhaUser.TabIndex = 21;
            txtSenhaUser.TextChanged += txtSenhaUser_TextChanged;
            // 
            // txtNomeUser
            // 
            txtNomeUser.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeUser.Location = new Point(248, 168);
            txtNomeUser.Margin = new Padding(4);
            txtNomeUser.Name = "txtNomeUser";
            txtNomeUser.Size = new Size(319, 30);
            txtNomeUser.TabIndex = 20;
            txtNomeUser.TextChanged += txtNomeUser_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(152, 235);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 19;
            label3.Text = "Senha:";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(66, 171);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 23);
            label1.TabIndex = 18;
            label1.Text = "Nome do usuário:";
            label1.Click += label1_Click;
            // 
            // FormEditarUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button6);
            Controls.Add(button1);
            Controls.Add(txtSenhaUser);
            Controls.Add(txtNomeUser);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "FormEditarUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEditarUser";
            Load += FormEditarUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button button6;
        private Button button1;
        private TextBox txtSenhaUser;
        private TextBox txtNomeUser;
        private Label label3;
        private Label label1;
    }
}