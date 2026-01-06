using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Uptown;

public class WalterCussler : NPC
{
	public new static string NPCId => "walter_cussler";

	internal WalterCussler()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "walter_cussler"))
	{
	}
}
