using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager =new CarManager(new EfCarDal());
            //var result=carManager.GetCarDetails();
            //if(result.Success==true)
            //{
            //    foreach (var cars in result.Data)
            //    {
            //        Console.WriteLine(cars.ModelYear+"//"+cars.Description);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}
            IUserService user = new UserManager(new EfUserDal());
            foreach (var VARIABLE in user.GetAll())
            {
                Console.WriteLine(VARIABLE.FirstName);
            }



        }
    }
}