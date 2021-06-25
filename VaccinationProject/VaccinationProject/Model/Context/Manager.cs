using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationProject.Context
{
    public partial class Manager
    {
        public Manager()
        {
            Citizens = new HashSet<Citizen>();
            Registers = new HashSet<Register>();
        }

        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public string HomeAddress { get; set; }
        public int IdTypeEmployee { get; set; }
        public string UserName { get; set; }
        public string Pass { get; set; }

        public virtual TypeEmployee IdTypeEmployeeNavigation { get; set; }
        public virtual ICollection<Citizen> Citizens { get; set; }
        public virtual ICollection<Register> Registers { get; set; }
    }
}
