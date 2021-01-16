using CarGalery.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarGalery.DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        
    }
}
