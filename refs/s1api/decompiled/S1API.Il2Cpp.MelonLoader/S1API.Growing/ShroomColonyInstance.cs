using Il2CppScheduleOne.Growing;
using UnityEngine;

namespace S1API.Growing;

public sealed class ShroomColonyInstance
{
	public const float MaxTemperatureForGrowth = 15f;

	internal readonly ShroomColony S1ShroomColony;

	public int BaseShroomYield => S1ShroomColony.BaseShroomYield;

	public float GrowthProgress => S1ShroomColony.GrowthProgress;

	public bool IsFullyGrown => S1ShroomColony.IsFullyGrown;

	public bool IsTooHotToGrow => S1ShroomColony.IsTooHotToGrow;

	public int GrownMushroomCount => S1ShroomColony.GrownMushroomCount;

	public float NormalizedQuality => S1ShroomColony.NormalizedQuality;

	public GameObject GameObject => ((Component)S1ShroomColony).gameObject;

	internal ShroomColonyInstance(ShroomColony colony)
	{
		S1ShroomColony = colony;
	}

	public void Destroy()
	{
		Object.Destroy((Object)(object)((Component)S1ShroomColony).gameObject);
	}
}
