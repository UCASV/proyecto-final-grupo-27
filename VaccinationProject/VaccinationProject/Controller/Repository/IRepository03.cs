using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccinationProject.Controller.Repository
{
    public interface IRepository03<T>
    {
        List<T> GetAll();
    }
}
