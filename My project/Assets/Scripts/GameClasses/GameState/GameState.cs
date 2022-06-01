using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clients;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
	public static partial class GameState
	{
		// Создаётся в MoneyUI
		public static void Restart(int money = 100)
		{
			var timer = GameObject.Find("Timer");
			if (timer != null)
				timer.GetComponent<Timer>().timeLeft = timer.GetComponent<Timer>().dayLength;
			StartMoney = money;
			Money = money;
			Day = 0;
			ServedClientsToday = 0;
			ServedClientsTotal = 0;
			SetGameObjects();
			Tasks = new List<string>();
			CurrentCustomer = CustomersToday[0];
			PlayerOrder = new PlayerOrder(CurrentCustomer);
			LastScene = "main";
		}
		
		public static int StartMoney { get; set; }
		public static int Money { get; set; }
		public static int TotalMoney { get; set; }
		public static int Day { get; set; }
		public static Customer CurrentCustomer { get; set; }
		public static int ServedClientsToday { get; set; }
		public static int ServedClientsTotal { get; set; }
		public static List<Customer> CustomersToday { get; set; }
		public static List<Container> Containers { get; set; }
		public static List<Attribute> Gravestones { get; set; }
		public static List<Attribute> Wreaths { get; set; }

		public static string LastScene;
		public static bool FalseCall;
		public static bool MatchesGone;
		
		public static PlayerOrder PlayerOrder { get; set; }
		public static int Score { get; set; }
		public static int TotalScore { get; set; }

		public static List<string> Tasks { get; set; }

		public static bool Paused { get; set; }
	}
}
