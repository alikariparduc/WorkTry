using Core.Utilities.Abstract.Result;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result.Concrete
{
    public class Result : IResult
    {
        public Result(bool success, string message):this(success)//Burası çalıştığında success olanda çalışacak.
        {
            //Success = success; Overloadingte success çalıştığı için burada kaldırıyorum ve yukarıda belirtiyorum.
            Message = message;
        }
        public Result(bool success)//Sadece true false bilgisini almak istediğimde kullanmak için overloadin yapısı kuruldu.
        {
            Success = success;
        }

        public bool Success { get; }
        public string Message { get; }
    }
}
