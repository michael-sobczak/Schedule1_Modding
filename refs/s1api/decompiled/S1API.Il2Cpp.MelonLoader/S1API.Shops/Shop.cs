using System.Collections.Generic;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.UI.Shop;
using Il2CppSystem.Collections.Generic;
using S1API.Internal.Shops;
using S1API.Items;
using UnityEngine;

namespace S1API.Shops;

public sealed class Shop
{
	internal ShopInterface S1ShopInterface { get; }

	public string Name => S1ShopInterface.ShopName;

	internal Shop(ShopInterface shopInterface)
	{
		S1ShopInterface = shopInterface;
	}

	public bool HasItem(string itemId)
	{
		if (string.IsNullOrEmpty(itemId))
		{
			return false;
		}
		Enumerator<ShopListing> enumerator = S1ShopInterface.Listings.GetEnumerator();
		while (enumerator.MoveNext())
		{
			ShopListing current = enumerator.Current;
			object obj;
			if (current == null)
			{
				obj = null;
			}
			else
			{
				StorableItemDefinition item = current.Item;
				obj = ((item != null) ? ((ItemDefinition)item).ID : null);
			}
			if ((string?)obj == itemId)
			{
				return true;
			}
		}
		return false;
	}

	public bool SellsCategory(ItemCategory category)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		EItemCategory val = (EItemCategory)category;
		Enumerator<ShopListing> enumerator = S1ShopInterface.Listings.GetEnumerator();
		while (enumerator.MoveNext())
		{
			ShopListing current = enumerator.Current;
			if ((Object)(object)((current != null) ? current.Item : null) != (Object)null && ((ItemDefinition)current.Item).Category == val)
			{
				return true;
			}
		}
		return false;
	}

	public string[] GetItemIds()
	{
		List<string> list = new List<string>();
		Enumerator<ShopListing> enumerator = S1ShopInterface.Listings.GetEnumerator();
		while (enumerator.MoveNext())
		{
			ShopListing current = enumerator.Current;
			if ((Object)(object)((current != null) ? current.Item : null) != (Object)null)
			{
				list.Add(((ItemDefinition)current.Item).ID);
			}
		}
		return list.ToArray();
	}

	public bool AddItem(ItemDefinition item, float? customPrice = null)
	{
		if (item == null)
		{
			return false;
		}
		if (HasItem(item.ID))
		{
			return false;
		}
		return ShopIntegration.AddItemToShop(this, item, customPrice);
	}

	public bool RemoveItem(string itemId)
	{
		if (string.IsNullOrEmpty(itemId))
		{
			return false;
		}
		return ShopIntegration.RemoveItemFromShop(this, itemId);
	}
}
