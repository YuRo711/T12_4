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
			string placeName = "",
			ContainerStyles style = ContainerStyles.Classic,
			List<Attribute> attributes = null, 
			Tuple<int, int> deadlines = null)
		{
			Ritual = ritual;
			PreferredContainerStyle = style;
            Deadlines = (deadlines != null) ? deadlines : Tuple.Create<int, int>(0, 24);
            PreferredAttributes = attributes;
            PlaceName = placeName;
		}

		public RitualTypes Ritual { get; set; }
		public Tuple<int, int> Deadlines { get; set; }
		public String PlaceName { get; set; }
		public ContainerStyles PreferredContainerStyle { get; set; }
		public List<Attribute> PreferredAttributes { get; set; }
	}
}