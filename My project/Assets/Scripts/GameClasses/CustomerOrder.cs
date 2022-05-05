using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	public class CustomerOrder
	{
		public CustomerOrder(
			RitualTypes ritual = RitualTypes.Funeral,
			ContainerStyles style = ContainerStyles.Classic,
			ContainerPalette palette = ContainerPalette.Color, 
			List<Attribute> attributes = null, 
			Tuple<int, int> deadlines = null)
		{
			Ritual = ritual;
			PreferredContainerStyle = style;
			PreferredContainerPalette = palette;
            Deadlines = (deadlines != null) ? deadlines : Tuple.Create<int, int>(0, 24);
            PreferredAttributes = attributes;
		}

		public RitualTypes Ritual { get; set; }
		public Tuple<int, int> Deadlines { get; set; }
		public ContainerStyles PreferredContainerStyle { get; set; }
		public ContainerPalette PreferredContainerPalette { get; set; }
		//public Container Container { get; set; }
		public List<Attribute> PreferredAttributes { get; set; }
	}
}