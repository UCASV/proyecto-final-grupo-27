using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccinationProject.Context;
using VaccinationProject.Controller.Repository;

namespace VaccinationProject.Controller.Services
{
    public class BoothServices : IRepository01<Booth> , IRepository03<Booth>
    {
        private VaccinationProjectDBContext _context;

        public BoothServices()
        {
            _context = new VaccinationProjectDBContext();
        }

        public Booth GetById(int id)
        {
            return _context.Booths.Find(id);
        }

        public List<Booth> GetAll()
        {
            return _context.Booths.ToList();
        }
    }
}
