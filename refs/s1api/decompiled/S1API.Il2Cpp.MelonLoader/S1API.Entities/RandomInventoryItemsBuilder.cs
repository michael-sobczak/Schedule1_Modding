using System.Collections.Generic;
using UnityEngine;

namespace S1API.Entities;

public sealed class RandomInventoryItemsBuilder
{
	internal sealed class InventoryDefaultsData
	{
		public List<string> StartupItems { get; set; }

		public int? RandomCashMin { get; set; }

		public int? RandomCashMax { get; set; }

		public bool? ClearInventoryEachNight { get; set; }
	}

	private readonly List<string> _startupItems = new List<string>();

	private int? _randomCashMin;

	private int? _randomCashMax;

	private bool? _clearInventoryEachNight;

	internal RandomInventoryItemsBuilder()
	{
	}

	public RandomInventoryItemsBuilder WithRandomCash(int min, int max)
	{
		_randomCashMin = Mathf.Max(0, Mathf.Min(min, max));
		_randomCashMax = Mathf.Max(0, Mathf.Max(min, max));
		return this;
	}

	public RandomInventoryItemsBuilder WithStartupItem(string itemId)
	{
		if (!string.IsNullOrEmpty(itemId))
		{
			_startupItems.Add(itemId);
		}
		return this;
	}

	public RandomInventoryItemsBuilder WithStartupItems(params string[] itemIds)
	{
		if (itemIds == null)
		{
			return this;
		}
		foreach (string text in itemIds)
		{
			if (!string.IsNullOrEmpty(text))
			{
				_startupItems.Add(text);
			}
		}
		return this;
	}

	public RandomInventoryItemsBuilder WithClearInventoryEachNight(bool clearEachNight)
	{
		_clearInventoryEachNight = clearEachNight;
		return this;
	}

	internal InventoryDefaultsData BuildInternal()
	{
		bool? clearInventoryEachNight = _clearInventoryEachNight;
		if (!clearInventoryEachNight.HasValue && _startupItems.Count > 0)
		{
			clearInventoryEachNight = false;
		}
		return new InventoryDefaultsData
		{
			StartupItems = new List<string>(_startupItems),
			RandomCashMin = _randomCashMin,
			RandomCashMax = _randomCashMax,
			ClearInventoryEachNight = clearInventoryEachNight
		};
	}
}
