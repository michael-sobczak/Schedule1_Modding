using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Northtown;

public class SamThompson : NPC
{
	public new static string NPCId => "sam_thompson";

	internal SamThompson()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "sam_thompson"))
	{
	}
}
