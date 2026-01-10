namespace ByteTech.UI.Dashboard
{
    // Using the full path ensures it converts to the correct type for Application.Run
    public partial class Admin_Dashboard : System.Windows.Forms.Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            DiscountListForm discountListForm = new DiscountListForm();
            discountListForm.ShowDialog();

        }
    }
}