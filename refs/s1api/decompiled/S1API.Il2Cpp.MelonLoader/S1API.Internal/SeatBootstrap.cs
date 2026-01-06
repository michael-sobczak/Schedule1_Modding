using System.Collections;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.AvatarFramework.Animation;
using MelonLoader;
using S1API.Avatar;
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
		Il2CppArrayBase<AvatarSeat> val = Object.FindObjectsOfType<AvatarSeat>(true);
		if (val == null)
		{
			return;
		}
		for (int i = 0; i < val.Length; i++)
		{
			AvatarSeat val2 = val[i];
			if ((Object)(object)val2 != (Object)null)
			{
				Seat.Register(val2);
			}
		}
	}
}
