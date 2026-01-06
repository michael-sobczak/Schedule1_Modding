using System;
using System.Collections.Generic;
using S1API.Internal.Utils;
using S1API.Money;
using S1API.Products;
using ScheduleOne;
using ScheduleOne.Clothing;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Product;
using UnityEngine;

namespace S1API.Items;

public static class ItemManager
{
	public static ItemDefinition GetItemDefinition(string itemID)
	{
		ItemDefinition item = Registry.GetItem(itemID);
		if ((Object)(object)item == (Object)null)
		{
			return null;
		}
		if (CrossType.Is<ProductDefinition>(item, out var result))
		{
			return new ProductDefinition((ItemDefinition)(object)result);
		}
		if (CrossType.Is<CashDefinition>(item, out var result2))
		{
			return new CashDefinition(result2);
		}
		if (CrossType.Is<ClothingDefinition>(item, out var result3))
		{
			return new ClothingItemDefinition(result3);
		}
		if (CrossType.Is<BuildableItemDefinition>(item, out var result4))
		{
			return new BuildableItemDefinition(result4);
		}
		if (CrossType.Is<StorableItemDefinition>(item, out var result5))
		{
			return new StorableItemDefinition(result5);
		}
		return new ItemDefinition(item);
	}

	public static void RegisterItem(ItemDefinition definition)
	{
		if (definition == null)
		{
			throw new ArgumentNullException("definition", "Cannot register null item definition");
		}
		Singleton<Registry>.Instance.AddToRegistry(definition.S1ItemDefinition);
	}

	public static List<ItemDefinition> GetAllItemDefinitions()
	{
		if ((Object)(object)Singleton<Registry>.Instance == (Object)null)
		{
			return new List<ItemDefinition>();
		}
		List<ItemDefinition> allItems = Singleton<Registry>.Instance.GetAllItems();
		if (allItems == null)
		{
			return new List<ItemDefinition>();
		}
		List<ItemDefinition> list = new List<ItemDefinition>();
		foreach (ItemDefinition item in allItems)
		{
			if ((Object)(object)item == (Object)null)
			{
				continue;
			}
			string text = null;
			try
			{
				text = item.ID;
			}
			catch
			{
				continue;
			}
			if (!string.IsNullOrEmpty(text))
			{
				ItemDefinition itemDefinition = GetItemDefinition(text);
				if (itemDefinition != null)
				{
					list.Add(itemDefinition);
				}
			}
		}
		return list;
	}
}
