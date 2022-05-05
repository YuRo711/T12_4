using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	public enum ContainerTypes
	{
		Coffin,
		Urn,
		None
	}

	public enum ContainerStyles
	{
		Classic,
		Custom
	}

	public enum ContainerPalette
	{
		Dark,
		Light,
		Color
	}

	public enum AttributeTypes
    {
		Service,
		Gravestone,
		Wreath
    }
	
	public enum PlaceTypes
	{
		Cemetery,
		Crematory,
		None
	}

	public enum RitualTypes
	{
		Funeral,
		Cremation
	}
}
