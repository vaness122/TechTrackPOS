using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using ByteTech.Core.Models; 

namespace ByteTech.UI.Dashboard
{

    public partial class DiscountListForm : Form
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public DiscountListForm()
        {
            InitializeComponent();

            this.Load += DiscountListForm_Load;
        }

        private async void DiscountListForm_Load(object sender, EventArgs e)
        {
            try
            {

                var discounts = await _httpClient.GetFromJsonAsync<List<Discount>>("https://localhost:7296/api/Discounts");

                if (discounts != null)
                {

                    dgvDiscounts.DataSource = discounts;


                    if (dgvDiscounts.Columns.Contains("Orders"))
                        dgvDiscounts.Columns["Orders"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching data: {ex.Message}", "API Connection Error");
            }
        }

        private void dgvDiscounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}