using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using ByteTech.Core.Models;

namespace ByteTech.UI.Dashboard
{
    public partial class DiscountListForm : System.Windows.Forms.Form
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private List<Discount> _allDiscounts = new List<Discount>();

        public DiscountListForm()
        {
            InitializeComponent();
     
            dgvDiscounts.DataError += (s, e) => { e.ThrowException = false; };
            this.Load += async (s, e) => await LoadData();
        }

        private async Task LoadData()
        {
            try
            {
                var discounts = await _httpClient.GetFromJsonAsync<List<Discount>>("https://localhost:7296/api/Discounts");
                if (discounts != null)
                {
                    _allDiscounts = discounts;
                    UpdateGrid(_allDiscounts);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load discounts: {ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateGrid(List<Discount> list)
        {
            dgvDiscounts.DataSource = null;
            dgvDiscounts.DataSource = list;
            if (dgvDiscounts.Columns.Contains("Orders")) dgvDiscounts.Columns["Orders"].Visible = false;
            dgvDiscounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDiscounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }



        private async void btnAdd_Click_1(object sender, EventArgs e)
        {
      
            using (var entryForm = new DiscountEntryForm())
            {
                if (entryForm.ShowDialog() == DialogResult.OK)
                {
                    await LoadData(); 
                }
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDiscounts.CurrentRow?.DataBoundItem is Discount selected)
            {
                using (var entryForm = new DiscountEntryForm(selected))
                {
                    if (entryForm.ShowDialog() == DialogResult.OK)
                    {
                        await LoadData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a discount to edit.");
            }
        }

        private async void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvDiscounts.CurrentRow?.DataBoundItem is Discount selected)
            {
                var confirm = MessageBox.Show($"Delete {selected.Code}?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    await _httpClient.DeleteAsync($"https://localhost:7296/api/Discounts/{selected.Id}");
                    await LoadData();
                }
            }
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            string filter = txtSearch.Text.ToLower().Trim();
            if (string.IsNullOrEmpty(filter) || filter == "search:")
            {
                UpdateGrid(_allDiscounts);
                return;
            }

            var filtered = _allDiscounts.Where(d =>
                d.Code.ToLower().Contains(filter) ||
                (d.Description != null && d.Description.ToLower().Contains(filter))
            ).ToList();
            UpdateGrid(filtered);
        }

        private async void btnRefresh_Click_1(object sender, EventArgs e) => await LoadData();

        private async void btnAdd_Click(object sender, EventArgs e)
        {
    
            using (DiscountEntryForm entryForm = new DiscountEntryForm())
            {
               
                DialogResult result = entryForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    
                    await LoadData();
                }
            }
        }
    }
}