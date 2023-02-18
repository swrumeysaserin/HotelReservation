using Otel.Business.Abstract;//----
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Otel.Presentation
{
    public partial class frmReservationAdd : Form
    {
        private readonly ICustomerService _customerService;
        private readonly IOtelService _otelService;
        private readonly IReservationService _reservationService;
        public frmReservationAdd(ICustomerService customerService, IOtelService otelService)
        {
            InitializeComponent();
            _customerService = customerService;
            _otelService = otelService;
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            //_customerService.List overload ettim 
            // 
            Action act = () =>
            {

                var list = _customerService.List(txtCustomerName.Text.Trim()); // trim son baş boşluk alır.
                dataCustomerList.DataSource = list;
                dataCustomerList.Columns[0].Visible = false;
                dataCustomerList.Columns[2].Visible = false;
                dataCustomerList.Columns[3].Visible = false;
            };

            dataCustomerList.BeginInvoke(act);
        }

        private void txtOtelName_TextChanged(object sender, EventArgs e)
        {
            Action act = () =>
            {

                var list = _otelService.List(txtOtelName.Text);
                dataOtelList.DataSource = list;
                dataOtelList.Columns[0].Visible = false;
                dataOtelList.Columns[2].Visible = false;
                dataOtelList.Columns[3].Visible = false;
            }; // inline action yazımı
            dataOtelList.BeginInvoke(act);//
        }

        private void dataCustomerList_SelectionChanged(object sender, EventArgs e)
        {
            var select = dataCustomerList.CurrentRow.Cells[0];
            var customer = _customerService.Get(Convert.ToInt32(select.Value));
            lblCustomerName.Text = customer.Name;
            lblCustomerName.Tag = customer.Id;
        }

        private void dataOtelList_SelectionChanged(object sender, EventArgs e)
        {
            var select = dataCustomerList.CurrentRow.Cells[0];
            var otel = _otelService.Get(Convert.ToInt32(select.Value));
            lblOtelName.Text = otel.Name;
            lblOtelName.Tag = otel.Id;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            var t = monthCalendar1.SelectionStart;
            var t1 = monthCalendar1.SelectionEnd;
            lblStartDate.Text = t.ToString();
            lblEndDate.Text = t1.ToString();
            var days = (t1 - t).Days;
            txtPrice.Text = (days * 300M).ToString("C");
        }

        private void btnAddRez_Click(object sender, EventArgs e)
        {
            int customerId = Convert.ToInt32(dataCustomerList.CurrentRow.Cells[0].Value);
            int otelId = Convert.ToInt32(dataOtelList.CurrentRow.Cells[0].Value);

            _reservationService.Add(new Entites.Concrete.Reservation()
            {
                CreateDate = DateTime.Now,
                CustomerId = customerId,
                EndDate = monthCalendar1.SelectionEnd,
                OtelId = otelId,
                Price = Convert.ToDecimal(txtPrice.Text),
                StartDate = monthCalendar1.SelectionStart
            });
        }
    }
}
