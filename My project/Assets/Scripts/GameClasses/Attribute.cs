using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	public class Attribute : IPreference
	{
		public Attribute(AttributeTypes type, string image = null, string name = "Unnamed", int price = 20)
        {
			Id = Count[type]++;
			Type = type;
			Price = price;
			Name = name;
			Image = (image != null) ? image : DefaultImage;
        }

		public int Id { get; set; }
		public AttributeTypes Type { get; set; }
		public string Name { get; set; }
		public int Price { get; set; }
		public string Image { get; set; }
		private Dictionary<AttributeTypes, int> Count = new Dictionary<AttributeTypes, int> {
			{ AttributeTypes.Service, 0 }, { AttributeTypes.Gravestone, 0}, { AttributeTypes.Wreath, 0} };
		//Add default image
		public static string DefaultImage = null;
	}
}
