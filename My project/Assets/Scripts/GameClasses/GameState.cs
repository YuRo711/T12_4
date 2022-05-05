using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

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
			CurrentOrder = new List<IPreference>();
			LastScene = "main";
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

		public static string LastScene;
		
		public static List<IPreference> CurrentOrder { get; set; }
		public static List<Customer> Customers { get; set; }
		public static List<string> DialogueQueue { get; set; } = new List<string>();

		public static List<string> Tasks { get; set; }

		public static bool Paused { get; set; }
		
		
		private static void SetGameObjects()
                {
                    Containers = GetContainers();
                    Gravestones = GetGravestones();
                    Wreaths = GetWreaths();
                    /*
                    Services = GetServices();
                    Customers = GetCustomers();
                    CustomerOrdersToday = GetOrders(Day);
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
        
                private static List<Container> GetContainers()
                {
	                return new List<Container>
	                {
		                new Container(
			                ContainerTypes.Coffin,
			                "Sprites/coffin_1",
			                "Спортивный",
			                30),
		                new Container(
			                ContainerTypes.Coffin,
			                "Sprites/coffin_2",
			                "Гламур",
			                40),
		                new Container(
			                ContainerTypes.Coffin,
			                "Sprites/coffin_3",
			                "BBQ",
			                45),
		                
		                new Container(
			                ContainerTypes.Urn,
			                "Sprites/urn_1",
			                "Классика",
			                10),
		                new Container(
			                ContainerTypes.Urn,
			                "Sprites/urn_3",
			                "Яркая",
			                15),
		                new Container(
			                ContainerTypes.Urn,
			                "Sprites/urn_2",
			                "Ар-деко",
			                20)
	                };
                }
        
                private static List<Attribute> GetGravestones()
                {
	                return new List<Attribute>
	                {
		                new Attribute(
			                AttributeTypes.Gravestone,
			                "Sprites/stone_1",
			                "Кельтский крест",
			                50),
		                new Attribute(
			                AttributeTypes.Gravestone,
			                "Sprites/stone_2",
			                "Готика",
			                40),
		                new Attribute(
			                AttributeTypes.Gravestone,
			                "Sprites/stone_3",
			                "Классика",
			                30)
	                };
                }
        
                private static List<Attribute> GetWreaths()
                {
	                return new List<Attribute>();
                }
        
                private static IEnumerable<Attribute> GetServices()
                {
                    yield break;
                }
	}
}
