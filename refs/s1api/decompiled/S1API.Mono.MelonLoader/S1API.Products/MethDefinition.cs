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

public class MethDefinition : ProductDefinition
{
	internal MethDefinition S1MethDefinition => CrossType.As<MethDefinition>(base.S1ItemDefinition);

	internal MethDefinition(MethDefinition definition)
		: base((ItemDefinition)(object)definition)
	{
	}

	public override ItemInstance CreateInstance(int quantity = 1)
	{
		return new ProductInstance(CrossType.As<ProductItemInstance>(((ItemDefinition)S1MethDefinition).GetDefaultInstance(quantity)));
	}

	public List<PropertyBase> GetProperties()
	{
		List<PropertyBase> list = new List<PropertyBase>();
		List<Effect> list2 = ((PropertyItemDefinition)(S1MethDefinition?)).Properties;
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
		List<Effect> list2 = ((PropertyItemDefinition)(S1MethDefinition?)).Properties;
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
