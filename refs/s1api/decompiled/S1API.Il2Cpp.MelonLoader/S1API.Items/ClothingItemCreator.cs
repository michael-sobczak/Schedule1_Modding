using Il2CppScheduleOne;
using Il2CppScheduleOne.Clothing;
using Il2CppScheduleOne.ItemFramework;
using S1API.Internal.Utils;
using S1API.Logging;
using UnityEngine;

namespace S1API.Items;

public static class ClothingItemCreator
{
	private static readonly Log Logger = new Log("ClothingItemCreator");

	public static ClothingItemDefinitionBuilder CreateBuilder()
	{
		return new ClothingItemDefinitionBuilder();
	}

	public static ClothingItemDefinitionBuilder CloneFrom(string sourceItemId)
	{
		ItemDefinition item = Registry.GetItem(sourceItemId);
		if ((Object)(object)item == (Object)null)
		{
			Logger.Error("Cannot clone clothing item '" + sourceItemId + "': source item not found in registry");
			return null;
		}
		if (!CrossType.Is<ClothingDefinition>((object)item, out ClothingDefinition result))
		{
			Logger.Error($"Cannot clone item '{sourceItemId}': it is not a clothing item (found type: {((object)item).GetType().Name})");
			return null;
		}
		return new ClothingItemDefinitionBuilder(result);
	}

	public static ClothingItemDefinitionBuilder CloneFrom(ClothingItemDefinition source)
	{
		if (source == null)
		{
			Logger.Error("Cannot clone from null clothing item definition");
			return null;
		}
		return new ClothingItemDefinitionBuilder(source.S1ClothingDefinition);
	}
}
