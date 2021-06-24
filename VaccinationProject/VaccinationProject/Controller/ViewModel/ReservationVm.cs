using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccinationProject.Controller.ViewModel
{
    public class ReservationVm
    {
        public int Id { get; set; }
        public DateTime DateReservation { get; set; }
        public string VaccinationPlace { get; set; }
        public string DuiCitizen { get; set; }
    }
}
