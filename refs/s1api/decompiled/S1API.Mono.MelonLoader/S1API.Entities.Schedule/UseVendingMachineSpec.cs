using System;
using ScheduleOne.NPCs.Schedules;
using ScheduleOne.ObjectScripts;
using UnityEngine;

namespace S1API.Entities.Schedule;

public sealed class UseVendingMachineSpec : IScheduleActionSpec
{
	public int StartTime { get; set; }

	public string MachineGUID { get; set; }

	public string Name { get; set; }

	void IScheduleActionSpec.ApplyTo(NPCSchedule schedule)
	{
		NPCSignal_UseVendingMachine val = schedule.AddActionInternal<NPCSignal_UseVendingMachine>(StartTime, string.IsNullOrEmpty(Name) ? "UseVending" : Name);
		if ((Object)(object)val == (Object)null || string.IsNullOrEmpty(MachineGUID))
		{
			return;
		}
		try
		{
			Guid guid = new Guid(MachineGUID);
			VendingMachine machineOverride = GUIDManager.GetObject<VendingMachine>(guid);
			val.MachineOverride = machineOverride;
		}
		catch
		{
		}
	}
}
