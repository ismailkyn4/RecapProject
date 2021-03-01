using Business.Concrete;
using Business.Constants;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // CarTest();
            //BrandGetAllTest();
            //ColorGetAllTest();
            //ColorAddTest();
            //CustomerAddTest();
            //CarDeletedTest();
            //RentalDetailTest();
            //RentalAddTest();

        }

        private static void RentalAddTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Console.Write("Car Id:");
            int carIdNew = Convert.ToInt32(Console.ReadLine());
            Console.Write("Customer Id:");
            int customerIdNew = Convert.ToInt32(Console.ReadLine());

            Rental rentalAdd = new Rental()
            {
                CarId = carIdNew,
                CustomerId = customerIdNew,
                RentDate = DateTime.Now,
                ReturnDate=null, 
            };
            Console.WriteLine(rentalManager.Add(rentalAdd).Message);
        }

        private static void RentalDetailTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            foreach (var rental in rentalManager.GetRentalDetails().Data)
            {
                Console.WriteLine("Car Name: " + rental.CarName + " Customer Name: " + rental.CustomerName + " Rent Date: " + rental.RentDate + " RentReturned: " + rental.ReturnDate);
            }
        }

        private static void CarDeletedTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Delete(new Car { Id = 8, CarName = "Opel Astra", BrandId = 1, ColorId = 1, ModelYear = 2019, DailyPrice = 600, Description = "Hatcback" });
        }



        private static void CustomerAddTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer { UserId = 2, CompanyName = "RentCar" }
             );


        }

        private static void ColorAddTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorId = 4, ColorName = "Red" });
        }

        private static void ColorGetAllTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll().Data;
            foreach (var color in result)
            {
                Console.WriteLine(color.ColorId + "/" + color.ColorName); ;
            }
        }

        private static void BrandGetAllTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll().Data;
            foreach (var brand in result)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + " / " + car.BrandName);
                }

            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

    }
}
