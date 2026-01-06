using Il2CppScheduleOne.Cartel;
using Il2CppScheduleOne.Map;
using S1API.Map;

namespace S1API.Cartel;

public class CartelInfluence
{
	internal readonly CartelInfluence S1Influence;

	internal CartelInfluence(CartelInfluence influence)
	{
		S1Influence = influence;
	}

	public float GetInfluence(Region region)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return S1Influence.GetInfluence(ConvertToGameRegion(region));
	}

	public void ChangeInfluence(Region region, float amount)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		S1Influence.ChangeInfluence(ConvertToGameRegion(region), amount);
	}

	private static EMapRegion ConvertToGameRegion(Region region)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		return (EMapRegion)region;
	}
}
