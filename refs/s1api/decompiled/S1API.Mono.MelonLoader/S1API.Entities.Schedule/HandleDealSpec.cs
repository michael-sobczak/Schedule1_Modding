using System;

namespace S1API.Entities.Schedule;

[Obsolete("HandleDealSpec is no longer needed as of game version 0.4.2f4. Deal handling is now automatic through DealerAttendDealBehaviour.")]
public sealed class HandleDealSpec : IScheduleActionSpec
{
	public int StartTime { get; set; }

	public string Name { get; set; }

	void IScheduleActionSpec.ApplyTo(NPCSchedule schedule)
	{
	}
}
