using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationProject.VaccinationProjectDBContext
{
    public partial class TypeEmployee
    {
        public TypeEmployee()
        {
            Managers = new HashSet<Manager>();
        }

        public int Id { get; set; }
        public string TypeEmployee1 { get; set; }

        public virtual ICollection<Manager> Managers { get; set; }
    }
}
