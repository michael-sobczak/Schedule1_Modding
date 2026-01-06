using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Westville;

public class DorisLubbin : NPC
{
	public new static string NPCId => "doris_lubbin";

	internal DorisLubbin()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "doris_lubbin"))
	{
	}
}
