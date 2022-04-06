using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EfMemoryDal;
using DataAccess.Concrete.InMemoryDal;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(Car car)
        {
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetBrandIdAll(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GettAllByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
