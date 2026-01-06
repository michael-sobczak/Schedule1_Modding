using System.Collections;
using MelonLoader;
using S1API.Avatar;
using ScheduleOne.AvatarFramework.Animation;
using UnityEngine;

namespace S1API.Internal;

internal static class SeatBootstrap
{
	public static void OnMainSceneInitialized()
	{
		MelonCoroutines.Start(ScanAndRegisterSeats());
	}

	private static IEnumerator ScanAndRegisterSeats()
	{
		yield return (object)new WaitForSeconds(0.25f);
		RegisterAllCurrentSeats();
		yield return (object)new WaitForSeconds(1f);
		RegisterAllCurrentSeats();
	}

	private static void RegisterAllCurrentSeats()
	{
		AvatarSeat[] array = Object.FindObjectsOfType<AvatarSeat>(true);
		if (array == null)
		{
			return;
		}
		foreach (AvatarSeat val in array)
		{
			if ((Object)(object)val != (Object)null)
			{
				Seat.Register(val);
			}
		}
	}
}
