using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccinationProject.Controller.Repository;
using VaccinationProject.Context;

namespace VaccinationProject.Controller.Services
{
    public class ReservationServices : IRepository02<Reservation>
    {
        private VaccinationProjectDBContext _context;

        public ReservationServices()
        {
            _context = new VaccinationProjectDBContext();
        }

        public void Create(Reservation item)
        {
            _context.Add(item);
        }

        public List<Reservation> GetAll()
        {
            return _context.Reservations.ToList();
        }

        public Reservation GetById(string id)
        {
            return _context.Reservations.FirstOrDefault(r => r.DuiCitizen == id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
