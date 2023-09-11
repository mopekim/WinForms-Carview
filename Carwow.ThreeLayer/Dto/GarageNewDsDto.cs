using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwow.ThreeLayer.Dto
{
	public class GarageNewDsDto
	{
        public string Fuel { get; set; }
        public string Year { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }   
        public int CarId { get; set; }  
    }
}
