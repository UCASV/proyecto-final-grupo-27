using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccinationProject.Controller.Repository
{
    public interface IRepository02<T>
    {

        List<T> GetAll();

        T GetById(string id);

        void Create(T item);

        void Save();
    }
}
