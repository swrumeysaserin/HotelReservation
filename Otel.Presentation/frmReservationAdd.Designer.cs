namespace Otel.Presentation
{
    partial class frmReservationAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.dataCustomerList = new System.Windows.Forms.DataGridView();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblOtelName = new System.Windows.Forms.Label();
            this.dataOtelList = new System.Windows.Forms.DataGridView();
            this.txtOtelName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnAddRez = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOtelList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Ara";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(86, 6);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(191, 23);
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // dataCustomerList
            // 
            this.dataCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCustomerList.Location = new System.Drawing.Point(12, 35);
            this.dataCustomerList.Name = "dataCustomerList";
            this.dataCustomerList.RowTemplate.Height = 25;
            this.dataCustomerList.Size = new System.Drawing.Size(265, 150);
            this.dataCustomerList.TabIndex = 2;
            this.dataCustomerList.SelectionChanged += new System.EventHandler(this.dataCustomerList_SelectionChanged);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCustomerName.Location = new System.Drawing.Point(12, 188);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(265, 32);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "label2";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOtelName
            // 
            this.lblOtelName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOtelName.Location = new System.Drawing.Point(386, 188);
            this.lblOtelName.Name = "lblOtelName";
            this.lblOtelName.Size = new System.Drawing.Size(276, 32);
            this.lblOtelName.TabIndex = 8;
            this.lblOtelName.Text = "label2";
            this.lblOtelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataOtelList
            // 
            this.dataOtelList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOtelList.Location = new System.Drawing.Point(386, 35);
            this.dataOtelList.Name = "dataOtelList";
            this.dataOtelList.RowTemplate.Height = 25;
            this.dataOtelList.Size = new System.Drawing.Size(276, 150);
            this.dataOtelList.TabIndex = 7;
            this.dataOtelList.SelectionChanged += new System.EventHandler(this.dataOtelList_SelectionChanged);
            // 
            // txtOtelName
            // 
            this.txtOtelName.Location = new System.Drawing.Point(460, 6);
            this.txtOtelName.Name = "txtOtelName";
            this.txtOtelName.Size = new System.Drawing.Size(202, 23);
            this.txtOtelName.TabIndex = 6;
            this.txtOtelName.TextChanged += new System.EventHandler(this.txtOtelName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Otel Ara";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(386, 232);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(202, 23);
            this.txtPrice.TabIndex = 10;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(348, 240);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(32, 15);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Fiyat";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 240);
            this.monthCalendar1.MaxSelectionCount = 30;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(345, 325);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(38, 15);
            this.lblStartDate.TabIndex = 12;
            this.lblStartDate.Text = "label2";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(345, 352);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(38, 15);
            this.lblEndDate.TabIndex = 12;
            this.lblEndDate.Text = "label2";
            // 
            // btnAddRez
            // 
            this.btnAddRez.Location = new System.Drawing.Point(481, 261);
            this.btnAddRez.Name = "btnAddRez";
            this.btnAddRez.Size = new System.Drawing.Size(107, 46);
            this.btnAddRez.TabIndex = 13;
            this.btnAddRez.Text = "Ekle";
            this.btnAddRez.UseVisualStyleBackColor = true;
            this.btnAddRez.Click += new System.EventHandler(this.btnAddRez_Click);
            // 
            // frmReservationAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddRez);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblOtelName);
            this.Controls.Add(this.dataOtelList);
            this.Controls.Add(this.txtOtelName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.dataCustomerList);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label1);
            this.Name = "frmReservationAdd";
            this.Text = "frmReservationAdd";
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOtelList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.DataGridView dataCustomerList;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblOtelName;
        private System.Windows.Forms.DataGridView dataOtelList;
        private System.Windows.Forms.TextBox txtOtelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Button btnAddRez;
    }
}