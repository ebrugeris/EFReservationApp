using EFReservationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFReservationApp.Services
{
    public class CustomerServices : IService<Customer>
    {
        AcademyRestaurantContext context = new AcademyRestaurantContext();

        public Customer Add(Customer value)
        {
            context.Customers.Add(value);
            context.SaveChanges();

            return value;
        }
        public void Update(Customer value)
        {
            var foundCustomer = context.Customers.FirstOrDefault(c => c.Id == value.Id);

            if (foundCustomer != null)
            {
                foundCustomer.Name = value.Name;
                foundCustomer.Surname = value.Surname;
                foundCustomer.Address = value.Address;
                foundCustomer.Email = value.Email;
                foundCustomer.Phone = value.Phone;
            }
        }
        public void Delete(Customer value)
        {
            Customer customer = context.Customers.FirstOrDefault(c => c.Id == value.Id);

            customer.IsDeleted = true;
            context.SaveChanges();
        }
        public List<Customer> GetAll()
        {
            List<Customer> customers = context.Customers.Where(c => c.IsDeleted == false).ToList();
            return customers;
        }
    }
}
