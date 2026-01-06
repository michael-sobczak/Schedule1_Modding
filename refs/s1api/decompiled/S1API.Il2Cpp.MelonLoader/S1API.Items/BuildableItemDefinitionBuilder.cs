using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace S1API.Items;

public sealed class BuildableItemDefinitionBuilder
{
	private readonly BuildableItemDefinition _definition;

	internal BuildableItemDefinitionBuilder()
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		_definition = ScriptableObject.CreateInstance<BuildableItemDefinition>();
		((ItemDefinition)_definition).StackLimit = 10;
		((StorableItemDefinition)_definition).BasePurchasePrice = 10f;
		((StorableItemDefinition)_definition).ResellMultiplier = 0.5f;
		((ItemDefinition)_definition).Category = (EItemCategory)4;
		((ItemDefinition)_definition).legalStatus = (ELegalStatus)0;
		((ItemDefinition)_definition).AvailableInDemo = true;
		((ItemDefinition)_definition).UsableInFilters = true;
		((ItemDefinition)_definition).LabelDisplayColor = Color.white;
		_definition.BuildSoundType = (EBuildSoundType)1;
	}

	internal BuildableItemDefinitionBuilder(BuildableItemDefinition source)
	{
		_definition = ScriptableObject.CreateInstance<BuildableItemDefinition>();
		CopyPropertiesFrom(source);
	}

	private void CopyPropertiesFrom(BuildableItemDefinition source)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		((ItemDefinition)_definition).Name = ((ItemDefinition)source).Name;
		((ItemDefinition)_definition).Description = ((ItemDefinition)source).Description;
		((ItemDefinition)_definition).Category = ((ItemDefinition)source).Category;
		((ItemDefinition)_definition).StackLimit = ((ItemDefinition)source).StackLimit;
		((ItemDefinition)_definition).Keywords = ((ItemDefinition)source).Keywords;
		((ItemDefinition)_definition).AvailableInDemo = ((ItemDefinition)source).AvailableInDemo;
		((ItemDefinition)_definition).UsableInFilters = ((ItemDefinition)source).UsableInFilters;
		((ItemDefinition)_definition).LabelDisplayColor = ((ItemDefinition)source).LabelDisplayColor;
		((ItemDefinition)_definition).Icon = ((ItemDefinition)source).Icon;
		((ItemDefinition)_definition).legalStatus = ((ItemDefinition)source).legalStatus;
		((StorableItemDefinition)_definition).PickpocketDifficultyMultiplier = ((StorableItemDefinition)source).PickpocketDifficultyMultiplier;
		((StorableItemDefinition)_definition).CombatUtility = ((StorableItemDefinition)source).CombatUtility;
		((StorableItemDefinition)_definition).BasePurchasePrice = ((StorableItemDefinition)source).BasePurchasePrice;
		((StorableItemDefinition)_definition).ResellMultiplier = ((StorableItemDefinition)source).ResellMultiplier;
		((StorableItemDefinition)_definition).ShopCategories = ((StorableItemDefinition)source).ShopCategories;
		((StorableItemDefinition)_definition).RequiresLevelToPurchase = ((StorableItemDefinition)source).RequiresLevelToPurchase;
		((StorableItemDefinition)_definition).RequiredRank = ((StorableItemDefinition)source).RequiredRank;
		_definition.BuildSoundType = source.BuildSoundType;
		_definition.BuiltItem = source.BuiltItem;
		((StorableItemDefinition)_definition).StoredItem = ((StorableItemDefinition)source).StoredItem;
		((ItemDefinition)_definition).Equippable = ((ItemDefinition)source).Equippable;
	}

	public BuildableItemDefinitionBuilder WithBasicInfo(string id, string name, string description)
	{
		((ItemDefinition)_definition).ID = id;
		((ItemDefinition)_definition).Name = name;
		((ItemDefinition)_definition).Description = description;
		if (!string.IsNullOrEmpty(name))
		{
			((Object)_definition).name = name;
		}
		return this;
	}

	public BuildableItemDefinitionBuilder WithBuildSound(BuildSoundType soundType)
	{
		_definition.BuildSoundType = (EBuildSoundType)soundType;
		return this;
	}

	public BuildableItemDefinitionBuilder WithIcon(Sprite icon)
	{
		((ItemDefinition)_definition).Icon = icon;
		return this;
	}

	public BuildableItemDefinitionBuilder WithPricing(float basePurchasePrice, float resellMultiplier = 0.5f)
	{
		((StorableItemDefinition)_definition).BasePurchasePrice = Mathf.Max(0f, basePurchasePrice);
		((StorableItemDefinition)_definition).ResellMultiplier = Mathf.Clamp01(resellMultiplier);
		return this;
	}

	public BuildableItemDefinitionBuilder WithCategory(ItemCategory category)
	{
		((ItemDefinition)_definition).Category = (EItemCategory)category;
		return this;
	}

	public BuildableItemDefinitionBuilder WithStackLimit(int limit)
	{
		((ItemDefinition)_definition).StackLimit = Mathf.Clamp(limit, 1, 999);
		return this;
	}

	public BuildableItemDefinitionBuilder WithKeywords(params string[] keywords)
	{
		((ItemDefinition)_definition).Keywords = Il2CppStringArray.op_Implicit(keywords);
		return this;
	}

	public BuildableItemDefinitionBuilder WithLabelColor(Color color)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((ItemDefinition)_definition).LabelDisplayColor = color;
		return this;
	}

	public BuildableItemDefinitionBuilder WithLegalStatus(LegalStatus status)
	{
		((ItemDefinition)_definition).legalStatus = (ELegalStatus)status;
		return this;
	}

	public BuildableItemDefinitionBuilder WithEquippable(Equippable equippable)
	{
		if (equippable != null)
		{
			((ItemDefinition)_definition).Equippable = equippable.S1Equippable;
		}
		return this;
	}

	public BuildableItemDefinition Build()
	{
		Singleton<Registry>.Instance.AddToRegistry((ItemDefinition)(object)_definition);
		return new BuildableItemDefinition(_definition);
	}

	internal BuildableItemDefinition BuildInternal()
	{
		return _definition;
	}
}
