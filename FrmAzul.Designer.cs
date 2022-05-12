
namespace AppExemploMenu
{
    partial class FrmAzul
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
            this.mnsAzul = new System.Windows.Forms.MenuStrip();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFrmVermelho = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFrmAmarelo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsAzul.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsAzul
            // 
            this.mnsAzul.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirToolStripMenuItem});
            this.mnsAzul.Location = new System.Drawing.Point(0, 0);
            this.mnsAzul.Name = "mnsAzul";
            this.mnsAzul.Size = new System.Drawing.Size(800, 24);
            this.mnsAzul.TabIndex = 1;
            this.mnsAzul.Text = "menuStrip1";
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFrmVermelho,
            this.tsmiFrmAmarelo});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // tsmiFrmVermelho
            // 
            this.tsmiFrmVermelho.Name = "tsmiFrmVermelho";
            this.tsmiFrmVermelho.Size = new System.Drawing.Size(180, 22);
            this.tsmiFrmVermelho.Text = "Formulário Vermelho";
            this.tsmiFrmVermelho.Click += new System.EventHandler(this.tsmiFrmVermelho_Click);
            // 
            // tsmiFrmAmarelo
            // 
            this.tsmiFrmAmarelo.Name = "tsmiFrmAmarelo";
            this.tsmiFrmAmarelo.Size = new System.Drawing.Size(180, 22);
            this.tsmiFrmAmarelo.Text = "Formulário Amarelo";
            this.tsmiFrmAmarelo.Click += new System.EventHandler(this.tsmiFrmAmarelo_Click);
            // 
            // FrmAzul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnsAzul);
            this.Name = "FrmAzul";
            this.Text = "Formulário Azul";
            this.mnsAzul.ResumeLayout(false);
            this.mnsAzul.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsAzul;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiFrmVermelho;
        private System.Windows.Forms.ToolStripMenuItem tsmiFrmAmarelo;
    }
}

