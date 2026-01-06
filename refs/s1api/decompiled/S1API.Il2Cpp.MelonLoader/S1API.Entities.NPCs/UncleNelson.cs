using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs;

public class UncleNelson : NPC
{
	public new static string NPCId => "uncle_nelson";

	internal UncleNelson()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "uncle_nelson"))
	{
	}
}
