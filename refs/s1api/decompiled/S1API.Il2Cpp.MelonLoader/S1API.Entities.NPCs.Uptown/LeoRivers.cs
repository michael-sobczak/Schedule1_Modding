using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Uptown;

public class LeoRivers : NPC
{
	public new static string NPCId => "leo_rivers";

	internal LeoRivers()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "leo_rivers"))
	{
	}
}
