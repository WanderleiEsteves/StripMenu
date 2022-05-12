
namespace AppExemploMenu
{
    partial class FrmVermelho
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
            this.mnsVermelho = new System.Windows.Forms.MenuStrip();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFrmAzul = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFrmAmarelo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsVermelho.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsVermelho
            // 
            this.mnsVermelho.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirToolStripMenuItem});
            this.mnsVermelho.Location = new System.Drawing.Point(0, 0);
            this.mnsVermelho.Name = "mnsVermelho";
            this.mnsVermelho.Size = new System.Drawing.Size(800, 24);
            this.mnsVermelho.TabIndex = 1;
            this.mnsVermelho.Text = "menuStrip1";
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFrmAzul,
            this.tsmiFrmAmarelo});
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
            // tsmiFrmAmarelo
            // 
            this.tsmiFrmAmarelo.Name = "tsmiFrmAmarelo";
            this.tsmiFrmAmarelo.Size = new System.Drawing.Size(180, 22);
            this.tsmiFrmAmarelo.Text = "Formulário Amarelo";
            this.tsmiFrmAmarelo.Click += new System.EventHandler(this.tsmiFrmAmarelo_Click);
            // 
            // FrmVermelho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnsVermelho);
            this.Name = "FrmVermelho";
            this.Text = "Formulário Vermelho";
            this.mnsVermelho.ResumeLayout(false);
            this.mnsVermelho.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsVermelho;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiFrmAzul;
        private System.Windows.Forms.ToolStripMenuItem tsmiFrmAmarelo;
    }
}