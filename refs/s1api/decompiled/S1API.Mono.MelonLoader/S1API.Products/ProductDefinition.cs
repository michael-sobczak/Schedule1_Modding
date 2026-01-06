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

public class ProductDefinition : ItemDefinition
{
	internal ProductDefinition S1ProductDefinition => CrossType.As<ProductDefinition>(base.S1ItemDefinition);

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

	public List<DrugTypeContainer> DrugTypes => S1ProductDefinition.DrugTypes;

	public EDrugType DrugType => S1ProductDefinition.DrugType;

	internal ProductDefinition(ItemDefinition productDefinition)
		: base(productDefinition)
	{
	}

	public override ItemInstance CreateInstance(int quantity = 1)
	{
		return new ProductInstance(CrossType.As<ProductItemInstance>(((ItemDefinition)S1ProductDefinition).GetDefaultInstance(quantity)));
	}
}
