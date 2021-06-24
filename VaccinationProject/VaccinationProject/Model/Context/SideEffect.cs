using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationProject.Context
{
    public partial class SideEffect
    {
        public SideEffect()
        {
            VaccinationProcesses = new HashSet<VaccinationProcess>();
        }

        public int Id { get; set; }
        public string SideEffect1 { get; set; }

        public virtual ICollection<VaccinationProcess> VaccinationProcesses { get; set; }
    }
}
