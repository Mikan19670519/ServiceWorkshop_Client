
namespace WorkshopService
{
	partial class frmAddEditCustomer
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
			this.txtCustomerContactNumber = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCustomerSurname = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.txtCustomerId = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(61, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Customer Name:";
			// 
			// txtCustomerName
			// 
			this.txtCustomerName.Location = new System.Drawing.Point(152, 28);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.Size = new System.Drawing.Size(220, 20);
			this.txtCustomerName.TabIndex = 0;
			// 
			// txtCustomerContactNumber
			// 
			this.txtCustomerContactNumber.Location = new System.Drawing.Point(152, 108);
			this.txtCustomerContactNumber.Name = "txtCustomerContactNumber";
			this.txtCustomerContactNumber.Size = new System.Drawing.Size(220, 20);
			this.txtCustomerContactNumber.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 111);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(134, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Customer Contact Number:";
			// 
			// txtCustomerSurname
			// 
			this.txtCustomerSurname.Location = new System.Drawing.Point(152, 68);
			this.txtCustomerSurname.Name = "txtCustomerSurname";
			this.txtCustomerSurname.Size = new System.Drawing.Size(220, 20);
			this.txtCustomerSurname.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(47, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Customer Surname:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtCustomerId);
			this.groupBox1.Controls.Add(this.txtCustomerName);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtCustomerContactNumber);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtCustomerSurname);
			this.groupBox1.Location = new System.Drawing.Point(25, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(392, 151);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = " Customer ";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(25, 169);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(105, 33);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "Save Customer";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(338, 169);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(79, 33);
			this.btnClose.TabIndex = 7;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// txtCustomerId
			// 
			this.txtCustomerId.Enabled = false;
			this.txtCustomerId.Location = new System.Drawing.Point(143, 0);
			this.txtCustomerId.Name = "txtCustomerId";
			this.txtCustomerId.Size = new System.Drawing.Size(100, 20);
			this.txtCustomerId.TabIndex = 13;
			this.txtCustomerId.Visible = false;
			// 
			// frmAddEditCustomer
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(446, 218);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmAddEditCustomer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add Customer";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCustomerName;
		private System.Windows.Forms.TextBox txtCustomerContactNumber;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCustomerSurname;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.TextBox txtCustomerId;
	}
}