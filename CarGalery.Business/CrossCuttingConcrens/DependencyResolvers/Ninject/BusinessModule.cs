using CarGalery.Business.Abstract;
using CarGalery.Business.Concrete;
using CarGalery.DataAccess.Abstract;
using CarGalery.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarGalery.Business.CrossCuttingConcrens.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICarService>().To<CarManager>().InSingletonScope();
            Bind<ICarDal>().To<EfCarDal>().InSingletonScope();



        }
    }
}
