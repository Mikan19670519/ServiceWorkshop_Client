using ServiceWorkshop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkshopService
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void fileToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnBookings_Click(object sender, EventArgs e)
		{
			frmBookings myNewForm = new frmBookings();
			myNewForm.ShowDialog();
		}

		private void openBookingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmBookings myNewForm = new frmBookings();
			myNewForm.ShowDialog();
		}
		
		private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmAddEditCustomer myNewForm = new frmAddEditCustomer();
			myNewForm.ShowDialog();
		}

		private void newBookingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmNewBooking myNewForm = new frmNewBooking();
			myNewForm.ShowDialog();
		}

		private void addNewVechileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmAddEditVehicle myNewForm = new FrmAddEditVehicle();
			myNewForm.ShowDialog();
		}

		private void viewCustomersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmCustomers myNewForm = new frmCustomers();
			myNewForm.ShowDialog();
		}

		private void viewVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmVehicles myNewForm = new frmVehicles();
			myNewForm.ShowDialog();
		}

		private void btnViewCustomers_Click(object sender, EventArgs e)
		{
			frmCustomers myNewForm = new frmCustomers();
			myNewForm.ShowDialog();
		}

		private void btnViewVehicles_Click(object sender, EventArgs e)
		{
			frmVehicles myNewForm = new frmVehicles();
			myNewForm.ShowDialog();
		}
	}
}
