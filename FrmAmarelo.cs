using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemploMenu
{
    public partial class FrmAmarelo : Form
    {
        public FrmAmarelo()
        {
            InitializeComponent();
        }

        private void tsmiFrmAzul_Click(object sender, EventArgs e)
        {
            FrmAzul Frm = new FrmAzul();
            this.Hide();
            Frm.ShowDialog();
        }

        private void tsmiFrmVermelho_Click(object sender, EventArgs e)
        {
            FrmVermelho Frm = new FrmVermelho();
            this.Hide();
            Frm.ShowDialog();
        }
    }
}
