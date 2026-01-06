using System;
using System.Collections.Generic;
using System.Linq;
using S1API.Internal.Shops;
using S1API.Items;
using S1API.Logging;
using ScheduleOne.ItemFramework;
using ScheduleOne.UI.Shop;
using UnityEngine;

namespace S1API.Shops;

public static class ShopManager
{
	private static readonly Log Logger = new Log("ShopManager");

	private static readonly List<Shop> _cachedShops = new List<Shop>();

	private static bool _cacheValid = false;

	public static Shop[] GetAllShops()
	{
		RefreshCacheIfNeeded();
		return _cachedShops.ToArray();
	}

	public static Shop GetShopByName(string shopName)
	{
		if (string.IsNullOrEmpty(shopName))
		{
			return null;
		}
		return GetAllShops().FirstOrDefault((Shop s) => string.Equals(s.Name, shopName, StringComparison.OrdinalIgnoreCase));
	}

	public static Shop[] FindShopsByCategory(ItemCategory category)
	{
		return (from s in GetAllShops()
			where s.SellsCategory(category)
			select s).ToArray();
	}

	public static Shop[] FindShopsByItem(string itemId)
	{
		if (string.IsNullOrEmpty(itemId))
		{
			return Array.Empty<Shop>();
		}
		return (from s in GetAllShops()
			where s.HasItem(itemId)
			select s).ToArray();
	}

	public static int AddToCompatibleShops(ItemDefinition item, float? customPrice = null)
	{
		if (item == null)
		{
			return 0;
		}
		Shop[] array = FindShopsByCategory(item.Category);
		int num = 0;
		Shop[] array2 = array;
		foreach (Shop shop in array2)
		{
			if (shop.AddItem(item, customPrice))
			{
				num++;
			}
		}
		if (num > 0)
		{
			Logger.Msg($"Added item '{item.Name}' to {num} compatible shop(s)");
		}
		return num;
	}

	public static int AddToShops(ItemDefinition item, params string[] shopNames)
	{
		return AddToShops(item, null, shopNames);
	}

	public static int AddToShops(ItemDefinition item, float? customPrice, params string[] shopNames)
	{
		if (item == null || shopNames == null || shopNames.Length == 0)
		{
			return 0;
		}
		int num = 0;
		foreach (string shopName in shopNames)
		{
			Shop shopByName = GetShopByName(shopName);
			if (shopByName != null && shopByName.AddItem(item, customPrice))
			{
				num++;
			}
		}
		return num;
	}

	public static int RefreshItemIcon(ItemDefinition item)
	{
		if (item == null)
		{
			return 0;
		}
		return ShopIntegration.RefreshItemIconInShops(item);
	}

	public static int RefreshItemIcon(string itemId)
	{
		if (string.IsNullOrEmpty(itemId))
		{
			return 0;
		}
		Shop[] array = FindShopsByItem(itemId);
		if (array.Length == 0)
		{
			return 0;
		}
		Shop[] array2 = array;
		foreach (Shop shop in array2)
		{
			foreach (ShopListing listing in shop.S1ShopInterface.Listings)
			{
				if (((ItemDefinition)(listing?.Item?)).ID == itemId)
				{
					ItemDefinition itemDefinition = ItemManager.GetItemDefinition(itemId);
					if (itemDefinition != null)
					{
						return RefreshItemIcon(itemDefinition);
					}
					return 0;
				}
			}
		}
		return 0;
	}

	internal static void InvalidateCache()
	{
		_cacheValid = false;
		_cachedShops.Clear();
	}

	private static void RefreshCacheIfNeeded()
	{
		if (_cacheValid)
		{
			return;
		}
		_cachedShops.Clear();
		try
		{
			List<ShopInterface> allShops = ShopInterface.AllShops;
			if (allShops == null)
			{
				_cacheValid = true;
				return;
			}
			foreach (ShopInterface item in allShops)
			{
				if ((Object)(object)item != (Object)null)
				{
					_cachedShops.Add(new Shop(item));
				}
			}
			_cacheValid = true;
		}
		catch (Exception ex)
		{
			Logger.Error("Failed to refresh shop cache: " + ex.Message);
			_cacheValid = false;
		}
	}
}
