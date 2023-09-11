using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Carwow.ThreeLayer.Dto
{
	public class CarDto
	{
        public int Id  { get; set; }
        public string  Brand { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public string Seller { get; set; }
    }
}
    