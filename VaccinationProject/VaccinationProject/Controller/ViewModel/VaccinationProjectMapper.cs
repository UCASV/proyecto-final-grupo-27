using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccinationProject.Context;

namespace VaccinationProject.Controller.ViewModel
{
    public static class VaccinationProjectMapper
    {

        public static ReservationVm MapReservationToReservationVm(Reservation r)
        {
            return new ReservationVm
            {
                Id = r.Id,
                DateReservation = r.DateReservation,
                VaccinationPlace = r.VaccinationPlace,
                DuiCitizen = r.DuiCitizen
            };
        }
    }
}
