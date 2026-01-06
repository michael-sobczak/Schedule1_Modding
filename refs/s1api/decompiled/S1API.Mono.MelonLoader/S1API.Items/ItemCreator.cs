using UnityEngine;

namespace S1API.Items;

public static class ItemCreator
{
	public static StorableItemDefinitionBuilder CreateBuilder()
	{
		return new StorableItemDefinitionBuilder();
	}

	public static StorableItemDefinition CreateItem(string id, string name, string description, ItemCategory category, int stackLimit = 10, float basePurchasePrice = 10f, float resellMultiplier = 0.5f, LegalStatus legalStatus = LegalStatus.Legal, Sprite icon = null, Equippable equippable = null)
	{
		StorableItemDefinitionBuilder storableItemDefinitionBuilder = new StorableItemDefinitionBuilder().WithBasicInfo(id, name, description, category).WithStackLimit(stackLimit).WithPricing(basePurchasePrice, resellMultiplier)
			.WithLegalStatus(legalStatus);
		if ((Object)(object)icon != (Object)null)
		{
			storableItemDefinitionBuilder.WithIcon(icon);
		}
		if (equippable != null)
		{
			storableItemDefinitionBuilder.WithEquippable(equippable);
		}
		return storableItemDefinitionBuilder.Build();
	}

	public static EquippableBuilder CreateEquippableBuilder()
	{
		return new EquippableBuilder();
	}
}
