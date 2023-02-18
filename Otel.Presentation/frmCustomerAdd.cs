using Otel.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;//-------------------
using System.Drawing;
using Otel.Business.ExtensionMethods;//-----

namespace Otel.Presentation
{
    public partial class frmCustomerAdd : Form
    {
        private readonly ICustomerService _customerService;
        public frmCustomerAdd(ICustomerService customerService)
        {
            _customerService = customerService;
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            List<string> errors = new List<string>();
            #region Validation
            if (txtEmail.Text == null)
            {
                errors.Add("Email Giriniz");
            }
            if (txtName.Text == null)
            {
                errors.Add("Adınızı giriniz");
            }
            if (txtPicture.TextLength == 0)
            {
                errors.Add("Resim Seçilmedi");
            }
            #endregion
            if (errors.Count == 0)
            {
                _customerService.Add(new Entites.Concrete.Customer()
                {
                    Email = txtEmail.Text,
                    Name = txtName.Text,
                    CustomerPicture = picCustomer.Image.ToByte()
                }) ;
                LoadData();//-----
            }
            else
            {
                MessageBox.Show(String.Join('\n', errors));
            }

        }
        private void LoadData()
        {
            bool isOpen = Application.OpenForms["frmCustomerList"] != null;
            if (isOpen)
            {
                Program._act.Invoke();//Invoke bir action içindeki methodu çalıştırır.
            }
        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var file = openFileDialog.FileName;
                Image image = Image.FromFile(file);
                picCustomer.Image = image;
                txtPicture.Text = file;
            }
        }

        public void SetEditData(string name,string email,byte[] pic,int id)
        {
            txtEmail.Text = email;
            txtName.Text = name;
            picCustomer.Image = pic.ToImage();
            btnAddCustomer.Text = "Kaydet";
            btnAddCustomer.Tag = id;

        }
    }
}
