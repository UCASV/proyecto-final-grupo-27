using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccinationProject.Context;
using VaccinationProject.Controller.Repository;

namespace VaccinationProject.Controller.Services
{
    public class TypeEmployeeServices : IRepository01 <TypeEmployee>
    {
        private VaccinationProjectDBContext _context;

        public TypeEmployeeServices()
        {
            _context = new VaccinationProjectDBContext();
        }

        public TypeEmployee GetById(int id)
        {
            return _context.TypeEmployees.Find(id);
        }
    }
}
