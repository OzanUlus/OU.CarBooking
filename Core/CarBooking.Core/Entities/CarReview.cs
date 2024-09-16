using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Core.Entities
{
    public class CarReview
    {
        public int CarReviewId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        #region Nav Properties
        public AppUser AppUser { get; set; }
        public Car Car { get; set; }
        public int UserId { get; set; }
        public int CarId { get; set; }
        #endregion
    }
}
