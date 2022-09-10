using Businnes.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businnes.Concrete
{
    public class CarManager: ICarService
    {
        ICarDal _carDal;
        public InMemoryCarDal ınMemoryCarDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public CarManager(InMemoryCarDal ınMemoryCarDal)
        {
            this.ınMemoryCarDal = ınMemoryCarDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
    }
}
