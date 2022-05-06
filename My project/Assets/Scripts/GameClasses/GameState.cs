using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clients;
using UnityEditor.Animations;
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
			Tasks = new List<string>();
			CurrentCustomer = CustomersToday[0];
			PlayerOrder = new PlayerOrder(CurrentCustomer);
			LastScene = "main";
        }

		public static void NextClient()
		{
			ServedClientsToday++;
			Tasks = new List<string>();
			if (CustomersToday.Count == ServedClientsToday)
				return;
			CurrentCustomer = CustomersToday[ServedClientsToday];
			PlayerOrder = new PlayerOrder(CurrentCustomer);
			var client = GameObject.Find("Client");
			client.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(CurrentCustomer.Sprite);
			client.GetComponent<Animator>().Play(CurrentCustomer.Name, 0, 0);
			client.GetComponent<DialogueWindow>().talked = false;
		}
		
		public static int Money { get; set; }
		public static int Day { get; set; }
		public static int Time { get; set; }
		public static Customer CurrentCustomer { get; set; }
		public static int ServedClientsToday { get; set; }
		public static int ServedClientsTotal { get; set; }
		public static List<Customer> CustomersToday { get; set; }
		public static List<Container> Containers { get; set; }
		public static List<Attribute> Gravestones { get; set; }
		public static List<Attribute> Wreaths { get; set; }

		public static string LastScene;
		
		public static PlayerOrder PlayerOrder { get; set; }
		public static List<Customer> Customers { get; set; }
		public static int Score { get; set; }

		public static List<string> Tasks { get; set; }

		public static bool Paused { get; set; }
		
		
		private static void SetGameObjects()
                {
                    Containers = GetContainers();
                    Gravestones = GetGravestones();
                    Wreaths = GetWreaths();
                    CustomersToday = GetCustomers();
                    /*
                    CustomerOrdersToday = GetOrders(Day);
                    */
                }
        
                //Add objects here
                private static List<Customer> GetCustomers()
                {
	                return new List<Customer> { new Customer("Sprites/Characters/Abigaile", "Abigaile"),
		                new Customer("Sprites/Characters/Harold", "Harold") };
                }
        
                private static List<Container> GetContainers()
                {
	                return new List<Container>
	                {
		                new Container(
			                ContainerTypes.Coffin,
			                "Sprites/coffin_5",
			                "Деревянный",
			                20),
		                new Container(
			                ContainerTypes.Coffin,
			                "Sprites/coffin_6",
			                "С крестом",
			                30,
			                ContainerStyles.Cross),
		                new Container(
			                ContainerTypes.Coffin,
			                "Sprites/coffin_4",
			                "Саркофаг",
			                80,
			                ContainerStyles.Rich),
		                
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
			                25,
			                ContainerStyles.Rich)
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
	}
}
