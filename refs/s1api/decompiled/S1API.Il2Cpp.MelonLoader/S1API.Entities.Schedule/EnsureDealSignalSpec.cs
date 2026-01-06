namespace S1API.Entities.Schedule;

public sealed class EnsureDealSignalSpec : IScheduleActionSpec
{
	void IScheduleActionSpec.ApplyTo(NPCSchedule schedule)
	{
		schedule.EnsureDealSignal();
	}
}
