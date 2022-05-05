using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Game
{	public class Place : IPreference
	{
		public Place(PlaceTypes type, string name = "Unnamed", int price = 0)
		{
			Type = type;
			Name = name;
			Price = price;
        }
		public string Name { get; set; }
		public int Price { get; set; }
		public PlaceTypes Type { get; set; }

		public bool IsMatch(RitualTypes ritual)
        {
			return (Type == PlaceTypes.Cemetery && ritual == RitualTypes.Funeral)
				|| (Type == PlaceTypes.Crematory && ritual == RitualTypes.Cremation);
        }
	}
}

