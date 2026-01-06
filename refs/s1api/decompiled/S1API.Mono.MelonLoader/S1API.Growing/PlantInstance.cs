using ScheduleOne.DevUtilities;
using ScheduleOne.Growing;
using ScheduleOne.Trash;
using UnityEngine;

namespace S1API.Growing;

public class PlantInstance
{
	internal readonly Plant S1Plant;

	public float NormalizedGrowth => S1Plant.NormalizedGrowthProgress;

	public bool IsFullyGrown => S1Plant.IsFullyGrown;

	public SeedDefinition SeedDefinition => new SeedDefinition(S1Plant.SeedDefinition);

	public float Quality => S1Plant.QualityLevel;

	public float YieldMultiplier => S1Plant.YieldMultiplier;

	private GameObject GameObject => ((Component)S1Plant).gameObject;

	internal PlantInstance(Plant plant)
	{
		S1Plant = plant;
	}

	public void Destroy(bool dropScraps = false)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		if (dropScraps && (Object)(object)S1Plant.PlantScrapPrefab != (Object)null)
		{
			try
			{
				TrashManager instance = NetworkSingleton<TrashManager>.Instance;
				if ((Object)(object)instance != (Object)null)
				{
					Vector3 position = ((Component)S1Plant).transform.position;
					Quaternion identity = Quaternion.identity;
					instance.CreateTrashItem(S1Plant.PlantScrapPrefab.ID, position, identity, default(Vector3), "", false);
				}
			}
			catch
			{
			}
		}
		Object.Destroy((Object)(object)((Component)S1Plant).gameObject);
	}
}
