using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Northtown;

public class LudwigMeyer : NPC
{
	public new static string NPCId => "ludwig_meyer";

	internal LudwigMeyer()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "ludwig_meyer"))
	{
	}
}
