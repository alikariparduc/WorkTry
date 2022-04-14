using Business.Abstract;
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
        SqlServerDbContext sqlServerDbContext = new SqlServerDbContext();
        

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add(Customer customer)
        {
            if (_customerDal.GetAll(c => c.Mail == customer.Mail).Count == 0)
            {

                _customerDal.Add(customer);
                Console.WriteLine("Kayıt Tamamlandı");
            }
            else
            {
                Console.WriteLine("Mail adresi sistemde kayıtlı. Giriş yapmayı deneyiniz.");
            }
        }

        public void Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            Console.WriteLine("Müşteri veritabanından silindi!!");
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }
    }
}
