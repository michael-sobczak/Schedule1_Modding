using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Docks;

public class CrankyFrank : NPC
{
	public new static string NPCId => "cranky_frank";

	internal CrankyFrank()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "cranky_frank"))
	{
	}
}
