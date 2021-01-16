using CarGalery.DataAccess.Abstract;
using CarGalery.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarGalery.DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : 
        EfRepositoryBase<Car, CarGaleryContext>,
        ICarDal
    {

    }
}
