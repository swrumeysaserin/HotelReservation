using Otel.Business.Abstract;
using Otel.Business.ExtensionMethods;
using System;
using System.Windows.Forms;

namespace Otel.Presentation
{
    public partial class frmCustomerList : Form, IDisposable
    {
        private readonly ICustomerService _customerService;
        public Action act;
        public frmCustomerList(ICustomerService customerService)
        {
            _customerService = customerService;
            InitializeComponent();
            act = LoadData;
            Program._act = act;
            act.Invoke();//----
        }
        public void LoadData()
        {
            dataGridView1.DataSource = _customerService.List();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var selectedRow = (byte[])dataGridView1.CurrentRow.Cells[3].Value;
            if (selectedRow != null)
            {
                pictureBox1.Image = selectedRow.ToImage();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmCustomerList_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selected = dataGridView1.CurrentRow.Cells[0];
            var customerDetail = _customerService.Get(selected.ToInt32());

            var frm = Program.staticContainer.GetInstance<frmCustomerAdd>();
            frm.MdiParent = this;
            frm.SetEditData(customerDetail.Name, customerDetail.Email, customerDetail.CustomerPicture, customerDetail.Id);

            frm.Show();
        }
    }
}
