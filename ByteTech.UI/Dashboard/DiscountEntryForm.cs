using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;
using ByteTech.Core.Models;
using ByteTech.Shared.Enum;

namespace ByteTech.UI.Dashboard
{
    public partial class DiscountEntryForm : System.Windows.Forms.Form
    {
        private readonly HttpClient _httpClient;
        private Discount _existingDiscount = null;

        public DiscountEntryForm()
        {
            InitializeComponent();

           
            var handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
            _httpClient = new HttpClient(handler);

            SetupComboBox();
            this.Text = "Add New Discount";
        }

  
        public DiscountEntryForm(Discount discountToEdit) : this()
        {
            _existingDiscount = discountToEdit;
            this.Text = "Edit Discount";

       
            txtCode.Text = _existingDiscount.Code;
            txtDescription.Text = _existingDiscount.Description;
            cmbType.SelectedItem = _existingDiscount.DiscountType;
            numValue.Value = _existingDiscount.Value;
            dtpStart.Value = _existingDiscount.StartDate;
            dtpEnd.Value = _existingDiscount.EndDate;
            chkIsActive.Checked = _existingDiscount.IsActive;
        }

        private void SetupComboBox()
        {
            cmbType.DataSource = Enum.GetValues(typeof(DiscountType));
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
       
            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                MessageBox.Show("Please enter a Discount Code.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
       
                var discountData = new Discount
                {
                    Id = _existingDiscount?.Id ?? 0,
                    Code = txtCode.Text.Trim(),
                    Description = txtDescription.Text?.Trim() ?? "No Description",
                    DiscountType = cmbType.SelectedItem != null ? (DiscountType)cmbType.SelectedItem : DiscountType.Percentage,
                    Value = numValue.Value,

                
                    StartDate = dtpStart.Value,
                    EndDate = dtpEnd.Value,

                    IsActive = chkIsActive.Checked,

                
                    MinimumOrderAmount = 0,
                    MaximumDiscountAmount = 0,
                    UsageLimit = 100,
                    UsageCount = _existingDiscount?.UsageCount ?? 0
                };

                HttpResponseMessage response;
                string apiUrl = "https://localhost:7296/api/Discounts";

    
                if (_existingDiscount == null)
                {
        
                    response = await _httpClient.PostAsJsonAsync(apiUrl, discountData);
                }
                else
                {
        
                    response = await _httpClient.PutAsJsonAsync($"{apiUrl}/{_existingDiscount.Id}", discountData);
                }

  
                if (response.IsSuccessStatusCode)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
        
                    var errorDetails = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Server Rejected Save: {response.StatusCode}\nDetails: {errorDetails}", "API Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not connect to API: {ex.Message}\nMake sure your API project is running!", "Connection Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

     
        private async void btnSave_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                MessageBox.Show("Please enter a Discount Code.");
                return;
            }

            try
            {
         
                var discountData = new Discount
                {
                    Id = _existingDiscount?.Id ?? 0,
                    Code = txtCode.Text.Trim(),
                    Description = txtDescription.Text ?? "No Description",
                    DiscountType = cmbType.SelectedItem != null ? (DiscountType)cmbType.SelectedItem : DiscountType.Percentage,
                    Value = numValue.Value,
                    StartDate = dtpStart.Value,
                    EndDate = dtpEnd.Value,
                    IsActive = chkIsActive.Checked,
                    MinimumOrderAmount = 0,
                    MaximumDiscountAmount = 0,
                    UsageLimit = 100,
                    UsageCount = _existingDiscount?.UsageCount ?? 0
                };

                string apiUrl = "https://localhost:7296/api/Discounts";
                HttpResponseMessage response;

           
                if (_existingDiscount == null)
                    response = await _httpClient.PostAsJsonAsync(apiUrl, discountData);
                else
                    response = await _httpClient.PutAsJsonAsync($"{apiUrl}/{_existingDiscount.Id}", discountData);

                if (response.IsSuccessStatusCode)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    var errorBody = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Server Rejected: {response.StatusCode}\nDetails: {errorBody}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection Error: {ex.Message}");
            }
        }
    }
    }
