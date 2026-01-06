using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Westville;

public class ShirleyWatts : NPC
{
	public new static string NPCId => "shirley_watts";

	internal ShirleyWatts()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "shirley_watts"))
	{
	}
}
