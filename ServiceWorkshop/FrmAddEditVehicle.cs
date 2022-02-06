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

namespace WorkshopService
{
	public partial class FrmAddEditVehicle : Form
	{
		static HttpClient client = new HttpClient();
		static CancellationToken cancellationToken = new CancellationToken();

		WaitWnd.WaitWndFun waitForm = new WaitWnd.WaitWndFun();

		public FrmAddEditVehicle()
		{
			InitializeComponent();
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
				};

				await AddVehicleAsync(vehicle, cancellationToken).ConfigureAwait(true);

				btnSave.Enabled = true;
				MessageBox.Show($" {vehicle.Make} successfully added...");
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
									throw new Exception($"Source: frmAddEditVehicle - AddVehicleAsync, Message: { response.StatusCode }");
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

	}
}
