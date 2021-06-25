using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationProject.Context
{
    public partial class VaccinationProcess
    {
        public int Id { get; set; }
        public int? TimeSideEffects { get; set; }
        public int? IdSideEffects { get; set; }
        public DateTime DatewWaitingQueue { get; set; }
        public DateTime DateVaccination { get; set; }
        public DateTime? DateSecondDose { get; set; }
        public string PlaceSecondDose { get; set; }
        public int IdReservation { get; set; }

        public virtual Reservation IdReservationNavigation { get; set; }
        public virtual SideEffect IdSideEffectsNavigation { get; set; }
    }
}
