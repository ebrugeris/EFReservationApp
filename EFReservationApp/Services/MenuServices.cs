using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFReservationApp.Models;
using EFReservationApp.Services;

namespace EFReservationApp.Services
{
    public class MenuServices : IService<Menu>
    {
        AcademyRestaurantContext context = new AcademyRestaurantContext();
        public Menu Add(Menu value)
        {
            context.Menus.Add(value);
            context.SaveChanges();

            return value;
        }
        public void Delete(Menu value)
        {
            Menu menu = context.Menus.FirstOrDefault(m => m.Id == value.Id);

            menu.IsDeleted = true;
            context.SaveChanges();
        }
        public List<Menu> GetAll()
        {
            List<Menu> menus = context.Menus.Where(m => m.IsDeleted == false).ToList();
            return menus;
        }
        public void Update(Menu value)
        {
            var menu = context.Menus.FirstOrDefault(m => m.Id == value.Id);

            if (menu != null)
            {
                menu.Title = value.Title;
                menu.Description = value.Description;
                menu.Price = value.Price;
            }
        }
    }
}
