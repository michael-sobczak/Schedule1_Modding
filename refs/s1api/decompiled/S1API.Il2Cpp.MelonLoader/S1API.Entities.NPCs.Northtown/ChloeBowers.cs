using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Northtown;

public class ChloeBowers : NPC
{
	public new static string NPCId => "chloe_bowers";

	internal ChloeBowers()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "chloe_bowers"))
	{
	}
}
