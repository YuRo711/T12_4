using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	partial class GameState
	{
		public GameState(int money = 100)
        {
			Money = money;
			Day = 1;
			Time = 0;
			ServedClientsToday = 0;
			ServedClientsTotal = 0;
			SetGameObjects();
			CurrentCustomerOrder = CustomerOrdersToday[0];
        }

		public int Money { get; set; }
		public int Day { get; set; }
		public int Time { get; set; }
		public CustomerOrder CurrentCustomerOrder { get; set; }
		public Customer CurrentCustomer 
		{ get
			{
				return CurrentCustomerOrder.Customer;
			} 
		}
		public int ServedClientsToday { get; set; }
		public int ServedClientsTotal { get; set; }
		public List<CustomerOrder> CustomerOrdersToday { get; set; }
		public List<Place> Places { get; set; }
		public List<Container> Containers { get; set; }
		public List<Attribute> Gravestones { get; set; }
		public List<Attribute> Wreaths { get; set; }
		public List<Attribute> Services { get; set; }
		public List<Customer> Customers { get; set; }
	}
}
