using Il2CppScheduleOne.PlayerScripts;
using UnityEngine;

namespace S1API.Law;

public sealed class PlayerCrimeData
{
	internal readonly PlayerCrimeData S1CrimeData;

	public PursuitLevel CurrentPursuitLevel => (PursuitLevel)S1CrimeData.CurrentPursuitLevel;

	public Vector3 LastKnownPosition => S1CrimeData.LastKnownPosition;

	public float TimeSinceSighted => S1CrimeData.TimeSinceSighted;

	public bool BodySearchPending => S1CrimeData.BodySearchPending;

	public bool EvadedArrest => S1CrimeData.EvadedArrest;

	internal PlayerCrimeData(PlayerCrimeData crimeData)
	{
		S1CrimeData = crimeData;
	}

	public float GetSearchTime()
	{
		return S1CrimeData.GetSearchTime();
	}

	public void SetPursuitLevel(PursuitLevel level)
	{
		S1CrimeData.SetPursuitLevel((EPursuitLevel)level);
	}

	public void Escalate()
	{
		S1CrimeData.Escalate();
	}

	public void Deescalate()
	{
		S1CrimeData.Deescalate();
	}

	public void ClearCrimes()
	{
		S1CrimeData.ClearCrimes();
	}

	public void RecordLastKnownPosition(bool resetTimeSinceSighted = true)
	{
		S1CrimeData.RecordLastKnownPosition(resetTimeSinceSighted);
	}
}
