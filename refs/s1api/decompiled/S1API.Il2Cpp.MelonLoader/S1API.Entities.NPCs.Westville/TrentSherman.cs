using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Westville;

public class TrentSherman : NPC
{
	public new static string NPCId => "trent_sherman";

	internal TrentSherman()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "trent_sherman"))
	{
	}
}
