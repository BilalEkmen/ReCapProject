using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            InMemoryCarDal inMemoryCarDal = new InMemoryCarDal();

            Console.WriteLine("-----GetAll-----");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            } 

            Console.WriteLine("-----Add-----");
            carManager.Add(new Car { Id = 6, BrandID = 1, ColorId = 3, ModelYear = 2015, DailyPrice = 100000, Description = "Suda Havada ve Karada Gidebilen TosTos" });

            Console.WriteLine("-----GetAll-----");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("-----Delete----");
            carManager.Delete(2);

            Console.WriteLine("-----GetAll-----");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("-----Update-----");
            carManager.Update(new Car
            {
                Id = 1,
                BrandID = 1,
                ColorId = 2,
                ModelYear = 2017,
                DailyPrice = 700000,
                Description = "Sahibinden azıcık hasarlı BMW i3"
            });

            Console.WriteLine("-----GetAll-----");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            
            Console.WriteLine("-----GetById-----");
            Console.WriteLine(carManager.GetById(6).Description);

            


        }
    }
}
