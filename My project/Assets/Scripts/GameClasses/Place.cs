using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Game
{	public class Place : IPreference
	{
		public Place(string name = "Unnamed")
        {
			Name = name;
		}
		public string Name { get; set; }
		public int Price { get; set; }
		public int Day { get; set; }
	}
}

