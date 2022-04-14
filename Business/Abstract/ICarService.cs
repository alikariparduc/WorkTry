using Core.Utilities.Abstract;
using Core.Utilities.Abstract.Result;
using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll(); 

        List<Car> GettAllByBrandId(int id);

        List<Car> GetCarsByColorId(int id);
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);

        List<CarDetailDto> GetCarDetails();

      
    }
}
