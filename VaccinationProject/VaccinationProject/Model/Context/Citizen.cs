using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationProject.Context
{
    public partial class Citizen
    {
        public Citizen()
        {
            ChronicDiseases = new HashSet<ChronicDisease>();
            Reservations = new HashSet<Reservation>();
        }

        public string Dui { get; set; }
        public string CitizenName { get; set; }
        public string CitizenAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int? NumIdentifier { get; set; }
        public int IdPriorityGroup { get; set; }
        public int IdManager { get; set; }

        public virtual Manager IdManagerNavigation { get; set; }
        public virtual PriorityGroup IdPriorityGroupNavigation { get; set; }
        public virtual ICollection<ChronicDisease> ChronicDiseases { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
