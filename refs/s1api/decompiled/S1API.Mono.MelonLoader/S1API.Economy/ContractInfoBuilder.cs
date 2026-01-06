using System;
using System.Collections.Generic;
using S1API.Map;
using S1API.Products;

namespace S1API.Economy;

public sealed class ContractInfoBuilder
{
	private float _payment;

	private readonly List<ContractInfo.OrderLine> _orders = new List<ContractInfo.OrderLine>();

	private DeliveryLocation _deliveryLocation;

	private (int startTime, int endTime)? _deliveryWindow;

	private bool _isCounterOffer;

	private bool _expires = true;

	private int _expiresAfterMinutes = 600;

	private int _pickupScheduleIndex = 0;

	public ContractInfoBuilder WithPayment(float payment)
	{
		_payment = Math.Max(0f, payment);
		return this;
	}

	public ContractInfoBuilder AddProduct(ProductDefinition definition, int quantity, Quality minQuality)
	{
		if (definition == null)
		{
			throw new ArgumentNullException("definition");
		}
		_orders.Add(new ContractInfo.OrderLine
		{
			ProductId = definition.ID,
			Quantity = Math.Max(1, quantity),
			MinQuality = minQuality
		});
		return this;
	}

	public ContractInfoBuilder AddProducts(IEnumerable<(ProductDefinition definition, int quantity, Quality minQuality)> products)
	{
		if (products == null)
		{
			return this;
		}
		foreach (var (definition, quantity, minQuality) in products)
		{
			AddProduct(definition, quantity, minQuality);
		}
		return this;
	}

	public ContractInfoBuilder WithDeliveryLocation(DeliveryLocation location)
	{
		_deliveryLocation = location;
		return this;
	}

	public ContractInfoBuilder WithDeliveryLocationByName(string locationName)
	{
		_deliveryLocation = DeliveryLocation.GetByName(locationName);
		return this;
	}

	public ContractInfoBuilder WithDeliveryLocationByGuid(string locationGuid)
	{
		_deliveryLocation = DeliveryLocation.GetByGuid(locationGuid);
		return this;
	}

	public ContractInfoBuilder WithDeliveryWindow(int startTime, int endTime)
	{
		_deliveryWindow = (ClampTime(startTime), ClampTime(endTime));
		return this;
	}

	public ContractInfoBuilder WithDeliveryWindow(TimeSpan startTime, TimeSpan endTime)
	{
		int startTime2 = (int)(startTime.TotalHours * 100.0) + startTime.Minutes;
		int endTime2 = (int)(endTime.TotalHours * 100.0) + endTime.Minutes;
		return WithDeliveryWindow(startTime2, endTime2);
	}

	public ContractInfoBuilder WithoutDeliveryWindow()
	{
		_deliveryWindow = null;
		return this;
	}

	public ContractInfoBuilder AsCounterOffer(bool isCounterOffer = true)
	{
		_isCounterOffer = isCounterOffer;
		return this;
	}

	public ContractInfoBuilder WithExpiration(bool expires)
	{
		_expires = expires;
		return this;
	}

	public ContractInfoBuilder ExpiresAfter(int minutes)
	{
		_expiresAfterMinutes = Math.Max(0, minutes);
		return this;
	}

	public ContractInfoBuilder WithPickupScheduleIndex(int index)
	{
		_pickupScheduleIndex = Math.Max(0, index);
		return this;
	}

	public static ContractInfo QuickContract(ProductDefinition definition, int quantity, float payment, Quality minQuality = Quality.Standard)
	{
		return new ContractInfoBuilder().WithPayment(payment).AddProduct(definition, quantity, minQuality).Build();
	}

	public ContractInfo Build()
	{
		if (_orders.Count == 0)
		{
			throw new InvalidOperationException("Contract must have at least one product");
		}
		ContractInfo contractInfo = new ContractInfo
		{
			Payment = _payment,
			DeliveryLocationGuid = (_deliveryLocation?.GUID ?? string.Empty),
			DeliveryWindow = _deliveryWindow,
			IsCounterOffer = _isCounterOffer,
			Expires = _expires,
			ExpiresAfterMinutes = _expiresAfterMinutes,
			PickupScheduleIndex = _pickupScheduleIndex
		};
		foreach (ContractInfo.OrderLine order in _orders)
		{
			contractInfo.Orders.Add(order);
		}
		return contractInfo;
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
}
