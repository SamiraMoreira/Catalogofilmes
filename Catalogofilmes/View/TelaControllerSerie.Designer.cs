namespace Catalogofilmes.View
{
    partial class TelaControllerSerie
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
            this.button1 = new System.Windows.Forms.Button();
            this.txBoxDuracao = new System.Windows.Forms.TextBox();
            this.cBoxCategoria = new System.Windows.Forms.ComboBox();
            this.txBoxEstreia = new System.Windows.Forms.TextBox();
            this.txBoxSerie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(187, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 33);
            this.button1.TabIndex = 19;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txBoxDuracao
            // 
            this.txBoxDuracao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txBoxDuracao.Location = new System.Drawing.Point(25, 220);
            this.txBoxDuracao.Name = "txBoxDuracao";
            this.txBoxDuracao.Size = new System.Drawing.Size(100, 23);
            this.txBoxDuracao.TabIndex = 18;
            // 
            // cBoxCategoria
            // 
            this.cBoxCategoria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cBoxCategoria.FormattingEnabled = true;
            this.cBoxCategoria.Items.AddRange(new object[] {
            "Terror",
            "Romance",
            "Comédia",
            "Ficção",
            "Animação",
            "Ação",
            "Suspense",
            "Drama"});
            this.cBoxCategoria.Location = new System.Drawing.Point(187, 151);
            this.cBoxCategoria.Name = "cBoxCategoria";
            this.cBoxCategoria.Size = new System.Drawing.Size(121, 23);
            this.cBoxCategoria.TabIndex = 17;
            this.cBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.cBoxCategoria_SelectedIndexChanged);
            // 
            // txBoxEstreia
            // 
            this.txBoxEstreia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txBoxEstreia.Location = new System.Drawing.Point(25, 151);
            this.txBoxEstreia.Name = "txBoxEstreia";
            this.txBoxEstreia.Size = new System.Drawing.Size(104, 23);
            this.txBoxEstreia.TabIndex = 16;
            // 
            // txBoxSerie
            // 
            this.txBoxSerie.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txBoxSerie.Location = new System.Drawing.Point(25, 84);
            this.txBoxSerie.Name = "txBoxSerie";
            this.txBoxSerie.Size = new System.Drawing.Size(304, 23);
            this.txBoxSerie.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(25, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Duração:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(187, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(25, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Estreia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(25, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Serie:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(106, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cadastro Da Serie";
            // 
            // TelaControllerSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 286);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txBoxDuracao);
            this.Controls.Add(this.cBoxCategoria);
            this.Controls.Add(this.txBoxEstreia);
            this.Controls.Add(this.txBoxSerie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaControllerSerie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaControllerSerie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox txBoxDuracao;
        private ComboBox cBoxCategoria;
        private TextBox txBoxEstreia;
        private TextBox txBoxSerie;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}