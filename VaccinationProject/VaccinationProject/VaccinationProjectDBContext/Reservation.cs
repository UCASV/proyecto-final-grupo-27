using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationProject.VaccinationProjectDBContext
{
    public partial class Reservation
    {
        public Reservation()
        {
            VaccinationProcesses = new HashSet<VaccinationProcess>();
        }

        public int Id { get; set; }
        public DateTime DateReservation { get; set; }
        public string VaccinationPlace { get; set; }
        public string DuiCitizen { get; set; }

        public virtual Citizen DuiCitizenNavigation { get; set; }
        public virtual ICollection<VaccinationProcess> VaccinationProcesses { get; set; }
    }
}
