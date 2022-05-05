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
			Day = 0;
			Place = null;
			Container = null;
			Services = new Dictionary<Attribute, int>();
			customerOrder = Customer.Order;
        }

		public Customer Customer { get; set; }
		public List<string> KeyWords { get; set; }
		public int Day { get; set; }
		public Place Place { get; set; }
		public Container Container { get; set; }
		public Dictionary<Attribute, int> Services { get; set; }
		private CustomerOrder customerOrder;
		private static double profitCoefficient = 1.65;

		public double Score
        {
            get
            {
				return
					  0.25 * Convert.ToInt32(Place.IsMatch(customerOrder.Ritual))
					+ 0.25 * Convert.ToInt32(Container.IsMatch(customerOrder.Ritual))
					+ 0.18 * servicesScore
					+ 0.12 * Convert.ToInt32(Day >= customerOrder.Deadlines.Item1 
										&& Day <= customerOrder.Deadlines.Item2)
					+ 0.10 * Convert.ToInt32(Container.Style == customerOrder.PreferredContainerStyle)
					+ 0.10 * Convert.ToInt32(Container.Palette == customerOrder.PreferredContainerPalette);
            }
        }

		public int Award
        {
            get
            {
				var selfCost = Container.Price + Place.Price + servicesCost;
				return (int)(Score * profitCoefficient * selfCost);
            }
        }

		private double servicesScore
        {
            get
            {
				var customerAttributes = customerOrder.PreferredServices;
				var singleAttributeScore = 1 / customerAttributes.Keys.Count;
				var score = 0;
				foreach (var attribute in customerAttributes.Keys)
                {
					var expectedQuantity = customerAttributes[attribute];
					var realQuantity = 0;
					Services.TryGetValue(attribute, out realQuantity);
					if (expectedQuantity >= realQuantity)
						score += singleAttributeScore;
					else
						score += singleAttributeScore * (realQuantity / expectedQuantity);
                }
				return score;
            }
        }

		private int servicesCost
        {
            get
            {
				var cost = 0;
				foreach(var attribute in Services.Keys)
                {
					cost += attribute.Price * Services[attribute];
                }
				return cost;
            }
		}
	}
}
