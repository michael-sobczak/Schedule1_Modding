using System.Collections.Generic;
using ScheduleOne;
using ScheduleOne.Clothing;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace S1API.Items;

public sealed class ClothingItemDefinitionBuilder
{
	private readonly ClothingDefinition _definition;

	internal ClothingItemDefinitionBuilder()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		_definition = ScriptableObject.CreateInstance<ClothingDefinition>();
		((ItemDefinition)_definition).StackLimit = 10;
		((StorableItemDefinition)_definition).BasePurchasePrice = 10f;
		((StorableItemDefinition)_definition).ResellMultiplier = 0.5f;
		((ItemDefinition)_definition).Category = (EItemCategory)11;
		((ItemDefinition)_definition).legalStatus = (ELegalStatus)0;
		((ItemDefinition)_definition).AvailableInDemo = true;
		((ItemDefinition)_definition).UsableInFilters = true;
		((ItemDefinition)_definition).LabelDisplayColor = Color.white;
		_definition.Slot = (EClothingSlot)8;
		_definition.ApplicationType = (EClothingApplicationType)2;
		_definition.ClothingAssetPath = "Path/To/Clothing/Asset";
		_definition.Colorable = true;
		_definition.DefaultColor = (EClothingColor)0;
		_definition.SlotsToBlock = new List<EClothingSlot>();
	}

	internal ClothingItemDefinitionBuilder(ClothingDefinition source)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		_definition = ScriptableObject.CreateInstance<ClothingDefinition>();
		((ItemDefinition)_definition).ID = ((ItemDefinition)source).ID;
		((ItemDefinition)_definition).Name = ((ItemDefinition)source).Name;
		((ItemDefinition)_definition).Description = ((ItemDefinition)source).Description;
		((ItemDefinition)_definition).Icon = ((ItemDefinition)source).Icon;
		((ItemDefinition)_definition).StackLimit = ((ItemDefinition)source).StackLimit;
		((StorableItemDefinition)_definition).BasePurchasePrice = ((StorableItemDefinition)source).BasePurchasePrice;
		((StorableItemDefinition)_definition).ResellMultiplier = ((StorableItemDefinition)source).ResellMultiplier;
		((ItemDefinition)_definition).Category = ((ItemDefinition)source).Category;
		((ItemDefinition)_definition).legalStatus = ((ItemDefinition)source).legalStatus;
		((ItemDefinition)_definition).AvailableInDemo = ((ItemDefinition)source).AvailableInDemo;
		((ItemDefinition)_definition).UsableInFilters = ((ItemDefinition)source).UsableInFilters;
		((ItemDefinition)_definition).LabelDisplayColor = ((ItemDefinition)source).LabelDisplayColor;
		((ItemDefinition)_definition).Keywords = ((ItemDefinition)source).Keywords;
		((StorableItemDefinition)_definition).StoredItem = ((StorableItemDefinition)source).StoredItem;
		((ItemDefinition)_definition).Equippable = ((ItemDefinition)source).Equippable;
		_definition.Slot = source.Slot;
		_definition.ApplicationType = source.ApplicationType;
		_definition.ClothingAssetPath = source.ClothingAssetPath;
		_definition.Colorable = source.Colorable;
		_definition.DefaultColor = source.DefaultColor;
		_definition.SlotsToBlock = new List<EClothingSlot>(source.SlotsToBlock);
	}

	public ClothingItemDefinitionBuilder WithBasicInfo(string id, string name, string description)
	{
		((ItemDefinition)_definition).ID = id;
		((ItemDefinition)_definition).Name = name;
		((ItemDefinition)_definition).Description = description;
		((Object)_definition).name = (string.IsNullOrEmpty(name) ? id : name);
		return this;
	}

	public ClothingItemDefinitionBuilder WithSlot(ClothingSlot slot)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		_definition.Slot = (EClothingSlot)slot;
		return this;
	}

	public ClothingItemDefinitionBuilder WithApplicationType(ClothingApplicationType applicationType)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		_definition.ApplicationType = (EClothingApplicationType)applicationType;
		return this;
	}

	public ClothingItemDefinitionBuilder WithClothingAsset(string assetPath)
	{
		_definition.ClothingAssetPath = assetPath;
		return this;
	}

	public ClothingItemDefinitionBuilder WithColorable(bool colorable)
	{
		_definition.Colorable = colorable;
		return this;
	}

	public ClothingItemDefinitionBuilder WithDefaultColor(ClothingColor color)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		_definition.DefaultColor = (EClothingColor)color;
		return this;
	}

	public ClothingItemDefinitionBuilder WithBlockedSlots(params ClothingSlot[] slots)
	{
		_definition.SlotsToBlock = new List<EClothingSlot>();
		foreach (ClothingSlot clothingSlot in slots)
		{
			_definition.SlotsToBlock.Add((EClothingSlot)clothingSlot);
		}
		return this;
	}

	public ClothingItemDefinitionBuilder WithIcon(Sprite icon)
	{
		((ItemDefinition)_definition).Icon = icon;
		return this;
	}

	public ClothingItemDefinitionBuilder WithPricing(float basePurchasePrice, float resellMultiplier = 0.5f)
	{
		((StorableItemDefinition)_definition).BasePurchasePrice = Mathf.Max(0f, basePurchasePrice);
		((StorableItemDefinition)_definition).ResellMultiplier = Mathf.Clamp01(resellMultiplier);
		return this;
	}

	public ClothingItemDefinitionBuilder WithKeywords(params string[] keywords)
	{
		((ItemDefinition)_definition).Keywords = keywords;
		return this;
	}

	public ClothingItemDefinitionBuilder WithLabelColor(Color color)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		((ItemDefinition)_definition).LabelDisplayColor = color;
		return this;
	}

	public ClothingItemDefinition Build()
	{
		Singleton<Registry>.Instance.AddToRegistry((ItemDefinition)(object)_definition);
		return new ClothingItemDefinition(_definition);
	}

	internal ClothingDefinition BuildInternal()
	{
		return _definition;
	}
}
