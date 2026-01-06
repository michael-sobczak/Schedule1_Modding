using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Uptown;

public class HerbertBleuball : NPC
{
	public new static string NPCId => "herbert_bleuball";

	internal HerbertBleuball()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "herbert_bleuball"))
	{
	}
}
