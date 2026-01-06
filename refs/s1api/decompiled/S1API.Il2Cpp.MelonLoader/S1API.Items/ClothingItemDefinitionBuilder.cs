using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne;
using Il2CppScheduleOne.Clothing;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace S1API.Items;

public sealed class ClothingItemDefinitionBuilder
{
	private readonly ClothingDefinition _definition;

	internal ClothingItemDefinitionBuilder()
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
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
		_definition.SlotsToBlock = new List<EClothingSlot>();
		if (source.SlotsToBlock != null)
		{
			Enumerator<EClothingSlot> enumerator = source.SlotsToBlock.GetEnumerator();
			while (enumerator.MoveNext())
			{
				EClothingSlot current = enumerator.Current;
				_definition.SlotsToBlock.Add(current);
			}
		}
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
		_definition.Slot = (EClothingSlot)slot;
		return this;
	}

	public ClothingItemDefinitionBuilder WithApplicationType(ClothingApplicationType applicationType)
	{
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
		((ItemDefinition)_definition).Keywords = Il2CppStringArray.op_Implicit(keywords);
		return this;
	}

	public ClothingItemDefinitionBuilder WithLabelColor(Color color)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
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
