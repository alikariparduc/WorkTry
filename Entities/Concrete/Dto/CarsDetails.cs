using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.Dto
{
    public class CarsDetails:IEntity
    {
        public int Id { get; set; }
        public string CarBrandName { get; set; }
        public string CarColorName { get; set; } 

    }
}
