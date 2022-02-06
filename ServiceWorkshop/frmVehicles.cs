using Newtonsoft.Json;
using ServiceWorkshop.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkshopService;

namespace ServiceWorkshop
{
	public partial class frmVehicles : Form
	{
		static CancellationToken cancellationToken = new CancellationToken();

		WaitWnd.WaitWndFun waitForm = new WaitWnd.WaitWndFun();

		public frmVehicles()
		{
			InitializeComponent();
			GetAllVehicles();
		}

		private void btnAddNewVehicle_Click(object sender, EventArgs e)
		{
			FrmAddEditVehicle myNewForm = new FrmAddEditVehicle();
			myNewForm.ShowDialog();
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

					IEnumerable<VehicleModel> vehicles = await GetVehiclesByNameAsync(txtSearch.Text, cancellationToken).ConfigureAwait(true);
					dtgVehicles.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
					dtgVehicles.DataSource = vehicles;
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

		private void btnClose_Click(object sender, EventArgs e)
		{
			ActiveForm.Close();
		}

		static async Task DeleteVehicleAsync(VehicleModel vehicle, CancellationToken cancellationToken)
		{
			try
			{
				using (var client = new HttpClient())
				{
					client.BaseAddress = new Uri("https://localhost:5001/");
					client.DefaultRequestHeaders.Accept.Clear();
					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

					using (var request = new HttpRequestMessage(HttpMethod.Delete, $"api/vehicle/deletevehicle"))
					{
						var json = JsonConvert.SerializeObject(vehicle);
						using (var stringContent = new StringContent(json, Encoding.UTF8, "application/json"))
						{
							request.Content = stringContent;
							using (var response = await client
										.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(true))
							{
								if (!response.IsSuccessStatusCode)
								{
									throw new Exception($"Source: frmVehicles - DeleteVehicleAsync, Message: { response.StatusCode }");
								}

								response.Dispose();
								request.Dispose();
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + " Please make sure the API Service is started...");
			}
		}

		static async Task UpdateVehicleInfoAsync(VehicleModel vehicle, CancellationToken cancellationToken)
		{
			try
			{
				using (var client = new HttpClient())
				{
					client.BaseAddress = new Uri("https://localhost:5001/");
					client.DefaultRequestHeaders.Accept.Clear();
					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

					using (var request = new HttpRequestMessage(HttpMethod.Put, $"api/vehicle/updatevehicle"))
					{
						var json = JsonConvert.SerializeObject(vehicle);
						using (var stringContent = new StringContent(json, Encoding.UTF8, "application/json"))
						{
							request.Content = stringContent;
							using (var response = await client
										.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(true))
							{
								if (!response.IsSuccessStatusCode)
								{
									throw new Exception($"Source: frmVehicles - UpdateVehicleInfoAsync, Message: { response.StatusCode }");
								}

								response.Dispose();
								request.Dispose();
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + " Please make sure the API Service is started...");
			}
		}

		static async Task<VehicleModel> AddVehicleAsync(VehicleModel vehicle, CancellationToken cancellationToken)
		{
			try
			{
				using (var client = new HttpClient())
				{
					client.BaseAddress = new Uri("https://localhost:5001/");
					client.DefaultRequestHeaders.Accept.Clear();
					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

					using (var request = new HttpRequestMessage(HttpMethod.Post, $"api/vehicle/addvehicle"))
					{
						var json = JsonConvert.SerializeObject(vehicle);
						using (var stringContent = new StringContent(json, Encoding.UTF8, "application/json"))
						{
							request.Content = stringContent;
							using (var response = await client
										.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(true))
							{
								if (response.IsSuccessStatusCode)
								{
									var responseContent = await response.Content.ReadAsStringAsync();
									var myDetails = JsonConvert.DeserializeObject<VehicleModel>(responseContent);

									vehicle = new VehicleModel
									{
										Make = myDetails.Make,
										Model = myDetails.Model,
										RegNumber = myDetails.RegNumber,
										VehicleID = myDetails.VehicleID
									};
								}
								else
								{
									throw new Exception($"Source: frmVehicles - AddVehicleAsync, Message: { response.StatusCode }");
								}

								response.Dispose();
								request.Dispose();
							}
						}
					}
				}

				return vehicle;
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
								throw new Exception($"Source: frmVehicles - GetVehiclesAsync, Message: { response.StatusCode }");
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

		static async Task<IEnumerable<VehicleModel>> GetVehiclesByNameAsync(string vehicle, CancellationToken cancellationToken)
		{
			try
			{
				IEnumerable<VehicleModel> vehicles = new List<VehicleModel>();

				using (var client = new HttpClient())
				{
					client.BaseAddress = new Uri("https://localhost:5001/");
					client.DefaultRequestHeaders.Accept.Clear();
					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

					using (var request = new HttpRequestMessage(HttpMethod.Post, $"api/vehicle/getvehiclesbyname/{vehicle}"))
					{
						var parameters = new Dictionary<string, string> { { "vehicle", vehicle } };
						var encodedContent = new FormUrlEncodedContent(parameters);

						request.Content = encodedContent;
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
								throw new Exception($"Source: frmVehicles - GetVehiclesByNameAsync, Message: { response.StatusCode }");
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

		private async void GetAllVehicles()
		{
			waitForm.Show(this);

			IEnumerable<VehicleModel> vehicles = await GetVehiclesAsync(cancellationToken).ConfigureAwait(true);
			dtgVehicles.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
			dtgVehicles.DataSource = vehicles;

			waitForm.Close();
		}

		private async void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				btnSave.Enabled = false;
				waitForm.Show(this);

				VehicleModel vehicle = new VehicleModel
				{
					Make = txtMake.Text.Trim(),
					Model = txtModel.Text.Trim(),
					RegNumber = txtRegNo.Text.Trim(),
					VehicleID = txtVehicleId.Text == string.Empty ? new Guid() : Guid.Parse(txtVehicleId.Text)
				};

				if (txtVehicleId.Text == string.Empty)
				{
					await AddVehicleAsync(vehicle, cancellationToken).ConfigureAwait(true);
				}
				else
				{
					await UpdateVehicleInfoAsync(vehicle, cancellationToken).ConfigureAwait(true);
				}

				btnSave.Enabled = true;

				GetAllVehicles();
				MessageBox.Show($" {vehicle.Make} successfully saved...");
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

		private async void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this vehicle", "Delete Vehicle", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					btnDelete.Enabled = false;
					waitForm.Show(this);

					VehicleModel vehicle = new VehicleModel
					{
						Make = txtMake.Text.Trim(),
						Model = txtModel.Text.Trim(),
						RegNumber = txtRegNo.Text.Trim(),
						VehicleID = Guid.Parse(txtVehicleId.Text),
					};

					await DeleteVehicleAsync(vehicle, cancellationToken).ConfigureAwait(true);

					txtMake.Text = "";
					txtVehicleId.Text = "";
					txtModel.Text = "";
					txtRegNo.Text = "";

					GetAllVehicles();
					MessageBox.Show($" {vehicle.Make} successfully deleted...");
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

		private void dtgVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex > -1)
			{
				DataGridViewRow row = this.dtgVehicles.Rows[e.RowIndex];
				txtVehicleId.Text = row.Cells["VehicleID"].Value.ToString();
				txtMake.Text = row.Cells["Make"].Value.ToString();
				txtModel.Text = row.Cells["Model"].Value.ToString();
				txtRegNo.Text = row.Cells["RegNumber"].Value.ToString();

				btnDelete.Enabled = true;
				btnAddNewVehicle.Enabled = true;
			}
			else
			{
				btnDelete.Enabled = false;
				btnAddNewVehicle.Enabled = false;
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			GetAllVehicles();
		}
	}
}
