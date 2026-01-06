using System.Collections.Generic;
using ScheduleOne.Clothing;
using ScheduleOne.ItemFramework;

namespace S1API.Items;

public sealed class ClothingItemDefinition : StorableItemDefinition
{
	internal ClothingDefinition S1ClothingDefinition { get; }

	public ClothingSlot Slot
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Expected I4, but got Unknown
			return (ClothingSlot)S1ClothingDefinition.Slot;
		}
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			S1ClothingDefinition.Slot = (EClothingSlot)value;
		}
	}

	public ClothingApplicationType ApplicationType
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Expected I4, but got Unknown
			return (ClothingApplicationType)S1ClothingDefinition.ApplicationType;
		}
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			S1ClothingDefinition.ApplicationType = (EClothingApplicationType)value;
		}
	}

	public string ClothingAssetPath
	{
		get
		{
			return S1ClothingDefinition.ClothingAssetPath;
		}
		set
		{
			S1ClothingDefinition.ClothingAssetPath = value;
		}
	}

	public bool Colorable
	{
		get
		{
			return S1ClothingDefinition.Colorable;
		}
		set
		{
			S1ClothingDefinition.Colorable = value;
		}
	}

	public ClothingColor DefaultColor
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Expected I4, but got Unknown
			return (ClothingColor)S1ClothingDefinition.DefaultColor;
		}
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			S1ClothingDefinition.DefaultColor = (EClothingColor)value;
		}
	}

	public List<ClothingSlot> SlotsToBlock
	{
		get
		{
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected I4, but got Unknown
			List<ClothingSlot> list = new List<ClothingSlot>();
			if (S1ClothingDefinition.SlotsToBlock != null)
			{
				foreach (EClothingSlot item in S1ClothingDefinition.SlotsToBlock)
				{
					list.Add((ClothingSlot)item);
				}
			}
			return list;
		}
		set
		{
			S1ClothingDefinition.SlotsToBlock = new List<EClothingSlot>();
			if (value == null)
			{
				return;
			}
			foreach (ClothingSlot item in value)
			{
				S1ClothingDefinition.SlotsToBlock.Add((EClothingSlot)item);
			}
		}
	}

	internal ClothingItemDefinition(ClothingDefinition definition)
		: base((StorableItemDefinition)(object)definition)
	{
		S1ClothingDefinition = definition;
	}
}
