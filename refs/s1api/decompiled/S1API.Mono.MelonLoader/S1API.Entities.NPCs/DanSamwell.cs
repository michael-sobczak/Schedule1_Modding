using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs;

public class DanSamwell : NPC
{
	public new static string NPCId => "dan_samwell";

	internal DanSamwell()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "dan_samwell"))
	{
	}
}
