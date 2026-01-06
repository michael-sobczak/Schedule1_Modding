using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Westville;

public class JerryMontero : NPC
{
	public new static string NPCId => "jerry_montero";

	internal JerryMontero()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "jerry_montero"))
	{
	}
}
