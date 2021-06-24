using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccinationProject.Controller.Repository
{
    public interface IRepository01<T>
    {

        T GetById(int id);

    }
}
