using CarGalery.Business.Abstract;
using CarGalery.Business.CrossCuttingConcrens.DependencyResolvers.Ninject;
using System;

namespace CarGalery.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var carService = InstanceFactory.Get<ICarService>();
            var list = carService.GetAll();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
