using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, SqlServerDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (SqlServerDbContext context = new SqlServerDbContext())
            {
                var result = from c in context.Car
                             join b in context.Brands on c.BrandId equals b.Id
                             join cl in context.Colors on c.ColorId equals cl.Id
                             join m in context.Models on c.ModelId equals m.ModelId
                             select new CarDetailDto
                             {
                                 CarId = c.Id,
                                 CarBrandName = b.BrandName,
                                 CarColor = cl.ColorName,
                                 Description = c.Description,
                                 CarModelName = m.ModelName

                             };
                return result.ToList();
            }
        }
    }
}
