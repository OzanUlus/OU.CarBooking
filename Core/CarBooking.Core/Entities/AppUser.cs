
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Core.Entities
{
    public class AppUser : IdentityUser<int>
    {
   
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }


        #region Nav Properties
        public IEnumerable<Payment> Payments { get; set; }
        public IEnumerable<CarReview> CarReviews { get; set; }
        public IEnumerable<Reservation> Reservations { get; set; }
        #endregion
    }
}
