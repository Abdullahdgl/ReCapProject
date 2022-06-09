using DataAccess.Abstract;
using Entities.Contrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Contrete
{
	public class InMemoryDal : ICarDal
	{
		List<Car> _cars;
		public InMemoryDal()
		{
			_cars = new List<Car>
			{
				new Car{Id = 1, BrandId=1, ColorId=1 , DailyPrice=125,ModelYear="15.06.1993" , Description="Dizel" },
				new Car{Id = 2, BrandId=2, ColorId=5 , DailyPrice=125,ModelYear="15.06.1999" , Description="LPG & Benzin" },
				new Car{Id = 3, BrandId=3, ColorId=1 , DailyPrice=125,ModelYear="15.06.1998" , Description="Benzin" },
				new Car{Id = 4, BrandId=4, ColorId=7 , DailyPrice=125,ModelYear="15.06.1997" , Description="‪Hybrid" },

			};
		}
		public void Add(Car car)
		{
			_cars.Add(car);
		}

		public void Delete(Car car)
		{
			Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
			_cars.Remove(carToDelete);
		}

		public List<Car> GetAll()
		{
			return _cars;
		}

		public List<Car> GetById(int BrandId)
		{
			return _cars.Where(c => c.BrandId == BrandId).ToList();
		}

		public void Update(Car car)
		{
			Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
			carToUpdate.BrandId = car.BrandId;
			carToUpdate.ColorId = car.ColorId;
			carToUpdate.DailyPrice = car.DailyPrice;
			carToUpdate.Description = car.Description;
			carToUpdate.ModelYear = car.ModelYear;


		}
	}
}
