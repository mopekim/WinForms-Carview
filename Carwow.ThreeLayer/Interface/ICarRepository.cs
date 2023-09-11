using Carwow.ThreeLayer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwow.ThreeLayer.Interface
{
	public interface ICarRepository
	{
		void Update( GarageDto dto );
		void Delete(int carId);
	}
}
