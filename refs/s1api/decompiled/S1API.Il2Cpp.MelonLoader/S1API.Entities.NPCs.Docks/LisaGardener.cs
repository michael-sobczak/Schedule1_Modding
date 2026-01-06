using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Docks;

public class LisaGardener : NPC
{
	public new static string NPCId => "lisa_gardener";

	internal LisaGardener()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "lisa_gardener"))
	{
	}
}
