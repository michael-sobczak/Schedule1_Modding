using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Northtown;

public class SamThompson : NPC
{
	public new static string NPCId => "sam_thompson";

	internal SamThompson()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "sam_thompson"))
	{
	}
}
