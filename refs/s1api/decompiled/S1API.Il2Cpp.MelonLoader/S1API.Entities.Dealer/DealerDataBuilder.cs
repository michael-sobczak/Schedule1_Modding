using S1API.Economy;
using S1API.Map;
using UnityEngine;

namespace S1API.Entities.Dealer;

public sealed class DealerDataBuilder
{
	internal class DealerConfigData
	{
		public float SigningFee { get; set; } = 500f;

		public float Cut { get; set; } = 0.2f;

		public DealerType DealerType { get; set; } = DealerType.PlayerDealer;

		public string HomeName { get; set; } = "Home";

		public global::S1API.Map.Building? Home { get; set; } = null;

		public bool SellInsufficientQualityItems { get; set; } = false;

		public bool SellExcessQualityItems { get; set; } = true;

		public string CompletedDealsVariable { get; set; } = string.Empty;
	}

	private readonly DealerConfigData _data;

	internal DealerDataBuilder()
	{
		_data = new DealerConfigData();
	}

	public DealerDataBuilder WithSigningFee(float fee)
	{
		_data.SigningFee = Mathf.Max(0f, fee);
		return this;
	}

	public DealerDataBuilder WithCut(float percentage)
	{
		_data.Cut = Mathf.Clamp01(percentage);
		return this;
	}

	public DealerDataBuilder WithDealerType(DealerType type)
	{
		_data.DealerType = type;
		return this;
	}

	public DealerDataBuilder WithHomeName(string name)
	{
		_data.HomeName = name ?? "Home";
		return this;
	}

	public DealerDataBuilder WithHome(global::S1API.Map.Building building)
	{
		_data.Home = building;
		if (building != null)
		{
			_data.HomeName = building.Name;
		}
		return this;
	}

	public DealerDataBuilder AllowInsufficientQuality(bool allow)
	{
		_data.SellInsufficientQualityItems = allow;
		return this;
	}

	public DealerDataBuilder AllowExcessQuality(bool allow)
	{
		_data.SellExcessQualityItems = allow;
		return this;
	}

	public DealerDataBuilder WithCompletedDealsVariable(string varName)
	{
		_data.CompletedDealsVariable = varName ?? string.Empty;
		return this;
	}

	internal DealerConfigData BuildInternal()
	{
		return _data;
	}
}
