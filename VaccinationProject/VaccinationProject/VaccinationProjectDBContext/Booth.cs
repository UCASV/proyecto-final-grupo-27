using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationProject.VaccinationProjectDBContext
{
    public partial class Booth
    {
        public Booth()
        {
            Registers = new HashSet<Register>();
        }

        public int Id { get; set; }
        public string Place { get; set; }
        public string PhoneNumber { get; set; }
        public string ManagerBooth { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Register> Registers { get; set; }
    }
}
