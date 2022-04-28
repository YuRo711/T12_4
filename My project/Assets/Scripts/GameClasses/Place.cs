using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Game
{	public class Place
	{
		public Place(PlaceTypes type, string image = null, string name = "Unnamed")
        {
			Id = Count++;
			Name = name;
			Type = type;
			Image = (image != null) ? image : DefaultImage;
		}

		public int Id { get; set; }
		public PlaceTypes Type { get; set; }
		public string Name { get; set; }
		public string Image;
		private static int Count = 0;
		//Add default image
		public static string DefaultImage = null;
	}
}

