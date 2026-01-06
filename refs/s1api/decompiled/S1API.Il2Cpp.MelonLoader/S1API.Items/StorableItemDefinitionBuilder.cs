using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Storage;
using UnityEngine;

namespace S1API.Items;

public sealed class StorableItemDefinitionBuilder
{
	private readonly StorableItemDefinition _definition;

	private readonly GameObject _storedItemPlaceholder;

	private bool _hasCustomStoredItem;

	internal StorableItemDefinitionBuilder()
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		_definition = ScriptableObject.CreateInstance<StorableItemDefinition>();
		((ItemDefinition)_definition).StackLimit = 10;
		_definition.BasePurchasePrice = 10f;
		_definition.ResellMultiplier = 0.5f;
		((ItemDefinition)_definition).Category = (EItemCategory)3;
		((ItemDefinition)_definition).legalStatus = (ELegalStatus)0;
		((ItemDefinition)_definition).AvailableInDemo = true;
		((ItemDefinition)_definition).UsableInFilters = true;
		((ItemDefinition)_definition).LabelDisplayColor = Color.white;
		_storedItemPlaceholder = new GameObject("S1API_DefaultStoredItem");
		_storedItemPlaceholder.SetActive(false);
		((Object)_storedItemPlaceholder).hideFlags = (HideFlags)61;
		Object.DontDestroyOnLoad((Object)(object)_storedItemPlaceholder);
		StoredItem storedItem = _storedItemPlaceholder.AddComponent<StoredItem>();
		_definition.StoredItem = storedItem;
	}

	public StorableItemDefinitionBuilder WithBasicInfo(string id, string name, string description, ItemCategory category)
	{
		((ItemDefinition)_definition).ID = id;
		((ItemDefinition)_definition).Name = name;
		((ItemDefinition)_definition).Description = description;
		((ItemDefinition)_definition).Category = (EItemCategory)category;
		string text = (string.IsNullOrEmpty(name) ? id : name);
		if (!string.IsNullOrEmpty(text))
		{
			((Object)_definition).name = text;
			if ((Object)(object)_storedItemPlaceholder != (Object)null && !_hasCustomStoredItem)
			{
				((Object)_storedItemPlaceholder).name = text + "_StoredItem";
			}
		}
		return this;
	}

	public StorableItemDefinitionBuilder WithStackLimit(int limit)
	{
		((ItemDefinition)_definition).StackLimit = Mathf.Clamp(limit, 1, 999);
		return this;
	}

	public StorableItemDefinitionBuilder WithIcon(Sprite icon)
	{
		((ItemDefinition)_definition).Icon = icon;
		return this;
	}

	public StorableItemDefinitionBuilder WithPricing(float basePurchasePrice, float resellMultiplier = 0.5f)
	{
		_definition.BasePurchasePrice = Mathf.Max(0f, basePurchasePrice);
		_definition.ResellMultiplier = Mathf.Clamp01(resellMultiplier);
		return this;
	}

	public StorableItemDefinitionBuilder WithLegalStatus(LegalStatus status)
	{
		((ItemDefinition)_definition).legalStatus = (ELegalStatus)status;
		return this;
	}

	public StorableItemDefinitionBuilder WithLabelColor(Color color)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((ItemDefinition)_definition).LabelDisplayColor = color;
		return this;
	}

	public StorableItemDefinitionBuilder WithKeywords(params string[] keywords)
	{
		((ItemDefinition)_definition).Keywords = Il2CppStringArray.op_Implicit(keywords);
		return this;
	}

	public StorableItemDefinitionBuilder WithEquippable(Equippable equippable)
	{
		if (equippable != null)
		{
			((ItemDefinition)_definition).Equippable = equippable.S1Equippable;
		}
		return this;
	}

	public StorableItemDefinitionBuilder WithStoredItem(GameObject storedItemPrefab)
	{
		if ((Object)(object)storedItemPrefab == (Object)null)
		{
			return this;
		}
		StoredItem storedItem = storedItemPrefab.GetComponent<StoredItem>() ?? storedItemPrefab.AddComponent<StoredItem>();
		_definition.StoredItem = storedItem;
		_hasCustomStoredItem = true;
		return this;
	}

	public StorableItemDefinitionBuilder WithDemoAvailability(bool available)
	{
		((ItemDefinition)_definition).AvailableInDemo = available;
		return this;
	}

	public StorableItemDefinition Build()
	{
		if (!_hasCustomStoredItem && (Object)(object)_definition.StoredItem != (Object)null && !string.IsNullOrEmpty(((ItemDefinition)_definition).Name) && (Object)(object)_storedItemPlaceholder != (Object)null)
		{
			((Object)_storedItemPlaceholder).name = ((ItemDefinition)_definition).Name + "_StoredItem";
		}
		Singleton<Registry>.Instance.AddToRegistry((ItemDefinition)(object)_definition);
		return new StorableItemDefinition(_definition);
	}

	internal StorableItemDefinition BuildInternal()
	{
		return _definition;
	}
}
