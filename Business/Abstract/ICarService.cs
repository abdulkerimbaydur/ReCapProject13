﻿using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface ICarService
    {
        List<Car> GetAll();
        void Add(Car car);
        void Update(Car car );
        void Delete(Car car);

       
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        Car GetById(int carId);
        List<CarDetailDto> GetCarDetails();

    }
}
