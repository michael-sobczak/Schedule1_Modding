using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Northtown;

public class Ming : NPC
{
	public new static string NPCId => "ming";

	internal Ming()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "ming"))
	{
	}
}
