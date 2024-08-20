namespace ProjetoComboBox
{
    partial class Ttc
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Ttexto = new System.Windows.Forms.TextBox();
            this.Tic = new System.Windows.Forms.TextBox();
            this.TC = new System.Windows.Forms.TextBox();
            this.CBl = new System.Windows.Forms.ComboBox();
            this.Qi = new System.Windows.Forms.Label();
            this.Bic = new System.Windows.Forms.Button();
            this.Boc = new System.Windows.Forms.Button();
            this.Brc = new System.Windows.Forms.Button();
            this.Bedc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidades d\'itens";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Índice do Combo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Texto do Combo:";
            // 
            // Ttexto
            // 
            this.Ttexto.Location = new System.Drawing.Point(103, 49);
            this.Ttexto.Name = "Ttexto";
            this.Ttexto.Size = new System.Drawing.Size(639, 20);
            this.Ttexto.TabIndex = 5;
            // 
            // Tic
            // 
            this.Tic.Location = new System.Drawing.Point(155, 412);
            this.Tic.Name = "Tic";
            this.Tic.Size = new System.Drawing.Size(587, 20);
            this.Tic.TabIndex = 6;
            // 
            // TC
            // 
            this.TC.Location = new System.Drawing.Point(155, 467);
            this.TC.Name = "TC";
            this.TC.Size = new System.Drawing.Size(587, 20);
            this.TC.TabIndex = 7;
            // 
            // CBl
            // 
            this.CBl.FormattingEnabled = true;
            this.CBl.Location = new System.Drawing.Point(103, 158);
            this.CBl.Name = "CBl";
            this.CBl.Size = new System.Drawing.Size(639, 21);
            this.CBl.TabIndex = 8;
            // 
            // Qi
            // 
            this.Qi.AutoSize = true;
            this.Qi.Location = new System.Drawing.Point(399, 292);
            this.Qi.Name = "Qi";
            this.Qi.Size = new System.Drawing.Size(10, 13);
            this.Qi.TabIndex = 9;
            this.Qi.Text = ".";
            // 
            // Bic
            // 
            this.Bic.Location = new System.Drawing.Point(234, 86);
            this.Bic.Name = "Bic";
            this.Bic.Size = new System.Drawing.Size(149, 57);
            this.Bic.TabIndex = 10;
            this.Bic.Text = "Inserir no Combo";
            this.Bic.UseVisualStyleBackColor = true;
            this.Bic.Click += new System.EventHandler(this.Bic_Click);
            // 
            // Boc
            // 
            this.Boc.Location = new System.Drawing.Point(422, 86);
            this.Boc.Name = "Boc";
            this.Boc.Size = new System.Drawing.Size(149, 57);
            this.Boc.TabIndex = 11;
            this.Boc.Text = "Ordenar o Combo";
            this.Boc.UseVisualStyleBackColor = true;
            this.Boc.Click += new System.EventHandler(this.Boc_Click);
            // 
            // Brc
            // 
            this.Brc.Location = new System.Drawing.Point(337, 199);
            this.Brc.Name = "Brc";
            this.Brc.Size = new System.Drawing.Size(149, 57);
            this.Brc.TabIndex = 12;
            this.Brc.Text = "Remover do Combo";
            this.Brc.UseVisualStyleBackColor = true;
            this.Brc.Click += new System.EventHandler(this.Brc_Click);
            // 
            // Bedc
            // 
            this.Bedc.Location = new System.Drawing.Point(337, 332);
            this.Bedc.Name = "Bedc";
            this.Bedc.Size = new System.Drawing.Size(149, 57);
            this.Bedc.TabIndex = 13;
            this.Bedc.Text = "Exibir Dados do Combo";
            this.Bedc.UseVisualStyleBackColor = true;
            this.Bedc.Click += new System.EventHandler(this.Bedc_Click);
            // 
            // Ttc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.Bedc);
            this.Controls.Add(this.Brc);
            this.Controls.Add(this.Boc);
            this.Controls.Add(this.Bic);
            this.Controls.Add(this.Qi);
            this.Controls.Add(this.CBl);
            this.Controls.Add(this.TC);
            this.Controls.Add(this.Tic);
            this.Controls.Add(this.Ttexto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ttc";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Ttexto;
        private System.Windows.Forms.TextBox Tic;
        private System.Windows.Forms.TextBox TC;
        private System.Windows.Forms.ComboBox CBl;
        private System.Windows.Forms.Label Qi;
        private System.Windows.Forms.Button Bic;
        private System.Windows.Forms.Button Boc;
        private System.Windows.Forms.Button Brc;
        private System.Windows.Forms.Button Bedc;
    }
}

