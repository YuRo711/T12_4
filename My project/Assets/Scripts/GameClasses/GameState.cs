using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
	public static class GameState
	{
		private static bool exists;
		
		// Создаётся в MoneyUI
		public static void Restart(int money = 100)
        {
			Money = money;
			Day = 1;
			Time = 0;
			ServedClientsToday = 0;
			ServedClientsTotal = 0;
			SetGameObjects();
			CustomersToday = new List<Customer> { new Customer("a", "Abigaile") };
			Tasks = new List<string>();
			CurrentCustomer = CustomersToday[0];
        }
		
		public static int Money { get; set; }
		public static int Day { get; set; }
		public static int Time { get; set; }
		public static Customer CurrentCustomer { get; set; }
		public static int ServedClientsToday { get; set; }
		public static int ServedClientsTotal { get; set; }
		public static List<Customer> CustomersToday { get; set; }
		public static List<Place> Places { get; set; }
		public static List<Container> Containers { get; set; }
		public static List<Attribute> Gravestones { get; set; }
		public static List<Attribute> Wreaths { get; set; }
		public static List<Attribute> Services { get; set; }
		public static List<Customer> Customers { get; set; }
		public static List<string> DialogueQueue { get; set; } = new List<string>();

		public static List<string> Tasks { get; set; }

		public static bool Paused { get; set; }
		
		
		private static void SetGameObjects()
                {
                    //Places = (List<Place>)GetPlaces();
                    Containers = GetContainers();
                    /*
                     Gravestones = (List<Attribute>)GetGravestones();
                    Wreaths = (List<Attribute>)GetWreaths();
                    Services = (List<Attribute>)GetServices();
                    Customers = (List<Customer>)GetCustomers();
                    CustomerOrdersToday = (List<CustomerOrder>)GetOrders(Day);
                    */
                }
        
                //Add objects here
                private static IEnumerable<Customer> GetCustomers()
                {
                    yield break;
                }
        
                private static IEnumerable<CustomerOrder> GetOrders(int day)
                {
                    switch (day)
                    {
                        case 0:
                            yield return new CustomerOrder(Customers[0]);
                            break;
                    }
                    yield break;
                }
        
                private static IEnumerable<Place> GetPlaces()
                {
                    yield break;
                }
        
                private static List<Container> GetContainers()
                {
	                return new List<Container>
	                {
		                new Container(
			                ContainerTypes.Coffin,
			                "Sprites/coffin_1",
			                "Nike",
			                30)
	                };
                }
        
                private static IEnumerable<Attribute> GetGravestones()
                {
                    yield break;
                }
        
                private static IEnumerable<Attribute> GetWreaths()
                {
                    yield break;
                }
        
                private static IEnumerable<Attribute> GetServices()
                {
                    yield break;
                }
	}
}
