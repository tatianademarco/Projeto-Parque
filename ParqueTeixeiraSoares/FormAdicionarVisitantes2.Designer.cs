namespace Teste
{
    partial class FormAdicionarVisitantes2
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
            button7 = new Button();
            textBoxPesquisa = new TextBox();
            listBoxVis = new ListBox();
            button6 = new Button();
            button5 = new Button();
            listBoxAdicionados = new ListBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(87, 39);
            label2.Name = "label2";
            label2.Size = new Size(147, 23);
            label2.TabIndex = 82;
            label2.Text = "Procurar visitante:";
            // 
            // button7
            // 
            button7.BackgroundImage = Properties.Resources.pngtree_search_icon_image_1344447;
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.Location = new Point(416, 62);
            button7.Name = "button7";
            button7.Size = new Size(35, 35);
            button7.TabIndex = 81;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPesquisa.Location = new Point(87, 65);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(328, 30);
            textBoxPesquisa.TabIndex = 80;
            // 
            // listBoxVis
            // 
            listBoxVis.FormattingEnabled = true;
            listBoxVis.ItemHeight = 20;
            listBoxVis.Location = new Point(87, 107);
            listBoxVis.Name = "listBoxVis";
            listBoxVis.ScrollAlwaysVisible = true;
            listBoxVis.Size = new Size(334, 304);
            listBoxVis.TabIndex = 79;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(496, 339);
            button6.Name = "button6";
            button6.Size = new Size(217, 33);
            button6.TabIndex = 78;
            button6.Text = "Cadastrar novo visitante";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(619, 378);
            button5.Name = "button5";
            button5.Size = new Size(94, 33);
            button5.TabIndex = 77;
            button5.Text = "Cancelar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // listBoxAdicionados
            // 
            listBoxAdicionados.FormattingEnabled = true;
            listBoxAdicionados.ItemHeight = 20;
            listBoxAdicionados.Location = new Point(496, 107);
            listBoxAdicionados.Name = "listBoxAdicionados";
            listBoxAdicionados.Size = new Size(217, 224);
            listBoxAdicionados.TabIndex = 76;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(496, 378);
            button3.Name = "button3";
            button3.Size = new Size(94, 33);
            button3.TabIndex = 75;
            button3.Text = "Salvar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(619, 62);
            button2.Name = "button2";
            button2.Size = new Size(94, 33);
            button2.TabIndex = 74;
            button2.Text = "Remover";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(496, 63);
            button1.Name = "button1";
            button1.Size = new Size(94, 33);
            button1.TabIndex = 73;
            button1.Text = "Adicionar Visitante";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormAdicionarVisitantes2
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
            Name = "FormAdicionarVisitantes2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdicionarVisitantes2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button7;
        private TextBox textBoxPesquisa;
        private ListBox listBoxVis;
        private Button button6;
        private Button button5;
        private ListBox listBoxAdicionados;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}