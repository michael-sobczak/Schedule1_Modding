using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Northtown;

public class MickLubbin : NPC
{
	public new static string NPCId => "mick_lubbin";

	internal MickLubbin()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "mick_lubbin"))
	{
	}
}
