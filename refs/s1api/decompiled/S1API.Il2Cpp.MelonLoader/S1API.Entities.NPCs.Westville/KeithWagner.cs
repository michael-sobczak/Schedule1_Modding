using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Westville;

public class KeithWagner : NPC
{
	public new static string NPCId => "keith_wagner";

	internal KeithWagner()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "keith_wagner"))
	{
	}
}
