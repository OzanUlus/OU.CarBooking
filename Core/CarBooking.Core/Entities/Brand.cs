using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Core.Entities
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string BrandImageUrl { get; set; }

        #region Nav Property
        public IEnumerable<Car> Cars { get; set; }
        #endregion
    }
}
