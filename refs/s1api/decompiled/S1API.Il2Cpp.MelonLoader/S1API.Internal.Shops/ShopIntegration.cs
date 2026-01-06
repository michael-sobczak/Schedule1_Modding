using System;
using System.Reflection;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.UI.Shop;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using S1API.Items;
using S1API.Logging;
using S1API.Shops;
using UnityEngine;

namespace S1API.Internal.Shops;

internal static class ShopIntegration
{
	private static readonly Log Logger = new Log("ShopIntegration");

	internal static bool AddItemToShop(Shop shop, ItemDefinition item, float? customPrice)
	{
		if ((Object)(object)shop?.S1ShopInterface == (Object)null || (Object)(object)item?.S1ItemDefinition == (Object)null)
		{
			return false;
		}
		StorableItemDefinition storableItemDefinition = item as StorableItemDefinition;
		if (storableItemDefinition == null)
		{
			Logger.Warning("Item '" + item.ID + "' is not storable and cannot be sold in shops.");
			return false;
		}
		try
		{
			ShopListing val = CreateListing(storableItemDefinition, customPrice);
			if (val == null)
			{
				return false;
			}
			shop.S1ShopInterface.Listings.Add(val);
			val.Initialize(shop.S1ShopInterface);
			CreateListingUI(shop.S1ShopInterface, val);
			return true;
		}
		catch (Exception ex)
		{
			Logger.Error($"Failed to add item '{item.ID}' to shop '{shop.Name}': {ex.Message}");
			return false;
		}
	}

	internal static bool RemoveItemFromShop(Shop shop, string itemId)
	{
		if ((Object)(object)shop?.S1ShopInterface == (Object)null || string.IsNullOrEmpty(itemId))
		{
			return false;
		}
		try
		{
			ShopListing val = null;
			Enumerator<ShopListing> enumerator = shop.S1ShopInterface.Listings.GetEnumerator();
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
					val = current;
					break;
				}
			}
			if (val == null)
			{
				return false;
			}
			shop.S1ShopInterface.Listings.Remove(val);
			RemoveListingUI(shop.S1ShopInterface, val);
			return true;
		}
		catch (Exception ex)
		{
			Logger.Error($"Failed to remove item '{itemId}' from shop '{shop.Name}': {ex.Message}");
			return false;
		}
	}

	private static ShopListing CreateListing(StorableItemDefinition item, float? customPrice)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		ShopListing result = new ShopListing
		{
			Item = item.S1StorableItemDefinition,
			name = item.Name
		};
		if (customPrice.HasValue && customPrice.Value != item.BasePurchasePrice)
		{
			Logger.Warning("Custom price override requested but not fully supported. Using item's BasePurchasePrice.");
		}
		return result;
	}

	private static void CreateListingUI(ShopInterface shop, ShopListing listing)
	{
		if ((Object)(object)shop.ListingUIPrefab == (Object)null || (Object)(object)shop.ListingContainer == (Object)null)
		{
			Logger.Warning("Shop '" + shop.ShopName + "' missing UI prefab or container");
			return;
		}
		GameObject val = Object.Instantiate<GameObject>(((Component)shop.ListingUIPrefab).gameObject, (Transform)(object)shop.ListingContainer);
		ListingUI component = val.GetComponent<ListingUI>();
		if ((Object)(object)component == (Object)null)
		{
			Logger.Error("Failed to get ListingUI component from instantiated prefab");
			Object.Destroy((Object)(object)val);
		}
		else
		{
			component.Initialize(listing);
			BindListingUIEvents(shop, component);
			AddToListingUICollection(shop, component);
		}
	}

	private static void BindListingUIEvents(ShopInterface shop, ListingUI listingUI)
	{
		listingUI.onClicked = Action.op_Implicit((Action)delegate
		{
			shop.ListingClicked(listingUI);
		});
		listingUI.onDropdownClicked = Action.op_Implicit((Action)delegate
		{
			shop.DropdownClicked(listingUI);
		});
		listingUI.hoverStart = Action.op_Implicit((Action)delegate
		{
			shop.EntryHovered(listingUI);
		});
		listingUI.hoverEnd = Action.op_Implicit((Action)delegate
		{
			shop.EntryUnhovered();
		});
	}

	private static void AddToListingUICollection(ShopInterface shop, ListingUI listingUI)
	{
		try
		{
			FieldInfo field = typeof(ShopInterface).GetField("listingUI", BindingFlags.Instance | BindingFlags.NonPublic);
			if (field != null && field.GetValue(shop) is List<ListingUI> val)
			{
				val.Add(listingUI);
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("Could not add ListingUI to shop's internal collection: " + ex.Message);
		}
	}

	internal static int RefreshItemIconInShops(ItemDefinition item)
	{
		if ((Object)(object)item?.S1ItemDefinition == (Object)null)
		{
			return 0;
		}
		int num = 0;
		try
		{
			Shop[] allShops = ShopManager.GetAllShops();
			Shop[] array = allShops;
			foreach (Shop shop in array)
			{
				if ((Object)(object)shop?.S1ShopInterface == (Object)null)
				{
					continue;
				}
				Enumerator<ShopListing> enumerator = shop.S1ShopInterface.Listings.GetEnumerator();
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
						StorableItemDefinition item2 = current.Item;
						obj = ((item2 != null) ? ((ItemDefinition)item2).ID : null);
					}
					if ((string?)obj == item.ID)
					{
						num += UpdateListingUIcons(shop.S1ShopInterface, current, item.Icon);
					}
				}
			}
		}
		catch (Exception ex)
		{
			Logger.Error("Failed to refresh item icon for '" + item.ID + "': " + ex.Message);
		}
		return num;
	}

	private static int UpdateListingUIcons(ShopInterface shop, ShopListing listing, Sprite newIcon)
	{
		if ((Object)(object)newIcon == (Object)null)
		{
			return 0;
		}
		int num = 0;
		try
		{
			FieldInfo field = typeof(ShopInterface).GetField("listingUI", BindingFlags.Instance | BindingFlags.NonPublic);
			if (field != null && field.GetValue(shop) is List<ListingUI> val)
			{
				Enumerator<ListingUI> enumerator = val.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListingUI current = enumerator.Current;
					if (((current != null) ? current.Listing : null) == listing && (Object)(object)current.Icon != (Object)null)
					{
						current.Icon.sprite = newIcon;
						num++;
					}
				}
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("Could not update ListingUI icons: " + ex.Message);
		}
		return num;
	}

	private static void RemoveListingUI(ShopInterface shop, ShopListing listing)
	{
		try
		{
			FieldInfo field = typeof(ShopInterface).GetField("listingUI", BindingFlags.Instance | BindingFlags.NonPublic);
			if (!(field != null) || !(field.GetValue(shop) is List<ListingUI> val))
			{
				return;
			}
			for (int num = val.Count - 1; num >= 0; num--)
			{
				ListingUI val2 = val[num];
				if (((val2 != null) ? val2.Listing : null) == listing)
				{
					if ((Object)(object)((Component)val2).gameObject != (Object)null)
					{
						Object.Destroy((Object)(object)((Component)val2).gameObject);
					}
					val.RemoveAt(num);
				}
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("Could not remove ListingUI from shop: " + ex.Message);
		}
	}
}
