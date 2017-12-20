using System;
using System.ComponentModel.DataAnnotations;

namespace AmpPwaApps.Models
{
    public class CarDealerAppointment
    {
        //aanhef
        public string GreetingPrefix { get; set; }
        //voornam
        [Required(ErrorMessage = "First name is required!")]
        public string FirstName { get; set; }
        //achternaam
        [Required(ErrorMessage = "Last name is required!")]
        public string LastName { get; set; }
        //tussenvoegsel
        public string MainText { get; set; }
        //toevoeging
        [Required(ErrorMessage = "Appointment date is required!")]
        public DateTime AppointmentDate { get; set; }
        public string AdditiveText { get; set; }
        //email
        [Required(ErrorMessage = "Email is required!")]
        public string Email { get; set; }
        //telefoonnummer
        public string TelephoneNumber { get; set; }
        //postcode
        public string PostCode { get; set; }
        //huisnummer
        public string HouseNumber { get; set; }
        [Required(ErrorMessage = "You must select a dealer!")]
        public string DealerName { get; set; }

    }
}
