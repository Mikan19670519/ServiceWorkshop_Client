
namespace ServiceWorkshop
{
	partial class frmCustomers
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomers));
			this.btnAddNewCustomer = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.dtgCustomers = new System.Windows.Forms.DataGridView();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtCustomerName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCustomerContactNumber = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCustomerSurname = new System.Windows.Forms.TextBox();
			this.txtCustomerId = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnRefresh = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dtgCustomers)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAddNewCustomer
			// 
			this.btnAddNewCustomer.Location = new System.Drawing.Point(343, 443);
			this.btnAddNewCustomer.Name = "btnAddNewCustomer";
			this.btnAddNewCustomer.Size = new System.Drawing.Size(112, 40);
			this.btnAddNewCustomer.TabIndex = 5;
			this.btnAddNewCustomer.Text = "Add New Customer";
			this.btnAddNewCustomer.UseVisualStyleBackColor = true;
			this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(774, 443);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(106, 40);
			this.btnClose.TabIndex = 14;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// dtgCustomers
			// 
			this.dtgCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgCustomers.Location = new System.Drawing.Point(343, 63);
			this.dtgCustomers.Name = "dtgCustomers";
			this.dtgCustomers.Size = new System.Drawing.Size(537, 374);
			this.dtgCustomers.TabIndex = 12;
			this.dtgCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCustomers_CellContentClick);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(805, 34);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 11;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(590, 36);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(209, 20);
			this.txtSearch.TabIndex = 10;
			// 
			// btnDelete
			// 
			this.btnDelete.Enabled = false;
			this.btnDelete.Location = new System.Drawing.Point(218, 220);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(105, 33);
			this.btnDelete.TabIndex = 18;
			this.btnDelete.Text = "Delete Customer";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(12, 220);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(105, 33);
			this.btnSave.TabIndex = 15;
			this.btnSave.Text = "Save Customer";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtCustomerName);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtCustomerContactNumber);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtCustomerSurname);
			this.groupBox1.Location = new System.Drawing.Point(12, 63);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(311, 151);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = " Customer ";
			// 
			// txtCustomerName
			// 
			this.txtCustomerName.Location = new System.Drawing.Point(105, 28);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.Size = new System.Drawing.Size(185, 20);
			this.txtCustomerName.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(61, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 111);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Contact Number:";
			// 
			// txtCustomerContactNumber
			// 
			this.txtCustomerContactNumber.Location = new System.Drawing.Point(105, 108);
			this.txtCustomerContactNumber.Name = "txtCustomerContactNumber";
			this.txtCustomerContactNumber.Size = new System.Drawing.Size(185, 20);
			this.txtCustomerContactNumber.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(47, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Surname:";
			// 
			// txtCustomerSurname
			// 
			this.txtCustomerSurname.Location = new System.Drawing.Point(105, 68);
			this.txtCustomerSurname.Name = "txtCustomerSurname";
			this.txtCustomerSurname.Size = new System.Drawing.Size(185, 20);
			this.txtCustomerSurname.TabIndex = 1;
			// 
			// txtCustomerId
			// 
			this.txtCustomerId.Enabled = false;
			this.txtCustomerId.Location = new System.Drawing.Point(159, 34);
			this.txtCustomerId.Name = "txtCustomerId";
			this.txtCustomerId.Size = new System.Drawing.Size(100, 20);
			this.txtCustomerId.TabIndex = 13;
			this.txtCustomerId.Visible = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(451, 39);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(133, 13);
			this.label4.TabIndex = 21;
			this.label4.Text = "Search by Customer Name";
			// 
			// btnRefresh
			// 
			this.btnRefresh.AutoSize = true;
			this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
			this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
			this.btnRefresh.Location = new System.Drawing.Point(343, 16);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(36, 35);
			this.btnRefresh.TabIndex = 22;
			this.btnRefresh.UseVisualStyleBackColor = false;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// frmCustomers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(892, 495);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtCustomerId);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.dtgCustomers);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.btnAddNewCustomer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmCustomers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Customers";
			((System.ComponentModel.ISupportInitialize)(this.dtgCustomers)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAddNewCustomer;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.DataGridView dtgCustomers;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtCustomerName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCustomerContactNumber;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCustomerSurname;
		private System.Windows.Forms.TextBox txtCustomerId;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnRefresh;
	}
}