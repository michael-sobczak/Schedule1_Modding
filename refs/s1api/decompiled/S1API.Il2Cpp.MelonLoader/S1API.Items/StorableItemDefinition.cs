using Il2CppScheduleOne.ItemFramework;

namespace S1API.Items;

public class StorableItemDefinition : ItemDefinition
{
	internal StorableItemDefinition S1StorableItemDefinition { get; }

	public float BasePurchasePrice
	{
		get
		{
			return S1StorableItemDefinition.BasePurchasePrice;
		}
		set
		{
			S1StorableItemDefinition.BasePurchasePrice = value;
		}
	}

	public float ResellMultiplier
	{
		get
		{
			return S1StorableItemDefinition.ResellMultiplier;
		}
		set
		{
			S1StorableItemDefinition.ResellMultiplier = value;
		}
	}

	public bool IsUnlocked => S1StorableItemDefinition.IsUnlocked;

	internal StorableItemDefinition(StorableItemDefinition definition)
		: base((ItemDefinition)(object)definition)
	{
		S1StorableItemDefinition = definition;
	}
}
