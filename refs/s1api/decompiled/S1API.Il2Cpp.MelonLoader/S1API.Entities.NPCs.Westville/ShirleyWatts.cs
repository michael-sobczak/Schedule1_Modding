using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Westville;

public class ShirleyWatts : NPC
{
	public new static string NPCId => "shirley_watts";

	internal ShirleyWatts()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "shirley_watts"))
	{
	}
}
