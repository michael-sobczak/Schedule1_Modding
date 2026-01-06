using System.Collections.Generic;
using S1API.Internal.Utils;
using S1API.Items;
using S1API.Properties;
using S1API.Properties.Interfaces;
using ScheduleOne.Effects;
using ScheduleOne.ItemFramework;
using ScheduleOne.Product;
using UnityEngine;

namespace S1API.Products;

public sealed class ShroomDefinition : ProductDefinition
{
	internal ShroomDefinition S1ShroomDefinition => CrossType.As<ShroomDefinition>(base.S1ItemDefinition);

	public Material ShroomMaterial => S1ShroomDefinition.ShroomMaterial;

	public Material BulkMaterial => S1ShroomDefinition.BulkMaterial;

	public Material EyeballMaterial => S1ShroomDefinition.EyeballMaterial;

	public ShroomAppearanceSettings AppearanceSettings => new ShroomAppearanceSettings(S1ShroomDefinition.AppearanceSettings);

	internal ShroomDefinition(ShroomDefinition definition)
		: base((ItemDefinition)(object)definition)
	{
	}

	public override ItemInstance CreateInstance(int quantity = 1)
	{
		return new ProductInstance(CrossType.As<ProductItemInstance>(((ItemDefinition)S1ShroomDefinition).GetDefaultInstance(quantity)));
	}

	public List<PropertyBase> GetProperties()
	{
		List<PropertyBase> list = new List<PropertyBase>();
		List<Effect> list2 = ((PropertyItemDefinition)(S1ShroomDefinition?)).Properties;
		if (list2 != null)
		{
			for (int i = 0; i < list2.Count; i++)
			{
				list.Add(new ProductPropertyWrapper(list2[i]));
			}
		}
		return list;
	}
}
