using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwow.ThreeLayer.Dto
{
	public class GarageDto
	{
		public int Id { get; set; }
		public string Brand	 { get; set; }
        public string Model	{ get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }   
        public int MemberId { get; set; }   
        public string Fuel { get; set; }
        public string Year { get; set; }
        public string Description { get; set; } 


    }
}
