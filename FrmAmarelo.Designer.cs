
namespace AppExemploMenu
{
    partial class FrmAmarelo
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
            this.mnsAmarelo = new System.Windows.Forms.MenuStrip();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFrmAzul = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFrmVermelho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsAmarelo.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsAmarelo
            // 
            this.mnsAmarelo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirToolStripMenuItem});
            this.mnsAmarelo.Location = new System.Drawing.Point(0, 0);
            this.mnsAmarelo.Name = "mnsAmarelo";
            this.mnsAmarelo.Size = new System.Drawing.Size(800, 24);
            this.mnsAmarelo.TabIndex = 0;
            this.mnsAmarelo.Text = "menuStrip1";
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFrmAzul,
            this.tsmiFrmVermelho});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // tsmiFrmAzul
            // 
            this.tsmiFrmAzul.Name = "tsmiFrmAzul";
            this.tsmiFrmAzul.Size = new System.Drawing.Size(180, 22);
            this.tsmiFrmAzul.Text = "Formulário Azul";
            this.tsmiFrmAzul.Click += new System.EventHandler(this.tsmiFrmAzul_Click);
            // 
            // tsmiFrmVermelho
            // 
            this.tsmiFrmVermelho.Name = "tsmiFrmVermelho";
            this.tsmiFrmVermelho.Size = new System.Drawing.Size(180, 22);
            this.tsmiFrmVermelho.Text = "Formulário Vermelho";
            this.tsmiFrmVermelho.Click += new System.EventHandler(this.tsmiFrmVermelho_Click);
            // 
            // FrmAmarelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnsAmarelo);
            this.MainMenuStrip = this.mnsAmarelo;
            this.Name = "FrmAmarelo";
            this.Text = "Formulário Amarelo";
            this.mnsAmarelo.ResumeLayout(false);
            this.mnsAmarelo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsAmarelo;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiFrmAzul;
        private System.Windows.Forms.ToolStripMenuItem tsmiFrmVermelho;
    }
}