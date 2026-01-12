using System;
using System.Windows.Forms;
using ByteTech.Core.Interfaces; 

namespace ByteTech.UI.Dashboard
{
    public partial class Admin_Dashboard : System.Windows.Forms.Form
    {
        private readonly ICustomerRepository _customerRepo;
        public Admin_Dashboard(ICustomerRepository customerRepo)
        {
            InitializeComponent();
            _customerRepo = customerRepo;
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            DiscountListForm discountListForm = new DiscountListForm();
            discountListForm.ShowDialog();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new CustomerForms(_customerRepo);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Customers: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       

    }
}