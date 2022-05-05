using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	public class Container : IPreference
	{
		public Container(ContainerTypes type, string image = null, string name = "Unnamed", int price = 50, 
			ContainerStyles style = ContainerStyles.Classic, ContainerPalette palette = ContainerPalette.Color )
        {
			Image = (image != null) ? image : DefaultImage;
			Name = name;
			Price = price;
			Style = style;
			Palette = palette;
			Type = type;
		}

		public string Image { get; set; }
		public ContainerTypes Type { get; set; }
		public int Price { get; set; }
		public string Name { get; set; }
		public ContainerStyles Style { get; set; }
		public ContainerPalette Palette { get; set; }
		//Add default image
		public static string DefaultImage = null;

		public bool IsMatch(RitualTypes ritual)
        {
			return (Type == ContainerTypes.Coffin && ritual == RitualTypes.Funeral)
				|| (Type == ContainerTypes.Urn && ritual == RitualTypes.Cremation);
        }
	}
}
