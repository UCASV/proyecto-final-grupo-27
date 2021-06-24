using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccinationProject.Context;
using VaccinationProject.Controller.Repository;

namespace VaccinationProject.Controller.Services
{
    class RegisterServices : IRepository02<Register>
    {
        private VaccinationProjectDBContext _context;

        public RegisterServices()
        {
            _context = new VaccinationProjectDBContext();
        }

        public void Create(Register item)
        {
            _context.Add(item);
        }
        public List<Register> GetAll()
        {
            return _context.Registers.ToList();
        }

        public Register GetById(int id)
        {
            return _context.Registers.Find(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
