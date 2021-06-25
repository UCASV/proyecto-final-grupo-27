using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccinationProject.Controller.Repository;
using VaccinationProject.Context;

namespace VaccinationProject.Controller.Services
{
    public class ReservationServices : IRepository01<Reservation>,IRepository02<Reservation>, IRepository03<Reservation>
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


        public Reservation GetByDUI(string id)
        {
            return _context.Reservations.FirstOrDefault(r => r.DuiCitizen == id);
        }

        public Reservation GetById(int id)
        {
            return _context.Reservations.Find(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
