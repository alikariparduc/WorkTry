using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c=>c.FirstName).NotEmpty();
            RuleFor(c=>c.LastName).NotEmpty();
            RuleFor(c=>c.Adress).NotEmpty();
            RuleFor(c=>c.Phone).NotEmpty();
            RuleFor(c => c.Phone).Must(StartWithPhone).WithMessage("Telefon 5 ile başlamalı..");//Kendi yazdığımız kuralı kullanmak için Must=uygnamalı metodunu kullanıyoruz.

        }

        private bool StartWithPhone(string arg)
        {
            return arg.StartsWith("5"); // Gönderilen değer % ile başlıyorsa true dönecek yoksa false.
        }
    }
}
