using System;
using S1API.Internal.Utils;
using ScheduleOne.Money;
using ScheduleOne.NPCs.Schedules;
using UnityEngine;

namespace S1API.Entities.Schedule;

public sealed class UseATMSpec : IScheduleActionSpec
{
	public int StartTime { get; set; }

	public string ATMGUID { get; set; }

	public string Name { get; set; }

	void IScheduleActionSpec.ApplyTo(NPCSchedule schedule)
	{
		NPCSignal_UseATM val = schedule.AddActionInternal<NPCSignal_UseATM>(StartTime, string.IsNullOrEmpty(Name) ? "UseATM" : Name);
		if ((Object)(object)val == (Object)null || string.IsNullOrEmpty(ATMGUID))
		{
			return;
		}
		try
		{
			Guid guid = new Guid(ATMGUID);
			ATM value = GUIDManager.GetObject<ATM>(guid);
			ReflectionUtils.TrySetFieldOrProperty(val, "ATM", value);
		}
		catch
		{
		}
	}
}
