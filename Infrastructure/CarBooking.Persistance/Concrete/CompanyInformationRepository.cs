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
    public class CompanyInformationRepository : Repository<CompanyInformation>, ICompanyInformationRepository
    {
        public CompanyInformationRepository(CarBookingContext context) : base(context)
        {
        }
    }
}
