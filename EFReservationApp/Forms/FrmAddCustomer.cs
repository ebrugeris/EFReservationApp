using EFReservationApp.Models;
using EFReservationApp.Services;

namespace EFReservationApp.Forms
{
    public partial class FrmAddCustomer : Form
    {
        public FrmAddCustomer()
        {
            InitializeComponent();
        }
        CustomerServices customerServices = new CustomerServices();
        AcademyRestaurantContext context = new AcademyRestaurantContext();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer();
                customer.Name = txtName.Text.Trim();
                customer.Surname = txtSurname.Text.Trim();
                customer.Email = txtEmail.Text.Trim();
                customer.Phone = txtPhone.Text.Trim();
                customer.Address = txtAddress.Text.Trim();

                customerServices.Add(customer);
                LoadData();
                MessageBox.Show("Customer added successfully.");
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred");
            }
        }

        private void FrmAddCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            dgvCustomers.DataSource = customerServices.GetAll();
        }
        int selectedCustomerId;

        private void btnDelete_Click(object sender, EventArgs e)
        {
            selectedCustomerId = Convert.ToInt32(dgvCustomers.CurrentRow.Cells["Id"].Value);
            var customer = context.Customers.FirstOrDefault(c => c.Id == selectedCustomerId);
            if (customer != null)
            {
                customerServices.Delete(customer);
            }      
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                selectedCustomerId = Convert.ToInt32(dgvCustomers.CurrentRow.Cells["Id"].Value);
                var customer = context.Customers.FirstOrDefault(c => c.Id == selectedCustomerId);

                customer.Name = txtName.Text.Trim();
                customer.Surname = txtSurname.Text.Trim();
                customer.Email = txtEmail.Text.Trim();
                customer.Phone = txtPhone.Text.Trim();
                customer.Address = txtAddress.Text.Trim();

                customerServices.Update(customer);
                context.SaveChanges();
                LoadData();

                MessageBox.Show("Customer updated successfully.");
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred");
            }
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedCustomerId = Convert.ToInt32(dgvCustomers.CurrentRow.Cells["Id"].Value);
            Customer customer = context.Customers.FirstOrDefault(c => c.Id == selectedCustomerId);

            txtName.Text = customer.Name;
            txtSurname.Text = customer.Surname;
            txtEmail.Text = customer.Email;
            txtPhone.Text = customer.Phone;
            txtAddress.Text = customer.Address;
        }
    }
}
