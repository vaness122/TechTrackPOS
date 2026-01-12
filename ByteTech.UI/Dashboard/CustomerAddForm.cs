using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ByteTech.Core.Models;
using ByteTech.Core.Interfaces;

namespace ByteTech.UI.Dashboard
{
    public partial class CustomerAddForm : System.Windows.Forms.Form
    {

        private readonly ICustomerRepository _repo;
        private byte[] _selectedImageBytes = null;
        private Customer _selectedCustomer = null;


        public CustomerAddForm(ICustomerRepository customerRepo, Customer customerToEdit = null)
        {
            InitializeComponent();


            _repo = customerRepo;
            _selectedCustomer = customerToEdit;


            numCreditLimit.ValueChanged += CalculateAvailableCredit;
            numBalance.ValueChanged += CalculateAvailableCredit;
        }

        private void CustomerAddForm_Load(object sender, EventArgs e)
        {

            cmbPriceLevel.DataSource = Enum.GetValues(typeof(PriceLevels));

            if (_selectedCustomer != null)
            {
                LoadCustomerData();
                btnSaves.Text = "Update Customer";
            }
            else
            {
       
                cmbPriceLevel.SelectedIndex = 0;
            }
        }

        private void CalculateAvailableCredit(object sender, EventArgs e)
        {

            decimal available = numCreditLimit.Value - numBalance.Value;
            txtAvailableCredit.Text = available.ToString("N2");


            txtAvailableCredit.ForeColor = available < 0 ? Color.Red : Color.Black;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "Images|*.jpg;*.png;*.jpeg", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbPicture.Image = Image.FromFile(ofd.FileName);
                    _selectedImageBytes = File.ReadAllBytes(ofd.FileName);
                }
            }
        }

        private async void btnSaves_Click(object sender, EventArgs e)
        {
  
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a Customer Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                var customer = _selectedCustomer ?? new Customer();

                customer.Name = txtName.Text.Trim();
                customer.TIN = txtTIN.Text.Trim();
                customer.BusinessStyle = txtBusinessStyle.Text.Trim();
                customer.Address = txtAddress.Text.Trim();
                customer.Remarks = txtRemarks.Text.Trim();
                customer.PriceLevel = (PriceLevels)cmbPriceLevel.SelectedItem;
                customer.CreditLimit = numCreditLimit.Value;
                customer.Balance = numBalance.Value;
                customer.IsInactive = chkIsInactive.Checked;
                customer.Picture = _selectedImageBytes;

                if (_selectedCustomer == null)
                {
                    await _repo.AddAsync(customer);
                    MessageBox.Show("New customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    await _repo.UpdateAsync(customer);
                    MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadCustomerData()
        {
            txtName.Text = _selectedCustomer.Name;
            txtTIN.Text = _selectedCustomer.TIN;
            txtBusinessStyle.Text = _selectedCustomer.BusinessStyle;
            txtAddress.Text = _selectedCustomer.Address;
            txtRemarks.Text = _selectedCustomer.Remarks;
            cmbPriceLevel.SelectedItem = _selectedCustomer.PriceLevel;
            numCreditLimit.Value = _selectedCustomer.CreditLimit;
            numBalance.Value = _selectedCustomer.Balance;
            chkIsInactive.Checked = _selectedCustomer.IsInactive;

            if (_selectedCustomer.Picture != null)
            {
                _selectedImageBytes = _selectedCustomer.Picture;
                using (var ms = new MemoryStream(_selectedCustomer.Picture))
                {
                    pbPicture.Image = Image.FromStream(ms);
                }
            }
            CalculateAvailableCredit(null, null);
        }

        private async void btnSaves_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Customer Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            try
            {
        
                var customer = _selectedCustomer ?? new ByteTech.Core.Models.Customer();


                customer.Name = txtName.Text.Trim();
                customer.TIN = txtTIN.Text.Trim();
                customer.BusinessStyle = txtBusinessStyle.Text.Trim();
                customer.Address = txtAddress.Text.Trim();
                customer.Remarks = txtRemarks.Text.Trim();

                if (cmbPriceLevel.SelectedItem != null)
                    customer.PriceLevel = (PriceLevels)cmbPriceLevel.SelectedItem;

                customer.CreditLimit = numCreditLimit.Value;
                customer.Balance = numBalance.Value;
                customer.IsInactive = chkIsInactive.Checked;

           
                customer.Picture = _selectedImageBytes;

    
                if (_selectedCustomer == null)
                {
       
                    await _repo.AddAsync(customer);
                    MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
        
                    await _repo.UpdateAsync(customer);
                    MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

         
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                var result = MessageBox.Show("Are you sure you want to discard your changes?",
                                           "Confirm",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);

                if (result == DialogResult.No) return;
            }

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnBrowse_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
        
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "Select Customer Picture";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                   
                        byte[] imageBytes = File.ReadAllBytes(ofd.FileName);
                        _selectedImageBytes = imageBytes;

                        using (var ms = new MemoryStream(imageBytes))
                        {
                            pbPicture.Image = Image.FromStream(ms);
                            pbPicture.SizeMode = PictureBoxSizeMode.Zoom; 
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}", "Image Error",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}