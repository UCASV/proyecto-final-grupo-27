using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccinationProject.Context;
using VaccinationProject.Controller.Repository;

namespace VaccinationProject.Controller.Services
{
        public class CitizenServices : IRepository02<Citizen>, IRepository03<Citizen>
        {
            private VaccinationProjectDBContext _context;

            public CitizenServices()
            {
                _context = new VaccinationProjectDBContext();
            }

            public void Create(Citizen item)
            {
                _context.Add(item);
            }

            public List<Citizen> GetAll()
            {
                return _context.Citizens.ToList();
            }

            public void Save()
            {
                _context.SaveChanges();
            }
            public Citizen Comprobation(string DUI, string phone, string email)
            {
                return _context.Citizens.FirstOrDefault(c => c.Dui == DUI || c.PhoneNumber == phone || c.Email == email);
            }
    }
}

