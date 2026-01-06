using System;
using System.Collections.Generic;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Quests;
using S1API.Products;

namespace S1API.Economy;

public sealed class Contract
{
	internal readonly Contract S1Contract;

	public float Payment => S1Contract.Payment;

	public int WindowStartTime => (S1Contract.DeliveryWindow != null) ? S1Contract.DeliveryWindow.WindowStartTime : 0;

	public int WindowEndTime => (S1Contract.DeliveryWindow != null) ? S1Contract.DeliveryWindow.WindowEndTime : 0;

	public int TotalQuantity
	{
		get
		{
			int num = 0;
			ProductList productList = S1Contract.ProductList;
			if (productList != null && productList.entries != null)
			{
				for (int i = 0; i < productList.entries.Count; i++)
				{
					num += Math.Max(0, productList.entries[i].Quantity);
				}
			}
			return num;
		}
	}

	internal Contract(Contract contract)
	{
		S1Contract = contract ?? throw new ArgumentNullException("contract");
	}

	public IEnumerable<(string productId, int quantity, Quality minQuality)> GetOrders()
	{
		ProductList list = S1Contract.ProductList;
		if (list != null && list.entries != null)
		{
			for (int i = 0; i < list.entries.Count; i++)
			{
				Entry e = list.entries[i];
				yield return (productId: e.ProductID, quantity: Math.Max(0, e.Quantity), minQuality: e.Quality.ToAPI());
			}
		}
	}
}
