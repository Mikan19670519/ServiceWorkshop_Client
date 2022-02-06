
namespace WorkshopService
{
	partial class frmNewBooking
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
			this.label3 = new System.Windows.Forms.Label();
			this.cboCustomers = new System.Windows.Forms.ComboBox();
			this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
			this.btnSaveBooking = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.cboModel = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cboMake = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtVehicleID = new System.Windows.Forms.TextBox();
			this.txtCustomerID = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(35, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Customer:";
			// 
			// cboCustomers
			// 
			this.cboCustomers.FormattingEnabled = true;
			this.cboCustomers.Location = new System.Drawing.Point(95, 35);
			this.cboCustomers.Name = "cboCustomers";
			this.cboCustomers.Size = new System.Drawing.Size(251, 21);
			this.cboCustomers.TabIndex = 0;
			this.cboCustomers.SelectedIndexChanged += new System.EventHandler(this.cboCustomers_SelectedIndexChanged);
			this.cboCustomers.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cboCustomerFormat);
			// 
			// dtpBookingDate
			// 
			this.dtpBookingDate.Location = new System.Drawing.Point(95, 164);
			this.dtpBookingDate.Name = "dtpBookingDate";
			this.dtpBookingDate.Size = new System.Drawing.Size(200, 20);
			this.dtpBookingDate.TabIndex = 3;
			// 
			// btnSaveBooking
			// 
			this.btnSaveBooking.Location = new System.Drawing.Point(23, 388);
			this.btnSaveBooking.Name = "btnSaveBooking";
			this.btnSaveBooking.Size = new System.Drawing.Size(111, 35);
			this.btnSaveBooking.TabIndex = 7;
			this.btnSaveBooking.Text = "Save Booking";
			this.btnSaveBooking.UseVisualStyleBackColor = true;
			this.btnSaveBooking.Click += new System.EventHandler(this.btnSaveBooking_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(317, 388);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(111, 35);
			this.btnClose.TabIndex = 8;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// cboModel
			// 
			this.cboModel.FormattingEnabled = true;
			this.cboModel.Location = new System.Drawing.Point(95, 121);
			this.cboModel.Name = "cboModel";
			this.cboModel.Size = new System.Drawing.Size(251, 21);
			this.cboModel.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Vehicle Model:";
			// 
			// cboMake
			// 
			this.cboMake.FormattingEnabled = true;
			this.cboMake.Location = new System.Drawing.Point(95, 78);
			this.cboMake.Name = "cboMake";
			this.cboMake.Size = new System.Drawing.Size(251, 21);
			this.cboMake.TabIndex = 1;
			this.cboMake.SelectedIndexChanged += new System.EventHandler(this.cboMake_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 81);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Vehicle Make:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtCustomerID);
			this.groupBox1.Controls.Add(this.txtVehicleID);
			this.groupBox1.Controls.Add(this.txtNotes);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.cboMake);
			this.groupBox1.Controls.Add(this.dtpBookingDate);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.cboModel);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cboCustomers);
			this.groupBox1.Location = new System.Drawing.Point(23, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(405, 357);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = " Add New Booking ";
			// 
			// txtNotes
			// 
			this.txtNotes.Location = new System.Drawing.Point(95, 206);
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Size = new System.Drawing.Size(282, 124);
			this.txtNotes.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(41, 206);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(38, 13);
			this.label7.TabIndex = 37;
			this.label7.Text = "Notes:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(14, 170);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(75, 13);
			this.label6.TabIndex = 7;
			this.label6.Text = "Booking Date:";
			// 
			// txtVehicleID
			// 
			this.txtVehicleID.Location = new System.Drawing.Point(275, 9);
			this.txtVehicleID.Name = "txtVehicleID";
			this.txtVehicleID.Size = new System.Drawing.Size(100, 20);
			this.txtVehicleID.TabIndex = 38;
			this.txtVehicleID.Visible = false;
			// 
			// txtCustomerID
			// 
			this.txtCustomerID.Location = new System.Drawing.Point(169, 0);
			this.txtCustomerID.Name = "txtCustomerID";
			this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
			this.txtCustomerID.TabIndex = 39;
			this.txtCustomerID.Visible = false;
			// 
			// frmNewBooking
			// 
			this.AllowDrop = true;
			this.ClientSize = new System.Drawing.Size(456, 446);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnSaveBooking);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmNewBooking";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "New Bookings";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCustomer;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cboCustomers;
		private System.Windows.Forms.DateTimePicker dtpBookingDate;
		private System.Windows.Forms.Button btnSaveBooking;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.ComboBox cboModel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cboMake;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtCustomerID;
		private System.Windows.Forms.TextBox txtVehicleID;
	}
}