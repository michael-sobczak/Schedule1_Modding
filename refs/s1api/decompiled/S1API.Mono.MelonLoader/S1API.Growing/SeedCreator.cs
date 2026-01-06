using ScheduleOne;
using ScheduleOne.DevUtilities;
using ScheduleOne.Growing;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace S1API.Growing;

public static class SeedCreator
{
	public static SeedDefinition CreateSeed(string id, string name, string description, int stackLimit = 10, GameObject? functionSeedPrefab = null, GameObject? plantPrefab = null, Sprite? icon = null)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		SeedDefinition val = ScriptableObject.CreateInstance<SeedDefinition>();
		((ItemDefinition)val).ID = id;
		((ItemDefinition)val).Name = name;
		((ItemDefinition)val).Description = description;
		((ItemDefinition)val).StackLimit = stackLimit;
		((ItemDefinition)val).Category = (EItemCategory)2;
		if ((Object)(object)functionSeedPrefab != (Object)null)
		{
			val.FunctionSeedPrefab = functionSeedPrefab.GetComponent<FunctionalSeed>();
		}
		if ((Object)(object)plantPrefab != (Object)null)
		{
			val.PlantPrefab = plantPrefab.GetComponent<Plant>();
		}
		Singleton<Registry>.Instance.AddToRegistry((ItemDefinition)(object)val);
		return new SeedDefinition(val);
	}
}
