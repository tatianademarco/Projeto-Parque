namespace Teste
{
    partial class FormMeuPerfil
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
            label2.Location = new Point(335, 71);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(165, 41);
            label2.TabIndex = 35;
            label2.Text = "Meu Perfil";
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(465, 341);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(150, 50);
            button6.TabIndex = 34;
            button6.Text = "Sair";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(233, 341);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(150, 50);
            button1.TabIndex = 33;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtSenhaUser
            // 
            txtSenhaUser.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenhaUser.Location = new Point(294, 239);
            txtSenhaUser.Margin = new Padding(4);
            txtSenhaUser.Name = "txtSenhaUser";
            txtSenhaUser.Size = new Size(319, 30);
            txtSenhaUser.TabIndex = 30;
            // 
            // txtNomeUser
            // 
            txtNomeUser.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeUser.Location = new Point(294, 176);
            txtNomeUser.Margin = new Padding(4);
            txtNomeUser.Name = "txtNomeUser";
            txtNomeUser.Size = new Size(319, 30);
            txtNomeUser.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(198, 243);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 28;
            label3.Text = "Senha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(112, 179);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 23);
            label1.TabIndex = 27;
            label1.Text = "Nome do usuário:";
            // 
            // FormMeuPerfil
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
            Name = "FormMeuPerfil";
            Text = "FormMeuPerfil";
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