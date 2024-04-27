namespace Teste
{
    partial class FormGerenciarVisitantes
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
            label1 = new Label();
            button4 = new Button();
            textBoxPesquisa = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            listBoxVis = new ListBox();
            SuspendLayout();
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(477, 303);
            button6.Name = "button6";
            button6.Size = new Size(160, 40);
            button6.TabIndex = 71;
            button6.Text = "Cadastrar novo";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(477, 240);
            button5.Name = "button5";
            button5.Size = new Size(160, 40);
            button5.TabIndex = 70;
            button5.Text = "Vizualizar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(104, 37);
            label1.Name = "label1";
            label1.Size = new Size(147, 23);
            label1.TabIndex = 68;
            label1.Text = "Procurar visitante:";
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.pngtree_search_icon_image_1344447;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Location = new Point(433, 60);
            button4.Name = "button4";
            button4.Size = new Size(35, 35);
            button4.TabIndex = 67;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPesquisa.Location = new Point(104, 63);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(328, 30);
            textBoxPesquisa.TabIndex = 66;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(477, 366);
            button3.Name = "button3";
            button3.Size = new Size(160, 40);
            button3.TabIndex = 65;
            button3.Text = "Sair";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(477, 177);
            button2.Name = "button2";
            button2.Size = new Size(160, 40);
            button2.TabIndex = 64;
            button2.Text = "Excluir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(477, 114);
            button1.Name = "button1";
            button1.Size = new Size(160, 40);
            button1.TabIndex = 63;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBoxVis
            // 
            listBoxVis.FormattingEnabled = true;
            listBoxVis.ItemHeight = 20;
            listBoxVis.Location = new Point(104, 105);
            listBoxVis.Name = "listBoxVis";
            listBoxVis.ScrollAlwaysVisible = true;
            listBoxVis.Size = new Size(334, 304);
            listBoxVis.TabIndex = 62;
            // 
            // FormGerenciarVisitantes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(textBoxPesquisa);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBoxVis);
            Name = "FormGerenciarVisitantes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormGerenciarVisitantes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button6;
        private Button button5;
        private Label label1;
        private Button button4;
        private TextBox textBoxPesquisa;
        private Button button3;
        private Button button2;
        private Button button1;
        private ListBox listBoxVis;
    }
}