using System;
using S1API.Map;
using ScheduleOne.Cartel;
using ScheduleOne.Map;

namespace S1API.Cartel;

public class CartelInfluence
{
	internal readonly CartelInfluence S1Influence;

	public event Action<Region, float, float> OnInfluenceChanged
	{
		add
		{
			if (value != null)
			{
				CartelInfluence s1Influence = S1Influence;
				s1Influence.OnInfluenceChanged = (Action<EMapRegion, float, float>)Delegate.Combine(s1Influence.OnInfluenceChanged, (Action<EMapRegion, float, float>)delegate(EMapRegion gameRegion, float oldVal, float newVal)
				{
					//IL_000d: Unknown result type (might be due to invalid IL or missing references)
					value?.Invoke(ConvertFromGameRegion(gameRegion), oldVal, newVal);
				});
			}
		}
		remove
		{
		}
	}

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

	private static Region ConvertFromGameRegion(EMapRegion region)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected I4, but got Unknown
		return (Region)region;
	}

	private static EMapRegion ConvertToGameRegion(Region region)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		return (EMapRegion)region;
	}
}
