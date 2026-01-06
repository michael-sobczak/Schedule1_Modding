using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace S1API.Items;

public sealed class BuildableItemDefinition : StorableItemDefinition
{
	internal BuildableItemDefinition S1BuildableItemDefinition { get; }

	public BuildSoundType BuildSoundType
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Expected I4, but got Unknown
			return (BuildSoundType)S1BuildableItemDefinition.BuildSoundType;
		}
		set
		{
			S1BuildableItemDefinition.BuildSoundType = (EBuildSoundType)value;
		}
	}

	public new Color LabelDisplayColor
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return ((ItemDefinition)S1BuildableItemDefinition).LabelDisplayColor;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			((ItemDefinition)S1BuildableItemDefinition).LabelDisplayColor = value;
		}
	}

	internal BuildableItemDefinition(BuildableItemDefinition definition)
		: base((StorableItemDefinition)(object)definition)
	{
		S1BuildableItemDefinition = definition;
	}
}
