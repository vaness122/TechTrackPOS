using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ByteTech.Core.Models;
using ByteTech.Core.Interfaces;

namespace ByteTech.UI.Dashboard
{
    public partial class CustomerForms : System.Windows.Forms.Form
    {
        private readonly ICustomerRepository _repo;
        private BindingSource _bindingSource = new BindingSource();
        private byte[]? _selectedImageBytes = null;
        private ByteTech.Core.Models.Customer? _selectedCustomer = null;

        public CustomerForms(ICustomerRepository repo)
        {
            InitializeComponent();
            _repo = repo;

         
            this.dgvCustomers.CellClick += dgvCustomers_CellClick;
            this.numCreditLimit.ValueChanged += numFields_ValueChanged;
            this.numBalance.ValueChanged += numFields_ValueChanged;

            this.btnBrowse.Click += btnBrowse_Click;
            this.btnNew.Click += (s, e) => ClearFields();
            this.btnAdd.Click += (s, e) => ClearFields(); 
            this.btnDelete.Click += btnDelete_Click;      
            this.txtSearch.TextChanged += txtSearch_TextChanged;
            this.btnRefresh.Click += btnRefresh_Click;
            this.Load += async (s, e) => await LoadDataAsync();

        
            numCreditLimit.Maximum = 9999999;
            numBalance.Maximum = 9999999;
            dgvCustomers.AutoGenerateColumns = false;
            ConfigureGrid();
        }

        private async void CustomersForm_Load(object sender, EventArgs e)
        {
            SetupComboBox();
            await LoadDataAsync();
        }

        private void ConfigureGrid()
        {
            dgvCustomers.Columns.Clear();
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID", Width = 40 });
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Name", HeaderText = "Customer Name", Width = 150 });
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TIN", HeaderText = "TIN", Width = 100 });

            var balanceCol = new DataGridViewTextBoxColumn { DataPropertyName = "Balance", HeaderText = "Balance" };
            balanceCol.DefaultCellStyle.Format = "N2";
            balanceCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCustomers.Columns.Add(balanceCol);

            dgvCustomers.DataSource = _bindingSource;
        }

        private async Task LoadDataAsync()
        {
            try
            {
                var customers = await _repo.GetAllAsync();
                _bindingSource.DataSource = new BindingList<ByteTech.Core.Models.Customer>(customers.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupComboBox()
        {
            cmbPriceLevel.DataSource = Enum.GetValues(typeof(PriceLevels));
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCustomers.Rows[e.RowIndex].DataBoundItem is ByteTech.Core.Models.Customer customer)
            {
                _selectedCustomer = customer;
                txtName.Text = customer.Name;
                txtTIN.Text = customer.TIN;
                txtBusinessStyle.Text = customer.BusinessStyle;
                txtAddress.Text = customer.Address;
                cmbPriceLevel.SelectedItem = customer.PriceLevel;
                numCreditLimit.Value = customer.CreditLimit;
                numBalance.Value = customer.Balance;
                txtRemarks.Text = customer.Remarks;
                chkIsInactive.Checked = customer.IsInactive;

                if (customer.Picture != null)
                {
                    using (var ms = new MemoryStream(customer.Picture))
                    {
                        pbPicture.Image = Image.FromStream(ms);
                        _selectedImageBytes = customer.Picture;
                    }
                }
                else { pbPicture.Image = null; _selectedImageBytes = null; }

                btnSave.Text = "Update Record";
            }
        }



        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedCustomer == null)
            {
                MessageBox.Show("Please select a customer from the list first.");
                return;
            }

            var result = MessageBox.Show($"Are you sure you want to delete {_selectedCustomer.Name}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                await _repo.DeleteAsync(_selectedCustomer.Id);
                ClearFields();
                await LoadDataAsync();
                MessageBox.Show("Customer deleted successfully.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filter = txtSearch.Text.ToLower().Trim();
            if (string.IsNullOrWhiteSpace(filter))
            {
                dgvCustomers.DataSource = _bindingSource;
            }
            else
            {
                var fullList = (BindingList<ByteTech.Core.Models.Customer>)_bindingSource.DataSource;
                var filtered = fullList.Where(c => c.Name.ToLower().Contains(filter) ||
                                                  (c.TIN != null && c.TIN.Contains(filter))).ToList();
                dgvCustomers.DataSource = filtered;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "Images|*.jpg;*.png;*.jpeg" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbPicture.Image = Image.FromFile(ofd.FileName);
                    _selectedImageBytes = File.ReadAllBytes(ofd.FileName);
                }
            }
        }

        private void numFields_ValueChanged(object sender, EventArgs e)
        {
            decimal available = numCreditLimit.Value - numBalance.Value;
            txtAvailableCredit.Text = available.ToString("N2");
            txtAvailableCredit.ForeColor = available < 0 ? Color.Red : Color.DarkGreen;
        }

        private void ClearFields()
        {
            _selectedCustomer = null;
            txtName.Clear(); txtTIN.Clear(); txtBusinessStyle.Clear();
            txtAddress.Clear(); txtRemarks.Clear(); txtAvailableCredit.Clear();
            numCreditLimit.Value = 0; numBalance.Value = 0;
            pbPicture.Image = null; _selectedImageBytes = null;
            chkIsInactive.Checked = false;
            btnSave.Text = "Save New";
        }

        private async void btnRefresh_Click(object sender, EventArgs e) => await LoadDataAsync();

        private void btnAdd_Click(object sender, EventArgs e)
        {
          
            using (var addForm = new CustomerAddForm(_repo))
            {
            
                var result = addForm.ShowDialog();

           
                if (result == DialogResult.OK)
                {
          
                    _ = LoadDataAsync();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (dgvCustomers.CurrentRow != null && dgvCustomers.CurrentRow.DataBoundItem is Customer selectedCustomer)
            {
       
                using (var editForm = new CustomerAddForm(_repo, selectedCustomer))
                {
                 
                    editForm.Text = "Edit Customer Details";

        
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                   
                        _ = LoadDataAsync();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a customer from the list to edit.", "Selection Required",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnSave_Click_1(object sender, EventArgs e)
        {
 
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a Customer Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                {
                    customer.PriceLevel = (PriceLevels)cmbPriceLevel.SelectedItem;
                }


                customer.CreditLimit = numCreditLimit.Value;
                customer.Balance = numBalance.Value;

               customer.IsInactive = chkIsInactive.Checked;
                customer.Picture = _selectedImageBytes;

  
                if (_selectedCustomer == null)
                {
                    await _repo.AddAsync(customer);
                    MessageBox.Show("New customer saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show($"An error occurred while saving: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}