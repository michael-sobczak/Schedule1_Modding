using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Westville;

public class DorisLubbin : NPC
{
	public new static string NPCId => "doris_lubbin";

	internal DorisLubbin()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "doris_lubbin"))
	{
	}
}
