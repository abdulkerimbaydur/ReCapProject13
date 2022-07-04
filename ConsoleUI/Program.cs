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

             
            foreach (var c in carManager.GetCarDetails())
            {
                Console.WriteLine("Araba İsmi"+ "=" + c.CarName+ "    Marka" + "=" + c.BrandName + "    Renk" + "=" +  c.ColorName +"    Fiyat" +"="+ c.DailyPrice);
            }
        }
    }
}
