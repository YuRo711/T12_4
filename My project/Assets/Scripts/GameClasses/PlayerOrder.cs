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
			Day = 0;
			Month = 0;
			Place = new Place(PlaceTypes.None, "none");
			Coffin = new Container(ContainerTypes.None);
			Urn = new Container(ContainerTypes.None);
			Attributes = new List<Attribute>();
			customerOrder = customer.Order;
			CustomerName = customer.Name;
        }

		public string CustomerName { get; set; }
		public int Day { get; set; }
		public int Month { get; set; }
		public Place Place { get; set; }
		public Container Coffin { get; set; }
		public Container Urn { get; set; }
		public List<Attribute> Attributes { get; set; }
		private CustomerOrder customerOrder;
		private static double profitCoefficient = 1.65;
		
		
		public int Award
		{
			get
			{
				if (CustomerName == "Milly")
					return (Stars == 3) ? 1 : 0;
				if (CustomerName == "Robber")
					return Math.Max(-100, -GameState.Money);
				var selfCost = Coffin.Price + Place.Price + servicesCost;
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
					  0.25 * Convert.ToInt32(Place.IsMatch(customerOrder.Ritual)) + 0.12
					+ 0.38 * containerScore
					+ 0.18 * servicesScore
					+ 0.12 * Convert.ToInt32(Day >= customerOrder.Deadlines.Item1 
										&& Day <= customerOrder.Deadlines.Item2 && Month == 5)
					  + 0.07 * Convert.ToInt32(Place.Name == customerOrder.PlaceName);
            }
        }

		
		private double servicesScore
        {
            get
            {
				var customerAttributes = customerOrder.PreferredAttributes;
				if (customerAttributes == null)
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

		private double containerScore
		{
			get
			{
				var cremation = customerOrder.Ritual == RitualTypes.Cremation;
				var score = 0.6 * Convert.ToInt32(Coffin.Type == ContainerTypes.Coffin)
				            + 0.4 * Convert.ToInt32(Coffin.Style == customerOrder.PreferredContainerStyle
				                              || customerOrder.PreferredContainerStyle == ContainerStyles.None);
				if (cremation)
					return 0.5 * score
					       + 0.3 * Convert.ToInt32(Urn.Type == ContainerTypes.Urn)
					       + 0.2 * Convert.ToInt32(Urn.Style == customerOrder.PreferredContainerStyle
					                               || customerOrder.PreferredContainerStyle == ContainerStyles.None);
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
