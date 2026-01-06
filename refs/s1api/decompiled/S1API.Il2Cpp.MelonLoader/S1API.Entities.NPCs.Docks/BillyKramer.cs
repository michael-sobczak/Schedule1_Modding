using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Docks;

public class BillyKramer : NPC
{
	public new static string NPCId => "billy_kramer";

	internal BillyKramer()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "billy_kramer"))
	{
	}
}
