using System;
using System.Collections.Generic;
using S1API.Economy;
using S1API.GameTime;
using S1API.Products;
using S1API.Properties;
using S1API.Properties.Interfaces;
using S1API.Properties.Internal;
using ScheduleOne.Economy;
using ScheduleOne.Effects;
using ScheduleOne.GameTime;
using ScheduleOne.Product;
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
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(day) && Enum.TryParse(typeof(EDay), day, ignoreCase: true, out object result))
		{
			_data.PreferredOrderDay = (EDay)result;
		}
		return this;
	}

	public CustomerDataBuilder WithPreferredOrderDay(Day day)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(standards) && Enum.TryParse(typeof(ECustomerStandard), standards, ignoreCase: true, out object result))
		{
			_data.Standards = (ECustomerStandard)result;
		}
		return this;
	}

	public CustomerDataBuilder WithStandards(CustomerStandard standards)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
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
				foreach (ProductTypeAffinity productAffinity in _data.DefaultAffinityData.ProductAffinities)
				{
					if (productAffinity != null && productAffinity.DrugType == val)
					{
						val2 = productAffinity;
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
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
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
				foreach (ProductTypeAffinity productAffinity in _data.DefaultAffinityData.ProductAffinities)
				{
					if (productAffinity != null && productAffinity.DrugType == val)
					{
						val2 = productAffinity;
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
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		if (_data.DefaultAffinityData == null)
		{
			_data.DefaultAffinityData = new CustomerAffinityData();
		}
		ProductTypeAffinity val = null;
		foreach (ProductTypeAffinity productAffinity in _data.DefaultAffinityData.ProductAffinities)
		{
			if (productAffinity != null && (int)productAffinity.DrugType == (int)drugType)
			{
				val = productAffinity;
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
			Effect[] array3 = Resources.LoadAll<Effect>(text);
			if (array3 == null || array3.Length == 0)
			{
				continue;
			}
			foreach (string text2 in propertyNames)
			{
				if (string.IsNullOrEmpty(text2))
				{
					continue;
				}
				Effect val = null;
				Effect[] array4 = array3;
				foreach (Effect val2 in array4)
				{
					if ((Object)(object)val2 != (Object)null && string.Equals(((Object)val2).name, text2, StringComparison.OrdinalIgnoreCase))
					{
						val = val2;
						break;
					}
				}
				if ((Object)(object)val != (Object)null && !list.Contains(val))
				{
					list.Add(val);
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
			Effect[] array3 = Resources.LoadAll<Effect>(text);
			if (array3 == null || array3.Length == 0)
			{
				continue;
			}
			foreach (string text2 in propertyIds)
			{
				if (string.IsNullOrEmpty(text2))
				{
					continue;
				}
				Effect val = null;
				Effect[] array4 = array3;
				foreach (Effect val2 in array4)
				{
					if ((Object)(object)val2 != (Object)null && string.Equals(val2.ID, text2, StringComparison.OrdinalIgnoreCase))
					{
						val = val2;
						break;
					}
				}
				if ((Object)(object)val != (Object)null && !list.Contains(val))
				{
					list.Add(val);
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
		return source;
	}
}
