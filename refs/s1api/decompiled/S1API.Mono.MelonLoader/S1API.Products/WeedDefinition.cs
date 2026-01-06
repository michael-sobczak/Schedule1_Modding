using System;
using System.Collections.Generic;
using S1API.Internal.Utils;
using S1API.Items;
using S1API.Properties;
using S1API.Properties.Interfaces;
using ScheduleOne.Effects;
using ScheduleOne.ItemFramework;
using ScheduleOne.Product;

namespace S1API.Products;

public class WeedDefinition : ProductDefinition
{
	internal WeedDefinition S1WeedDefinition => CrossType.As<WeedDefinition>(base.S1ItemDefinition);

	internal WeedDefinition(WeedDefinition definition)
		: base((ItemDefinition)(object)definition)
	{
	}

	public override ItemInstance CreateInstance(int quantity = 1)
	{
		return new ProductInstance(CrossType.As<ProductItemInstance>(((ItemDefinition)S1WeedDefinition).GetDefaultInstance(quantity)));
	}

	public List<PropertyBase> GetProperties()
	{
		List<PropertyBase> list = new List<PropertyBase>();
		List<Effect> list2 = ((PropertyItemDefinition)(S1WeedDefinition?)).Properties;
		if (list2 != null)
		{
			for (int i = 0; i < list2.Count; i++)
			{
				list.Add(new ProductPropertyWrapper(list2[i]));
			}
		}
		return list;
	}

	[Obsolete("Use GetProperties() instead for IL2CPP compatibility")]
	public List<Effect> GetRawProperties()
	{
		List<Effect> list = new List<Effect>();
		List<Effect> list2 = ((PropertyItemDefinition)(S1WeedDefinition?)).Properties;
		if (list2 != null)
		{
			for (int i = 0; i < list2.Count; i++)
			{
				list.Add(list2[i]);
			}
		}
		return list;
	}
}
