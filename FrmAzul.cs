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
    public partial class FrmAzul : Form
    {
        public FrmAzul()
        {
            InitializeComponent();
        }

        private void tsmiFrmVermelho_Click(object sender, EventArgs e)
        {
            FrmVermelho Frm = new FrmVermelho();
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
