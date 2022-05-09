using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public  class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()// Car için Validator kodlamaları.
        {
            RuleFor(c => c.Description).NotEmpty();//Açıklama boş olamaz.
            RuleFor(c => c.Description).MinimumLength(2);//Açıklama enaz 2 karakter olamlıdır.
            RuleFor(c => c.DailyPrice).NotEmpty(); // DailyPrice boş olamaz.
            RuleFor(c=>c.DailyPrice).GreaterThan(0);//0 dan büyük bir değer olmalıdır.
            RuleFor(c => c.ModelYear).GreaterThanOrEqualTo(2010).When(c => c.BrandId ==1);//BrandId 1 olduğu zaman ModelYear 2010dan büyük olmalıdır.
            RuleFor(c => c.Description).Must(StartWithA).WithMessage("Açıklama A harfi ile başlamalı.");//Kendi yazdığımız kuralı kullanmak için Must=uygnamalı metodunu kullanıyoruz.
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A"); // Gönderilen değer A ile başlıyorsa true dönecek yoksa false.
        }
    }
}
