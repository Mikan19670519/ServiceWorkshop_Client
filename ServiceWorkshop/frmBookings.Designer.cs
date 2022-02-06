
namespace WorkshopService
{
	partial class frmBookings
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookings));
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.dtgBookings = new System.Windows.Forms.DataGridView();
			this.btnAddBooking = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSearchByDate = new System.Windows.Forms.Button();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtRegNo = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.cboModel = new System.Windows.Forms.ComboBox();
			this.cboMake = new System.Windows.Forms.ComboBox();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtBookingId = new System.Windows.Forms.TextBox();
			this.txtCustomerId = new System.Windows.Forms.TextBox();
			this.txtVehicleId = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dtgBookings)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(714, 56);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(209, 20);
			this.txtSearch.TabIndex = 0;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(929, 54);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 1;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// dtgBookings
			// 
			this.dtgBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dtgBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgBookings.Location = new System.Drawing.Point(388, 93);
			this.dtgBookings.Name = "dtgBookings";
			this.dtgBookings.Size = new System.Drawing.Size(616, 373);
			this.dtgBookings.TabIndex = 2;
			this.dtgBookings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBookings_CellContentClick);
			// 
			// btnAddBooking
			// 
			this.btnAddBooking.Location = new System.Drawing.Point(388, 475);
			this.btnAddBooking.Name = "btnAddBooking";
			this.btnAddBooking.Size = new System.Drawing.Size(106, 33);
			this.btnAddBooking.TabIndex = 3;
			this.btnAddBooking.Text = "Add Booking";
			this.btnAddBooking.UseVisualStyleBackColor = true;
			this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(898, 475);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(106, 33);
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.AutoSize = true;
			this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
			this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
			this.btnRefresh.Location = new System.Drawing.Point(388, 52);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(36, 35);
			this.btnRefresh.TabIndex = 23;
			this.btnRefresh.UseVisualStyleBackColor = false;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(575, 59);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(133, 13);
			this.label4.TabIndex = 24;
			this.label4.Text = "Search by Customer Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(627, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 13);
			this.label1.TabIndex = 27;
			// 
			// btnSearchByDate
			// 
			this.btnSearchByDate.Location = new System.Drawing.Point(929, 15);
			this.btnSearchByDate.Name = "btnSearchByDate";
			this.btnSearchByDate.Size = new System.Drawing.Size(75, 23);
			this.btnSearchByDate.TabIndex = 26;
			this.btnSearchByDate.Text = "Search";
			this.btnSearchByDate.UseVisualStyleBackColor = true;
			this.btnSearchByDate.Click += new System.EventHandler(this.btnSearchByDate_Click);
			// 
			// dtpFrom
			// 
			this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFrom.Location = new System.Drawing.Point(673, 15);
			this.dtpFrom.Name = "dtpFrom";
			this.dtpFrom.Size = new System.Drawing.Size(96, 20);
			this.dtpFrom.TabIndex = 28;
			// 
			// dtpTo
			// 
			this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpTo.Location = new System.Drawing.Point(827, 15);
			this.dtpTo.Name = "dtpTo";
			this.dtpTo.Size = new System.Drawing.Size(96, 20);
			this.dtpTo.TabIndex = 29;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(611, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 30;
			this.label2.Text = "From Date";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(775, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 13);
			this.label3.TabIndex = 31;
			this.label3.Text = "To Date";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(12, 475);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(105, 33);
			this.btnUpdate.TabIndex = 32;
			this.btnUpdate.Text = "Update Booking";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtRegNo);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.cboModel);
			this.groupBox1.Controls.Add(this.cboMake);
			this.groupBox1.Controls.Add(this.txtNotes);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.dtpBookingDate);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Location = new System.Drawing.Point(12, 93);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(370, 373);
			this.groupBox1.TabIndex = 34;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = " Booking ";
			// 
			// txtRegNo
			// 
			this.txtRegNo.Location = new System.Drawing.Point(154, 110);
			this.txtRegNo.Name = "txtRegNo";
			this.txtRegNo.Size = new System.Drawing.Size(198, 20);
			this.txtRegNo.TabIndex = 40;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(44, 113);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(104, 13);
			this.label10.TabIndex = 39;
			this.label10.Text = "Vehicle Registration:";
			// 
			// cboModel
			// 
			this.cboModel.FormattingEnabled = true;
			this.cboModel.Location = new System.Drawing.Point(154, 69);
			this.cboModel.Name = "cboModel";
			this.cboModel.Size = new System.Drawing.Size(198, 21);
			this.cboModel.TabIndex = 38;
			// 
			// cboMake
			// 
			this.cboMake.FormattingEnabled = true;
			this.cboMake.Location = new System.Drawing.Point(154, 28);
			this.cboMake.Name = "cboMake";
			this.cboMake.Size = new System.Drawing.Size(198, 21);
			this.cboMake.TabIndex = 37;
			// 
			// txtNotes
			// 
			this.txtNotes.Location = new System.Drawing.Point(60, 192);
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Size = new System.Drawing.Size(292, 162);
			this.txtNotes.TabIndex = 36;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(73, 154);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(75, 13);
			this.label9.TabIndex = 34;
			this.label9.Text = "Booking Date:";
			// 
			// dtpBookingDate
			// 
			this.dtpBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpBookingDate.Location = new System.Drawing.Point(154, 150);
			this.dtpBookingDate.Name = "dtpBookingDate";
			this.dtpBookingDate.Size = new System.Drawing.Size(96, 20);
			this.dtpBookingDate.TabIndex = 32;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(73, 31);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Vehicle Make:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(16, 195);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(38, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Notes:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(71, 72);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(77, 13);
			this.label7.TabIndex = 4;
			this.label7.Text = "Vehicle Model:";
			// 
			// txtBookingId
			// 
			this.txtBookingId.Enabled = false;
			this.txtBookingId.Location = new System.Drawing.Point(114, 38);
			this.txtBookingId.Name = "txtBookingId";
			this.txtBookingId.Size = new System.Drawing.Size(100, 20);
			this.txtBookingId.TabIndex = 13;
			this.txtBookingId.Visible = false;
			// 
			// txtCustomerId
			// 
			this.txtCustomerId.Enabled = false;
			this.txtCustomerId.Location = new System.Drawing.Point(114, 61);
			this.txtCustomerId.Name = "txtCustomerId";
			this.txtCustomerId.Size = new System.Drawing.Size(100, 20);
			this.txtCustomerId.TabIndex = 35;
			this.txtCustomerId.Visible = false;
			// 
			// txtVehicleId
			// 
			this.txtVehicleId.Enabled = false;
			this.txtVehicleId.Location = new System.Drawing.Point(220, 38);
			this.txtVehicleId.Name = "txtVehicleId";
			this.txtVehicleId.Size = new System.Drawing.Size(100, 20);
			this.txtVehicleId.TabIndex = 36;
			this.txtVehicleId.Visible = false;
			// 
			// frmBookings
			// 
			this.AllowDrop = true;
			this.ClientSize = new System.Drawing.Size(1027, 526);
			this.Controls.Add(this.txtVehicleId);
			this.Controls.Add(this.txtCustomerId);
			this.Controls.Add(this.txtBookingId);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dtpTo);
			this.Controls.Add(this.dtpFrom);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSearchByDate);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnAddBooking);
			this.Controls.Add(this.dtgBookings);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtSearch);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmBookings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "View Bookings";
			((System.ComponentModel.ISupportInitialize)(this.dtgBookings)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.DataGridView dtgBookings;
		private System.Windows.Forms.Button btnAddBooking;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSearchByDate;
		private System.Windows.Forms.DateTimePicker dtpFrom;
		private System.Windows.Forms.DateTimePicker dtpTo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtBookingId;
		private System.Windows.Forms.TextBox txtCustomerId;
		private System.Windows.Forms.TextBox txtVehicleId;
		private System.Windows.Forms.ComboBox cboModel;
		private System.Windows.Forms.ComboBox cboMake;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DateTimePicker dtpBookingDate;
		private System.Windows.Forms.TextBox txtRegNo;
		private System.Windows.Forms.Label label10;
	}
}