using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	public class Customer
	{
		public Customer(string sprite, string name = "Unnamed")
		{
			Id = Count++;
			Name = name;
			Sprite = sprite;
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public string Sprite { get; set; }
		private static int Count = 0;
	}
}
