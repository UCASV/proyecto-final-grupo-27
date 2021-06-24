using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationProject.VaccinationProjectDBContext
{
    public partial class ChronicDisease
    {
        public int Id { get; set; }
        public string ChronicDisease1 { get; set; }
        public string DuiCitizen { get; set; }

        public virtual Citizen DuiCitizenNavigation { get; set; }
    }
}
