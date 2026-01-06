using System.Collections.Generic;
using S1API.Internal.Shops;
using S1API.Items;
using ScheduleOne.ItemFramework;
using ScheduleOne.UI.Shop;
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
		foreach (ShopListing listing in S1ShopInterface.Listings)
		{
			if (((ItemDefinition)(listing?.Item?)).ID == itemId)
			{
				return true;
			}
		}
		return false;
	}

	public bool SellsCategory(ItemCategory category)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		EItemCategory val = (EItemCategory)category;
		foreach (ShopListing listing in S1ShopInterface.Listings)
		{
			if ((Object)(object)listing?.Item != (Object)null && ((ItemDefinition)listing.Item).Category == val)
			{
				return true;
			}
		}
		return false;
	}

	public string[] GetItemIds()
	{
		List<string> list = new List<string>();
		foreach (ShopListing listing in S1ShopInterface.Listings)
		{
			if ((Object)(object)listing?.Item != (Object)null)
			{
				list.Add(((ItemDefinition)listing.Item).ID);
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
