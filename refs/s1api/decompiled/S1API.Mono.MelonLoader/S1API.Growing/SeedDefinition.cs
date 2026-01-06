using System;
using S1API.Internal.Utils;
using S1API.Items;
using ScheduleOne.Growing;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace S1API.Growing;

public class SeedDefinition : ItemDefinition
{
	internal SeedDefinition S1SeedDefinition => CrossType.As<SeedDefinition>(base.S1ItemDefinition);

	public GameObject? FunctionalSeedPrefab
	{
		get
		{
			FunctionalSeed functionSeedPrefab = S1SeedDefinition.FunctionSeedPrefab;
			return (functionSeedPrefab != null) ? ((Component)functionSeedPrefab).gameObject : null;
		}
	}

	public GameObject? PlantPrefab
	{
		get
		{
			Plant plantPrefab = S1SeedDefinition.PlantPrefab;
			return (plantPrefab != null) ? ((Component)plantPrefab).gameObject : null;
		}
	}

	internal SeedDefinition(SeedDefinition definition)
		: base((ItemDefinition)(object)definition)
	{
	}

	public GameObject CreateSeedInstance()
	{
		if ((Object)(object)S1SeedDefinition.FunctionSeedPrefab != (Object)null)
		{
			return ((Component)Object.Instantiate<FunctionalSeed>(S1SeedDefinition.FunctionSeedPrefab)).gameObject;
		}
		throw new NullReferenceException("No FunctionalSeedPrefab assigned to this SeedDefinition!");
	}
}
