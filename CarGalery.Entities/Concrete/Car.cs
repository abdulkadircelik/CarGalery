using CarGalery.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarGalery.Entities.Concrete
{
    public class Car : IEntity
    {
        
        public int CarId { get; set; }
        public string Model { get; set; }
        public decimal UnitPrice { get; set; }

        public Car()
        {

        }
        public Car(string model, decimal price)
        {
            Model = model;
            UnitPrice = price;
        }

        public override string ToString()
        {
            return $"{CarId,-5} {Model,-30} {UnitPrice,-10}";
        }
    }
}
