namespace Teste
{
    partial class FormAdicionarVisitantes
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
            button2 = new Button();
            button3 = new Button();
            listBoxAdicionados = new ListBox();
            button5 = new Button();
            button6 = new Button();
            label2 = new Label();
            button7 = new Button();
            textBoxPesquisa = new TextBox();
            listBoxVis = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(448, 56);
            button1.Name = "button1";
            button1.Size = new Size(94, 33);
            button1.TabIndex = 1;
            button1.Text = "Adicionar Visitante";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(571, 55);
            button2.Name = "button2";
            button2.Size = new Size(94, 33);
            button2.TabIndex = 2;
            button2.Text = "Remover";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(448, 371);
            button3.Name = "button3";
            button3.Size = new Size(94, 33);
            button3.TabIndex = 3;
            button3.Text = "Salvar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBoxAdicionados
            // 
            listBoxAdicionados.FormattingEnabled = true;
            listBoxAdicionados.ItemHeight = 20;
            listBoxAdicionados.Location = new Point(448, 100);
            listBoxAdicionados.Name = "listBoxAdicionados";
            listBoxAdicionados.Size = new Size(217, 224);
            listBoxAdicionados.TabIndex = 59;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(571, 371);
            button5.Name = "button5";
            button5.Size = new Size(94, 33);
            button5.TabIndex = 60;
            button5.Text = "Cancelar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(448, 332);
            button6.Name = "button6";
            button6.Size = new Size(217, 33);
            button6.TabIndex = 61;
            button6.Text = "Cadastrar novo visitante";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 32);
            label2.Name = "label2";
            label2.Size = new Size(147, 23);
            label2.TabIndex = 72;
            label2.Text = "Procurar visitante:";
            // 
            // button7
            // 
            button7.BackgroundImage = Properties.Resources.pngtree_search_icon_image_1344447;
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.Location = new Point(368, 55);
            button7.Name = "button7";
            button7.Size = new Size(35, 35);
            button7.TabIndex = 71;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPesquisa.Location = new Point(39, 58);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(328, 30);
            textBoxPesquisa.TabIndex = 70;
            // 
            // listBoxVis
            // 
            listBoxVis.FormattingEnabled = true;
            listBoxVis.ItemHeight = 20;
            listBoxVis.Location = new Point(39, 100);
            listBoxVis.Name = "listBoxVis";
            listBoxVis.ScrollAlwaysVisible = true;
            listBoxVis.Size = new Size(334, 304);
            listBoxVis.TabIndex = 69;
            // 
            // FormAdicionarVisitantes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button7);
            Controls.Add(textBoxPesquisa);
            Controls.Add(listBoxVis);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(listBoxAdicionados);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormAdicionarVisitantes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdicionarVisitantes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox listBoxAdicionados;
        private Button button5;
        private Button button6;
        private Label label2;
        private Button button7;
        private TextBox textBoxPesquisa;
        private ListBox listBoxVis;
    }
}