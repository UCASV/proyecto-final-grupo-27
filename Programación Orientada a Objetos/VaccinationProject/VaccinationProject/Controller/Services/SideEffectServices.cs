using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccinationProject.Context;
using VaccinationProject.Controller.Repository;

namespace VaccinationProject.Controller.Services
{
    public class SideEffectServices : IRepository03<SideEffect>
    {
        private VaccinationProjectDBContext _context;

        public SideEffectServices()
        {
            _context = new VaccinationProjectDBContext();
        }
        public List<SideEffect> GetAll()
        {
            return _context.SideEffects.ToList();
        }
    }
}
