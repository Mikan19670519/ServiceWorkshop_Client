using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkshopService;
using WorkshopService.Models;

namespace ServiceWorkshop
{
	public partial class frmCustomers : Form
	{
		static CancellationToken cancellationToken = new CancellationToken();

		WaitWnd.WaitWndFun waitForm = new WaitWnd.WaitWndFun();

		public frmCustomers()
		{
			InitializeComponent();
			GetAllCustomers();
		}

		private void btnAddNewCustomer_Click(object sender, EventArgs e)
		{
			frmAddEditCustomer myNewForm = new frmAddEditCustomer();
			myNewForm.ShowDialog();
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
					DateUpdated = DateTime.Now,
					CustomerID = txtCustomerId.Text == string.Empty ? new Guid() : Guid.Parse(txtCustomerId.Text)
				};

				if (txtCustomerId.Text == string.Empty)
				{
					await AddCustomerAsync(customer, cancellationToken).ConfigureAwait(true);
				}
				else
				{
					await UpdateCustomerInfoAsync(customer, cancellationToken).ConfigureAwait(true);
				}

				btnSave.Enabled = true;

				GetAllCustomers();
				MessageBox.Show($" {customer.Name} successfully saved...");
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

					IEnumerable<CustomerModel> customers = await GetCustomersByNameAsync(txtSearch.Text, cancellationToken).ConfigureAwait(true);
					dtgCustomers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
					dtgCustomers.DataSource = customers;
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

		private void dtgCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex > -1)
			{
				DataGridViewRow row = this.dtgCustomers.Rows[e.RowIndex];
				txtCustomerId.Text = row.Cells["CustomerID"].Value.ToString();
				txtCustomerName.Text = row.Cells["Name"].Value.ToString();
				txtCustomerSurname.Text = row.Cells["Surname"].Value.ToString();
				txtCustomerContactNumber.Text = row.Cells["ContactNumber"].Value.ToString();

				btnDelete.Enabled = true;
				btnAddNewCustomer.Enabled = true;
			}
			else
			{
				btnDelete.Enabled = false;
				btnAddNewCustomer.Enabled = false;
			}
		}

		private async void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this customer", "Delete Customer", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					btnDelete.Enabled = false;
					waitForm.Show(this);

					CustomerModel customer = new CustomerModel
					{
						Name = txtCustomerName.Text.Trim(),
						Surname = txtCustomerSurname.Text.Trim(),
						ContactNumber = txtCustomerContactNumber.Text.Trim(),
						CustomerID = Guid.Parse(txtCustomerId.Text),
						DateUpdated = DateTime.Now,
					};

					await DeleteCustomerAsync(customer, cancellationToken).ConfigureAwait(true);

					txtCustomerContactNumber.Text = "";
					txtCustomerId.Text = "";
					txtCustomerName.Text = "";
					txtCustomerSurname.Text = "";

					GetAllCustomers();
					MessageBox.Show($" {customer.Name} successfully deleted...");
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

		static async Task DeleteCustomerAsync(CustomerModel customer, CancellationToken cancellationToken)
		{
			try
			{
				using (var client = new HttpClient())
				{
					client.BaseAddress = new Uri("https://localhost:5001/");
					client.DefaultRequestHeaders.Accept.Clear();
					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

					using (var request = new HttpRequestMessage(HttpMethod.Delete, $"api/customer/deletecustomer"))
					{
						var json = JsonConvert.SerializeObject(customer);
						using (var stringContent = new StringContent(json, Encoding.UTF8, "application/json"))
						{
							request.Content = stringContent;
							using (var response = await client
										.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(true))
							{
								if (!response.IsSuccessStatusCode)
								{
									throw new Exception($"Source: frmCustomers - DeleteCustomerAsync, Message: { response.StatusCode }");
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

		static async Task UpdateCustomerInfoAsync(CustomerModel customer, CancellationToken cancellationToken)
		{
			try
			{
				using (var client = new HttpClient())
				{
					client.BaseAddress = new Uri("https://localhost:5001/");
					client.DefaultRequestHeaders.Accept.Clear();
					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

					using (var request = new HttpRequestMessage(HttpMethod.Put, $"api/customer/updatecustomer"))
					{
						var json = JsonConvert.SerializeObject(customer);
						using (var stringContent = new StringContent(json, Encoding.UTF8, "application/json"))
						{
							request.Content = stringContent;
							using (var response = await client
										.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(true))
							{
								if (!response.IsSuccessStatusCode)
								{
									throw new Exception($"Source: frmCustomers - UpdateCustomerInfoAsync, Message: { response.StatusCode }");
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
									throw new Exception($"Source: frmCustomers - AddCustomerAsync, Message: { response.StatusCode }");
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
								throw new Exception($"Source: frmCustomers - GetCustomersAsync, Message: { response.StatusCode }");
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

		static async Task<IEnumerable<CustomerModel>> GetCustomersByNameAsync(string customer, CancellationToken cancellationToken)
		{
			try
			{
				IEnumerable<CustomerModel> customers = new List<CustomerModel>();

				using (var client = new HttpClient())
				{
					client.BaseAddress = new Uri("https://localhost:5001/");
					client.DefaultRequestHeaders.Accept.Clear();
					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

					using (var request = new HttpRequestMessage(HttpMethod.Post, $"api/customer/getcustomersbyname/{customer}"))
					{
						var parameters = new Dictionary<string, string> { { "customer", customer } };
						var encodedContent = new FormUrlEncodedContent(parameters);

						request.Content = encodedContent;
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
								throw new Exception($"Source: frmAddEditCustomer - GetCustomersByNameAsync, Message: { response.StatusCode }");
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

		private async void GetAllCustomers()
		{
			try
			{
				waitForm.Show(this);

				IEnumerable<CustomerModel> customers = await GetCustomersAsync(cancellationToken).ConfigureAwait(true);
				dtgCustomers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
				dtgCustomers.DataSource = customers;

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

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			GetAllCustomers();
		}
	}
}
