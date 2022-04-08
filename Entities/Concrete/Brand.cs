using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Brand:IEntity // IEntity diyerek bir db tablosu nesnesi olduğunu belirtiyorum.
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
    }
}
