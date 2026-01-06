using ScheduleOne.Growing;
using UnityEngine;

namespace S1API.Growing;

public class SeedInstance
{
	internal readonly FunctionalSeed S1FunctionalSeed;

	private GameObject GameObject => ((Component)S1FunctionalSeed).gameObject;

	public bool HasExitedVial { get; private set; } = false;

	internal SeedInstance(FunctionalSeed functionalSeed)
	{
		S1FunctionalSeed = functionalSeed;
	}

	public void ForceExitVial()
	{
		if ((Object)(object)S1FunctionalSeed.Vial != (Object)null)
		{
			S1FunctionalSeed.TriggerExit(((Component)S1FunctionalSeed.Vial).GetComponent<Collider>());
			HasExitedVial = true;
		}
	}
}
