using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemoryDal;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            //using (SqlServerDbContext context = new SqlServerDbContext())
            //{
            //    //return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
            //    var result = from p in context.Car

            //                 join c in context.Brands on p.BrandId equals c.Id
            //                 join cl in context.Colors on p.ColorId equals cl.Id
            //                 where p.Id==1
            //                 select new
            //                 {
            //                     Description = p.Description,
            //                     BrandName = c.BrandName,
            //                     ColorName =cl.ColorName
            //                 };
            //    result.ToList().ForEach(x =>
            //    {
            //        Console.WriteLine($"Araç Markası {x.BrandName}, Araç Rengi :{x.ColorName} , Araç Açıklaması: {x.Description}");
            //    });

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine(cars.Description);
            }
        }
        

    /////LINQ//////s/
    //List<Category> _Category = new List<Category>
    //{
    //    new Category{CategoryId=100,CategoryName="Jeep"},
    //    new Category{CategoryId=200,CategoryName="Otomobil"}, 
    //};

    //List<Car> _cars = new List<Car>
    //{
    //    new Car{Id=1,CategoryId=100,BrandId=1,ColorId=1,ModelYear=2022,DailyPrice=250,Description="Volvo - Otomatik Vites - Dizel"},
    //    new Car{Id=2,CategoryId=200,BrandId=2,ColorId=2,ModelYear=2021,DailyPrice=230,Description="Mercedess - Otomatik Vites - Benzin"},
    //    new Car{Id=3,BrandId=3,ColorId=3,ModelYear=2020,DailyPrice=210,Description="Hyundai - Düz Vites - Lpg"},
    //    new Car{Id=4,BrandId=4,ColorId=4,ModelYear=2023,DailyPrice=240,Description="Honda - Otomatik Vites - Dizel"},
    //};

    //var result = _cars.Find(c => c.Id == 2); // Şartı sağlayan değeri bulur.
    //Console.WriteLine(result.Description);
    //var result = _cars.Any(c => c.Id == 1); // Şartı sağlayan bir değer olup olmadığını kontrol eder (True - False)
    //if (result==true)
    //{
    //    Console.WriteLine("Ürün eklendi.");
    //}
    //else
    //{
    //    Console.WriteLine("Böyle Bir Ürün Yok");
    //}
    //var result1 = _cars.Find(c => c.Id==1); // Id değeri 1 olanı getirir.

    ////////////////FindAll//////////////////////////
    //var result2 = _cars.FindAll(c => c.Description.Contains("Otomatik")); // İçinde otomatik geçen araçları liste olarak döner.
    //foreach (var cars in result2)//Foreach'le listeyi döneriz.
    //{
    //    Console.WriteLine(cars.Description);
    //}

    //Artan Sıralama//OrderBy
    //var result3 = _cars.FindAll(c => c.Description.Contains("Otomatik")).OrderBy(p=>p.DailyPrice); // İçinde otomatik geçen araçları liste olarak döner.
    //foreach (var cars in result3)//Foreach'le listeyi döneriz.
    //{
    //    Console.WriteLine(cars.Description);
    //}
    //Azalan Sıralama//OrderByDescending
    //var result4 = _cars.FindAll(c => c.Description.Contains("Otomatik")).OrderByDescending(p => p.DailyPrice); // İçinde otomatik geçen araçları liste olarak döner.
    //foreach (var cars in result4)//Foreach'le listeyi döneriz.
    //{
    //    Console.WriteLine(cars.Description);
    //}
    //Console.WriteLine("Alfabetik sıralama");
    ////ThenBy// Alfabetik sıralama
    //var result5 = _cars.FindAll(c => c.Description.Contains("Otomatik")).OrderByDescending(p => p.DailyPrice).ThenBy(p=>p.Description); // İçinde otomatik geçen araçları liste olarak döner.
    //foreach (var cars in result5)//Foreach'le listeyi döneriz.
    //{
    //    Console.WriteLine(cars.Description);
    //}
    ////Alfebe ters sıralama //ThenByDescending
    //Console.WriteLine("Alfabetik Ters Sıralama");
    //var result6 = _cars.FindAll(c => c.Description.Contains("Otomatik")).OrderByDescending(p => p.DailyPrice).ThenByDescending(p => p.Description); // İçinde otomatik geçen araçları liste olarak döner.
    //foreach (var cars in result6)//Foreach'le listeyi döneriz.
    //{
    //    Console.WriteLine(cars.Description);
    //}
    ///////////////////////////////////
    //var result7 = from p in _cars
    //              select p;
    //foreach (var cars in result7)
    //{
    //    Console.WriteLine(cars.Description) ;
    //}
    ////////////////////////////////////
    //var result8 = from p in _cars
    //              where p.DailyPrice > 230
    //              orderby p.DailyPrice descending,p.Description  ascending
    //              select p;

    //foreach (var cars1 in result8)
    //{
    //    Console.WriteLine(cars1.Description);
    //}




}
    }

