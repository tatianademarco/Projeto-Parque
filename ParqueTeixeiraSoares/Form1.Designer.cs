namespace Teste
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtLoginNome = new TextBox();
            txtLoginSenha = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.Parque_teixeira_soares;
            pictureBox1.Location = new Point(230, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 219);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(217, 255);
            label1.Name = "label1";
            label1.Size = new Size(86, 28);
            label1.TabIndex = 1;
            label1.Text = "Usuário:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(230, 311);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 2;
            label2.Text = "Senha:";
            // 
            // txtLoginNome
            // 
            txtLoginNome.Anchor = AnchorStyles.None;
            txtLoginNome.BackColor = SystemColors.Window;
            txtLoginNome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtLoginNome.Location = new Point(309, 252);
            txtLoginNome.Name = "txtLoginNome";
            txtLoginNome.Size = new Size(175, 34);
            txtLoginNome.TabIndex = 3;
            // 
            // txtLoginSenha
            // 
            txtLoginSenha.Anchor = AnchorStyles.None;
            txtLoginSenha.BackColor = SystemColors.Window;
            txtLoginSenha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtLoginSenha.Location = new Point(309, 308);
            txtLoginSenha.Name = "txtLoginSenha";
            txtLoginSenha.PasswordChar = '•';
            txtLoginSenha.Size = new Size(175, 34);
            txtLoginSenha.TabIndex = 4;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = SystemColors.Window;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(331, 367);
            button1.Name = "button1";
            button1.Size = new Size(119, 44);
            button1.TabIndex = 5;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtLoginSenha);
            Controls.Add(txtLoginNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtLoginNome;
        private TextBox txtLoginSenha;
        private Button button1;
    }
}