using EFReservationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EFReservationApp.Services
{
    public interface IService <T> where T: class 
    {
        public T Add(T value);
        public void Update(T value);
        public void Delete(T value);
        public List<T> GetAll();
    }
}
