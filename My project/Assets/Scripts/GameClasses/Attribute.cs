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
			Type = type;
			Price = price;
			Name = name;
			Image = (image != null) ? image : DefaultImage;
        }

		public AttributeTypes Type { get; set; }
		public string Name { get; set; }
		public int Price { get; set; }
		public string Image { get; set; }
		public static string DefaultImage = null;
	}
}
