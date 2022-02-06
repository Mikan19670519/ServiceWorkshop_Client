
namespace WorkshopService
{
	partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openBookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNewVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnBookings = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnViewCustomers = new System.Windows.Forms.Button();
			this.btnViewVehicles = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.bookingsToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.vehiclesToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(635, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
			this.closeToolStripMenuItem.Text = "Exit";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// bookingsToolStripMenuItem
			// 
			this.bookingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBookingToolStripMenuItem,
            this.openBookingsToolStripMenuItem,
            this.saveBookingToolStripMenuItem});
			this.bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
			this.bookingsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
			this.bookingsToolStripMenuItem.Text = "Bookings";
			// 
			// newBookingToolStripMenuItem
			// 
			this.newBookingToolStripMenuItem.Name = "newBookingToolStripMenuItem";
			this.newBookingToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.newBookingToolStripMenuItem.Text = "New Booking";
			this.newBookingToolStripMenuItem.Click += new System.EventHandler(this.newBookingToolStripMenuItem_Click);
			// 
			// openBookingsToolStripMenuItem
			// 
			this.openBookingsToolStripMenuItem.Name = "openBookingsToolStripMenuItem";
			this.openBookingsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.openBookingsToolStripMenuItem.Text = "Open Bookings";
			this.openBookingsToolStripMenuItem.Click += new System.EventHandler(this.openBookingsToolStripMenuItem_Click);
			// 
			// saveBookingToolStripMenuItem
			// 
			this.saveBookingToolStripMenuItem.Name = "saveBookingToolStripMenuItem";
			this.saveBookingToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.saveBookingToolStripMenuItem.Text = "Save Booking";
			// 
			// customersToolStripMenuItem
			// 
			this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCustomerToolStripMenuItem,
            this.viewCustomersToolStripMenuItem});
			this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
			this.customersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
			this.customersToolStripMenuItem.Text = "Customers";
			// 
			// addNewCustomerToolStripMenuItem
			// 
			this.addNewCustomerToolStripMenuItem.Name = "addNewCustomerToolStripMenuItem";
			this.addNewCustomerToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.addNewCustomerToolStripMenuItem.Text = "Add/Edit";
			this.addNewCustomerToolStripMenuItem.Click += new System.EventHandler(this.addNewCustomerToolStripMenuItem_Click);
			// 
			// viewCustomersToolStripMenuItem
			// 
			this.viewCustomersToolStripMenuItem.Name = "viewCustomersToolStripMenuItem";
			this.viewCustomersToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.viewCustomersToolStripMenuItem.Text = "View Customers";
			this.viewCustomersToolStripMenuItem.Click += new System.EventHandler(this.viewCustomersToolStripMenuItem_Click);
			// 
			// vehiclesToolStripMenuItem
			// 
			this.vehiclesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewVehicleToolStripMenuItem,
            this.viewVehiclesToolStripMenuItem});
			this.vehiclesToolStripMenuItem.Name = "vehiclesToolStripMenuItem";
			this.vehiclesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.vehiclesToolStripMenuItem.Text = "Vehicles";
			// 
			// addNewVehicleToolStripMenuItem
			// 
			this.addNewVehicleToolStripMenuItem.Name = "addNewVehicleToolStripMenuItem";
			this.addNewVehicleToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.addNewVehicleToolStripMenuItem.Text = "Add/Edit";
			this.addNewVehicleToolStripMenuItem.Click += new System.EventHandler(this.addNewVechileToolStripMenuItem_Click);
			// 
			// viewVehiclesToolStripMenuItem
			// 
			this.viewVehiclesToolStripMenuItem.Name = "viewVehiclesToolStripMenuItem";
			this.viewVehiclesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.viewVehiclesToolStripMenuItem.Text = "View Vehicles";
			this.viewVehiclesToolStripMenuItem.Click += new System.EventHandler(this.viewVehiclesToolStripMenuItem_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(44, 114);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(545, 186);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(502, 326);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(87, 40);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnBookings
			// 
			this.btnBookings.Location = new System.Drawing.Point(44, 326);
			this.btnBookings.Name = "btnBookings";
			this.btnBookings.Size = new System.Drawing.Size(112, 40);
			this.btnBookings.TabIndex = 3;
			this.btnBookings.Text = "View Bookings";
			this.btnBookings.UseVisualStyleBackColor = true;
			this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(145, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(352, 31);
			this.label1.TabIndex = 6;
			this.label1.Text = "Workshop Service Bookings";
			// 
			// btnViewCustomers
			// 
			this.btnViewCustomers.Location = new System.Drawing.Point(172, 326);
			this.btnViewCustomers.Name = "btnViewCustomers";
			this.btnViewCustomers.Size = new System.Drawing.Size(112, 40);
			this.btnViewCustomers.TabIndex = 7;
			this.btnViewCustomers.Text = "View Customers";
			this.btnViewCustomers.UseVisualStyleBackColor = true;
			this.btnViewCustomers.Click += new System.EventHandler(this.btnViewCustomers_Click);
			// 
			// btnViewVehicles
			// 
			this.btnViewVehicles.Location = new System.Drawing.Point(300, 326);
			this.btnViewVehicles.Name = "btnViewVehicles";
			this.btnViewVehicles.Size = new System.Drawing.Size(112, 40);
			this.btnViewVehicles.TabIndex = 8;
			this.btnViewVehicles.Text = "View Vehicles";
			this.btnViewVehicles.UseVisualStyleBackColor = true;
			this.btnViewVehicles.Click += new System.EventHandler(this.btnViewVehicles_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(635, 391);
			this.Controls.Add(this.btnViewVehicles);
			this.Controls.Add(this.btnViewCustomers);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnBookings);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Service Workshop Bookings";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bookingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newBookingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openBookingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveBookingToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnBookings;
		private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addNewCustomerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem vehiclesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addNewVehicleToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripMenuItem viewCustomersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewVehiclesToolStripMenuItem;
		private System.Windows.Forms.Button btnViewCustomers;
		private System.Windows.Forms.Button btnViewVehicles;
	}
}

