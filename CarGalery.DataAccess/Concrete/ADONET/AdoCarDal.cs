using CarGalery.DataAccess.Abstract;
using CarGalery.Entities.Concrete;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CarGalery.DataAccess.Concrete.ADONET
{
    public class AdoCarDal : ICarDal
    {
        public void Add(Car entity)
        {

            using (SqlCommand cmd = new SqlCommand("INSERT INTO CarDB (CarId,Model,UnitPrice) " +
                "VALUES(@CarId,@Model,@UnitPrice)"))
            {
                cmd.Parameters.AddWithValue("CarId", entity.CarId);
                cmd.Parameters.AddWithValue("Model", entity.Model);
                cmd.Parameters.AddWithValue("UnitPrice", entity.UnitPrice);
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }

        public void Delete(Car entity)
        {
            using (SqlCommand cmd =
                new SqlCommand("DELETE FROM CarDB WHERE CarId = @CarId"))
            {
                cmd.Parameters.AddWithValue("CarId", entity.CarId);
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            List<Car> carList = new List<Car>();
            SqlCommand cmd = new SqlCommand("Select * from CarDB");

            SqlDataReader reader = VTYS.SqlExecuteReader(cmd);
            while (reader.Read())
            {
                Car car = new Car
                {
                    CarId = Convert.ToInt32(reader[0]),
                    Model = reader[1].ToString(),
                    UnitPrice = Convert.ToInt32(reader[2]),
                    
                };

                carList.Add(car);
            }
            var list = carList.Where(filter.Compile()).ToList();
            return list[0];
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            List<Car> CarList = new List<Car>();
            SqlCommand cmd = new SqlCommand("Select * from CarDB");

            SqlDataReader reader = VTYS.SqlExecuteReader(cmd);
            while (reader.Read())
            {
                Car car = new Car
                {
                    CarId = Convert.ToInt32(reader[0]),
                    Model = reader[1].ToString(),
                    UnitPrice = Convert.ToInt32(reader[2]),
                    
                };

                CarList.Add(car);
            }

            return filter == null ? CarList : CarList.Where(filter.Compile()).ToList();
        }
            public void Update(Car entity)
            {
            using (SqlCommand cmd = new SqlCommand("UPDATE CarDb set CarId = @CarId," +
                " Model=@Model, UnitPrice=@UnitPrice WHERE CarId = @CarId"))
            {
                cmd.Parameters.AddWithValue("@CarId", entity.CarId);
                cmd.Parameters.AddWithValue("@Model", entity.Model);
                cmd.Parameters.AddWithValue("@UnitPrice", entity.UnitPrice);
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }
        }
    }

