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
    public partial class FrmAddReservation : Form
    {
        public FrmAddReservation()
        {
            InitializeComponent();
        }
        AcademyRestaurantContext context = new AcademyRestaurantContext();
        CustomerServices customerServices = new CustomerServices();
        ReservationServices reservationServices = new ReservationServices();
        private void FrmAddReservation_Load(object sender, EventArgs e)
        {
            cmbCustomer.DataSource = customerServices.GetAll();
            LoadData();
        }
        public void LoadData()
        {
            List<Reservation> reservations = reservationServices.GetAll();
            dgvReservations.DataSource = reservations;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = (Customer)cmbCustomer.SelectedItem;

                Reservation reservation = new Reservation();
                reservation.CustomerId = reservation.Id;
                reservation.ReservationDate = Convert.ToDateTime(dtpDate.Value);
                reservation.Note = txtNote.Text;

                reservationServices.Add(reservation);
                LoadData();
                MessageBox.Show("Reservation added successfully.");
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                selectedReservationId = Convert.ToInt32(dgvReservations.CurrentRow.Cells["Id"].Value);
                var reservation = context.Reservations.FirstOrDefault(r => r.Id == selectedReservationId);

                Customer customer = (Customer)cmbCustomer.SelectedItem;

                reservation.ReservationDate = Convert.ToDateTime(dtpDate.Value);
                reservation.Note= txtNote.Text;
                reservation.CustomerId = customer.Id;

                reservationServices.Update(reservation);
                context.SaveChanges();
                LoadData();

                MessageBox.Show("Reservation updated successfully.");
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred");
            }
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        int selectedReservationId;
        private void dgvReservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedReservationId = Convert.ToInt32(dgvReservations.CurrentRow.Cells["Id"].Value);
            Reservation reservation = context.Reservations.FirstOrDefault(r => r.Id == selectedReservationId);

            txtNote.Text = reservation.Note;
            dtpDate.Value = Convert.ToDateTime(reservation.ReservationDate);
            Customer customer = (Customer)cmbCustomer.SelectedItem;
            cmbCustomer.SelectedItem = Convert.ToInt32(reservation.Id);         
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedCustomerId = Convert.ToInt32(dgvReservations.CurrentRow.Cells["Id"].Value);
            var reservation = context.Reservations.FirstOrDefault(c => c.Id == selectedCustomerId);

            if (reservation != null)
            {
                reservationServices.Delete(reservation);
            }
            LoadData();
        }
    }
}
