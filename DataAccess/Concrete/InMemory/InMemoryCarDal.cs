﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=1, ColorId=1, CarModelYear=2014, CarDailyPrice= 180, CarDescription="Dizel, Manuel, 5 Kişilik, Sedan"},
                 new Car{CarId=2, BrandId=2, ColorId=2, CarModelYear=2021, CarDailyPrice= 550, CarDescription="Elektrikli, Otomotik, 5 Kişilik, Sedan"},
                  new Car{CarId=3, BrandId=3, ColorId=2, CarModelYear=2018, CarDailyPrice= 350, CarDescription="Benzin, Manuel, 5 Kişilik, Hatchback 5 Kapı"},
                   new Car{CarId=4, BrandId=4, ColorId=3, CarModelYear=2020, CarDailyPrice= 700, CarDescription="Dizel, Manuel, 7 Kişilik, Station Wagon"},
                   new Car{CarId=5, BrandId=5, ColorId=4, CarModelYear=2022, CarDailyPrice= 850, CarDescription="Benzin,Otomatik,5 Kişilik, SUV/Jeep"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.CarModelYear = car.CarModelYear;
            carToUpdate.CarDailyPrice = car.CarDailyPrice;
            carToUpdate.CarDescription = car.CarDescription;
        }
    }
}