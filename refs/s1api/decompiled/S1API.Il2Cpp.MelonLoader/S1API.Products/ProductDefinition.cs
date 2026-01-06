using System.Collections.Generic;
using Il2CppScheduleOne.Effects;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Product;
using Il2CppSystem.Collections.Generic;
using S1API.Internal.Utils;
using S1API.Items;
using S1API.Properties;
using S1API.Properties.Interfaces;
using UnityEngine;

namespace S1API.Products;

public class ProductDefinition : ItemDefinition
{
	internal ProductDefinition S1ProductDefinition => CrossType.As<ProductDefinition>((object)base.S1ItemDefinition);

	public float Price => S1ProductDefinition.Price;

	public float BasePrice => S1ProductDefinition.BasePrice;

	public float MarketValue => S1ProductDefinition.MarketValue;

	public new Sprite Icon => ((ItemDefinition)S1ProductDefinition).Icon;

	public IReadOnlyList<PropertyBase> Properties
	{
		get
		{
			List<Effect> properties = ((PropertyItemDefinition)S1ProductDefinition).Properties;
			List<PropertyBase> list = new List<PropertyBase>(properties.Count);
			for (int i = 0; i < properties.Count; i++)
			{
				list.Add(new ProductPropertyWrapper(properties[i]));
			}
			return list.AsReadOnly();
		}
	}

	public IReadOnlyList<DrugTypeContainer> DrugTypes
	{
		get
		{
			List<DrugTypeContainer> drugTypes = S1ProductDefinition.DrugTypes;
			List<DrugTypeContainer> list = new List<DrugTypeContainer>(drugTypes?.Count ?? 0);
			if (drugTypes != null)
			{
				for (int i = 0; i < drugTypes.Count; i++)
				{
					list.Add(drugTypes[i]);
				}
			}
			return list.AsReadOnly();
		}
	}

	public EDrugType DrugType => S1ProductDefinition.DrugType;

	internal ProductDefinition(ItemDefinition productDefinition)
		: base(productDefinition)
	{
	}

	public override ItemInstance CreateInstance(int quantity = 1)
	{
		return new ProductInstance(CrossType.As<ProductItemInstance>((object)((ItemDefinition)S1ProductDefinition).GetDefaultInstance(quantity)));
	}
}
