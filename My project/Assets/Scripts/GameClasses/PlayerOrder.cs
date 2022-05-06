using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    public class PlayerOrder
    {
		public PlayerOrder(Customer customer)
        {
			Customer = customer;
			Day = 0;
			Month = 0;
			Place = new Place(PlaceTypes.None);
			Container = new Container(ContainerTypes.None);
			Attributes = new List<Attribute>();
			customerOrder = Customer.Order;
        }

		public Customer Customer { get; set; }
		public int Day { get; set; }
		public int Month { get; set; }
		public Place Place { get; set; }
		public Container Container { get; set; }
		public List<Attribute> Attributes { get; set; }
		private CustomerOrder customerOrder;
		private static double profitCoefficient = 1.65;
		
		
		public int Award
		{
			get
			{
				var selfCost = Container.Price + Place.Price + servicesCost;
				return (int)(Score * profitCoefficient * selfCost);
			}
		}

		public int Stars
		{
			get
			{
				if (Score >= 0.75)
					return 3;
				if (Score >= 0.5)
					return 2;
				if (Score >= 0.25)
					return 1;
				return 0;
			}
		}

		private double Score
        {
            get
            {
				return
					  0.25 * Convert.ToInt32(Place.IsMatch(customerOrder.Ritual))
					+ 0.25 * Convert.ToInt32(Container.IsMatch(customerOrder.Ritual))
					+ 0.18 * servicesScore
					+ 0.12 * Convert.ToInt32(Day >= customerOrder.Deadlines.Item1 
										&& Day <= customerOrder.Deadlines.Item2 && Month == 5)
					+ 0.07 * Convert.ToInt32(Container.Style == customerOrder.PreferredContainerStyle)
					+ 0.06 * Convert.ToInt32(Container.Palette == customerOrder.PreferredContainerPalette)
					  + 0.07 * Convert.ToInt32(Place.Name == customerOrder.PlaceName);
            }
        }

		
		private double servicesScore
        {
            get
            {
				var customerAttributes = customerOrder.PreferredAttributes;
				if (customerAttributes.Count == 0)
					return 1;
				var singleAttributeScore = (double)1 / customerAttributes.Count;
				double score = 0;
				foreach (var attribute in customerAttributes)
					foreach (var a in Attributes)
						if (attribute.Name == a.Name)
							score += singleAttributeScore;
				return score;
            }
        }

		private int servicesCost
		{
			get
			{
				var cost = 0;
				foreach (var attribute in Attributes)
				{
					cost += attribute.Price;
				}

				return cost;
			}
		}
    }
}
