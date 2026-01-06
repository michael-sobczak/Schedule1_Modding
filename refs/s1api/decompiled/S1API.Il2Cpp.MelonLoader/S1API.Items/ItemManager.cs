using System;
using System.Collections.Generic;
using Il2CppScheduleOne;
using Il2CppScheduleOne.Clothing;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Product;
using Il2CppSystem.Collections.Generic;
using S1API.Internal.Utils;
using S1API.Money;
using S1API.Products;
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
		if (CrossType.Is<ProductDefinition>((object)item, out ProductDefinition result))
		{
			return new ProductDefinition((ItemDefinition)(object)result);
		}
		if (CrossType.Is<CashDefinition>((object)item, out CashDefinition result2))
		{
			return new CashDefinition(result2);
		}
		if (CrossType.Is<ClothingDefinition>((object)item, out ClothingDefinition result3))
		{
			return new ClothingItemDefinition(result3);
		}
		if (CrossType.Is<BuildableItemDefinition>((object)item, out BuildableItemDefinition result4))
		{
			return new BuildableItemDefinition(result4);
		}
		if (CrossType.Is<StorableItemDefinition>((object)item, out StorableItemDefinition result5))
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
		Enumerator<ItemDefinition> enumerator = allItems.GetEnumerator();
		while (enumerator.MoveNext())
		{
			ItemDefinition current = enumerator.Current;
			if ((Object)(object)current == (Object)null)
			{
				continue;
			}
			string text = null;
			try
			{
				text = current.ID;
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
