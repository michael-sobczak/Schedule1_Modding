using Il2Cpp;
using Il2CppScheduleOne.NPCs.Schedules;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem;
using UnityEngine;

namespace S1API.Entities.Schedule;

public sealed class UseVendingMachineSpec : IScheduleActionSpec
{
	public int StartTime { get; set; }

	public string MachineGUID { get; set; }

	public string Name { get; set; }

	void IScheduleActionSpec.ApplyTo(NPCSchedule schedule)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		NPCSignal_UseVendingMachine val = schedule.AddActionInternal<NPCSignal_UseVendingMachine>(StartTime, string.IsNullOrEmpty(Name) ? "UseVending" : Name);
		if ((Object)(object)val == (Object)null || string.IsNullOrEmpty(MachineGUID))
		{
			return;
		}
		try
		{
			Guid val2 = default(Guid);
			((Guid)(ref val2))._002Ector(MachineGUID);
			VendingMachine machineOverride = GUIDManager.GetObject<VendingMachine>(val2);
			val.MachineOverride = machineOverride;
		}
		catch
		{
		}
	}
}
