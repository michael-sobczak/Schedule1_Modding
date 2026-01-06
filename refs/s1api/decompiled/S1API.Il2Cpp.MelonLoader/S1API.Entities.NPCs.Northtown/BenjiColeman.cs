using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Northtown;

public class BenjiColeman : NPC
{
	public new static string NPCId => "benji_coleman";

	internal BenjiColeman()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "benji_coleman"))
	{
	}
}
