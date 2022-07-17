using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();
            if (result.Success==true)
            {
                foreach (var c in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine("Marka" + "=" + c.BrandName + "    Araba İsmi" + "=" + c.CarName + "    Renk" + "=" + c.ColorName + "    Fiyat" + "=" + c.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);     
            }

             
            
        }
    }
}
