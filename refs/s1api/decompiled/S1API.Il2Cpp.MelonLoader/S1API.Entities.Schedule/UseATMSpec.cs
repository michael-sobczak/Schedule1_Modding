using Il2Cpp;
using Il2CppScheduleOne.Money;
using Il2CppScheduleOne.NPCs.Schedules;
using Il2CppSystem;
using S1API.Internal.Utils;
using UnityEngine;

namespace S1API.Entities.Schedule;

public sealed class UseATMSpec : IScheduleActionSpec
{
	public int StartTime { get; set; }

	public string ATMGUID { get; set; }

	public string Name { get; set; }

	void IScheduleActionSpec.ApplyTo(NPCSchedule schedule)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		NPCSignal_UseATM val = schedule.AddActionInternal<NPCSignal_UseATM>(StartTime, string.IsNullOrEmpty(Name) ? "UseATM" : Name);
		if ((Object)(object)val == (Object)null || string.IsNullOrEmpty(ATMGUID))
		{
			return;
		}
		try
		{
			Guid val2 = default(Guid);
			((Guid)(ref val2))._002Ector(ATMGUID);
			ATM value = GUIDManager.GetObject<ATM>(val2);
			ReflectionUtils.TrySetFieldOrProperty(val, "ATM", value);
		}
		catch
		{
		}
	}
}
