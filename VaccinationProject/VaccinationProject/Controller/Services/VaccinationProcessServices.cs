﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccinationProject.Context;
using VaccinationProject.Controller.Repository;

namespace VaccinationProject.Controller.Services
{
    public class VaccinationProcessServices : IRepository02<VaccinationProcess>
    {
        private VaccinationProjectDBContext _context;

        public VaccinationProcessServices()
        {
            _context = new VaccinationProjectDBContext();
        }

        public void Create(VaccinationProcess item)
        {
            _context.Add(item);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
