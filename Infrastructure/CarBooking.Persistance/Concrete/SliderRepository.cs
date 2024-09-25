using CarBooking.Application.Interfaces;
using CarBooking.Core.Entities;
using CarBooking.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Persistance.Concrete
{
    public class SliderRepository : Repository<Slider> , ISliderRepository
    {
        public SliderRepository(CarBookingContext context) : base(context)
        {
        }
    }
}
