
namespace ServiceWorkshop
{
	partial class frmVehicles
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehicles));
			this.btnClose = new System.Windows.Forms.Button();
			this.dtgVehicles = new System.Windows.Forms.DataGridView();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnAddNewVehicle = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtModel = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtRegNo = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtMake = new System.Windows.Forms.TextBox();
			this.txtVehicleId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnRefresh = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dtgVehicles)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(738, 438);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(106, 40);
			this.btnClose.TabIndex = 9;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// dtgVehicles
			// 
			this.dtgVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtgVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgVehicles.Location = new System.Drawing.Point(329, 50);
			this.dtgVehicles.Name = "dtgVehicles";
			this.dtgVehicles.Size = new System.Drawing.Size(515, 371);
			this.dtgVehicles.TabIndex = 7;
			this.dtgVehicles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVehicles_CellContentClick);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(769, 21);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(554, 23);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(209, 20);
			this.txtSearch.TabIndex = 5;
			// 
			// btnAddNewVehicle
			// 
			this.btnAddNewVehicle.Location = new System.Drawing.Point(329, 438);
			this.btnAddNewVehicle.Name = "btnAddNewVehicle";
			this.btnAddNewVehicle.Size = new System.Drawing.Size(112, 40);
			this.btnAddNewVehicle.TabIndex = 10;
			this.btnAddNewVehicle.Text = "Add New Vehicle";
			this.btnAddNewVehicle.UseVisualStyleBackColor = true;
			this.btnAddNewVehicle.Click += new System.EventHandler(this.btnAddNewVehicle_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(211, 215);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(97, 33);
			this.btnDelete.TabIndex = 18;
			this.btnDelete.Text = "Delete Vehicle";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(12, 215);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(97, 33);
			this.btnSave.TabIndex = 17;
			this.btnSave.Text = "Save Vehicle";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtModel);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.txtRegNo);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.txtMake);
			this.groupBox2.Location = new System.Drawing.Point(12, 50);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(296, 159);
			this.groupBox2.TabIndex = 16;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = " Vehicle ";
			// 
			// txtModel
			// 
			this.txtModel.Location = new System.Drawing.Point(114, 69);
			this.txtModel.Name = "txtModel";
			this.txtModel.Size = new System.Drawing.Size(161, 20);
			this.txtModel.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(69, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Model:";
			// 
			// txtRegNo
			// 
			this.txtRegNo.Location = new System.Drawing.Point(114, 110);
			this.txtRegNo.Name = "txtRegNo";
			this.txtRegNo.Size = new System.Drawing.Size(161, 20);
			this.txtRegNo.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(71, 31);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Make:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(25, 113);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Registration No:";
			// 
			// txtMake
			// 
			this.txtMake.Location = new System.Drawing.Point(114, 28);
			this.txtMake.Name = "txtMake";
			this.txtMake.Size = new System.Drawing.Size(161, 20);
			this.txtMake.TabIndex = 3;
			// 
			// txtVehicleId
			// 
			this.txtVehicleId.Enabled = false;
			this.txtVehicleId.Location = new System.Drawing.Point(208, 21);
			this.txtVehicleId.Name = "txtVehicleId";
			this.txtVehicleId.Size = new System.Drawing.Size(100, 20);
			this.txtVehicleId.TabIndex = 19;
			this.txtVehicleId.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(463, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 13);
			this.label1.TabIndex = 20;
			this.label1.Text = "Search by Make";
			// 
			// btnRefresh
			// 
			this.btnRefresh.AutoSize = true;
			this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
			this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
			this.btnRefresh.Location = new System.Drawing.Point(329, 13);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(36, 35);
			this.btnRefresh.TabIndex = 23;
			this.btnRefresh.UseVisualStyleBackColor = false;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// frmVehicles
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(874, 495);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtVehicleId);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnAddNewVehicle);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.dtgVehicles);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtSearch);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmVehicles";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Vehicles";
			((System.ComponentModel.ISupportInitialize)(this.dtgVehicles)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.DataGridView dtgVehicles;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnAddNewVehicle;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtModel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtRegNo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtMake;
		private System.Windows.Forms.TextBox txtVehicleId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnRefresh;
	}
}