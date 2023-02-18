using Otel.Business.Abstract;
using Otel.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;//-----
using System.Text;
using System.Windows.Forms;
using Otel.Business.ExtensionMethods;//-------------------

namespace Otel.Presentation
{
    public partial class frmAddOtel : Form
    {
        private readonly IOtelService _otelService;
        List<OtelModel> _otelData;
        public frmAddOtel(IOtelService otelService)
        {
            _otelService = otelService;
            InitializeComponent();
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<string> errorList = new List<string>();
            if (txtName.Text.Length == 0)
            {
                errorList.Add("İsim Giriniz");
            }
            if (txtPhone.Text.Length == 0)
            {
                errorList.Add("Telefon Giriniz.");
            }
            if (txtAddress.TextLength == 0)
            {
                errorList.Add("Adres Giriniz");
            }
            if (txtAddress.TextLength > 250)
            {
                errorList.Add("Adres 250 karakterden büyük olamaz.");
            }

            if (errorList.Count == 0)
            {
                if (btnAdd.Tag == null)
                {
                    OtelModel otelModel = new OtelModel();
                    otelModel.Name = txtName.Text;
                    otelModel.PhoneNumber = txtPhone.Text;
                    otelModel.OtelAddress = txtAddress.Text;
                    _otelService.Add(otelModel);
                    LoadData(); 
                }
                else
                {
                    int otelId = btnAdd.Tag.ToInt32();
                    var otelData = _otelService.Get(otelId);
                    if (otelData != null)
                    {
                        otelData.OtelAddress = txtAddress.Text;
                        otelData.Name = txtName.Text;
                        otelData.PhoneNumber = txtPhone.Text;

                        _otelService.Update(otelData);
                        btnAdd.Text = "Ekle";
                        btnAdd.Tag = null;
                        txtPhone.Text = null;
                        txtName.Text = null;
                        txtAddress.Text = null;
                        LoadData();
                        
                    }
                }
            }
        }

        void LoadData()
        {
            _otelData = _otelService.List();
            dataGridView1.DataSource = _otelData;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Otel Adı";
            dataGridView1.Columns[2].HeaderText = "Adres";
            dataGridView1.Columns[3].HeaderText = "Telefon";
        }

        private void txtSearchOtel_Click(object sender, EventArgs e)
        {
            txtSearchOtel.Text = null;
    

        }

        private void txtSearchOtel_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _otelData.Where(x => x.Name.ToUpper().Contains(txtSearchOtel.Text.ToUpper())).ToList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var otelId = dataGridView1.CurrentRow.Cells[0].Value.ToInt32();
            var otelDetail = _otelService.Get(otelId);
            if (otelDetail != null)
            {
                txtAddress.Text = otelDetail.OtelAddress;
                txtName.Text = otelDetail.Name;
                txtPhone.Text = otelDetail.PhoneNumber;
                btnAdd.Text = "Kaydet";
                btnAdd.Tag = otelId;
            }
        }
    }
}
