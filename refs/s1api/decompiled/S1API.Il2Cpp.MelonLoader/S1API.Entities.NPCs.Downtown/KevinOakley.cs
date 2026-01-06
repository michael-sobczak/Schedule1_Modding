using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Downtown;

public class KevinOakley : NPC
{
	public new static string NPCId => "kevin_oakley";

	internal KevinOakley()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "kevin_oakley"))
	{
	}
}
