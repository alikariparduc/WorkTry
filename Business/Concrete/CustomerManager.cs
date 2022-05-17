using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Abstract.Result;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        [ValidationAspect(typeof(CustomerValidator))]
        public IResult Add(Customer customer)
        {
            //if (_customerDal.GetAll(c => c.Mail == customer.Mail).Count == 0)
            //{

            //    _customerDal.Add(customer);
            //    Console.WriteLine("Kayıt Tamamlandı");
            //}
            //else
            //{
            //    Console.WriteLine("Mail adresi sistemde kayıtlı. Giriş yapmayı deneyiniz.");
            //}

            _customerDal.Add(customer);
            return new SuccessResult(Messages.AddedMessage);
        }

        public void Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            Console.WriteLine("Müşteri veritabanından silindi!!");
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.ListedMessage);
        }
    }
}
