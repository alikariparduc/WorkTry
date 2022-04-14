using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto:IDto
    {
        public int CarId { get; set; }
        public string CarBrandName { get; set; }
        public string CarModelName { get; set; }
        public string CarColor { get; set; }
        public string Description { get; set; }
    }
}
