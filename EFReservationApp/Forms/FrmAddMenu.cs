using EFReservationApp.Models;
using EFReservationApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EFReservationApp.Forms
{
    public partial class FrmAddMenu : Form
    {
        public FrmAddMenu()
        {
            InitializeComponent();
        }
        AcademyRestaurantContext context = new AcademyRestaurantContext();
        MenuServices menuServices = new MenuServices();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Menu menu = new Menu();
                menu.Title = txtTitle.Text.Trim();
                menu.Description = txtdescription.Text.Trim();
                menu.Price = Convert.ToDecimal(txtPrice.Text);

                menuServices.Add(menu);
                LoadData();
                MessageBox.Show("Menu added successfully.");
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred");
            }
        }

        private void FrmAddMenu_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            dgvMenus.DataSource = menuServices.GetAll();
        }
        int selectedMenuId;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                selectedMenuId = Convert.ToInt32(dgvMenus.CurrentRow.Cells["Id"].Value);
                var menu = context.Menus.FirstOrDefault(m => m.Id == selectedMenuId);

                menu.Title = txtTitle.Text.Trim();
                menu.Description = txtdescription.Text.Trim();
                menu.Price = Convert.ToDecimal(txtPrice.Text);

                menuServices.Update(menu);
                context.SaveChanges();
                LoadData();

                MessageBox.Show("Customer updated successfully.");
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            selectedMenuId = Convert.ToInt32(dgvMenus.CurrentRow.Cells["Id"].Value);
            var menu = context.Menus.FirstOrDefault(c => c.Id == selectedMenuId);
            if (menu != null)
            {
                menuServices.Delete(menu);
            }
            LoadData();
        }

        private void dgvMenus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedMenuId = Convert.ToInt32(dgvMenus.CurrentRow.Cells["Id"].Value);
            Menu menu = context.Menus.FirstOrDefault(m => m.Id == selectedMenuId);

            txtTitle.Text = menu.Title;
            txtdescription.Text = menu.Description;
            txtPrice.Text = menu.Price.ToString();     
        }
    }
}
