using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Game
{	public class Place : IPreference
	{
		public Place(string name = "Unnamed", int price = 0)
        {
			Name = name;
			Price = price;
        }
		public string Name { get; set; }
		public int Price { get; set; }
		public int Day { get; set; }
		public PlaceTypes Type { get; set; }

		public bool IsMatch(RitualTypes ritual)
        {
			return (Type == PlaceTypes.Cementery && ritual == RitualTypes.Funeral)
				|| (Type == PlaceTypes.Crematory && ritual == RitualTypes.Cremation);
        }
	}
}

