using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car
                {
                    Id = 1,
                    BrandID = 1,
                    ColorId = 1,
                    ModelYear = 2017,
                    DailyPrice = 720000,
                    Description = "Sahibinden az hasarlı BMW i3"
                },
                new Car
                {
                    Id = 2,
                    BrandID = 2,
                    ColorId = 2,
                    ModelYear = 2019,
                    DailyPrice = 500000,
                    Description = "Sadece -> kapıları - boyası - ön 2 tekeri - şanzımanı fln değişmiş Audi a6"
                },
                new Car
                {
                    Id = 3,
                    BrandID = 3,
                    ColorId = 3,
                    ModelYear = 2021,
                    DailyPrice = 1200000,
                    Description = "Tesle Model x Fabrika çıkışı sıfır"
                },
                new Car
                {
                    Id = 4,
                    BrandID = 1,
                    ColorId = 2,
                    ModelYear = 2009,
                    DailyPrice = 300000,
                    Description = "bmw 5 serisi 520d standart deri döşemeli"
                },
                new Car
                {
                    Id = 5,
                    BrandID = 4,
                    ColorId = 7,
                    ModelYear = 2022,
                    DailyPrice = 3000000,
                    Description = "Yerli ve Milli uçan araba"
                },
            };

        }

        public void Add(Car car)
        {
            _car.Add(car);
            Console.WriteLine("Araba Eklendi");
        }

        public void Delete(int id)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.Id == id);
            _car.Remove(carToDelete);
            Console.WriteLine("Araba Silindi");
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public Car GetById(int id)
        {
            return _car.Where(c => c.Id == id).SingleOrDefault();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandID = car.BrandID;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            Console.WriteLine("Araba Güncellendi");

        }
    }
}
