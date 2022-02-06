using Newtonsoft.Json;
using ServiceWorkshop.Models;
using System;
using System.Collections.Generic;
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
	public partial class frmBookings : Form
	{
		static CancellationToken cancellationToken = new CancellationToken();

		WaitWnd.WaitWndFun waitForm = new WaitWnd.WaitWndFun();

		public frmBookings()
		{
			InitializeComponent();
			GetAllBookings();
		}

		private async void btnSearch_Click(object sender, EventArgs e)
		{
			try
			{
				if (String.IsNullOrEmpty(txtSearch.Text))
				{
					MessageBox.Show("Please enter a search value.");
					txtSearch.Focus();
				}
				else
				{
					waitForm.Show(this);

					IEnumerable<BookingModel> bookings = await GetBookingsByCustomerNameAsync(txtSearch.Text, cancellationToken).ConfigureAwait(true);
					dtgBookings.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
					dtgBookings.DataSource = bookings;
				}
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

		private void btnAddBooking_Click(object sender, EventArgs e)
		{
			frmNewBooking myNewForm = new frmNewBooking();
			myNewForm.ShowDialog();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			ActiveForm.Close();
		}

		private async void GetAllBookings()
		{
			try
			{
				waitForm.Show(this);

				IEnumerable<BookingModel> bookings = await GetBookingsAsync(cancellationToken).ConfigureAwait(true);
				dtgBookings.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

				//Set AutoGenerateColumns False
				dtgBookings.AutoGenerateColumns = false;

				//Set Columns Count
				dtgBookings.ColumnCount = 10;

				//Add Columns
				dtgBookings.Columns[0].Name = "CustomerID";
				dtgBookings.Columns[0].HeaderText = "CustomerID";
				dtgBookings.Columns[0].DataPropertyName = "CustomerID";
				dtgBookings.Columns[0].Visible = false;

				dtgBookings.Columns[1].Name = "BookingID";
				dtgBookings.Columns[1].HeaderText = "BookingID";
				dtgBookings.Columns[1].DataPropertyName = "BookingID";
				dtgBookings.Columns[1].Visible = false;

				dtgBookings.Columns[2].Name = "VehicleID";
				dtgBookings.Columns[2].HeaderText = "VehicleID";
				dtgBookings.Columns[2].DataPropertyName = "VehicleID";
				dtgBookings.Columns[2].Visible = false;

				dtgBookings.Columns[3].Name = "Customer Name";
				dtgBookings.Columns[3].HeaderText = "Customer Name";
				dtgBookings.Columns[3].DataPropertyName = "CustomerName";

				dtgBookings.Columns[4].Name = "Contact No";
				dtgBookings.Columns[4].HeaderText = "Contact No";
				dtgBookings.Columns[4].DataPropertyName = "CustomerContactNumber";

				dtgBookings.Columns[5].Name = "Make";
				dtgBookings.Columns[5].HeaderText = "Make";
				dtgBookings.Columns[5].DataPropertyName = "VehicleMake";

				dtgBookings.Columns[6].Name = "VehicleModel";
				dtgBookings.Columns[6].HeaderText = "Model";
				dtgBookings.Columns[6].DataPropertyName = "VehicleModel";

				dtgBookings.Columns[7].Name = "RegistrationNo";
				dtgBookings.Columns[7].HeaderText = "Registration No";
				dtgBookings.Columns[7].DataPropertyName = "RegistrationNo";

				dtgBookings.Columns[8].Name = "Date";
				dtgBookings.Columns[8].HeaderText = "Booking Date";
				dtgBookings.Columns[8].DataPropertyName = "BookingDate";

				dtgBookings.Columns[9].Name = "Notes";
				dtgBookings.Columns[9].HeaderText = "Booking Notes";
				dtgBookings.Columns[9].DataPropertyName = "Notes";

				dtgBookings.DataSource = bookings;

				GetAllVehicles();
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
			IEnumerable<VehicleModel> vehicles = await GetVehiclesAsync(cancellationToken).ConfigureAwait(true);
			cboMake.DataSource = vehicles.Select(p => p.Make).ToList();
			cboMake.DisplayMember = "Make";

			cboModel.DataSource = vehicles.Select(p => p.Model).ToList();
			cboModel.DisplayMember = "Model";
		}

		static async Task<IEnumerable<BookingModel>> GetBookingsAsync(CancellationToken cancellationToken)
		{
			try
			{
				IEnumerable<BookingModel> bookings = new List<BookingModel>();

				using (var client = new HttpClient())
				{
					client.BaseAddress = new Uri("https://localhost:5001/");
					client.DefaultRequestHeaders.Accept.Clear();
					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

					using (var request = new HttpRequestMessage(HttpMethod.Get, $"api/booking/getbookings"))
					{
						using (var response = await client
									.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(true))
						{
							if (response.IsSuccessStatusCode)
							{
								IEnumerable<BookingModel> result = await response.Content.ReadAsAsync<IEnumerable<BookingModel>>();
								bookings = result;
							}
							else
							{
								throw new Exception($"Source: frmBooking - GetBookingsAsync, Message: { response.StatusCode }");
							}

							response.Dispose();
							request.Dispose();
						}
					}
				}

				return bookings;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + " Please make sure the API Service is started...");
				return null;
			}
		}

		static async Task<IEnumerable<BookingModel>> GetBookingsByCustomerNameAsync(string customer, CancellationToken cancellationToken)
		{
			try
			{
				IEnumerable<BookingModel> bookings = new List<BookingModel>();

				using (var client = new HttpClient())
				{
					client.BaseAddress = new Uri("https://localhost:5001/");
					client.DefaultRequestHeaders.Accept.Clear();
					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

					using (var request = new HttpRequestMessage(HttpMethod.Post, $"api/booking/getbookingsbycustomername/{customer}"))
					{
						var parameters = new Dictionary<string, string> { { "booking", customer } };
						var encodedContent = new FormUrlEncodedContent(parameters);

						request.Content = encodedContent;
						using (var response = await client
									.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(true))
						{
							if (response.IsSuccessStatusCode)
							{
								var responseContent = await response.Content.ReadAsStringAsync();

								IEnumerable<BookingModel> result = await response.Content.ReadAsAsync<IEnumerable<BookingModel>>();
								bookings = result;
							}
							else
							{
								throw new Exception($"Source: frmBooking - GetBookingsByNameAsync, Message: { response.StatusCode }");
							}

							response.Dispose();
							request.Dispose();
						}
					}
				}

				return bookings;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + " Please make sure the API Service is started...");
				return null;
			}
		}

		static async Task<IEnumerable<BookingModel>> GetBookingsByDateRangeAsync(string dateFrom, string dateTo, CancellationToken cancellationToken)
		{
			try
			{
				IEnumerable<BookingModel> bookings = new List<BookingModel>();

				using (var client = new HttpClient())
				{
					client.BaseAddress = new Uri("https://localhost:5001/");
					client.DefaultRequestHeaders.Accept.Clear();
					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

					using (var request = new HttpRequestMessage(HttpMethod.Post, $"api/booking/getbookingsbydaterange/{dateFrom.Replace("/", "-")}/{dateTo.Replace("/", "-")}"))
					{
						var parameters = new Dictionary<string, string> { 
							{ "dateFrom", dateFrom },
							{ "dateTo", dateTo }
						};

						var encodedContent = new FormUrlEncodedContent(parameters);
						request.Content = encodedContent;
						using (var response = await client
									.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(true))
						{
							if (response.IsSuccessStatusCode)
							{
								var responseContent = await response.Content.ReadAsStringAsync();

								IEnumerable<BookingModel> result = await response.Content.ReadAsAsync<IEnumerable<BookingModel>>();
								bookings = result;
							}
							else
							{
								throw new Exception($"Source: frmBooking - GetBookingsByNameAsync, Message: { response.StatusCode }");
							}

							response.Dispose();
							request.Dispose();
						}
					}
				}

				return bookings;
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

		static async Task<BookingModel> UpdateBookingInfoAsync(BookingModel booking, CancellationToken cancellationToken)
		{
			try
			{
				using (var client = new HttpClient())
				{
					client.BaseAddress = new Uri("https://localhost:5001/");
					client.DefaultRequestHeaders.Accept.Clear();
					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

					using (var request = new HttpRequestMessage(HttpMethod.Put, $"api/booking/updatebooking"))
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
										Notes = myDetails.Notes,
										BookingDate = myDetails.BookingDate,
										BookingId = myDetails.BookingId,
									};
								}
								else
								{
									throw new Exception($"Source: frmBookings - UpdateBookingInfoAsync, Message: { response.StatusCode }");
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

		private async void btnRefresh_Click(object sender, EventArgs e)
		{
			IEnumerable<BookingModel> bookings = await GetBookingsAsync(cancellationToken).ConfigureAwait(true);
			dtgBookings.DataSource = bookings;
			dtgBookings.Refresh();
			dtgBookings.Update();
		}

		private async void btnSearchByDate_Click(object sender, EventArgs e)
		{
			try
			{
				waitForm.Show(this);

				IEnumerable<BookingModel> bookings = await GetBookingsByDateRangeAsync(dtpFrom.Value.ToShortDateString(), dtpTo.Value.ToShortDateString(), cancellationToken).ConfigureAwait(true);
				dtgBookings.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
				dtgBookings.DataSource = bookings;
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

		private void dtgBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex > -1)
			{
				DataGridViewRow row = this.dtgBookings.Rows[e.RowIndex];
				txtCustomerId.Text = row.Cells["CustomerID"].Value.ToString();
				txtVehicleId.Text = row.Cells["VehicleID"].Value.ToString();
				txtBookingId.Text = row.Cells["BookingID"].Value.ToString();
				txtNotes.Text = row.Cells["Notes"].Value.ToString();
				txtRegNo.Text = row.Cells["RegistrationNo"].Value.ToString();
				dtpBookingDate.Value = Convert.ToDateTime(row.Cells["Date"].Value.ToString());

				int makeIndex = cboMake.FindString(row.Cells["Make"].Value.ToString());
				cboMake.SelectedIndex = makeIndex;
				int modelIndex = cboModel.FindString(row.Cells["VehicleModel"].Value.ToString());
				cboModel.SelectedIndex = modelIndex;

				btnUpdate.Enabled = true;
			}
			else
			{
				btnUpdate.Enabled = false;
			}
		}

		private async void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				btnUpdate.Enabled = false;
				waitForm.Show(this);

				BookingModel booking = new BookingModel
				{
					Notes = txtNotes.Text.Trim(),
					BookingDate = dtpBookingDate.Value,
					VehicleID = txtVehicleId.Text == string.Empty ? new Guid() : Guid.Parse(txtVehicleId.Text),
					CustomerID = txtCustomerId.Text == string.Empty ? new Guid() : Guid.Parse(txtCustomerId.Text),
					BookingId = txtBookingId.Text == string.Empty ? new Guid() : Guid.Parse(txtBookingId.Text)
				};

				await UpdateBookingInfoAsync(booking, cancellationToken).ConfigureAwait(true);

				btnUpdate.Enabled = true;

				GetAllBookings();
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
	}
}
