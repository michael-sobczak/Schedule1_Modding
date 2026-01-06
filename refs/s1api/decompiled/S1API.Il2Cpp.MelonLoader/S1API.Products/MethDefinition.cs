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

public class MethDefinition : ProductDefinition
{
	internal MethDefinition S1MethDefinition => CrossType.As<MethDefinition>((object)base.S1ItemDefinition);

	internal MethDefinition(MethDefinition definition)
		: base((ItemDefinition)(object)definition)
	{
	}

	public override ItemInstance CreateInstance(int quantity = 1)
	{
		return new ProductInstance(CrossType.As<ProductItemInstance>((object)((ItemDefinition)S1MethDefinition).GetDefaultInstance(quantity)));
	}

	public List<PropertyBase> GetProperties()
	{
		List<PropertyBase> list = new List<PropertyBase>();
		MethDefinition s1MethDefinition = S1MethDefinition;
		List<Effect> val = ((s1MethDefinition != null) ? ((PropertyItemDefinition)s1MethDefinition).Properties : null);
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
		MethDefinition s1MethDefinition = S1MethDefinition;
		List<Effect> val = ((s1MethDefinition != null) ? ((PropertyItemDefinition)s1MethDefinition).Properties : null);
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
