using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Downtown;

public class ElizabethHomley : NPC
{
	public new static string NPCId => "elizabeth_homley";

	internal ElizabethHomley()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "elizabeth_homley"))
	{
	}
}
