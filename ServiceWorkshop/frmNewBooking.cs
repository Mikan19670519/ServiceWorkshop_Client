using Newtonsoft.Json;
using ServiceWorkshop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkshopService.Models;

namespace WorkshopService
{
	public partial class frmNewBooking : Form
	{
		static CancellationToken cancellationToken = new CancellationToken();

		WaitWnd.WaitWndFun waitForm = new WaitWnd.WaitWndFun();
		public frmNewBooking()
		{
			InitializeComponent();
			GetAllCustomers();
			GetAllVehicles();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			ActiveForm.Close();
		}

		private async void btnSaveBooking_Click(object sender, EventArgs e)
		{
			try
			{
				waitForm.Show(this);

				BookingModel booking = new BookingModel
				{
					BookingDate = dtpBookingDate.Value,
					Notes = txtNotes.Text.Trim(),
					CustomerID = Guid.Parse(txtCustomerID.Text),
					VehicleID = Guid.Parse(txtVehicleID.Text),
				};

				await AddBookingAsync(booking, cancellationToken).ConfigureAwait(true);

				GetAllCustomers();
				MessageBox.Show($"Booking successfully saved...");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				waitForm.Close();
			}
		}

		private async void GetAllCustomers()
		{
			try
			{
				waitForm.Show(this);

				IEnumerable<CustomerModel> customers = await GetCustomersAsync(cancellationToken).ConfigureAwait(true);
				cboCustomers.ValueMember = "CustomerID";
				cboCustomers.DisplayMember = "Name";				
				cboCustomers.DataSource = customers;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				waitForm.Close();
			}
		}

		private async void GetAllVehicles()
		{
			try
			{
				waitForm.Show(this);

				IEnumerable<VehicleModel> vehicles = await GetVehiclesAsync(cancellationToken).ConfigureAwait(true);
				cboMake.DisplayMember = "Make";
				cboMake.ValueMember = "VehicleID";
				cboMake.DataSource = vehicles;

				cboModel.DisplayMember = "Model";
				cboMake.ValueMember = "VehicleID";
				cboModel.DataSource = vehicles;

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				waitForm.Close();
			}
		}

		static async Task<IEnumerable<CustomerModel>> GetCustomersAsync(CancellationToken cancellationToken)
		{
			try
			{
				IEnumerable<CustomerModel> customers = new List<CustomerModel>();

				using (var client = new HttpClient())
				{
					client.BaseAddress = new Uri("https://localhost:5001/");
					client.DefaultRequestHeaders.Accept.Clear();
					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

					using (var request = new HttpRequestMessage(HttpMethod.Get, $"api/customer/getcustomers"))
					{
						using (var response = await client
									.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(true))
						{
							if (response.IsSuccessStatusCode)
							{
								var responseContent = await response.Content.ReadAsStringAsync();

								IEnumerable<CustomerModel> result = await response.Content.ReadAsAsync<IEnumerable<CustomerModel>>();
								customers = result;
							}
							else
							{
								throw new Exception($"Source: frmNewBookings - GetCustomersAsync, Message: { response.StatusCode }");
							}

							response.Dispose();
							request.Dispose();
						}
					}
				}

				return customers;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + " Please make sure the API Service is started...");
				return null;
			}
		}

		static async Task<IEnumerable<VehicleModel>> GetVehiclesAsync(CancellationToken cancellationToken)
		{
			try
			{
				IEnumerable<VehicleModel> vehicles = new List<VehicleModel>();

				using (var client = new HttpClient())
				{
					client.BaseAddress = new Uri("https://localhost:5001/");
					client.DefaultRequestHeaders.Accept.Clear();
					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

					using (var request = new HttpRequestMessage(HttpMethod.Get, $"api/vehicle/getvehicles"))
					{
						using (var response = await client
									.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(true))
						{
							if (response.IsSuccessStatusCode)
							{
								var responseContent = await response.Content.ReadAsStringAsync();

								IEnumerable<VehicleModel> result = await response.Content.ReadAsAsync<IEnumerable<VehicleModel>>();
								vehicles = result;
							}
							else
							{
								throw new Exception($"Source: frmNewBookings - GetVehiclesAsync, Message: { response.StatusCode }");
							}

							response.Dispose();
							request.Dispose();
						}
					}
				}

				return vehicles;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + " Please make sure the API Service is started...");
				return null;
			}
		}

		static async Task<BookingModel> AddBookingAsync(BookingModel booking, CancellationToken cancellationToken)
		{
			try
			{
				using (var client = new HttpClient())
				{
					client.BaseAddress = new Uri("https://localhost:5001/");
					client.DefaultRequestHeaders.Accept.Clear();
					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

					using (var request = new HttpRequestMessage(HttpMethod.Post, $"api/booking/addbooking"))
					{
						var json = JsonConvert.SerializeObject(booking);
						using (var stringContent = new StringContent(json, Encoding.UTF8, "application/json"))
						{
							request.Content = stringContent;
							using (var response = await client
										.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(true))
							{
								if (response.IsSuccessStatusCode)
								{
									var responseContent = await response.Content.ReadAsStringAsync();
									var myDetails = JsonConvert.DeserializeObject<BookingModel>(responseContent);

									booking = new BookingModel
									{
										BookingDate = myDetails.BookingDate,
										BookingId = myDetails.BookingId,
										Notes = myDetails.Notes,
									};
								}
								else
								{
									throw new Exception($"Source: frmCustomers - AddCustomerAsync, Message: { response.StatusCode }");
								}

								response.Dispose();
								request.Dispose();
							}
						}
					}
				}

				return booking;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + " Please make sure the API Service is started...");
				return null;
			}
		}

		private void cboCustomers_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboCustomers.SelectedIndex > -1)
			{
				txtCustomerID.Text = cboCustomers.SelectedValue.ToString();
			}
		}

		private void cboCustomerFormat(object sender, ListControlConvertEventArgs e)
		{
			string lastname = ((CustomerModel)e.ListItem).Name;
			string firstname = ((CustomerModel)e.ListItem).Surname;
			e.Value = lastname + " " + firstname;
		}

		private void cboMake_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboMake.SelectedIndex > -1)
			{
				txtVehicleID.Text = cboMake.SelectedValue.ToString();
			}
		}
	}
}

