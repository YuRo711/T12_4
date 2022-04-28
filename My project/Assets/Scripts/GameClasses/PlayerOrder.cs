using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class PlayerOrder
    {
		public PlayerOrder(Customer customer)
        {
			Customer = customer;
			KeyWords = new List<string>();
			Time = 0;
			Place = null;
			Container = null;
			Services = new Dictionary<Attribute, int>();
        }

		public Customer Customer { get; set; }
		public List<string> KeyWords { get; set; }
		public int Time { get; set; }
		public Place Place { get; set; }
		public Container Container { get; set; }
		public Dictionary<Attribute, int> Services { get; set; }
	}
}
