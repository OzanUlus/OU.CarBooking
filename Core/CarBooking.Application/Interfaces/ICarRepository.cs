﻿using CarBooking.Application.Dtos.CarDtos;
using CarBooking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Application.Interfaces
{
    public interface ICarRepository : IRepository<Car>
    {
        Task<List<Car>> GetCarWithInformation();
        Task<List<Car>> GetCarByLocationId(int locationId);
        Task<List<Car>> GetCarsByWithStatus();
        
    }
}
