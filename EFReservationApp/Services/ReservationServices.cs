using EFReservationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFReservationApp.Services
{
    public class ReservationServices : IService<Reservation>
    {
        AcademyRestaurantContext context = new AcademyRestaurantContext();
        public Reservation Add(Reservation value)
        {

            context.Reservations.Add(value);
            context.SaveChanges();

            return value;
        }

        public void Delete(Reservation value)
        {
            Reservation reservation = context.Reservations.FirstOrDefault(r => r.Id == value.Id);

            reservation.IsDeleted = true;
            context.SaveChanges();
        }

        public List<Reservation> GetAll()
        {
            List<Reservation> reservations = context.Reservations.Where(r => r.IsDeleted == false).ToList();
            return reservations;
        }

        public void Update(Reservation value)
        {
            var reservation = context.Reservations.FirstOrDefault(r => r.Id == value.Id);

            if (reservation != null)
            {
                reservation.Customer = value.Customer;
                reservation.ReservationDate = value.ReservationDate;
                reservation.Note = value.Note;
            }
        }
    }
}
