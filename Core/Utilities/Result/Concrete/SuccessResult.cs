using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result.Concrete
{
    public class SuccessResult : Result
    {
        //SuccessResult newlendiğinde message alsın.Bu çalıştığındada basedeli(resulttaki)
        //iki parametreli yapı çalışsın successresult olduğu için ilk değeri true gönderiyoruz
        //messageda gönderilen değer olacak.
        public SuccessResult(string message) : base(true, message)
            
        {

        }
        //Parametre almayan bir metot bu.Base(Result)da ki tek parametreli metot çalışacak.Onun değerinide true gönderdik.
        public SuccessResult():base(true)
        {

        }
    }
}
