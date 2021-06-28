using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccinationProject.Context;
using VaccinationProject.Controller.Repository;

namespace VaccinationProject.Controller.Services
{
    public class ManagerServices : IRepository01<Manager>
    {
        private VaccinationProjectDBContext _context;

        public ManagerServices()
        {
            _context = new VaccinationProjectDBContext();
        }

        public Manager GetById(int id)
        {
            return _context.Managers.Find(id);
        }

        public Manager GetByUserandPass(string username, string password)
        {
            return _context.Managers.FirstOrDefault(m => m.UserName == username && m.Pass == password);
        }
    }
}
