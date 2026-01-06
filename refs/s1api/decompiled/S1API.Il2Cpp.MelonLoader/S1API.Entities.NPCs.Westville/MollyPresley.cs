using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Westville;

public class MollyPresley : NPC
{
	public new static string NPCId => "molly_presley";

	internal MollyPresley()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "molly_presley"))
	{
	}
}
