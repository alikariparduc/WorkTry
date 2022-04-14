using Core.Utilities.Abstract.Result;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result.Abstract
{
    public interface IDataResult<T>:IResult//Hangi Tipi döndüreceğini belirt.
    {
        T Data { get; }
    }
}
