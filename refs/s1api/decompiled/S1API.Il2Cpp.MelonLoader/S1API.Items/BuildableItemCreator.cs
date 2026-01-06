using System;
using Il2CppScheduleOne;
using Il2CppScheduleOne.ItemFramework;
using S1API.Internal.Utils;
using UnityEngine;

namespace S1API.Items;

public static class BuildableItemCreator
{
	public static BuildableItemDefinitionBuilder CreateBuilder()
	{
		return new BuildableItemDefinitionBuilder();
	}

	public static BuildableItemDefinitionBuilder CloneFrom(string sourceItemId)
	{
		ItemDefinition item = Registry.GetItem(sourceItemId);
		if ((Object)(object)item == (Object)null)
		{
			throw new ArgumentException("Source item with ID '" + sourceItemId + "' not found in registry", "sourceItemId");
		}
		if (!CrossType.Is<BuildableItemDefinition>((object)item, out BuildableItemDefinition result))
		{
			throw new ArgumentException("Item '" + sourceItemId + "' is not a BuildableItemDefinition", "sourceItemId");
		}
		return new BuildableItemDefinitionBuilder(result);
	}

	public static BuildableItemDefinitionBuilder CloneFrom(BuildableItemDefinition source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source", "Source item definition cannot be null");
		}
		return new BuildableItemDefinitionBuilder(source.S1BuildableItemDefinition);
	}
}
