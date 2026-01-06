using System;
using System.Collections.Generic;
using Il2CppScheduleOne.Effects;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Product;
using Il2CppSystem.Collections.Generic;
using S1API.Internal.Utils;
using S1API.Items;
using S1API.Properties;
using S1API.Properties.Interfaces;

namespace S1API.Products;

public class WeedDefinition : ProductDefinition
{
	internal WeedDefinition S1WeedDefinition => CrossType.As<WeedDefinition>((object)base.S1ItemDefinition);

	internal WeedDefinition(WeedDefinition definition)
		: base((ItemDefinition)(object)definition)
	{
	}

	public override ItemInstance CreateInstance(int quantity = 1)
	{
		return new ProductInstance(CrossType.As<ProductItemInstance>((object)((ItemDefinition)S1WeedDefinition).GetDefaultInstance(quantity)));
	}

	public List<PropertyBase> GetProperties()
	{
		List<PropertyBase> list = new List<PropertyBase>();
		WeedDefinition s1WeedDefinition = S1WeedDefinition;
		List<Effect> val = ((s1WeedDefinition != null) ? ((PropertyItemDefinition)s1WeedDefinition).Properties : null);
		if (val != null)
		{
			for (int i = 0; i < val.Count; i++)
			{
				list.Add(new ProductPropertyWrapper(val[i]));
			}
		}
		return list;
	}

	[Obsolete("Use GetProperties() instead for IL2CPP compatibility")]
	public List<Effect> GetRawProperties()
	{
		List<Effect> list = new List<Effect>();
		WeedDefinition s1WeedDefinition = S1WeedDefinition;
		List<Effect> val = ((s1WeedDefinition != null) ? ((PropertyItemDefinition)s1WeedDefinition).Properties : null);
		if (val != null)
		{
			for (int i = 0; i < val.Count; i++)
			{
				list.Add(val[i]);
			}
		}
		return list;
	}
}
