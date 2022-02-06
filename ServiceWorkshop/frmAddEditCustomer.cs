using Newtonsoft.Json;
using ServiceWorkshop;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkshopService.Models;

namespace WorkshopService
{
	public partial class frmAddEditCustomer : Form
	{
		static HttpClient client = new HttpClient();
		static CancellationToken cancellationToken = new CancellationToken();

		WaitWnd.WaitWndFun waitForm = new WaitWnd.WaitWndFun();

		public frmAddEditCustomer()
		{
			InitializeComponent();
			//_ = GetCustomersAsync();
		}

		private async Task GetCustomersAsync()
		{
			client.BaseAddress = new Uri("https://localhost:5001/");
			client.DefaultRequestHeaders.Accept.Clear();
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

			CustomerModel customer = new CustomerModel
			{
				Name = "Michael",
				Surname = "Lubbe",
				ContactNumber = "9999999999",
				CustomerID = new Guid("DF8332DF-5559-46CC-B7FA-CBD5C141F0C8")
			};

			await AddCustomerAsync(customer, cancellationToken).ConfigureAwait(true);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			ActiveForm.Close();
		}

		private async void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				btnSave.Enabled = false;
				waitForm.Show(this);

				CustomerModel customer = new CustomerModel
				{
					Name = txtCustomerName.Text.Trim(),
					Surname = txtCustomerSurname.Text.Trim(),
					ContactNumber = txtCustomerContactNumber.Text.Trim(),
					DateAdded = DateTime.Now
				};

				await AddCustomerAsync(customer, cancellationToken).ConfigureAwait(true);

				btnSave.Enabled = true;
				MessageBox.Show($" {customer.Name} successfully added...");
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

		static async Task<CustomerModel> GetCustomerByIdAsync(CustomerModel customer, CancellationToken cancellationToken)
		{
			try
			{
				using (var client = new HttpClient())
				{
					client.BaseAddress = new Uri("https://localhost:5001/");
					client.DefaultRequestHeaders.Accept.Clear();
					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

					using (var request = new HttpRequestMessage(HttpMethod.Post, $"api/customer/getcustomerdetailsbyid"))
					{
						var json = JsonConvert.SerializeObject(customer);
						using (var stringContent = new StringContent(json, Encoding.UTF8, "application/json"))
						{
							request.Content = stringContent;
							using (var response = await client
										.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(true))
							{
								if (response.IsSuccessStatusCode)
								{
									var responseContent = await response.Content.ReadAsStringAsync();
									var myDetails = JsonConvert.DeserializeObject<CustomerModel>(responseContent);

									customer = new CustomerModel
									{
										Name = myDetails.Name,
										Surname = myDetails.Surname,
										ContactNumber = myDetails.ContactNumber,
										CustomerID = myDetails.CustomerID
									};
								}
								else
								{
									throw new Exception($"Source: frmAddEditCustomer - GetCustomerByIdAsync, Message: { response.StatusCode }");
								}

								response.Dispose();
								request.Dispose();
							}
						}
					}
				}

				return customer;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + " Please make sure the API Service is started...");
				return null;
			}
		}

		static async Task<CustomerModel> AddCustomerAsync(CustomerModel customer, CancellationToken cancellationToken)
		{
			try
			{
				using (var client = new HttpClient())
				{
					client.BaseAddress = new Uri("https://localhost:5001/");
					client.DefaultRequestHeaders.Accept.Clear();
					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

					using (var request = new HttpRequestMessage(HttpMethod.Post, $"api/customer/addcustomer"))
					{
						var json = JsonConvert.SerializeObject(customer);
						using (var stringContent = new StringContent(json, Encoding.UTF8, "application/json"))
						{
							request.Content = stringContent;
							using (var response = await client
										.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(true))
							{
								if (response.IsSuccessStatusCode)
								{
									var responseContent = await response.Content.ReadAsStringAsync();
									var myDetails = JsonConvert.DeserializeObject<CustomerModel>(responseContent);

									customer = new CustomerModel
									{
										Name = myDetails.Name,
										Surname = myDetails.Surname,
										ContactNumber = myDetails.ContactNumber,
										CustomerID = myDetails.CustomerID
									};
								}
								else
								{
									throw new Exception($"Source: frmAddEditCustomer - AddCustomerAsync, Message: { response.StatusCode }");
								}

								response.Dispose();
								request.Dispose();
							}
						}
					}
				}

				return customer;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + " Please make sure the API Service is started...");
				return null;
			}
		}
	}
}
