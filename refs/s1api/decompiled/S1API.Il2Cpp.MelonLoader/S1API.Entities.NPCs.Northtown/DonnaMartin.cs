using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Northtown;

public class DonnaMartin : NPC
{
	public new static string NPCId => "donna_martin";

	internal DonnaMartin()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "donna_martin"))
	{
	}
}
