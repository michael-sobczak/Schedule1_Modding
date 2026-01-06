using System;
using System.Collections.Generic;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.Effects;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.Product;
using Il2CppSystem.Collections.Generic;
using S1API.Economy;
using S1API.GameTime;
using S1API.Products;
using S1API.Properties;
using S1API.Properties.Interfaces;
using S1API.Properties.Internal;
using UnityEngine;

namespace S1API.Entities.Customer;

public sealed class CustomerDataBuilder
{
	private readonly CustomerData _data;

	internal CustomerDataBuilder()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		_data = ScriptableObject.CreateInstance<CustomerData>();
		_data.DefaultAffinityData = new CustomerAffinityData();
	}

	public CustomerDataBuilder WithSpending(float minWeekly, float maxWeekly)
	{
		_data.MinWeeklySpend = Mathf.Max(0f, minWeekly);
		_data.MaxWeeklySpend = Mathf.Max(_data.MinWeeklySpend, maxWeekly);
		return this;
	}

	public CustomerDataBuilder WithOrdersPerWeek(int min, int max)
	{
		_data.MinOrdersPerWeek = Mathf.Clamp(min, 0, 7);
		_data.MaxOrdersPerWeek = Mathf.Clamp(Mathf.Max(min, max), 0, 7);
		return this;
	}

	public CustomerDataBuilder WithPreferredOrderDay(string day)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(day) && Enum.TryParse(typeof(EDay), day, ignoreCase: true, out object result))
		{
			_data.PreferredOrderDay = (EDay)result;
		}
		return this;
	}

	public CustomerDataBuilder WithPreferredOrderDay(Day day)
	{
		_data.PreferredOrderDay = (EDay)day;
		return this;
	}

	public CustomerDataBuilder WithOrderTime(int hhmm)
	{
		_data.OrderTime = Mathf.Clamp(hhmm, 0, 2359);
		return this;
	}

	public CustomerDataBuilder WithStandards(string standards)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(standards) && Enum.TryParse(typeof(ECustomerStandard), standards, ignoreCase: true, out object result))
		{
			_data.Standards = (ECustomerStandard)result;
		}
		return this;
	}

	public CustomerDataBuilder WithStandards(CustomerStandard standards)
	{
		_data.Standards = (ECustomerStandard)standards;
		return this;
	}

	public CustomerDataBuilder AllowDirectApproach(bool allow)
	{
		_data.CanBeDirectlyApproached = allow;
		return this;
	}

	public CustomerDataBuilder GuaranteeFirstSample(bool guarantee)
	{
		_data.GuaranteeFirstSampleSuccess = guarantee;
		return this;
	}

	public CustomerDataBuilder WithMutualRelationRequirement(float minAt50, float maxAt100)
	{
		_data.MinMutualRelationRequirement = Mathf.Clamp(minAt50, 0f, 5f);
		_data.MaxMutualRelationRequirement = Mathf.Clamp(maxAt100, 0f, 5f);
		return this;
	}

	public CustomerDataBuilder WithCallPoliceChance(float chance)
	{
		_data.CallPoliceChance = Mathf.Clamp01(chance);
		return this;
	}

	public CustomerDataBuilder WithDependence(float baseAddiction, float dependenceMultiplier = 1f)
	{
		_data.BaseAddiction = Mathf.Clamp01(baseAddiction);
		_data.DependenceMultiplier = Mathf.Clamp(dependenceMultiplier, 0f, 2f);
		return this;
	}

	public CustomerDataBuilder WithAffinities(IEnumerable<(string drugType, float affinity)> entries)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		_data.DefaultAffinityData = new CustomerAffinityData();
		Array values = Enum.GetValues(typeof(EDrugType));
		foreach (object item in values)
		{
			_data.DefaultAffinityData.ProductAffinities.Add(new ProductTypeAffinity
			{
				DrugType = (EDrugType)item,
				Affinity = 0f
			});
		}
		if (entries != null)
		{
			foreach (var (value, num) in entries)
			{
				if (string.IsNullOrEmpty(value) || !Enum.TryParse(typeof(EDrugType), value, ignoreCase: true, out object result))
				{
					continue;
				}
				EDrugType val = (EDrugType)result;
				ProductTypeAffinity val2 = null;
				Enumerator<ProductTypeAffinity> enumerator3 = _data.DefaultAffinityData.ProductAffinities.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					ProductTypeAffinity current2 = enumerator3.Current;
					if (current2 != null && current2.DrugType == val)
					{
						val2 = current2;
						break;
					}
				}
				if (val2 != null)
				{
					val2.Affinity = Mathf.Clamp(num, -1f, 1f);
				}
			}
		}
		return this;
	}

	public CustomerDataBuilder WithAffinities(IEnumerable<(DrugType drugType, float affinity)> entries)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		_data.DefaultAffinityData = new CustomerAffinityData();
		Array values = Enum.GetValues(typeof(EDrugType));
		foreach (object item3 in values)
		{
			_data.DefaultAffinityData.ProductAffinities.Add(new ProductTypeAffinity
			{
				DrugType = (EDrugType)item3,
				Affinity = 0f
			});
		}
		if (entries != null)
		{
			foreach (var entry in entries)
			{
				DrugType item = entry.drugType;
				float item2 = entry.affinity;
				EDrugType val = (EDrugType)item;
				ProductTypeAffinity val2 = null;
				Enumerator<ProductTypeAffinity> enumerator3 = _data.DefaultAffinityData.ProductAffinities.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					ProductTypeAffinity current3 = enumerator3.Current;
					if (current3 != null && current3.DrugType == val)
					{
						val2 = current3;
						break;
					}
				}
				if (val2 != null)
				{
					val2.Affinity = Mathf.Clamp(item2, -1f, 1f);
				}
			}
		}
		return this;
	}

	public CustomerDataBuilder WithAffinity(DrugType drugType, float affinity)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Invalid comparison between Unknown and I4
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		if (_data.DefaultAffinityData == null)
		{
			_data.DefaultAffinityData = new CustomerAffinityData();
		}
		ProductTypeAffinity val = null;
		Enumerator<ProductTypeAffinity> enumerator = _data.DefaultAffinityData.ProductAffinities.GetEnumerator();
		while (enumerator.MoveNext())
		{
			ProductTypeAffinity current = enumerator.Current;
			if (current != null && (int)current.DrugType == (int)drugType)
			{
				val = current;
				break;
			}
		}
		if (val == null)
		{
			_data.DefaultAffinityData.ProductAffinities.Add(new ProductTypeAffinity
			{
				DrugType = (EDrugType)drugType,
				Affinity = Mathf.Clamp(affinity, -1f, 1f)
			});
		}
		else
		{
			val.Affinity = Mathf.Clamp(affinity, -1f, 1f);
		}
		return this;
	}

	public CustomerDataBuilder WithPreferredPropertiesByName(params string[] propertyNames)
	{
		if (propertyNames == null || propertyNames.Length == 0)
		{
			return this;
		}
		List<Effect> list = new List<Effect>();
		string[] array = new string[5] { "Properties/Tier1", "Properties/Tier2", "Properties/Tier3", "Properties/Tier4", "Properties/Tier5" };
		string[] array2 = array;
		foreach (string text in array2)
		{
			Il2CppArrayBase<Effect> val = Resources.LoadAll<Effect>(text);
			if (val == null || val.Length == 0)
			{
				continue;
			}
			foreach (string text2 in propertyNames)
			{
				if (string.IsNullOrEmpty(text2))
				{
					continue;
				}
				Effect val2 = null;
				foreach (Effect item in val)
				{
					if ((Object)(object)item != (Object)null && string.Equals(((Object)item).name, text2, StringComparison.OrdinalIgnoreCase))
					{
						val2 = item;
						break;
					}
				}
				if ((Object)(object)val2 != (Object)null && !list.Contains(val2))
				{
					list.Add(val2);
				}
			}
		}
		_data.PreferredProperties = ToIl2CppList(list);
		return this;
	}

	public CustomerDataBuilder WithPreferredPropertiesById(params string[] propertyIds)
	{
		if (propertyIds == null || propertyIds.Length == 0)
		{
			return this;
		}
		List<Effect> list = new List<Effect>();
		string[] array = new string[5] { "Properties/Tier1", "Properties/Tier2", "Properties/Tier3", "Properties/Tier4", "Properties/Tier5" };
		string[] array2 = array;
		foreach (string text in array2)
		{
			Il2CppArrayBase<Effect> val = Resources.LoadAll<Effect>(text);
			if (val == null || val.Length == 0)
			{
				continue;
			}
			foreach (string text2 in propertyIds)
			{
				if (string.IsNullOrEmpty(text2))
				{
					continue;
				}
				Effect val2 = null;
				foreach (Effect item in val)
				{
					if ((Object)(object)item != (Object)null && string.Equals(item.ID, text2, StringComparison.OrdinalIgnoreCase))
					{
						val2 = item;
						break;
					}
				}
				if ((Object)(object)val2 != (Object)null && !list.Contains(val2))
				{
					list.Add(val2);
				}
			}
		}
		_data.PreferredProperties = ToIl2CppList(list);
		return this;
	}

	public CustomerDataBuilder WithPreferredProperties(params ProductPropertyWrapper[] wrappers)
	{
		if (wrappers == null || wrappers.Length == 0)
		{
			return this;
		}
		List<Effect> list = new List<Effect>();
		foreach (ProductPropertyWrapper productPropertyWrapper in wrappers)
		{
			if (productPropertyWrapper != null)
			{
				Effect innerProperty = productPropertyWrapper.InnerProperty;
				if ((Object)(object)innerProperty != (Object)null && !list.Contains(innerProperty))
				{
					list.Add(innerProperty);
				}
			}
		}
		_data.PreferredProperties = ToIl2CppList(list);
		return this;
	}

	public CustomerDataBuilder WithPreferredProperties(params PropertyBase[] properties)
	{
		if (properties == null || properties.Length == 0)
		{
			return this;
		}
		List<Effect> source = PropertyResolver.ResolveToGameProperties(properties);
		_data.PreferredProperties = ToIl2CppList(source);
		return this;
	}

	internal CustomerData BuildInternal()
	{
		return _data;
	}

	private static List<T> ToIl2CppList<T>(List<T> source)
	{
		List<T> val = new List<T>();
		if (source == null)
		{
			return val;
		}
		for (int i = 0; i < source.Count; i++)
		{
			val.Add(source[i]);
		}
		return val;
	}
}
