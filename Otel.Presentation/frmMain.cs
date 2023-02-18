using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Otel.Presentation
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void otelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAddOtel = Program.staticContainer.GetInstance<frmAddOtel>();
            frmAddOtel.MdiParent = this;
            frmAddOtel.Show();

        }

        private void otelİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = Program.staticContainer.GetInstance<frmCustomerAdd>();
            frm.MdiParent = this;
            frm.Show();
        }

        private void müşteriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = Program.staticContainer.GetInstance<frmCustomerList>();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rezervasyonEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = Program.staticContainer.GetInstance<frmReservationAdd>();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
