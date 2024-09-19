using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Core.Entities
{
    public class Image
    {
        public int ImageId { get; set; }
        public string ImageUrl { get; set; }


        #region Nav Property
        public Car Car { get; set; }
        public int CarId { get; set; }

        #endregion
    }
}
