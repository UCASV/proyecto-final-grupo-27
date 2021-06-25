using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccinationProject.Context;
using VaccinationProject.Controller.Repository;

namespace VaccinationProject.Controller.Services
{
    public class ChronicDiseaseServices : IRepository02<ChronicDisease>
    {
        private VaccinationProjectDBContext _context;

        public ChronicDiseaseServices()
        {
            _context = new VaccinationProjectDBContext();
        }

        public void Create(ChronicDisease item)
        {
            _context.Add(item);
        }

        public List<ChronicDisease> GetAll()
        {
            return _context.ChronicDiseases.ToList();
        }

        public ChronicDisease GetById(int id)
        {
            return _context.ChronicDiseases.Find(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
