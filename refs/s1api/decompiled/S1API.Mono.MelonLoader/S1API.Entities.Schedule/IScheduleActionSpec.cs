namespace S1API.Entities.Schedule;

public interface IScheduleActionSpec
{
	void ApplyTo(NPCSchedule schedule);
}
