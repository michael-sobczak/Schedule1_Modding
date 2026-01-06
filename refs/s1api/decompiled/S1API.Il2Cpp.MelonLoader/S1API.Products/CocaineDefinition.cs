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

public class CocaineDefinition : ProductDefinition
{
	internal CocaineDefinition S1CocaineDefinition => CrossType.As<CocaineDefinition>((object)base.S1ItemDefinition);

	internal CocaineDefinition(CocaineDefinition definition)
		: base((ItemDefinition)(object)definition)
	{
	}

	public override ItemInstance CreateInstance(int quantity = 1)
	{
		return new ProductInstance(CrossType.As<ProductItemInstance>((object)((ItemDefinition)S1CocaineDefinition).GetDefaultInstance(quantity)));
	}

	public List<PropertyBase> GetProperties()
	{
		List<PropertyBase> list = new List<PropertyBase>();
		CocaineDefinition s1CocaineDefinition = S1CocaineDefinition;
		List<Effect> val = ((s1CocaineDefinition != null) ? ((PropertyItemDefinition)s1CocaineDefinition).Properties : null);
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
		CocaineDefinition s1CocaineDefinition = S1CocaineDefinition;
		List<Effect> val = ((s1CocaineDefinition != null) ? ((PropertyItemDefinition)s1CocaineDefinition).Properties : null);
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
