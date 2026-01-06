using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Suburbia;

public class ChrisSullivan : NPC
{
	public new static string NPCId => "chris_sullivan";

	internal ChrisSullivan()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "chris_sullivan"))
	{
	}
}
