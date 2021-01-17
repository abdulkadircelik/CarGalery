using CarGalery.DataAccess.Abstract;
using CarGalery.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CarGalery.DataAccess.Concrete.ADONET
{
    public class AdoCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            List<Car> cars = new List<Car>
            {
                new Car{CarId=1,Model="Ford Mustang",UnitPrice=1150000},
                new Car{CarId=2,Model="Fiat Egea",UnitPrice=185000},
                new Car{CarId=3,Model="Mercedes S400",UnitPrice=2000000},
                new Car{CarId=4,Model="BMW 320",UnitPrice=500000},
                new Car{CarId=5,Model="Ford Focus",UnitPrice=350000}

            };
            return cars;
        }
            public void Update(Car entity)
            {
                throw new NotImplementedException();
            }
        }
    }

