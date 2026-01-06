using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Northtown;

public class PeggyMyers : NPC
{
	public new static string NPCId => "peggy_myers";

	internal PeggyMyers()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "peggy_myers"))
	{
	}
}
