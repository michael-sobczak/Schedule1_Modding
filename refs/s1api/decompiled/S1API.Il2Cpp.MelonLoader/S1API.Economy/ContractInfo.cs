using System;
using System.Collections.Generic;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Quests;
using S1API.Products;

namespace S1API.Economy;

public sealed class ContractInfo
{
	public sealed class OrderLine
	{
		public string ProductId { get; set; }

		public int Quantity { get; set; }

		public Quality MinQuality { get; set; }
	}

	public float Payment { get; set; }

	public List<OrderLine> Orders { get; } = new List<OrderLine>();

	public string DeliveryLocationGuid { get; set; }

	public (int startTime, int endTime)? DeliveryWindow { get; set; }

	public bool IsCounterOffer { get; set; }

	public bool Expires { get; set; } = true;

	public int ExpiresAfterMinutes { get; set; } = 600;

	public int PickupScheduleIndex { get; set; } = 0;

	public ContractInfo AddProduct(ProductDefinition definition, int quantity, Quality minQuality)
	{
		if (definition == null)
		{
			throw new ArgumentNullException("definition");
		}
		return AddProductById(definition.ID, quantity, minQuality);
	}

	public ContractInfo AddProductById(string productId, int quantity, Quality minQuality)
	{
		if (string.IsNullOrWhiteSpace(productId))
		{
			throw new ArgumentException("Product ID cannot be empty", "productId");
		}
		Orders.Add(new OrderLine
		{
			ProductId = productId,
			Quantity = Math.Max(1, quantity),
			MinQuality = minQuality
		});
		return this;
	}

	public ContractInfo WithWindow(int startTime, int endTime)
	{
		DeliveryWindow = (ClampTime(startTime), ClampTime(endTime));
		return this;
	}

	private static int ClampTime(int hhmm)
	{
		if (hhmm < 0)
		{
			return 0;
		}
		if (hhmm > 2359)
		{
			return 2359;
		}
		return hhmm;
	}

	internal ContractInfo ToInternal()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		ProductList val = new ProductList();
		for (int i = 0; i < Orders.Count; i++)
		{
			OrderLine orderLine = Orders[i];
			val.entries.Add(new Entry
			{
				ProductID = orderLine.ProductId,
				Quantity = Math.Max(1, orderLine.Quantity),
				Quality = orderLine.MinQuality.ToInternal()
			});
		}
		QuestWindowConfig val2 = new QuestWindowConfig
		{
			IsEnabled = DeliveryWindow.HasValue,
			WindowStartTime = (DeliveryWindow?.startTime ?? 0),
			WindowEndTime = (DeliveryWindow?.endTime ?? 0)
		};
		return new ContractInfo(Math.Max(0f, Payment), val, DeliveryLocationGuid ?? string.Empty, val2, Expires, Math.Max(0, ExpiresAfterMinutes), Math.Max(0, PickupScheduleIndex), IsCounterOffer);
	}
}
