using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Westville;

public class MegCooley : NPC
{
	public new static string NPCId => "meg_cooley";

	internal MegCooley()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "meg_cooley"))
	{
	}
}
