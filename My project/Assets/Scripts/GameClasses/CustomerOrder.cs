using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	public class CustomerOrder
	{
		public CustomerOrder(Customer customer, string text = "Kill me please", List<string> keyWords = null, 
			FuneralMethods method = FuneralMethods.Bury, 
			ContainerStyles style = ContainerStyles.Classic,
			ContainerPalette palette = ContainerPalette.Color, 
			Dictionary<Attribute, int> services = null, 
			Tuple<int, int> deadlines = null)
		{
			Customer = customer;
			Text = text;
			KeyWords = (keyWords != null) ? keyWords : new List<string>();
			FuneralMethod = method;
			PreferredContainerStyle = style;
			PreferredContainerPalette = palette;
            Deadlines = (deadlines != null) ? deadlines : Tuple.Create<int, int>(0, 24);
		}

		public Customer Customer { get; set; }
		public string Text { get; set; }
		public List<string> KeyWords { get; set; }
		public FuneralMethods FuneralMethod { get; set; }
		public Tuple<int, int> Deadlines { get; set; }
		public ContainerStyles PreferredContainerStyle { get; set; }
		public ContainerPalette PreferredContainerPalette { get; set; }
		//public Container Container { get; set; }
		public Dictionary<Attribute, int> PreferredServices { get; set; }
	}
}