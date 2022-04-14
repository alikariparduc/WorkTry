using Business.Abstract;
using Business.Constants;
using Core.Utilities.Abstract;
using Core.Utilities.Abstract.Result;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EfMemoryDal;
using DataAccess.Concrete.InMemoryDal;
using Entities.Concrete;
using Entities.DTOs;
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
        public IResult Add(Car car)
        {
            if (car.Description.Length<2)
            {
                return new ErrorResult(Messages.InvalidMessage);
            }
            
                _carDal.Add(car);
                //return new Result(true,"Kayıt Başarılı.");
                return new SuccessResult(Messages.AddedMessage);
            
               

        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new Result(true, "Silme İşlemi Başarılı.");
        }

        
            public IDataResult<List<Car>> GetAll()
            {
                if (DateTime.Now.Hour == 13)
                {
                    return new ErrorDataResult<List<Car>>(default,Messages.MaintenanceTimeMessage);
                }
                return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.ListedMessage);

            }
        

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public List<Car> GettAllByBrandId(int id)
        {
            
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public IResult Update(Car car)
        {
             _carDal.Update(car);
            return new Result(true, "Güncelleme  Başarılı.");
        }

      
    }
}
