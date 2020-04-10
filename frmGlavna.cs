using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_p
{
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void btnVerifikacija_Click(object sender, EventArgs e)
        {
            Radnja frmr = new Radnja();
            frmr.ShowDialog();
        }
    }
}
