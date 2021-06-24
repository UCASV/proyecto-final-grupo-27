using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationProject.VaccinationProjectDBContext
{
    public partial class Register
    {
        public int IdManager { get; set; }
        public int IdBooth { get; set; }
        public DateTime DateLogin { get; set; }

        public virtual Booth IdBoothNavigation { get; set; }
        public virtual Manager IdManagerNavigation { get; set; }
    }
}
