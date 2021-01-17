using CarGalery.Business.Abstract;
using CarGalery.DataAccess.Abstract;
using CarGalery.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CarGalery.Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _car;

        public CarManager(ICarDal car)
        {
            _car = car;
        }

        public void Add(Car entity)
        {
            _car.Add(entity);
        }

        public void Delete(Car entity)
        {
            _car.Delete(entity);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            return _car.Get(filter);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _car.GetAll(filter);
        }

        public void Update(Car entity)
        {
            _car.Update(entity);
        }
    }
}
