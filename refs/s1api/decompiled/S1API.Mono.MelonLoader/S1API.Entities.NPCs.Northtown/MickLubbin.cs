using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Northtown;

public class MickLubbin : NPC
{
	public new static string NPCId => "mick_lubbin";

	internal MickLubbin()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "mick_lubbin"))
	{
	}
}
