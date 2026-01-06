using ScheduleOne.EntityFramework;
using ScheduleOne.Growing;
using ScheduleOne.ObjectScripts;
using UnityEngine;

namespace S1API.Growing;

public sealed class MushroomBedInstance
{
	internal readonly MushroomBed S1MushroomBed;

	public ShroomColonyInstance CurrentColony
	{
		get
		{
			ShroomColony currentColony = S1MushroomBed.CurrentColony;
			return ((Object)(object)currentColony != (Object)null) ? new ShroomColonyInstance(currentColony) : null;
		}
	}

	public GameObject GameObject => ((Component)S1MushroomBed).gameObject;

	public Transform Transform => ((Component)S1MushroomBed).transform;

	internal MushroomBedInstance(MushroomBed mushroomBed)
	{
		S1MushroomBed = mushroomBed;
	}

	public bool ContainsGrowable()
	{
		return ((GrowContainer)S1MushroomBed).ContainsGrowable();
	}

	public float GetGrowthProgressNormalized()
	{
		return ((GrowContainer)S1MushroomBed).GetGrowthProgressNormalized();
	}

	public float GetAverageTileTemperature()
	{
		return ((GridItem)S1MushroomBed).GetAverageTileTemperature();
	}

	public bool IsReadyForHarvest(out string reason)
	{
		return S1MushroomBed.IsReadyForHarvest(ref reason);
	}

	public float GetGrowSurfaceSideLength()
	{
		return ((GrowContainer)S1MushroomBed).GetGrowSurfaceSideLength();
	}
}
