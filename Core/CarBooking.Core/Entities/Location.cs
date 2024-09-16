using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Core.Entities
{
    public class Location
    {
        public int LocationId { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        #region Nav Properties
        public IEnumerable<Car> Cars { get; set; }
        #endregion
    }
}
