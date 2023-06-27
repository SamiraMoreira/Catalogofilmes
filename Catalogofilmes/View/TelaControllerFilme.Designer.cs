namespace Catalogofilmes.View
{
    partial class TelaControllerFilme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaControllerFilme));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txBoxFilme = new System.Windows.Forms.TextBox();
            this.txBoxEstreia = new System.Windows.Forms.TextBox();
            this.cBoxCategoria = new System.Windows.Forms.ComboBox();
            this.txBoxDuracao = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(113, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro Do Filme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(19, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(19, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estreia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(202, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(19, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Duração:";
            // 
            // txBoxFilme
            // 
            this.txBoxFilme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txBoxFilme.Location = new System.Drawing.Point(19, 102);
            this.txBoxFilme.Name = "txBoxFilme";
            this.txBoxFilme.Size = new System.Drawing.Size(304, 23);
            this.txBoxFilme.TabIndex = 5;
            this.txBoxFilme.TextChanged += new System.EventHandler(this.txBoxFilme_TextChanged);
            // 
            // txBoxEstreia
            // 
            this.txBoxEstreia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txBoxEstreia.Location = new System.Drawing.Point(19, 157);
            this.txBoxEstreia.Name = "txBoxEstreia";
            this.txBoxEstreia.Size = new System.Drawing.Size(104, 23);
            this.txBoxEstreia.TabIndex = 6;
            this.txBoxEstreia.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            this.cBoxCategoria.Location = new System.Drawing.Point(202, 157);
            this.cBoxCategoria.Name = "cBoxCategoria";
            this.cBoxCategoria.Size = new System.Drawing.Size(121, 23);
            this.cBoxCategoria.TabIndex = 7;
            this.cBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txBoxDuracao
            // 
            this.txBoxDuracao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txBoxDuracao.Location = new System.Drawing.Point(19, 230);
            this.txBoxDuracao.Name = "txBoxDuracao";
            this.txBoxDuracao.Size = new System.Drawing.Size(100, 23);
            this.txBoxDuracao.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(202, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaControllerFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 303);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txBoxDuracao);
            this.Controls.Add(this.cBoxCategoria);
            this.Controls.Add(this.txBoxEstreia);
            this.Controls.Add(this.txBoxFilme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaControllerFilme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Catalogo Filmes - SCF";
            this.Load += new System.EventHandler(this.TelaControllerFilme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txBoxFilme;
        private TextBox txBoxEstreia;
        private ComboBox cBoxCategoria;
        private TextBox txBoxDuracao;
        private Button button1;
    }
}