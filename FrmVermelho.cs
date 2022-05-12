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
    public partial class FrmVermelho : Form
    {
        public FrmVermelho()
        {
            InitializeComponent();
        }

        private void tsmiFrmAzul_Click(object sender, EventArgs e)
        {
            FrmAzul Frm = new FrmAzul();
            this.Hide();
            Frm.ShowDialog();
        }

        private void tsmiFrmAmarelo_Click(object sender, EventArgs e)
        {
            FrmAmarelo Frm = new FrmAmarelo();
            this.Hide();
            Frm.ShowDialog();
        }
    }
}
